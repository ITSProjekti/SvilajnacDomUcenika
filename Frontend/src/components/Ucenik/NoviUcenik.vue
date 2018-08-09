<template>
<v-container>
    <v-layout row>
        <v-flex xs12  >
            <h1> Prijava novog učenika</h1>
        </v-flex>
    </v-layout>
    <v-layout row wrap>
        <v-flex xs12>
            <form @submit.prevent="PrijavaUcenika">
        <v-container grid-list-md>
            <v-layout wrap>
              
              
     <v-flex xs10 class="ml-5">
            <v-card >
              <v-card-title  primary-title>
                <v-flex offset-sm5>
                <div class="headline">Podaci o učeniku</div>
              </v-flex>
              </v-card-title>


            <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                 v-model="editedItem.ime"
                  label="Ime" 
                  required
                   :rules="[rules.required]"
                  ></v-text-field>
              </v-flex>
              </v-flex>

            <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                 v-model="editedItem.prezime"
                  label="Prezime"
                   required
                   :rules="[rules.required]"
                   ></v-text-field>
              </v-flex>
             </v-flex>

       


       <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                  v-model="editedItem.jmbg"
                  label="jmbg"
                  required
                  progress
                  input type="number"  onkeydown="javascript: if(event.keyCode == 69) {return false} else 
                  {
                   if(event.keyCode == 107) {return false}
                    else {
                   if(event.keyCode == 190) {return false}
                    else {
                   if(event.keyCode == 109) {return false}
                    else  {
                   if(event.keyCode == 187) {return false}
                    else  {
                   if(event.keyCode == 189) {return false}
                   else
                     {return true} } } } } }"                                       
                  :rules="[rules.required,rules.jmbg]"
                  :counter="13"
                  loading
                        >
                        <v-progress-linear
                      v-if="custom"
                      slot="progress"
                      :value="progress"
                      :color="color"
                      height="7"
                    ></v-progress-linear>
                        
                        </v-text-field>
              </v-flex>
          </v-flex>

          <v-flex offset-sm1 xs12>
                   <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                 v-model="editedItem.adresa"
                  label="Adresa prebivališta" 
                  required
                   :rules="[rules.required]"
                  ></v-text-field>
              </v-flex>
          </v-flex>

              <template>
                 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1  xs12 sm3 class="mt-4 ">
                     <p>Država rođenja</p>
                    </v-flex>
                           <v-flex xs12 sm3>
                               <v-select
                                :loading="loading"
                                :items="drzave"
                                v-model="editedItem.drzavaRodjenja.id"
                                label="Država"
                                item-text="nazivDrzave"
                                item-value="id"
                                autocomplete
                                required
                                 :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>
                      </template>
                <template>
                 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
                     <p>Pol</p>
                    </v-flex>
                           <v-flex xs12 sm3>
                               <v-select
                                :loading="loading"
                                :items="polovi"
                                v-model="editedItem.pol.id"
                                 item-text="nazivPola"
                                 item-value="id"
                                label="Pol"
                                autocomplete
                                required
                                 :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>
                      </template>
              <template>
                 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
                     <p>Opstina rođenja</p>
                    </v-flex>
                           <v-flex xs12 sm4>
                               <v-select
                                :loading="loading"
                                :items="opstine"
                                v-model="editedItem.opstina.id"
                                label="Izaberite opštinu rođenja"
                                item-text="nazivOpstine"
                                item-value="id"
                                autocomplete
                                required
                                 :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>
                      </template>
                      <template>
                 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
                     <p>Opština prebivališta</p>
                    </v-flex>
                           <v-flex xs12 sm5>
                               <v-select
                                :loading="loading"
                                :items="opstine"
                                v-model="editedItem.opstinaPrebivalista.id"
                                label="Izaberite opštinu prebivališta"
                                item-text="nazivOpstine"
                                item-value="id"
                                @change="changedValue"
                                autocomplete
                                required
                                 :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>
                      </template>
                      <template>
                 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
                   <p>Poštanski broj</p>
                    </v-flex>
                           <v-flex xs12 sm5>
                               <v-select
                                :loading="loading"
                                :items="brojevi.postanskiBrojevi"
                                v-model="editedItem.postanskiBroj.id"
                                 v-if="editedItem.opstinaPrebivalista.id !== '' "
                                label="Poštanski broj opštine prebivališta"
                                item-text="broj"
                                item-value="id"
                                autocomplete
                                required
                                 :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>
                      </template>
                     <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
                     <p>Mesto rođenja</p>
                    </v-flex>
                           <v-flex xs12 sm4>
                               <v-select
                                :loading="loading"
                                :items="mesta"
                                v-model="editedItem.mestoRodjenja.id"
                                label="Izaberite mesto rođenja"
                                item-text="nazivMesta"
                                item-value="id"
                                autocomplete
                                required
                                 :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>
                      <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
                     <p>Mesto prebivališta</p>
                    </v-flex>
                           <v-flex xs12 sm4>
                               <v-select
                                :loading="loading"
                                :items="mesta"
                                v-model="editedItem.mestoPrebivalista.id"
                                label="Izaberite mesto rođenja"
                                item-text="nazivMesta"
                                item-value="id"
                                autocomplete
                                required
                                 :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>

                        <v-container fluid>
                    <v-layout row wrap>
                       <v-flex offset-sm1  xs12 sm3 >
                      <p >Datum Rođenja</p>   
                      </v-flex>  
                      <v-flex xs12 sm6>         
                            <v-date-picker
                            v-model="datum"
                            locale="sr-Latn"
                            ></v-date-picker>
                            <template v-if="editedItem.dan !== ''"> 
                              <p>Prethodni: {{ editedItem.dan }}.{{ editedItem.mesec }}.{{editedItem.godina }}</p>
                              </template>  
                            <p>Novi: {{datum}}</p>
                          </v-flex>
                          </v-layout>
                        </v-container>




                               <v-container fluid>
                              <v-layout row wrap>
                              <v-flex offset-sm1  xs12 sm3 class="mt-4">
                              <p>Završena škola (osnovna)</p>
                              </v-flex>
                                    <v-flex xs12 sm4>
                                        <v-select
                                          :loading="loading"
                                          :items="osnovneSkole"
                                          v-model="editedItem.prethodnaSkola.id"
                                          label="Izaberite završenu školu"
                                          item-text="nazivPrethodneSkole"
                                          item-value="id"
                                          autocomplete
                                          required
                                          :rules="[rules.required]"
                                        ></v-select>
                                      </v-flex>
                                    </v-layout>
                                  </v-container>
                               <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
                     <p>Mesto prethodno zavrsene škole</p>
                    </v-flex>
                           <v-flex xs12 sm6>
                               <v-select
                                :loading="loading"
                                :items="mesta"
                                v-model="editedItem.mestoZavrseneSkole.id"
                                label="Izaberite mesto prethodno završene škole"
                                item-text="nazivMesta"
                                item-value="id"
                                autocomplete
                                required
                                :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>
                               <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
                     <p>Srednja škola koju učenik upisuje</p>
                    </v-flex>
                           <v-flex xs12 sm6>
                               <v-select
                                :loading="loading"
                                :items="srednjeSkole"
                                v-model="editedItem.upisanaSkola.id"
                                label="Izaberite srednju školu koju učenik upisuje"
                                item-text="nazivSrednjeSkole"
                                item-value="id"
                                autocomplete
                                required
                                 :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>
                        <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1 xs12 sm3 class="mt-4">
                     <p>Smer koji učenik upisuje</p>
                    </v-flex>
                           <v-flex xs12 sm5>
                               <v-select
                                :loading="loading"
                                :items="smerovi"
                                v-model="editedItem.smer.id"
                                label="Izaberite smer koji učenik upisuje"
                                item-text="nazivSmera"
                                item-value="id"
                                autocomplete
                                required
                                 :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>             
                        </v-container>
                              <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1 xs12 sm3 class="mt-4">
                     <p>Razred koji učenik upisuje</p>
                    </v-flex>
                           <v-flex xs12 sm2>
                               <v-select
                            :loading="loading"
                                :items="razredi"
                                v-model="editedItem.razred.id"
                                 item-text="brojRazreda"
                                 item-value="id"
                                label="Razred"
                                autocomplete
                                required
                                 :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>             
                        </v-container>

                  <v-container fluid>
                    <v-layout row wrap>
              <v-flex offset-sm1  xs12 sm3 class="mt-4">
                <p>Prethodni uspeh ucenika</p>
                </v-flex>
                <v-flex xs2 class="mt-2" >
                   
                <v-text-field
               v-model="editedItem.prethodniUspeh"                 
                   label="br"
                    input type="number"     onkeydown="javascript: if(event.keyCode == 69) {return false} else 
                  {
                   if(event.keyCode == 107) {return false}
                    else {
          
                   if(event.keyCode == 109) {return false}
                    else  {
                   if(event.keyCode == 187) {return false}
                    else  {
                   if(event.keyCode == 189) {return false}
                   else
                     {return true} } } }  }" 
                    required
                    :rules="[rules.required,rules.uspehX]"
                   ></v-text-field>
              
              </v-flex>
                  </v-layout>             
                        </v-container>

        <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
               v-model="editedItem.telefon.mobilni"                 
                   label="Mobilni telefon"

                  ></v-text-field>
              </v-flex>
              </v-flex>

                  <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
               v-model="editedItem.telefon.kucni"                
                   label="Kućni telefon" 

                  ></v-text-field>
              </v-flex>
              </v-flex>

   </v-card>
          </v-flex>
