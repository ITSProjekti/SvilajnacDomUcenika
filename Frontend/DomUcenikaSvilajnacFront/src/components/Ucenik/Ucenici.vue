
<template>
  <div>
    <v-dialog v-model="dialog" max-width="700">
      <v-btn slot="activator" color="primary" dark class="mb-2">Prijavi ucenika</v-btn>
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
                  :rules="[rules.required, rules.jmbg]"
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
                                :items="pol"
                                v-model="editedItem.pol"
                                 item-text="editedItem.pol"
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
    <v-layout> 
        <v-flex xs12 class="text-xs-center">
        <v-progress-circular
          indeterminate
          class="primary--text"
          :width="7"
          :size="150"
          v-if="loading"></v-progress-circular>
      </v-flex>
    </v-layout>
    <v-card>
      <v-layout xs12>
        <v-card-title>
          <h2>Lista ucenika</h2> 
      <v-spacer></v-spacer>
        <v-flex xs12 sm6 class="text-sm-left" absolute> 
      <v-text-field
        v-model="search"
        append-icon="search"
        label="Pretraga"
        single-line
        hide-details
      ></v-text-field> 
        </v-flex>    
    </v-card-title>
      </v-layout>
    <v-layout xs12 sm6  row wrap class="mt-2" absolute v-if="!loading">
   
    <v-data-table
      :headers="headers"
      :items="ucenici"
      rows-per-page-text="Redova po stranici"
      :rows-per-page-items="[5,10,15,20,25,30,35]"
      :search="search"
      :custom-filter="customFilter"
      class="text-xs-center"
    
     >
      <template slot="items" slot-scope="props" >
        <tr @click="props.expanded = !props.expanded">
        <td class="text-xs-center">{{ props.item.id}}</td>
        <td class="text-xs-center">{{ props.item.ime }}</td>
        <td class="text-xs-center">{{ props.item.prezime }}</td>
        <td class="text-xs-center">{{ props.item.jmbg }}</td>
        <td class="text-xs-center">{{ props.item.pol }}</td>
        <td class="text-xs-center">{{ props.item.dan }}.{{ props.item.mesec }}.{{ props.item.godina }}.</td>
        <td class="text-xs-center">{{ props.item.mestoRodjenja }}</td>
        <td class="text-xs-center">{{ props.item.opstina.nazivOpstine }}</td>
        <td class="justify-center layout px-0">
         
          <v-btn center  icon class="mx-0" @click="editItem(props.item)">
            <v-icon color="teal">edit</v-icon>
          </v-btn>
          <v-btn center icon class="mx-0" @click="deleteItem(props.item)">
            <v-icon  color="pink">delete</v-icon>
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
                  <v-card-text>Ostali podaci</v-card-text>
                    <v-flex xs12>
                      <v-subheader v-text="'Postanski broj'"></v-subheader>
                      <td class="text-xs-center">{{ props.item.opstina.postanskiBroj }}</td>
                      <v-subheader v-text="'Drzava rodjenja'"></v-subheader>
                      <td class="text-xs-center">{{ props.item.drzavaRodjenja.nazivDrzave }}</td>
                       <v-subheader v-text="'Mesto prebivalista'"></v-subheader>
                      <td class="text-xs-center">{{ props.item.mestoPrebivalista }}</td>
                    </v-flex>                  
                </v-card>
              </template>
    <v-alert slot="no-results" :value="true" color="error" icon="warning">
        Vasa pretraga za "{{ search }}" nije pronasla rezultate.
      </v-alert>
    </v-data-table>
    </v-layout>
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
          sortable: false,
           value: 'ime',
           width:'5%'
        },
        { text: 'Ime',value: false ,align: 'center',sortable:false, width:'10%'},
        { text: 'Prezime', value:false, align: 'center',sortable:false,width:'10%'},
        { text: 'JMBG', value:false,align: 'center',sortable:false ,width:'10%'},
        { text: 'Pol', value: false,align: 'center',sortable:false,width:'10%' },
        { text: 'Datum rodjenja', value: false,align: 'center',sortable:false,width:'10%' },
        { text: 'Mesto rodjenja', value: false,align: 'center',sortable:false,width:'10%' },
        { text: 'Opstina rodjenja', value: false,align: 'center',sortable:false ,width:'10%'},
        { text: 'Opcije', value: false,align: 'center',sortable:false,width:'10%' }
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
      pol:['Musko','Zensko'],
      editedIndex: -1,
      editedItem: {
        ime: '',
        prezime: '',
        jmbg: '',
        pol: '',
        dan: '',
        mesec: '',
        godina: '',
        mestoRodjenja: '',
        mestoPrebivalista: '',
        opstina: {
          id: '',
          nazivOpstine: '',
          postanskiBroj: ''

          },
        drzavaRodjenja: {
          id: '',
          nazivDrzave: ''
          }
      },
      defaultItem: {
         ime: '',
        prezime: '',
        jmbg: '',
        pol: '',
        dan: '',
        mesec: '',
        godina: '',
        mestoRodjenja: '',
        mestoPrebivalista: '',
        opstina: {
          id: '',
          nazivOpstine: '',
          postanskiBroj: ''
          },
        drzavaRodjenja: {
          id: '',
          nazivDrzave: ''
          }
      }
    }),
    computed: { formIsValid () {
        return this.editedItem.ime !== '' &&
          this.editedItem.prezimeime !== '' &&
          this.editedItem.jmbg !== '' &&
          this.editedItem.jmbg.length == 13 &&
          this.editedItem.pol !== '' &&
    //      this.editedItem.dan !== '' &&
    //      this.editedItem.mesec !== '' &&
   //       this.editedItem.godina !== '' &&
          this.editedItem.mestoRodjenja !== '' &&
          this.editedItem.mestoPrebivalista !== '' &&
          this.editedItem.opstina.id !== '' &&
          this.editedItem.drzavaRodjenja.id !== '' &&
          this.datum !== null
         
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
    methods: {customFilter(items, search, filter) {
          
            search = search.toString().toLowerCase()
            return items.filter(o => 
        Object.keys(o).some(k => 
            o[k].toString().toLowerCase().indexOf(search) !== -1));

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