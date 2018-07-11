
<template>
  <div>
    <v-toolbar  color="white">
       <v-toolbar-title >Spisak prijavljenih ucenika</v-toolbar-title>
        <v-divider
        class="mx-2"
        inset
        vertical
      ></v-divider>
      <v-spacer></v-spacer>
      
    <v-dialog v-model="dialog" max-width="600">
      <v-btn  slot="activator" color="blue-grey darken-2" dark class="mb-2">Prijavi ucenika</v-btn>
      <v-card>
        <v-card-title>
          <span class="headline">{{ formTitle }}</span>
        </v-card-title>
        <v-card-text>
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
                <h3 dark class="mb-2">Datum Rodjenja</h3>              
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
        </v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" flat @click.native="close">
            Otkazi
            </v-btn>
          <v-btn color="blue darken-1" flat @click.native="save"  :disabled="!formIsValid"
          >Sacuvaj
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
     </v-toolbar>
    <v-layout wrap justify-center=""> 
        <v-flex xs12 sm8 md6 class="text-xs-center">
        <v-progress-circular
          indeterminate
          class="primary--text"
          :width="7"
          :size="150"
          v-if="loading"></v-progress-circular>
      </v-flex>
    </v-layout>

    <v-card >
      <v-layout wrap justify-end >
  
        <v-flex xs3 >
        <v-text-field
        v-model="search"
        append-icon="search"
        label="Pretraga"
        single-line
        hide-details
      ></v-text-field> 
        </v-flex>
      </v-layout>

   
    <v-data-table
      :headers="headers"
      :items="ucenici"
       v-if="!loading"
      rows-per-page-text="Redova po stranici"
      :rows-per-page-items="[5,10,15,20,25,30,35]"
      :search="search"
      hide-actions
      single-line
      :custom-filter="customFilter"
      class="elevation-1"    
     >
      <template slot="items" slot-scope="props" >
        <tr @click="props.expanded = !props.expanded">
        <td class="text-xs-center">{{ props.item.id}}</td>
        <td class="text-xs-center">{{ props.item.ime }}</td>
        <td class="text-xs-center">{{ props.item.prezime }}</td>
        <td class="text-xs-center">{{ props.item.jmbg }}</td>
        <td class="text-xs-center">{{ props.item.pol.nazivPola }}</td>
        <td class="text-xs-center">{{ props.item.dan }}.{{ props.item.mesec }}.{{ props.item.godina }}.</td>
        <td class="text-xs-center">{{ props.item.mestoRodjenja }}</td>
        <td class="text-xs-center">{{ props.item.opstina.nazivOpstine }}</td>
        <td class="justify-center layout px-0">         
          <v-btn center  icon class="mx-0"
           @click="editItem(props.item)">
            <v-icon
             color="teal">edit
             </v-icon>
          </v-btn>
          <v-btn center icon class="mx-0"
           @click="deleteItem(props.item)">
            <v-icon
              color="pink">delete
              </v-icon>
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
        Od {{ pageStart }} do {{ pageStop }}
</template>
              <template slot="expand" slot-scope="props">
                <v-card flat>
                  <v-card-text> <h2>Ostali podaci</h2> </v-card-text>
                  <v-layout  xs12 sm8 md6  row wrap>  
                      <v-flex xs2>
                   <v-subheader>Postanski broj:</v-subheader> 
                       </v-flex>
                         <v-flex xs2>
                            <v-card-text class="text-lg-left">
                                {{ props.item.postanskiBroj.broj }}
                              </v-card-text>
                          </v-flex>                   
                       <v-flex xs2>
                      <v-subheader v-text="'Drzava rodjenja: '"></v-subheader>
                       </v-flex>
                     <v-flex xs2>
                            <v-card-text class="text-lg-left">
                                {{ props.item.drzavaRodjenja.nazivDrzave }}
                              </v-card-text>
                          </v-flex>
                      <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Mesto prebivalista: '"></v-subheader>
                       </v-flex>
                       <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.mestoPrebivalista }}
                              </v-card-text>
                       </v-flex>
                         <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Opstina prebivalista: '"></v-subheader>
                       </v-flex>
                       <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.opstinaPrebivalista.nazivOpstine }}
                              </v-card-text>
                       </v-flex>                  
                     <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Kucni telefon: '"></v-subheader>
                       </v-flex>
                       <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.telefon.kucni }}
                              </v-card-text>
                       </v-flex>
                         <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Mobilni telefon: '"></v-subheader>
                       </v-flex>

                       <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.telefon.mobilni }}
                              </v-card-text>
                       </v-flex>
                    </v-layout>                  
                </v-card>
              </template>
    <v-alert slot="no-results" :value="true" color="error" icon="warning">
        Vasa pretraga za "{{ search }}" nije pronasla rezultate.
      </v-alert>
    </v-data-table>

    </v-card>

  </div>
