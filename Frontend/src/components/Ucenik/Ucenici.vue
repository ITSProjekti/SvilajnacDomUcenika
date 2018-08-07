
<template>
  <div>
    <v-toolbar  color="white">
       <v-toolbar-title wrap >Spisak prijavljenih učenika</v-toolbar-title>
    
      <v-spacer></v-spacer>
      
    <v-dialog v-model="dialog" max-width="800">
      <v-btn  slot="activator" color="blue-grey darken-2" dark class="mb-2">Prijavi učenika</v-btn>
      <v-card>
        <v-card-title>
          <span class="headline">{{ formTitle }}</span>
        </v-card-title>
        <v-card-text>
        
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

            </v-layout>
          </v-container>
        </v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" flat @click.native="close">
            Otkaži
            </v-btn>
          <v-btn color="blue darken-1" flat @click.native="save"  :disabled="!formIsValid"
          >Sačuvaj
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
  
        <v-flex xs3 class="mb-2">
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

      :custom-filter="customFilter"
      class="elevation-1"    
     >
      <template slot="items" slot-scope="props" >
        <tr class="pageRow" @click="props.expanded = !props.expanded">
        <td class="text-xs-center">{{ props.item.id}}</td>
        <td class="text-xs-center">{{ props.item.ime }}</td>
        <td class="text-xs-center">{{ props.item.prezime }}</td>
        <td class="text-xs-center">{{ props.item.jmbg }}</td>
        <td class="text-xs-center">{{ props.item.pol.nazivPola }}</td>
        <td class="text-xs-center">{{ props.item.dan }}.{{ props.item.mesec }}.{{ props.item.godina }}.</td>
        <td class="text-xs-center">{{ props.item.mestoRodjenja.nazivMesta }}</td>
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
                                {{ props.item.mestoPrebivalista.nazivMesta }}
                              </v-card-text>
                       </v-flex>
                         <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Mesto zavrsene skole: '"></v-subheader>
                       </v-flex>

                       <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.mestoZavrseneSkole.nazivMesta }}
                              </v-card-text>
                       </v-flex>
                         <v-flex xs2>
                       <v-subheader class="text-lg-left" v-text="'Prethodna(osnovna) zavrsena skola: '"></v-subheader>
                       </v-flex>

                       <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.prethodnaSkola.nazivPrethodneSkole }}
                              </v-card-text>
                       </v-flex>
                         <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Naziv skole koju upisuje: '"></v-subheader>
                       </v-flex>

                       <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.upisanaSkola.nazivSrednjeSkole }}
                              </v-card-text>
                       </v-flex>
                         <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Smer na koji se upisuje: '"></v-subheader>
                       </v-flex>

                       <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.smer.nazivSmera }}
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

                           <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Razred: '"></v-subheader>
                       </v-flex>
                        <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.razred.brojRazreda }}
                              </v-card-text>
                       </v-flex>

                       
                           <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Prethodni uspeh: '"></v-subheader>
                       </v-flex>
                        <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.prethodniUspeh }}
                              </v-card-text>
                       </v-flex>
                       
                               <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Ime majke: '"></v-subheader>
                       </v-flex>
                        <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.roditelji[1].ime }}
                              </v-card-text>
                       </v-flex>

                               <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Prezime majke: '"></v-subheader>
                       </v-flex>
                        <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.roditelji[1].prezime }}
                              </v-card-text>
                       </v-flex>
                       
                               <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Broj telefona majke: '"></v-subheader>
                       </v-flex>
                        <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.roditelji[1].brojTelefona }}
                              </v-card-text>
                       </v-flex>
                       
                       
                               <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Strucna sprema majke: '"></v-subheader>
                       </v-flex>
                        <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ StepeniStrucneSpreme.find(x=>x.id===props.item.roditelji[1].stepenObrazovanjaId).opis }}
                              </v-card-text>
                       </v-flex>
                               <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Ime oca: '"></v-subheader>
                       </v-flex>
                        <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.roditelji[0].ime }}
                              </v-card-text>
                       </v-flex>

                               <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Prezime oca: '"></v-subheader>
                       </v-flex>
                        <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.roditelji[0].prezime }}
                              </v-card-text>
                       </v-flex>
                                              
                               <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Broj telefona oca: '"></v-subheader>
                       </v-flex>
                        <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ props.item.roditelji[0].brojTelefona }}
                              </v-card-text>
                       </v-flex>
                       
                        <v-flex xs2>
                       <v-subheader class="text-lg-right" v-text="'Strucna sprema oca: '"></v-subheader>
                       </v-flex>
                        <v-flex xs2>
                        <v-card-text class="text-lg-left">
                                {{ StepeniStrucneSpreme.find(x=>x.id===props.item.roditelji[0].stepenObrazovanjaId).opis }}
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
        { text: 'Ime',value: 'ime' ,align: 'center',sortable:true, width:'7.5%'},
        { text: 'Prezime', value:'prezime', align: 'center',sortable:true,width:'7.5%'},
        { text: 'JMBG', value:'jmbg',align: 'center',sortable:true ,width:'7.5%'},
        { text: 'Pol', value: 'pol.nazivPola',align: 'center',sortable:true,width:'7.5%' },
        { text: 'Datum rođenja', value: 'godina',align: 'center',sortable:true,width:'7.5%' },
        { text: 'Mesto rođenja', value: 'mestoRodjenja.nazivMesta',align: 'center',sortable:true,width:'7.5%' },
        { text: 'Opstina rođenja', value: 'opstina.nazivOpstine',align: 'center',sortable:true ,width:'7.5%'},
        { text: 'Opcije', value: 'opcije',align: 'center',sortable:false,width:'7.5%' }
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

      },

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
         (this.editedItem.dan !== '' ||  this.datum !== null)
          
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
      },
      formTitle () {
        return this.editedIndex === -1 ? 'Prijavi novog ucenika' : 'Izmeni'
      }
    },
    watch: {
      dialog (val) {
        console.log(this.datum)
         console.log(this.editedItem.dan)
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
        item.mestoZavrseneSkole.nazivMesta.toLowerCase().match(this.search.toLowerCase()) ||
        item.mestoPrebivalista.nazivMesta.toLowerCase().match(this.search.toLowerCase()) ||
        item.mestoRodjenja.nazivMesta.toLowerCase().match(this.search.toLowerCase()) ||
        item.smer.nazivSmera.toLowerCase().match(this.search.toLowerCase()) ||
        item.prethodnaSkola.nazivPrethodneSkole.toLowerCase().match(this.search.toLowerCase()) ||
        item.upisanaSkola.nazivSrednjeSkole.toLowerCase().match(this.search.toLowerCase()) ||
        item.postanskiBroj.broj.toLowerCase().match(this.search.toLowerCase()) ||
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
   
        confirm('Da li ste sigurni da zelite da izbrisete ovog ucenika?') && this.$store.dispatch('deleteUcenik',item.id) && this.ucenici.splice(index,1)
      },
      close () {
        
        this.dialog = false
        setTimeout(() => {
           this.editedItem = Object.assign({}, this.defaultItem)
           this.datum=null
          this.editedIndex = -1
        }, 300)
      },
      save () {
        if (this.editedIndex > -1) {    
          this.formatiranjeDatuma()
         // Object.assign(this.ucenici[this.editedIndex], this.editedItem)
          this.editedItem.roditelji.ucenikID= this.editedItem.id
          
          this.$store.dispatch('editUcenik',this.editedItem)
          this.editedItem = Object.assign({}, this.defaultItem)
          this.datum=null
        } else {
          this.formatiranjeDatuma() 
         
          this.$store.dispatch('createUcenik',this.editedItem)
          this.editedItem = Object.assign({}, this.defaultItem)
          this.datum=null
        }
        this.close()
      }  
      }

  }
</script>

<style >
table {
  border-top: 1px solid grey   !important;
  border-bottom: 1px solid grey  !important;
  
}
.pageRow td:nth-child(odd) {
  background-color: white;
  border-top: 1px solid grey !important
}
</style>
