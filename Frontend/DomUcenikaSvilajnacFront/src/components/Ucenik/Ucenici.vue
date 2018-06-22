
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
              <v-flex xs12 >
                <v-text-field v-model="editedItem.pol" label="Pol"></v-text-field>
              </v-flex>
              <v-flex xs12 >
                <v-text-field v-model="editedItem.mesto.id" label="MestoID"></v-text-field>
              </v-flex>
               <v-flex xs12 >
                <v-text-field v-model="editedItem.mesto.naziv" label="MestoNaziv"></v-text-field>
              </v-flex>
              <v-flex xs12 >
                <h3 dark class="mb-2">Datum Rodjenja</h3>
               
                <v-date-picker v-model="datum"></v-date-picker>
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
    <v-data-table
      :headers="headers"
      :items="ucenici"
      hide-actions
      class="elevation-1"
    >
      <template slot="items" slot-scope="props">
        <td>{{ props.item.mesto.naziv }}</td>
        <td class="text-xs-right">{{ props.item.ime }}</td>
        <td class="text-xs-right">{{ props.item.prezime }}</td>
        <td class="text-xs-right">{{ props.item.jmbg }}</td>
        <td class="text-xs-right">{{ props.item.pol }}</td>
        <td class="text-xs-right">{{ props.item.dan }}.{{ props.item.mesec }}.{{ props.item.godina }}.</td>
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
  </div>
</template>

<script>
/* eslint-disable */
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
        { text: 'Datum Rodjenja', value: 'dan',align: 'right' },
        { text: 'Opcije', value: 'opcije',align: 'right' }
      ],
      datum: null,
      editedIndex: -1,
      editedItem: {
        ime: '',
        prezime: '',
        jmbg: '',
        pol: '',
        dan: '',
        mesec: '',
        godina: '',
        mesto: {
          id: '',
          naziv: ''
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
        mesto: {
          id: '',
          naziv: ''
          }
      }
    }),
    computed: {ucenici () {
        return this.$store.getters.loadedUcenici
        
       
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
          console.log(this.datum)
          const xz= new Date(this.datum)
          this.editedItem.dan=xz.getDay()
          this.editedItem.mesec=xz.getMonth()
          this.editedItem.godina=xz.getYear()
      },
      editItem (item) {
        this.editedIndex = this.ucenici.indexOf(item)
        this.editedItem = Object.assign({}, item)
        this.dialog = true
      },
      deleteItem (item) {
        const index = this.ucenici.indexOf(item)
        confirm('Are you sure you want to delete this item?') && this.ucenici.remove(index, 1)
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
          this.$store.dispatch('createUcenik',this.editedItem)
          this.ucenici.push(this.editedItem)
        }
        this.close()
      }
    
            
               
            }
  }
</script>