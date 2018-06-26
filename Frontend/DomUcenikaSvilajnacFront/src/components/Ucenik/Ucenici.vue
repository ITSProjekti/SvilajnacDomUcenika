
<template>
  <div>
    <v-dialog v-model="dialog" max-width="500px">
      <v-btn slot="activator" color="primary" dark class="mb-2">Prijavi ucenika</v-btn>
      <v-card>
        <v-card-title>
          <span class="headline">{{ formTitle }}</span>
        </v-card-title>
        <v-card-text>
          <v-container grid-list-md>
            <v-layout wrap>
              <v-flex xs12 >
                <v-text-field v-model="editedItem.ime" label="Ime"></v-text-field>
              </v-flex>
              <v-flex xs12 >
                <v-text-field v-model="editedItem.prezime" label="Prezime"></v-text-field>
              </v-flex>
              <v-flex xs12 >
                <v-text-field v-model="editedItem.jmbg" label="jmbg"></v-text-field>
              </v-flex>
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
                                label="Pol"
                                autocomplete
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
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>
                      </template>
              <v-flex xs12 >
                <v-text-field v-model="editedItem.mestoRodjenja" label="Mesto rodjenja"></v-text-field>
              </v-flex>
              <v-flex xs12 >
                <h3 dark class="mb-2">Datum Rodjenja</h3>              
                <v-date-picker
                 v-model="datum"
                 locale="sr-Latn"
                 ></v-date-picker>
                 <p>Prethodni: {{ editedItem.dan }}.{{ editedItem.mesec }}.{{editedItem.godina }}</p>
                 <p>Novi: {{datum}}</p>
              </v-flex>              
            </v-layout>
          </v-container>
        </v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" flat @click.native="close">Cancel</v-btn>
          <v-btn color="blue darken-1" flat @click.native="save">Save</v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
    <v-layout> 
        <v-flex xs12 class="text-xs-center">
        <v-progress-circular
          indeterminate
          class="primary--text"
          :width="7"
          :size="70"
          v-if="loading"></v-progress-circular>
      </v-flex>
    </v-layout>
    <v-layout  row wrap class="mt-2" v-if="!loading">
    <v-data-table
      :headers="headers"
      :items="ucenici"
      hide-actions
      class="elevation-1"
    >
      <template slot="items" slot-scope="props" >
        <td>{{ props.item.ime }}</td>
        <td class="text-xs-right">{{ props.item.ime }}</td>
        <td class="text-xs-right">{{ props.item.prezime }}</td>
        <td class="text-xs-right">{{ props.item.jmbg }}</td>
        <td class="text-xs-right">{{ props.item.pol }}</td>
        <td class="text-xs-right">{{ props.item.dan }}.{{ props.item.mesec }}.{{ props.item.godina }}.</td>
        <td class="text-xs-right">{{ props.item.mestoRodjenja }}</td>
        <td class="text-xs-right">{{ props.item.opstina.nazivOpstine }}</td>
        <td class="justify-center layout px-0">
          <v-btn right icon class="mx-0" @click="editItem(props.item)">
            <v-icon right color="teal">edit</v-icon>
          </v-btn>
          <v-btn right icon class="mx-0" @click="deleteItem(props.item)">
            <v-icon right color="pink">delete</v-icon>
          </v-btn>
        </td>
      </template>

    </v-data-table>
    </v-layout>
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
          text: 'Ucenici',
          align: 'left',
          sortable: false,
           value: 'ime'
        },
        { text: 'Ime',value: 'ime' ,align: 'right'},
        { text: 'Prezime', value: 'prezime', align: 'right',},
        { text: 'JMBG', value: 'jmbg',align: 'right' },
        { text: 'Pol', value: 'pol',align: 'right' },
        { text: 'Datum rodjenja', value: 'dan',align: 'right' },
        { text: 'Mesto rodjenja', value: 'mestoR',align: 'right' },
        { text: 'Opstina', value: 'opstina',align: 'right' },
        { text: 'Opcije', value: 'opcije',align: 'right' }
      ],
      datum: null,
      a1: null,
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
        opstina: {
          id: '',
          nazivOpstine: ''
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
        opstina: {
          id: '',
          nazivOpstine: ''
          }
      }
    }),
    computed: {ucenici () {
       return this.$store.getters.loadedUcenici       
    },
    opstine () {
       return this.$store.getters.loadedOpstine  
           
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
       formatiranjeDatuma()
      {
          const dan=this.datum.slice(-2);
          this.editedItem.dan=dan
          const mesec=this.datum.substr(5,2)
          this.editedItem.mesec=mesec
          this.editedItem.godina=this.datum.substring(0,4)
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
          Object.assign(this.ucenici[this.editedIndex], this.editedItem)

        } else {
          this.formatiranjeDatuma() 
          console.log(this.editedItem)      
          this.$store.dispatch('createUcenik',this.editedItem)
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