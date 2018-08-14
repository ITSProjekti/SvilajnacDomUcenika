
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
              
              
     <v-flex xs12 class="ml-1">
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
                  loading
                  input type="number" onkeydown="javascript: if(event.keyCode == 69) {return false} else 
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
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
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
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
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
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
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
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
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
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
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
                    <v-flex offset-sm1  xs12 sm3 class="mt-4">
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
                        </v-container>
                              <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1 xs12 sm3 class="mt-4">
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

                  <v-container fluid>
                    <v-layout row wrap>
              <v-flex offset-sm1  xs12 sm3 class="mt-4">
                <p>Prethodni uspeh ucenika</p>
                </v-flex>
                 <v-flex xs2 class="mt-2" >
                   
                <v-text-field
                 v-model="editedItem.prethodniUspeh"                 
                   label="br"
                    input type="number"      step=0.01
                    onkeydown="javascript: if(event.keyCode == 69) {return false} else 
                          {
                   if(event.keyCode == 107) {return false}
                    else {
                   if(event.keyCode == 109) {return false}
                    else  {
                   if(event.keyCode == 187) {return false}
                    else  {
                   if(event.keyCode == 189) {return false}
                   else
                     {return true} } } } }" 
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


       <v-flex xs12 class="ml-1">
            <v-card raised >
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

   <transition name="fade" appear  mode="in-out">

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
        <td class="text-xs-center">{{ props.index+1}}</td>
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
</transition >
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
      // headeri sluze za generisanje polja koja se prikazuju u tabeli
      headers: [
        {
          text: 'Redni broj',  align: 'center', sortable: false,  value: 'id', width:'5%' },
        { text: 'Ime',value: 'ime' ,align: 'center',sortable:true, width:'7.5%'},
        { text: 'Prezime', value:'prezime', align: 'center',sortable:true,width:'7.5%'},
        { text: 'JMBG', value:'jmbg',align: 'center',sortable:true ,width:'7.5%'},
        { text: 'Pol', value: 'pol.nazivPola',align: 'center',sortable:true,width:'7.5%' },
        { text: 'Datum rođenja', value: 'godina',align: 'center',sortable:true,width:'7.5%' },
        { text: 'Mesto rođenja', value: 'mestoRodjenja.nazivMesta',align: 'center',sortable:true,width:'7.5%' },
        { text: 'Opstina rođenja', value: 'opstina.nazivOpstine',align: 'center',sortable:true ,width:'7.5%'},
        { text: 'Opcije', value: 'opcije',align: 'center',sortable:false,width:'7.5%' }
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
      // metoda koja na osnovu odabrane opstine prikazuje njene jedinstvene postanske brojeve
      changedValue: function(value) {
        function broj (opstina){
          return opstina.id===value
        }
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
        confirm('Da li ste sigurni da zelite da izbrisete ovog ucenika?') && this.$store.dispatch('deleteUcenik',item.id) && this.ucenici.splice(index,1)
      },
    // ako se odabere opcija close na dijalogu treba editeditem vratiti na pocetni sa praznim podacima
      close () {
        
        this.dialog = false
        setTimeout(() => {
           this.editedItem = Object.assign({}, this.defaultItem)
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
          this.datum=null
        } else {
          // u suprotnom radi se o novom uceniku te se vrsi POST metod nakon kojeg se editedItem i datum postavljaju na pocetne vrednosti
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
  
}
.pageRow td:nth-child(odd) {
  background-color: white;
  border-top: 1px solid grey !important
}
.pageRow td:nth-child(even) {
  background-color: white;
  border-top: 1px solid grey !important
}

</style>
