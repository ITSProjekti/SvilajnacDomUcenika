
<template>
  <div id="maindiv">
  
   <v-card>

      
  

    <v-layout wrap > 
        <v-flex xs12  class="text-xs-center">
        <v-progress-circular
          indeterminate
          class="primary--text"
          :width="7"
          :size="150"
          v-if="loading"></v-progress-circular>
      </v-flex>
    </v-layout>

    <v-card>
          <transition name="slidetoleft" appear>
       <v-card-title wrap >
        <h3>Pregled svih prijavljenih učenika</h3> </v-card-title>
          </transition>
      <v-layout wrap justify-end >
        



        <v-flex xs3 class="mb-2 mr-3">
        <v-text-field
        v-model="search"
        append-icon="search"
        label="Pretraga"
        single-line
        hide-details
      ></v-text-field>
       
        </v-flex>
      </v-layout>

   <transition name="fade" appear  mode="in-out">
        <v-flex xs12>
    <v-data-table  
      :headers="headers"
      :items="ucenici"
       v-if="!loading"
      rows-per-page-text="Redova po stranici"
      :rows-per-page-items="[10,15,20,ucenici.length]"
      :search="search"
      :custom-filter="customFilter"
      class="elevation-1"    
     >
      <template slot="items" slot-scope="props" >
        <tr  >
        <td class="text-xs-left priority-1" >{{ props.item.id}}</td>
        <td class="text-xs-left priority-1">{{ props.item.ime }}</td>
        <td class="text-xs-left priority-1">{{ props.item.prezime }}</td>
        <td class="text-xs-left priority-3">{{ props.item.jmbg }}</td>
        <td class="text-xs-left priority-3">{{ props.item.pol.nazivPola }}</td>
        <td class="text-xs-left priority-3">{{ props.item.dan }}.{{ props.item.mesec }}.{{ props.item.godina }}.</td>
        <td class="text-xs-left priority-4">{{ props.item.vaspitnaGrupa.naziv }}</td>
        <td class="text-xs-left priority-5">{{ props.item.upisanaSkola.nazivSrednjeSkole }}</td>
        <td class="justify-center layout px-0">
          <v-btn center icon class="mx-0"
           @click="deleteItem(props.item)">
      
              <img :src=kanta.srcmain>
          </v-btn>
             <v-btn center icon class="mx-0"
          v-bind:to="'/detalji/'+props.item.id">          
         <img :src=izmena.srcmain>
          </v-btn>
        </td>
         </tr>
      </template>
       <template slot="no-data">
      <v-alert :value="true" color="error" icon="warning">
        Nema ni jednog ucenika. :(
      </v-alert> 
    </template>
    <template slot="pageText" slot-scope="{ pageStart, pageStop }">
         {{ pageStart }} - {{ pageStop }} od {{ ucenici.length}}
</template>
    <v-alert slot="no-results" :value="true" color="error" icon="warning">
        Vasa pretraga za "{{ search }}" nije pronasla rezultate.
      </v-alert>
    </v-data-table>
    </v-flex>
</transition >
    </v-card>
</v-card>
  </div>
</template>


<script>
/* eslint-disable */
import moment from 'moment'

  export default {
    data: () => ({
      // dialog je promenljiva koja sluzi za prikazivanje dijaloga pri menjanju ili prijavi ucenika
      dialog: false,
      select: '',
      opcijeX: [
        'Ime',
        'Prezime',
        'Škola'
      ],
      kanta: { srcmain: require('../../assets/KANTA2.png')},
      izmena: { srcmain: require('../../assets/EDIT.png')} ,
      // headeri sluze za generisanje polja koja se prikazuju u tabeli
      headers: [
        {
          text: 'Redni broj',  align: 'left', sortable: false,  value: 'id', width:'100%' ,class: 'priority-1'},
        { text: 'Ime',value: 'ime' ,align: 'left',sortable:true, width:'100%',class: 'priority-1'},
        { text: 'Prezime', value:'prezime', align: 'left',sortable:true,width:'100%',class: 'priority-1'},
        { text: 'JMBG', value:'jmbg',align: 'left',sortable:true ,width:'100%',class: 'priority-3'},
        { text: 'Pol', value: 'pol.nazivPola',align: 'left',sortable:true,width:'100%',class: 'priority-3' },
        { text: 'Datum rođenja', value: 'godina',align: 'left',sortable:false,width:'100%',class: 'priority-3' },
        { text: 'Vaspitna grupa', value: 'vaspitnaGrupa.naziv',align: 'left',sortable:true,width:'100%',class: 'priority-4' },
        { text: 'Škola', value: 'upisanaSkola.nazivSrednjeSkole',align: 'left',sortable:true ,width:'100%',class: 'priority-5'},
        { text: 'Opcije', value: 'opcije',align: 'center',sortable:false,width:'100%' }
      ],
      // rules su pravila popunjavanja polja za unos
           rules: {
      // requiered pravilo je pravilo za neophodnost postojanja informacije koja se trazi na odgovarajucem polju sa opcijom requiered
          required: (value) => !!value || 'Ovo polje je obavezno.',
      // jmbg pravilo sluzi za pravilo duzine od tacno 13 cifara
          jmbg: (value) => {
            const pattern = /^(\w{13,13})$/ 
            return pattern.test(value) || 'Jmbg mora biti dugacak 13 cifara.'
          },
      // uspehX pravilo sluzi za krieranje formata unosa u zeljenom opsegu i obliku
           uspehX: (value) => {
            const pattern = /^([1-4](\.\d+){1}|5(\.0+)?)$/
            return pattern.test(value) || 'Uspeh mora biti u formatu B.BB (B - broj).'
          }
        },
      // pomocna promenljiva za generisanje podatka o datumu rodjenja
      datum: null,
      search: '',
        file: '',
        showPreview: false,
        imagePreview: '',
      // atribut za jmbg progress bar

      custom: true,
      editedIndex: -1,
      // brojevi su pomocna prom za rad sa postanskim brojevima
      brojevi: '',
      // objekat koji sluzi kao maska za prijavu ucenika, koristi se pri prijavi i izmeni podataka o uceniku
      editedItem: {
        ime: '',
        prezime: '',
        jmbg: '',
        adresa: '',
        prethodniUspeh: '',
       pol: {
          id: '',
          nazivPola: ''
       },
        dan: '',
        mesec: '',
        godina: '',
        mestoZavrseneSkole: {
          id: '',
          nazivMesta: ''
        },
        mestoRodjenja: {
          id: '',
          nazivMesta: ''
        },
        mestoPrebivalista: {
          id: '',
          nazivMesta: ''
        },
        prethodnaSkola: {
          id: '',
          nazivPrethodneSkole: '',
          opstinaId: '',
        },
          upisanaSkola: {
            id: '',
            nazivSrednjeSkole: '',
            opstinaId: ''
           
        },
        postanskiBroj: {
          id: '',
          broj: '',
          opstinaId: ''
          },
        opstina: {
          id: '',
          nazivOpstine: ''         
          },
        opstinaPrebivalista: {
          id: '',
          nazivOpstine: ''         
          },
        drzavaRodjenja: {
          id: '',
          nazivDrzave: ''
          },
        telefon: {
          id: '',
          mobilni: '',
          kucni: ''
          },
          smer: {
            id:'',
            nazivSmera: ''
          },
          razred:{
            id: '',
            brojRazreda: ''
          },
          roditelji:[
            {
              ime:'',
              prezime: '',
              brojTelefona: '',
              stepenObrazovanjaId: ''
            },
               {
              ime:'',
              prezime: '',
              brojTelefona: '',
              stepenObrazovanjaId: ''
            }
          ],
           tipPorodice:{
                id: '',
                nazivTipaPorodice: ''
           },
           staratelji:{
               ime:  '',
               prezime:   ''
               
            },
           slika: '',
           materijalniPrihodi: '',
            vaspitnaGrupa:{
              id:'',
              naziv: ''
            }


      },
    // defaultItem je objekat koji je po strukturi identican editedItemu i sluzi za resetovanje podataka u editedItemu na prazne podatke
    // pri zavrsetku prijave ili izmene podataka o uceniku
      defaultItem: {
        ime: '',
        prezime: '',
        jmbg: '',
        adresa: '',
        prethodniUspeh: '',
       pol: {
          id: '',
          nazivPola: ''
       },
        dan: '',
        mesec: '',
        godina: '',
        mestoZavrseneSkole: {
          id: '',
          nazivMesta: ''
        },
        mestoRodjenja: {
          id: '',
          nazivMesta: ''
        },
        mestoPrebivalista: {
          id: '',
          nazivMesta: ''
        },
        prethodnaSkola: {
          id: '',
          nazivPrethodneSkole: '',
          opstinaId: '',
        },
          upisanaSkola: {
            id: '',
            nazivSrednjeSkole: '',
            opstinaId: ''
          
        },
        postanskiBroj: {
          id: '',
          broj: '',
          opstinaId: ''
          },
        opstina: {
          id: '',
          nazivOpstine: ''         
          },
        opstinaPrebivalista: {
          id: '',
          nazivOpstine: ''         
          },
        drzavaRodjenja: {
          id: '',
          nazivDrzave: ''
          },
        telefon: {
          id: '',
          mobilni: '',
          kucni: ''
          },
          smer: {
            id:'',
            nazivSmera: ''
          },
          razred:{
            id: '',
            brojRazreda: ''
          },
         roditelji:[
            {
              ime:'',
              prezime: '',
              brojTelefona: '',
              stepenObrazovanjaId: ''

            },
               {
              ime:'',
              prezime: '',
              brojTelefona: '',
              stepenObrazovanjaId: ''
            }
          ],
           tipPorodice:{
                id: '',
                nazivTipaPorodice: ''
           },
           staratelji:{
               ime:  '',
               prezime:   ''
              
            },
           slika: '',
           materijalniPrihodi: '',      
           vaspitnaGrupa:{
              id:'',
              naziv: ''
            }


      }
    }),
    // computed metode su metode koje se desavaju onda kada dodje do nekakvim promena stanja komponente, neki vid watcher-a
    computed: {
    
      // logika za racunanje progress bar-a kod jmbg, 105 je prva granica a drugi parametar u math.min funkciji sluzi za formiranje 13 podeoka 
      // na progress baru za 13 jmbg cifara, dalje se ovi rezultati koriste za prikaz promene boja na progress baru
          progress () {
        return Math.min(105, this.editedItem.jmbg.length * 7.69)
      },
      // boja progress bara se generise u opsezima koji se odredjuju na osnovo trenutne vrednosti promenljive progress koja govori
      // dokle je stigao progress bar, 4 zone su crvena, narandzasta, zelena i na kraju opet crvena kad se predje 13 cifara
      color () {
      
        return ['error', 'warning', 'success','error'][Math.floor(this.progress / 34)]
      },
      // metoda koja vodi racuna o tome da se ne moze prijaviti ucenik koji nije ispunio sve neophodne podatke prilikom prijave ili izmene podataka
      formIsValid () {
       
        if( this.editedItem.ime !== '' &&
          this.editedItem.prezime!== '' &&         
          this.editedItem.jmbg !== '' &&
          this.editedItem.jmbg.length === 13 &&
          this.editedItem.pol.id !== '' &&
          this.editedItem.drzavaRodjenja.id !== '' &&
          this.editedItem.opstinaPrebivalista.id !== '' &&
          this.editedItem.opstina.id !== '' &&
          this.editedItem.postanskiBroj.id !== '' &&
          this.editedItem.mestoRodjenja.id !== '' &&
          this.editedItem.mestoPrebivalista.id !== '' &&
          this.editedItem.mestoZavrseneSkole.id !== '' &&
          this.editedItem.smer.id !== '' &&
          this.editedItem.prethodnaSkola.id !== '' &&
          this.editedItem.upisanaSkola.id !== '' &&
          this.editedItem.razred.id !== '' &&
          this.editedItem.prethodniUspeh !== '' &&
          this.editedItem.roditelji[0].ime !== '' &&
          this.editedItem.roditelji[0].prezime !== '' &&
          this.editedItem.roditelji[0].stepenObrazovanjaId !== '' &&
          this.editedItem.roditelji[0].brojTelefona !== '' &&
          this.editedItem.roditelji[1].ime !== '' &&
          this.editedItem.roditelji[1].prezime !== '' &&
          this.editedItem.roditelji[1].stepenObrazovanjaId !== '' &&
          this.editedItem.roditelji[1].brojTelefona !== '' &&
         (this.editedItem.dan !== '' ||  this.datum !== null)
          
          )
          {
            return true
            }
          else{
            return false
          }
         
      }, 
      TipoviPorodice () {
        return this.$store.getters.loadedTipoviPorodice
      },
      // pozivi store action metoda za preuzimanje neophodnih podataka za prijavu ucenika
      StepeniStrucneSpreme () {
        return this.$store.getters.loadedSSS
      },
      razredi () {
        return this.$store.getters.loadedRazredi
      },
      srednjeSkole () {
       return this.$store.getters.loadedSrednjeSkole       
      },
      osnovneSkole () {
       return this.$store.getters.loadedOsnovneSkole       
      },
      mesta () {
       return this.$store.getters.loadedMesta       
      },
      smerovi () {
       return this.$store.getters.loadedSmer       
      },
      polovi () {
       return this.$store.getters.loadedPolovi       
      },
      postanskiBrojevi () {
       return this.$store.getters.loadedPostanskiBrojevi       
      },
      ucenici () {
       return this.$store.getters.loadedUcenici       
      },
       opstine () {
       return this.$store.getters.loadedOpstine  
           
       },
       drzave () {
       return this.$store.getters.loadedDrzave
           
    },
      loading () {
        return this.$store.getters.loading
      },
      // promenljiva koja menja naslov dijaloga, ako se odabere za prijavu dobija sa prvi naslov, drugi naslov ako se radi o izmeni podataka
      formTitle () {
        return this.editedIndex === -1 ? 'Prijava novog ucenika' : 'Izmena podataka'
      }
    },
    // watch se koristi kad se radi sa dijalozima
    watch: {
      dialog (val) {

        val || this.close()
      }
    },
    methods: {
         ClearPicture(){
   this.file=''
   this.imagePreview=''
    this.editedItem.slika= ''
    	const input = this.$refs.file;
        input.type = 'text';
        input.type = 'file';
      },

           handleFileUpload(){
        
      
        this.file = this.$refs.file.files[0];


        let reader  = new FileReader();

       this.editedItem.slika=null;
        reader.addEventListener("load", function () {
          this.showPreview = true;
          this.imagePreview = reader.result;
            this.editedItem.slika= reader.result
        }.bind(this), false);

        if( this.file ){      
          if ( /\.(jpe?g|png|gif)$/i.test( this.file.name ) ) {
            reader.readAsDataURL( this.file );
          }
        }
      },
   
      changedTip: function(value) {
     this.editedItem.staratelji.ime=''
     this.editedItem.staratelji.prezime=''
      },
      // metoda koja na osnovu odabrane opstine prikazuje njene jedinstvene postanske brojeve
      changedValue: function(value) {
        function broj (opstina){
          return opstina.id===value
        }
        this.editedItem.postanskiBroj.id=''
      this.brojevi=this.opstine.find(broj)
      },

      // metoda koja daje funkcionalnost pretrage, moze se pretrazivati po svim podacima o uceniku
      customFilter(items, search, filter) {
      search = search.toString().toLowerCase()
       // ovo su podaci koji su odmah vidljivi u tabeli 
      var  filtered= items.filter(i => (
      Object.keys(i).some(j => filter(i[j], search)) 
    ))
    
    if (filtered.length !== 0)
    return filtered
    // podaci koji nisu vidljivi u kolonama/redovima tabela vec samo kada se klikne na ucenika radi prikaza svih preostalih podataka
    else
    {
         return items.filter((item) => {
           item.datum=item.dan+"."+item.mesec+"."+item.godina
           // postoji prioritet pretrage koji je ovde prikazan u poretku uslova, najveci prioritet za drzave pa nazive opstina itd...
        return 
      
        item.pol.nazivPola.toLowerCase().match(this.search.toLowerCase()) ||
      
        item.smer.nazivSmera.toLowerCase().match(this.search.toLowerCase()) ||
     
        item.upisanaSkola.nazivSrednjeSkole.toLowerCase().match(this.search.toLowerCase()) ||
        item.vaspitnaGrupa.naziv.toLowerCase().match(this.search.toLowerCase()) ||
        item.datum.toLowerCase().match(this.search.toLowerCase()) ||
        item.roditelji[0].ime.toLowerCase().match(this.search.toLowerCase()) ||
        item.roditelji[0].prezime.toLowerCase().match(this.search.toLowerCase()) ||
        item.roditelji[0].brojTelefona.toLowerCase().match(this.search.toLowerCase()) ||
        item.roditelji[1].ime.toLowerCase().match(this.search.toLowerCase()) ||
        item.roditelji[1].prezime.toLowerCase().match(this.search.toLowerCase()) ||
        item.roditelji[1].brojTelefona.toLowerCase().match(this.search.toLowerCase()) 

        })
    }
        },
        // v-date-picker generise datum u DD-MM-GGGG formatu koji treba prebaciti u 3 promenljive za dan, mesec i godinu pre nego sto se
        // zeli raditi sa PUT ili POST metodama
       formatiranjeDatuma()
      {
       
          if(this.datum !== null)
          {
          const dan=this.datum.slice(-2); 
          this.editedItem.dan=dan
          const mesec=this.datum.substr(5,2)
          this.editedItem.mesec=mesec
          this.editedItem.godina=this.datum.substring(0,4)
          }

       
      },
      editItem (item) {
        this.editedIndex = this.ucenici.indexOf(item)
        this.editedItem = Object.assign({}, item)
        this.previousItem = Object.assign({}, item)
        this.dialog = true
      },
      deleteItem (item) {
        const index = this.ucenici.indexOf(item)
    // pitanje za potrvrdu o brisanju gde ako se odabere potvrdan odgovor vrsi se poziv HTTP delete-a i brisanje ucenika iz vue-x store-a sa splice
    // na mestu index i broj 1 predstavlja broj ucenika koji se brisu
        confirm('Da li ste sigurni da zelite da izbrisete ovog ucenika?') && this.$store.dispatch('deleteUcenik',item.id)
         && this.ucenici.splice(index,1)
      },
    // ako se odabere opcija close na dijalogu treba editeditem vratiti na pocetni sa praznim podacima
      close () {
        
        this.dialog = false
        setTimeout(() => {
           this.editedItem = Object.assign({}, this.defaultItem)
             this.file=''
             this.imagePreview=''
           this.datum=null
          this.editedIndex = -1
        }, 300)
      },
      // ako se odabere potvrdan odgovor na dijalogu treba uradilit POST ili PUT metod u zavisnosti da li se radi o prijavi ili izmeni ucenika
      save () {
        // na osnovu toga da li postoji editedindex proveravamo da li se radi o novom ili starom uceniku
        // ako postoji onda je stari ucenik i radi se PUT zahtev nakon kojeg se datum i editedItem postavljaju na pocetne vrednosti
        if (this.editedIndex > -1) {    
          this.formatiranjeDatuma()
        
          this.editedItem.roditelji.ucenikID= this.editedItem.id
          
          this.$store.dispatch('editUcenik',this.editedItem)
          this.editedItem = Object.assign({}, this.defaultItem)
          this.file=''
          this.imagePreview=''
          this.datum=null
        } else {
          // u suprotnom radi se o novom uceniku te se vrsi POST metod nakon kojeg se editedItem i datum postavljaju na pocetne vrednosti
          this.formatiranjeDatuma() 
         
          this.$store.dispatch('createUcenik',this.editedItem)
          this.editedItem = Object.assign({}, this.defaultItem)
          this.file=''
          this.imagePreview=''
          this.datum=null
        }
        this.close()
      }  
      }

  }
</script>

<style >

.slidetoleft-enter{
  opacity: 0;
}

.slidetoleft-enter-active{
  animation: slidetoleft-in 1s ease-out forwards;
  transition: opacity 2s ease-out;
  
}

.slidetoleft-leave-active {
  animation: slidetoleft-out 1s ease-out forwards;
  transition: opacity 2s ease-out;
  opacity: 0;
}

#maindiv 
{
  vertical-align: top;
}

.fade-enter-active, .fade-leave-active {
  transition: opacity 2s ease-out;
}

.fade-enter, .fade-leave-to {
  opacity: 0;
}

/* Css koji iskljucuje na input poljima za brojeve HTML5 spinner za brojeve */

input[type="number"]::-webkit-outer-spin-button, 
input[type="number"]::-webkit-inner-spin-button {
    -webkit-appearance: none;
    margin: 0;
}
input[type="number"] {
    -moz-appearance: textfield;
}

/* menanje inicijalnog izgleda tabele*/


table {
  border-top: 1px solid grey   !important;
  border-bottom: 1px solid grey  !important;
  table-layout: fixed; width: 100%;
}
tr:nth-child(even) {background-color: lightgrey;}
td:nth-child(odd) {
    white-space:nowrap;
  overflow:hidden;
  text-overflow:ellipsis;


}td:nth-child(even) {
    white-space:nowrap;
  overflow:hidden;
  text-overflow:ellipsis;
 

}

      @media screen and (max-width: 1225px) and (min-width: 1045px) {
		.priority-5{
			display:none;
		}
    
	}
	
	@media screen and (max-width: 1045px) and (min-width: 835px) {
		.priority-5{
			display:none;
		}
		.priority-4{
			display:none;
		}
	}
	
	@media screen and (max-width: 565px) and (min-width: 300px) {
		.priority-5{
			display:none;
		}
		.priority-4{
			display:none;
		}
		.priority-3{
			display:none;
		}
	}
	
	@media screen and (max-width: 300px) {
		.priority-5{
			display:none;
		}
		.priority-4{
			display:none;
		}
		.priority-3{
			display:none;
		}
		.priority-2{
			display:none;
		}
	
	}

  @media screen and (max-width: 300px) {
   table tr:nth-child(1)
    {
      display:none;
    }
	
	}

  .responsive {
    width: 100%;
    height: auto;
    
}
</style>