<v-flex xs12>
  <p>
<br>
<br>
  </p>
</v-flex>


       <v-flex xs10 class="ml-5">
            <v-card >
              <v-card-title primary-title>
                <v-flex offset-sm4>
                <div class="headline">Podaci o roditelju - staratelju </div>
              </v-flex>
              </v-card-title>

            <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                    v-model="editedItem.roditelji[1].ime"                
                   label="Ime majke"   
                      required
                      :rules="[rules.required]" 
                  ></v-text-field>
              </v-flex>
              </v-flex>

             <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                    v-model="editedItem.roditelji[1].prezime"  
                    required
                    :rules="[rules.required]"              
                   label="Prezime majke" 
                  ></v-text-field>
              </v-flex>
              </v-flex>

                 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1 xs12 sm3 class="mt-4">
                     <p>Stepen strucne spreme majke</p>
                    </v-flex>
                           <v-flex xs12 sm6>
                               <v-select
                                :loading="loading"
                                :items="StepeniStrucneSpreme"
                                v-model="editedItem.roditelji[1].stepenObrazovanjaId"
                                label="Izaberite stepen obrazovanja"
                                item-text="opis"
                                item-value="id"
                                autocomplete
                                required
                                 :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>

       <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                  v-model="editedItem.roditelji[1].brojTelefona" 
                    required
                    :rules="[rules.required]"               
                   label="Broj telefona majke"  
                  ></v-text-field>
              </v-flex>
              </v-flex>

            <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
               v-model="editedItem.roditelji[0].ime" 
                    required
                    :rules="[rules.required]"               
                   label="Ime oca" 
                  ></v-text-field>
              </v-flex>
              </v-flex>

     <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                       v-model="editedItem.roditelji[0].prezime"                
                   label="Prezime oca"  
                      required
                      :rules="[rules.required]"   
                  ></v-text-field>
              </v-flex>
              </v-flex>

               <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1 xs12 sm3 class="mt-4">
                     <p>Stepen strucne spreme oca</p>
                    </v-flex>
                           <v-flex xs12 sm6>
                               <v-select
                                :loading="loading"
                                :items="StepeniStrucneSpreme"
                                v-model="editedItem.roditelji[0].stepenObrazovanjaId"
                                label="Izaberite stepen obrazovanja"
                                item-text="opis"
                                item-value="id"
                                autocomplete
                                required
                                 :rules="[rules.required]"
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>


   <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                   v-model="editedItem.roditelji[0].brojTelefona" 
                    required
                    :rules="[rules.required]"               
                   label="Broj telefona oca"   
                  ></v-text-field>
              </v-flex>
              </v-flex>

   </v-card>
          </v-flex>

               <v-flex xs12 sm6  offset-sm5  offset-xs4 >
              <v-btn
                class="primary"
                
                :disabled="!formIsValid"
                type="submit">Prijavi učenika</v-btn>
            </v-flex>            
            </v-layout>
          </v-container>
            </form>
        </v-flex>
    </v-layout>
