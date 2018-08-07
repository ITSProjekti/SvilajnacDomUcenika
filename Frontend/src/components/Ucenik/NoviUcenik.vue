<template>
<v-container>
    <v-layout row>
        <v-flex xs12>
            <h1> Prijava novog učenika</h1>
        </v-flex>
    </v-layout>
    <v-layout row wrap>
        <v-flex xs12>
            <form @submit.prevent="PrijavaUcenika">
<v-container grid-list-md>
            <v-layout wrap>
              
              <v-flex xs12 class="ml-3" >
                <v-text-field
                 v-model="editedItem.ime"
                  label="Ime" 
                  required
                   :rules="[rules.required]"
                  ></v-text-field>
              </v-flex>
              
              <v-flex xs12 class="ml-3" >
                <v-text-field
                 v-model="editedItem.prezime"
                  label="Prezime"
                   required
                   :rules="[rules.required]"
                   ></v-text-field>
              </v-flex>
            
              <v-flex xs12 class="ml-3" >
                <v-text-field
                  v-model="editedItem.jmbg"
                  label="jmbg"
                  required
                  input type="number"
                  :rules="[rules.required,rules.jmbg]"
                  :counter="13"
                    ></v-text-field>
              </v-flex>
                   <v-flex xs12 class="ml-3" >
                <v-text-field
                 v-model="editedItem.adresa"
                  label="Adresa prebivališta" 
                  required
                   :rules="[rules.required]"
                  ></v-text-field>
              </v-flex>
              <template>
                 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex xs6 class="mt-4 ">
                     <p>Država rođenja</p>
                    </v-flex>
                           <v-flex xs12 sm6>
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
                    <v-flex xs12 sm6 class="mt-4">
                     <p>Pol</p>
                    </v-flex>
                           <v-flex xs12 sm6>
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
                    <v-flex xs12 sm6 class="mt-4">
                     <p>Opstina rođenja</p>
                    </v-flex>
                           <v-flex xs12 sm6>
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
                    <v-flex xs12 sm6 class="mt-4">
                     <p>Opština prebivališta</p>
                    </v-flex>
                           <v-flex xs12 sm6>
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
                    <v-flex xs12 sm6 class="mt-4">
                   <p>Poštanski broj</p>
                    </v-flex>
                           <v-flex xs12 sm6>
                               <v-select
                                :loading="loading"
                                :items="brojevi.postanskiBrojevi"
                                v-model="editedItem.postanskiBroj.id"
                                 v-if="editedItem.opstinaPrebivalista.id !== '' "
                                label="Izaberite poštanski broj opštine prebivališta"
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
                    <v-flex xs12sm6 class="mt-4">
                     <p>Mesto rođenja</p>
                    </v-flex>
                           <v-flex xs12 sm6>
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
                    <v-flex xs12 sm6 class="mt-4">
                     <p>Mesto prebivališta</p>
                    </v-flex>
                           <v-flex xs12 sm6>
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
                    <v-flex xs12 sm6 class="mt-4">
                     <p>Završena škola (osnovna)</p>
                    </v-flex>
                           <v-flex xs12 sm6>
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
                    <v-flex xs12 sm6 class="mt-4">
                     <p>Mesto prethodno zavrsene škole</p>
                    </v-flex>
                           <v-flex xs12 >
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
                    <v-flex xs12 sm6 class="mt-4">
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
                    <v-flex xs12 sm6 class="mt-4">
                     <p>Smer koji učenik upisuje</p>
                    </v-flex>
                           <v-flex xs12 sm6>
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
                          <template>
                 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex xs12 sm6 class="mt-4">
                     <p>Razred koji učenik upisuje</p>
                    </v-flex>
                           <v-flex xs12 sm6>
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
                      </template>
                        </v-container>
              <v-flex xs12 class="ml-3">
             <p>Prethodni uspeh ucenika</p>
                <v-flex xs2 class="ml-3">
                <v-text-field
                 v-model="editedItem.prethodniUspeh"                 
                   label="br"
                   ></v-text-field>
              </v-flex>
              </v-flex>
               <v-flex xs6 class="ml-3">
                <v-text-field
                 v-model="editedItem.telefon.mobilni"                 
                   label="Mobilni telefon"
                   ></v-text-field>
              </v-flex>
               <v-flex xs6 class="ml-3">
                <v-text-field
                 v-model="editedItem.telefon.kucni"                
                   label="Kućni telefon"    
                   ></v-text-field>
              </v-flex>
    
               <v-flex xs6 class="ml-3">
                <v-text-field
                 v-model="editedItem.roditelji[1].ime"                
                   label="Ime majke"   
                      required
                      :rules="[rules.required]" 
                   ></v-text-field>
              </v-flex>
               <v-flex xs6 class="ml-3">
                <v-text-field
                 v-model="editedItem.roditelji[1].prezime"  
                    required
                    :rules="[rules.required]"              
                   label="Prezime majke"    
                   ></v-text-field>
              </v-flex>
                 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex xs12 sm6 class="mt-4">
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
                <v-flex xs6 class="ml-3">
                <v-text-field
                 v-model="editedItem.roditelji[1].brojTelefona" 
                    required
                    :rules="[rules.required]"               
                   label="Broj telefona majke"    
                   ></v-text-field>
              </v-flex>
               <v-flex xs6 class="ml-3">
                <v-text-field
                 v-model="editedItem.roditelji[0].ime" 
                    required
                    :rules="[rules.required]"               
                   label="Ime oca"    
                   ></v-text-field>
              </v-flex>
               <v-flex xs6 class="ml-3">
                <v-text-field
                 v-model="editedItem.roditelji[0].prezime"                
                   label="Prezime oca"  
                      required
                      :rules="[rules.required]"  
                   ></v-text-field>
              </v-flex>
               <v-container fluid>
                    <v-layout row wrap>
                    <v-flex xs12 sm6 class="mt-4">
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
                        <v-flex xs6 class="ml-3">
                <v-text-field
                 v-model="editedItem.roditelji[0].brojTelefona" 
                    required
                    :rules="[rules.required]"               
                   label="Broj telefona oca"    
                   ></v-text-field>
              </v-flex>
              <v-flex xs12 class="ml-3">
                <p class="mb-2">Datum Rođenja</p>              
                <v-date-picker
                 v-model="datum"
                 locale="sr-Latn"
                 ></v-date-picker>
                <template v-if="editedItem.dan !== ''"> 
                  <p>Prethodni: {{ editedItem.dan }}.{{ editedItem.mesec }}.{{editedItem.godina }}</p>
                  </template>  
                 <p>Novi: {{datum}}</p>
              </v-flex> 
               <v-flex xs12 sm6 class="ml-3" offset-sm10>
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
           rules: {
          required: (value) => !!value || 'Ovo polje je obavezno.',
          jmbg: (value) => {
            const pattern = /^(\w{13,13})$/ 
            return pattern.test(value) || 'Jmbg mora biti dugacak 13 cifara.'
          }
        },
      datum: null,
      brojevi: '',
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
    computed: { formIsValid () {      
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
