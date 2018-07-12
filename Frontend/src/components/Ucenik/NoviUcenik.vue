<template>
<v-container>
    <v-layout row>
        <v-flex xs12>
            <h1> Prijava novog ucenika</h1>
        </v-flex>
    </v-layout>
    <v-layout row wrap>
        <v-flex xs12>
            <form @submit.prevent="PrijavaUcenika">
            <v-container grid-list-md>
            <v-layout wrap>
              <v-flex xs12 >
                <v-text-field
                 v-model="editedItem.ime"
                  label="Ime" 
                  required
                   :rules="[rules.required]"
                  ></v-text-field>
              </v-flex>
              <v-flex xs12 >
                <v-text-field
                 v-model="editedItem.prezime"
                  label="Prezime"
                   required
                   :rules="[rules.required]"
                   ></v-text-field>
              </v-flex>
              <v-flex xs12 >
                <v-text-field
                  v-model="editedItem.jmbg"
                  label="jmbg"
                  required
                  input type="number"
                  :rules="[rules.required,rules.jmbg]"
                  :counter="13"
                    ></v-text-field>
              </v-flex>
              <template>
                 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex xs12 sm6>
                     <v-subheader v-text="'Drzava rodjenja'"></v-subheader>
                    </v-flex>
                           <v-flex xs12 sm6>
                               <v-select
                                :loading="loading"
                                :items="drzave"
                                v-model="editedItem.drzavaRodjenja.id"
                                label="Drzava"
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
                    <v-flex xs12 sm6>
                     <v-subheader v-text="'Pol'"></v-subheader>
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
                    <v-flex xs12 sm6>
                     <v-subheader v-text="'Opstina rodjenja'"></v-subheader>
                    </v-flex>
                           <v-flex xs12 sm6>
                               <v-select
                                :loading="loading"
                                :items="opstine"
                                v-model="editedItem.opstina.id"
                                label="Izaberite opstinu rodjenja"
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
                    <v-flex xs12 sm6>
                     <v-subheader v-text="'Opstina Prebivalista'"></v-subheader>
                    </v-flex>
                           <v-flex xs12 sm6>
                               <v-select
                                :loading="loading"
                                :items="opstine"
                                v-model="editedItem.opstinaPrebivalista.id"
                                label="Izaberite opstinu prebivalista"
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
                    <v-flex xs12 sm6>
                    <v-subheader v-text="'Postanski broj'"></v-subheader> 
                    </v-flex>
                           <v-flex xs12 sm6>
                               <v-select
                                :loading="loading"
                                :items="brojevi.postanskiBrojevi"
                                v-model="editedItem.postanskiBroj.id"
                                 v-if="editedItem.opstinaPrebivalista.id !== ''"
                                label="Izaberite postanski broj opstine prebivalista"
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
              <v-flex xs12 >
                <v-text-field
                 v-model="editedItem.mestoRodjenja"
                  required
                   label="Mesto rodjenja"
                    :rules="[rules.required]"
                   ></v-text-field>
              </v-flex>
               <v-flex xs12 >
                <v-text-field
                 v-model="editedItem.mestoPrebivalista"
                  required
                   label="Mesto prebivalista"
                    :rules="[rules.required]"
                   ></v-text-field>
              </v-flex>
               <v-flex xs12 >
                <v-text-field
                 v-model="editedItem.telefon.mobilni"                 
                   label="Mobilni telefon"
                   ></v-text-field>
              </v-flex>
               <v-flex xs12 >
                <v-text-field
                 v-model="editedItem.telefon.kucni"                
                   label="Kucni telefon"    
                   ></v-text-field>
              </v-flex>
              <v-flex xs12 >
                <p>Datum rođenja</p>             
                <v-date-picker
                 v-model="datum"
                 locale="sr-Latn"
                 ></v-date-picker>
                 <p>Trenutni: {{datum}}</p>
              </v-flex>  
               <v-flex xs12 sm6 offset-sm9>
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
       pol: {
          id: '',
          nazivPola: ''
       },
        dan: '',
        mesec: '',
        godina: '',
        mestoRodjenja: '',
        mestoPrebivalista: '',
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
          }
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
          this.editedItem.mestoRodjenja !== '' &&
          this.editedItem.mestoPrebivalista !== '' &&
          this.datum !== null)
          {
            return true
            }
          else{
            return false
          }
         
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