</template>


<script>
/* eslint-disable */
import moment from 'moment'

  export default {
    data: () => ({
      dialog: false,
      headers: [
        {
          text: 'Redni broj',
          align: 'center',
          sortable: true,
           value: 'id',
           width:'5%'
           
        },
        { text: 'Ime',value: 'ime' ,align: 'center',sortable:true, width:'10%'},
        { text: 'Prezime', value:'prezime', align: 'center',sortable:true,width:'10%'},
        { text: 'JMBG', value:'jmbg',align: 'center',sortable:true ,width:'10%'},
        { text: 'Pol', value: 'pol.nazivPola',align: 'center',sortable:true,width:'10%' },
        { text: 'Datum rodjenja', value: 'godina',align: 'center',sortable:true,width:'10%' },
        { text: 'Mesto rodjenja', value: 'mestoRodjenja',align: 'center',sortable:true,width:'10%' },
        { text: 'Opstina rodjenja', value: 'opstina.nazivOpstine',align: 'center',sortable:true ,width:'10%'},
        { text: 'Opcije', value: 'opcije',align: 'center',sortable:false,width:'10%' }
      ],
           rules: {
          required: (value) => !!value || 'Ovo polje je obavezno.',
          jmbg: (value) => {
            const pattern = /^(\w{13,13})$/ 
            return pattern.test(value) || 'Jmbg mora biti dugacak 13 cifara.'
          }
        },
      datum: null,
      search: '',
      editedIndex: -1,
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
      },

      defaultItem: {
        ime: '',
        prezime: '',
        jmbg: '',
        dan: '',
        mesec: '',
        godina: '',
        mestoRodjenja: '',
        mestoPrebivalista: '',
        pol: {
          id: '',
          nazivPola: ''
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
      },
      formTitle () {
        return this.editedIndex === -1 ? 'Prijavi novog ucenika' : 'Izmeni'
      }
    },
    watch: {
      dialog (val) {
        val || this.close()
      }
    },
    methods: {
      changedValue: function(value) {
        function broj (opstina){
          return opstina.id===value
        }
      this.brojevi=this.opstine.find(broj)
      },
      
      
      customFilter(items, search, filter) {
      search = search.toString().toLowerCase()
        
      var  filtered= items.filter(i => (
      Object.keys(i).some(j => filter(i[j], search)) 
    ))
    
    if (filtered.length !== 0)
    return filtered
    else
    {
         return items.filter((item) => {
           item.datum=item.dan+"."+item.mesec+"."+item.godina
           
        return item.drzavaRodjenja.nazivDrzave.toLowerCase().match(this.search.toLowerCase()) ||
        item.opstina.nazivOpstine.toLowerCase().match(this.search.toLowerCase()) ||
        item.pol.nazivPola.toLowerCase().match(this.search.toLowerCase()) ||
        item.opstinaPrebivalista.nazivOpstine.toLowerCase().match(this.search.toLowerCase()) ||
        item.telefon.kucni.toLowerCase().match(this.search.toLowerCase()) ||
        item.telefon.mobilni.toLowerCase().match(this.search.toLowerCase()) ||
        item.postanskiBroj.broj.toLowerCase().match(this.search.toLowerCase()) ||
        item.datum.toLowerCase().match(this.search.toLowerCase())
        })
    }
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
      editItem (item) {
        this.editedIndex = this.ucenici.indexOf(item)
        this.editedItem = Object.assign({}, item)
        this.dialog = true
      },
      deleteItem (item) {
        const index = this.ucenici.indexOf(item)
   
        confirm('Da li ste sigurni da zelite da izbrisete ovog ucenika?') && this.$store.dispatch('deleteUcenik',item.id) && this.ucenici.splice(index,1)
      },
      close () {
        this.dialog = false
        setTimeout(() => {
          this.editedItem = Object.assign({}, this.defaultItem)
          this.editedIndex = -1
        }, 300)
      },
      save () {
        if (this.editedIndex > -1) {    
          this.formatiranjeDatuma()
         // Object.assign(this.ucenici[this.editedIndex], this.editedItem)
          this.$store.dispatch('editUcenik',this.editedItem)
          this.editedItem = Object.assign({}, this.defaultItem)
        } else {
          this.formatiranjeDatuma() 
          console.log(this.editedItem)      
          this.$store.dispatch('createUcenik',this.editedItem)
          this.editedItem = Object.assign({}, this.defaultItem)
        }
        this.close()
      }  
      }

  }
</script>

<style scoped>
  .title {
    position: absolute;
    bottom: 50px;
    background-color: rgba(0,0,0,0.5);
    color: white;
    font-size: 2em;
    padding: 20px;
  }
</style>