</v-container>
</template>


<script>
/* eslint-disable */
import moment from 'moment'
  export default {
    data: () => ({   
      // rules su pravila popunjavanja polja za unos
           rules: {
      // requiered pravilo je pravilo za neophodnost postojanja informacije koja se trazi na odgovarajucem polju sa opcijom requiered
          required: (value) => !!value || 'Ovo polje je obavezno.',
       jmbg: (value) => {
            const pattern = /^(\w{13,13})$/ 
            return pattern.test(value) || 'Jmbg mora biti dugacak 13 cifara.'
          },
     
           uspehX: (value) => {
            const pattern = /^([1-4](\.\d+){1}|5(\.0+)?)$/
            return pattern.test(value) || 'Uspeh mora biti u formatu B.BB (B - broj).'
          }
        },
      // pomocna promenljiva za generisanje podatka o datumu rodjenja
      datum: null,
      
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
          ]
      
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
          this.editedItem.roditelji[0].ime !== '' &&
          this.editedItem.roditelji[0].prezime !== '' &&
          this.editedItem.roditelji[0].stepenObrazovanjaId !== '' &&
          this.editedItem.roditelji[0].brojTelefona !== '' &&
          this.editedItem.roditelji[1].ime !== '' &&
          this.editedItem.roditelji[1].prezime !== '' &&
          this.editedItem.roditelji[1].stepenObrazovanjaId !== '' &&
          this.editedItem.roditelji[1].brojTelefona !== '' &&
          this.datum !== null
          )
          {
            return true
            }
          else{
            return false
          }
         
      },
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
      }
     
    },
   
    methods: {


      
      changedValue: function(value) {
        function broj (opstina){
          return opstina.id===value
        }
      this.brojevi=this.opstine.find(broj)
      },

       formatiranjeDatuma()
      {
        console.log(this.datum)
          if(this.datum !== null)
          {
          const dan=this.datum.slice(-2); 
          this.editedItem.dan=dan
          const mesec=this.datum.substr(5,2)
          this.editedItem.mesec=mesec
          this.editedItem.godina=this.datum.substring(0,4)
          } 
      },
      PrijavaUcenika () {
      
        this.formatiranjeDatuma() 
        console.log(this.editedItem)      
        this.$store.dispatch('createUcenik',this.editedItem)
        this.$router.push('/ucenici')
      }  
      }
  }
</script>

<style>




</style>
