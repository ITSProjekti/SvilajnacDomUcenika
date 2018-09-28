<template>
<v-container>
    <v-layout row>
        <v-flex xs12  >
          <transition name="slidetoleft" appear>
            <h1> {{editedItem.ime}} {{editedItem.prezime}}</h1>
          </transition>
        </v-flex>
    </v-layout>
    <v-layout row wrap>
        <v-flex xs12>
            <form @submit.prevent="Prijavaucenika">
        <v-container grid-list-md>
            <v-layout wrap>
              <v-flex xs12>
                      <v-dialog v-model="dialogEditPohvala" max-width="500">
        <v-card>
                    <v-card-title>
          <span class="headline">Izmena podataka o pohvali</span>
        </v-card-title>
        <v-card-text>
            <v-container>  
                      <v-flex offset-sm1 xs12>
              <v-flex xs8 md8 class="ml-1" >
                <v-text-field
                  color="navbarcolor"
                 v-model="editedPohvale.opis"
                  label="Opis pohvale"               
                  ></v-text-field>
              </v-flex>
              </v-flex>

                         <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                  color="navbarcolor"
                 v-model="editedPohvale.bodoviPohvale"
                  label="Bodovi pohvale"               
                  ></v-text-field>
              </v-flex>
              </v-flex>

            </v-container>
        </v-card-text>
                <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" flat @click.native="closeEditPohvala">
            Otkaži
            </v-btn>
          <v-btn color="blue darken-1" flat @click.native="izmeniPohvalu()"  
          >Sačuvaj
          </v-btn>
        </v-card-actions>
        </v-card>
    </v-dialog>
                 <v-dialog v-model="dialogEditKazna" max-width="500">
        <v-card>
                    <v-card-title>
          <span class="headline">Izmena podataka o kazni</span>
        </v-card-title>
        <v-card-text>
            <v-container>  
                      <v-flex offset-sm1 xs12>
              <v-flex xs8 md8 class="ml-1" >
                <v-text-field
                  color="navbarcolor"
                 v-model="editedKazne.opis"
                  label="Opis kazne"               
                  ></v-text-field>
              </v-flex>
              </v-flex>

                         <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                  color="navbarcolor"
                 v-model="editedKazne.bodoviKazne"
                  label="Bodovi kazne"               
                  ></v-text-field>
              </v-flex>
              </v-flex>

            </v-container>
        </v-card-text>
                <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" flat @click.native="closeEditKazna">
            Otkaži
            </v-btn>
          <v-btn color="blue darken-1" flat @click.native="izmeniKaznu()"  
          >Sačuvaj
          </v-btn>
        </v-card-actions>
        </v-card>
    </v-dialog>
                                      <v-dialog v-model="dialogNewKazna" max-width="500">
        <v-card>
                    <v-card-title>
          <span class="headline">Nova kazna</span>
        </v-card-title>
        <v-card-text>
            <v-container>  
                      <v-flex offset-sm1 xs12>
              <v-flex xs8 md8 class="ml-1" >
                <v-text-field
                  color="navbarcolor"
                 v-model="editedKazne.opis"
                  label="Opis kazne"               
                  ></v-text-field>
              </v-flex>
              </v-flex>

                         <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                  color="navbarcolor"
                 v-model="editedKazne.bodoviKazne"
                  label="Bodovi kazne"               
                  ></v-text-field>
              </v-flex>
              </v-flex>

            </v-container>
        </v-card-text>
                <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" flat @click.native="closeCreateKazna">
            Otkaži
            </v-btn>
          <v-btn color="blue darken-1" flat @click.native="napraviKaznu()"  
          >Sačuvaj
          </v-btn>
        </v-card-actions>
        </v-card>
    </v-dialog>

                      <v-dialog v-model="dialogNewPohvala" max-width="500">
        <v-card>
                    <v-card-title>
          <span class="headline">Nova pohvala</span>
        </v-card-title>
        <v-card-text>
            <v-container>  
                      <v-flex offset-sm1 xs12>
              <v-flex xs8 md8 class="ml-1" >
                <v-text-field
                  color="navbarcolor"
                 v-model="editedPohvale.opis"
                  label="Opis pohvale"               
                  ></v-text-field>
              </v-flex>
              </v-flex>

                         <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                  color="navbarcolor"
                 v-model="editedPohvale.bodoviPohvale"
                  label="Bodovi pohvale"               
                  ></v-text-field>
              </v-flex>
              </v-flex>

            </v-container>
        </v-card-text>
                <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" flat @click.native="closeCreatePohvala">
            Otkaži
            </v-btn>
          <v-btn color="blue darken-1" flat @click.native="napraviPohvalu()"  
          >Sačuvaj
          </v-btn>
        </v-card-actions>
        </v-card>
    </v-dialog>

            <v-card width=1000px>
              <v-card-title  primary-title>
                <v-flex offset-sm5>
                <div class="headline">Podaci o učeniku</div>
              </v-flex>
              </v-card-title>


                <template>
                 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1  xs12 sm5 class="mt-4 ">
                        <v-text-field
                          color="navbarcolor"
                      v-model="editedItem.ime"
                        label="Ime" 
                        required
                        :rules="[rules.required]"
                        ></v-text-field>
                          </v-flex>
                           <v-flex xs12 sm3 offset-sm1 class="mt-4">
                             <v-card>
           <v-card-text>
                          <input type="file" id="file" ref="file" accept="image/*" v-on:change="handleFileUpload()"/>

                        <img v-bind:src="editedItem.slika" height="100px" contain class="responsive" v-show="showPreview"/>
                         <img v-bind:src="editedItem.slika" height="100px" contain class="responsive" v-show="!showPreview"/>
                       <!-- <button v-show="this.file!==''" v-on:click="ClearPicture()">Reset</button> -->
                        <v-btn dark left  class="blue-grey darken" small
                        v-show="this.file!==''" v-on:click="ClearPicture()"
                        >
                            Hello
                        </v-btn>
                  </v-card-text>
                    </v-card>
                            </v-flex>
                          </v-layout>
                        </v-container>
                      </template>

            <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                  color="navbarcolor"
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
                  color="navbarcolor"
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
                  color="navbarcolor"
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
                                 color="navbarcolor"
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
                    <v-flex offset-sm1  xs12 sm3 class="mt-4 ">
                     <p>Vaspitna grupa</p>
                    </v-flex>
                           <v-flex xs12 sm6>
                               <v-select
                                 color="navbarcolor"
                                :loading="loading"
                                :items="VaspitneGrupe"
                                v-model="editedItem.vaspitnaGrupa.id"
                                label="Naziv vaspitne grupe"
                                item-text="naziv"
                                item-value="id"
                   
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
                                 color="navbarcolor"
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
                                 color="navbarcolor"
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
                                 color="navbarcolor"
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
                                 color="navbarcolor"
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
                                 color="navbarcolor"
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
                                 color="navbarcolor"
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
                              color="navbarcolor"
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
                                          color="navbarcolor"
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
                                 color="navbarcolor"
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
                                 color="navbarcolor"
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
                                 color="navbarcolor"
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
                                 color="navbarcolor"
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
                <p>Prethodni uspeh editedItema</p>
                </v-flex>
                 <v-flex xs2 class="mt-2" >
                   
                <v-text-field
                  color="navbarcolor"
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
                  color="navbarcolor"
               v-model="editedItem.telefon.mobilni"                 
                   label="Mobilni telefon"

                  ></v-text-field>
              </v-flex>
              </v-flex>

                  <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                  color="navbarcolor"
               v-model="editedItem.telefon.kucni"                
                   label="Kućni telefon" 

                  ></v-text-field>
              </v-flex>
              </v-flex>

   </v-card>
               </v-flex>     
            </v-layout>
          </v-container>
     <div><br></div>
       <v-flex xs12 class="ml-2">
            <v-card width=1000px >
              <v-card-title primary-title>
                <v-flex offset-sm4>
                <div class="headline">Podaci o roditelju - staratelju </div>
              </v-flex>
              </v-card-title>

            <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                  color="navbarcolor"
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
                  color="navbarcolor"
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
                                 color="navbarcolor"
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
                  color="navbarcolor"
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
                  color="navbarcolor"
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
                  color="navbarcolor"
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
                                 color="navbarcolor"
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
                  color="navbarcolor"
                   v-model="editedItem.roditelji[0].brojTelefona" 
                    required
                    :rules="[rules.required]"               
                   label="Broj telefona oca"   
                  ></v-text-field>
              </v-flex>
              </v-flex>

   

 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1 xs12 sm3 class="mt-4">
                     <p>Tip porodice</p>
                    </v-flex>
                           <v-flex xs12 sm6>
                               <v-select
                                 color="navbarcolor"
                                :loading="loading"
                                :items="TipoviPorodice"
                                v-model="editedItem.tipPorodice.id"
                                label="Izaberite tip porodice"
                                item-text="nazivTipaPorodice"
                                item-value="id"
                                autocomplete
                                @change="changedTip"
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>

   <v-flex     offset-sm1 xs12>
      <transition name="fade" appear  mode="in-out">
              <v-flex v-if="editedItem.tipPorodice.id ===4 || editedItem.tipPorodice.id ===5 " xs8 md5 class="ml-1" >
                <v-text-field
                  color="navbarcolor"
                   v-model="editedItem.staratelji.ime" 
                              
                   label="Ime staratelja"   
                  ></v-text-field>
              </v-flex>
      </transition>
              </v-flex>
                 <v-flex offset-sm1 xs12>
                     <transition name="fade" appear  mode="in-out">
              <v-flex v-if="editedItem.tipPorodice.id ===4 || editedItem.tipPorodice.id ===5 " xs8 md5 class="ml-1" >
                
                <v-text-field
                  color="navbarcolor"
                   v-model="editedItem.staratelji.prezime" 
                       
                   label="Prezime staratelja"   
                  ></v-text-field>
                 
              </v-flex>
               </transition>
              </v-flex>
     </v-card>
             </v-flex>  
             <div><br></div>
                 <v-flex xs12 >
                   <v-container>
            <v-card width=1000px >
              <v-card-title primary-title>
                <v-flex offset-sm4>
                <div class="headline">Vrednovanje ucenika za upis u dom </div>
              </v-flex>
              </v-card-title>
                 <v-flex offset-sm1 xs12>
              <v-flex xs2 md2  >
                <v-text-field
                  color="navbarcolor"
                  v-model="editedItem.materijalniPrihodi"
                  label="Materijalni prihodi"

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
                        >
            
                        
                        </v-text-field>
              </v-flex>
          </v-flex>
                 <v-flex offset-sm1 xs12>
                     <transition name="fade" appear  mode="in-out">
              <v-flex xs12 md8 class="ml-1" >
                

                    <v-data-table
      :headers="headers"
      :items="Pohvale"
       v-if="!loading"
        hide-actions
      class="elevation-1"    
     >
      <template  slot="items" slot-scope="props" >
       
        <tr v-if="props.item.ucenikId=== editedItem.id" >
        <td class="text-xs-center" >{{ props.item.bodoviPohvale}}</td>
        <td class="text-xs-center">{{ props.item.opis }}</td>
 
        <td class="justify-center layout px-0">
  
          <v-btn center icon class="mx-0"
           @click="deletePohvala(props.item)">
            <v-icon
              color="navbarcolor">delete
              </v-icon>
          </v-btn>
             <v-btn center icon class="mx-0"
         @click="editPohvala(props.item)">    
          
            <v-icon
              color="navbarcolor">edit
              </v-icon>
          </v-btn>
        </td>
         </tr>
        
      </template>

    </v-data-table>
             <v-flex>
 <v-btn  dark class="navbarcolor" @click="dialogNewPohvala = true">Nova pohvala</v-btn>
             </v-flex>
 

              </v-flex>
               </transition>
              </v-flex>
                 
                                 <v-flex offset-sm1 xs12>
                     <transition name="fade" appear  mode="in-out">
              <v-flex xs12  md8  class="ml-1" >
                

                    <v-data-table
      :headers="headers"
      :items="Kazne"
       v-if="!loading"
        hide-actions
      class="elevation-1"    
     >
      <template  slot="items" slot-scope="props" >
       
        <tr v-if="props.item.ucenikId=== editedItem.id" >
        <td class="text-xs-center" >{{ props.item.bodoviKazne}}</td>
        <td class="text-xs-center">{{ props.item.opis }}</td>
 
        <td class="justify-center layout px-0">
          
          <v-btn center icon class="mx-0"
           @click="deleteKazna(props.item)">
            <v-icon
              color="navbarcolor">delete
              </v-icon>
          </v-btn>
             <v-btn center icon class="mx-0"
         @click="editKazna(props.item)">    
          
            <v-icon
              color="navbarcolor">edit
              </v-icon>
          </v-btn>
        </td>
         </tr>
        
      </template>

    </v-data-table>
                  <v-btn  dark class="navbarcolor" @click="dialogNewKazna = true">Nova kazna</v-btn>
              </v-flex>
               </transition>
              </v-flex>
              <v-card-actions>
                
  <v-btn @click="IzmeniUcenika">
    Izmeni
  </v-btn>
</v-card-actions>
            </v-card>
            </v-container>
                 </v-flex>

          
            </form>
        </v-flex>
    </v-layout>
</v-container>
</template>

<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
<script>

/* eslint-disable */

import moment from 'moment'
  export default {
    data: () => ({  
 
            headers: [
        {
          text: 'Broj bodova',  align: 'center', sortable: true,  value: 'id', width:'20%' },
        { text: 'Opis',value: 'opis' ,align: 'center',sortable:true, width:'15%'},
         { text: 'Opcije' ,align: 'center',sortable:false, width:'15%'},
   
      ],
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
          file: '',
        showPreview: false,
        imagePreview: '',
      // atribut za jmbg progress bar
      custom: true,
      editedIndex: -1,
      dialogEditPohvala: false,
      dialogEditKazna: false,
      dialogNewPohvala: false,
      dialogNewKazna: false,

      // brojevi su pomocna prom za rad sa postanskim brojevima
      brojevi: '',
          pohvaleID: '',
      kazneID: '',
      default: '',
      editedPohvale: {
        id: '',
        opis: '',
        ucenikId: '',
        bodoviPohvale: ''
      },
      defaultEditedPohvale: {
              id: '',
        opis: '',
        ucenikId: '',
        bodoviPohvale: ''
      },
      editedKazne: {
        id: '',
        opis: '',
        ucenikId: '',
        bodoviKazne: ''
      },
      defaultEditedKazne: {
            id: '',
        opis: '',
        ucenikId: '',
        bodoviKazne: ''
      }
      // objekat koji sluzi kao maska za prijavu editedItema, koristi se pri prijavi i izmeni podataka o editedItemu
      
    }),
    
      // computed metode su metode koje se desavaju onda kada dodje do nekakvim promena stanja komponente, neki vid watcher-a
    computed: {

        editedItem() {
         
           
            const y= parseInt(this.$route.params.id,10)
            console.log(y)
             console.log(this.$store.getters.loadedUceniciID(y))
            return this.$store.getters.loadedUceniciID(y)  

        },

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
      // metoda koja vodi racuna o tome da se ne moze prijaviti editedItem koji nije ispunio sve neophodne podatke prilikom prijave ili izmene podataka
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
       VaspitneGrupe () {
        return this.$store.getters.loadedVaspitneGrupe
      },
      TipoviPorodice () {
        return this.$store.getters.loadedTipoviPorodice
      },
      Pohvale () {
        return this.$store.getters.loadedPohvale
      },
 
      Kazne () {
        return this.$store.getters.loadedKazne
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
         editPohvala (item)
      {
                this.editedIndex = this.Pohvale.indexOf(item)
        this.editedPohvale = Object.assign({}, item)
         console.log(this.editedPohvale)
        this.dialogEditPohvala = true
      },
      editKazna (item)
      {

                this.editedIndex = this.Kazne.indexOf(item)
        this.editedKazne = Object.assign({}, item)
       console.log(this.editedKazne)
        this.dialogEditKazna = true
      },
          izmeniPohvalu()
      {
        console.log('helloP')
      console.log(this.editedPohvale)                            
         this.$store.dispatch('editPohvale',this.editedPohvale)     

        
        this.closeEditPohvala()
      },
      izmeniKaznu()
      {
  console.log('helloK')
      console.log(this.editedKazne)                            
          this.$store.dispatch('editKazne',this.editedKazne)     

          
        this.closeEditKazna()
      },
      napraviKaznu()
      {
                     console.log(this.editedKazne) 
                    this.editedKazne.ucenikId=this.editedItem.id    
                   
          this.$store.dispatch('createKazna',this.editedKazne)   
                      this.editedKazne.opis=''     
                    this.editedKazne.bodoviKazne=''  
                    this.editedKazne.ucenikId=''
          this.closeCreateKazna()
      },
      napraviPohvalu()
      {
                     console.log(this.editedPohvale)   
                     this.editedPohvale.ucenikId=this.editedItem.id   
          this.$store.dispatch('createPohvala',this.editedPohvale)   
                    this.editedPohvale.opis=''     
                    this.editedPohvale.bodoviPohvale=''  
                    this.editedPohvale.ucenikId=''
          this.closeCreatePohvala()
      },
         closeCreateKazna () {
        
        this.dialogNewKazna = false
        
        setTimeout(() => {
          this.editedIndex = -1
        }, 300)
      }, 
         closeCreatePohvala () {
        
        this.dialogNewPohvala = false
         
        setTimeout(() => {
          this.editedIndex = -1
        }, 300)
      }, 
         closeEditKazna () {
        
        this.dialogEditKazna = false
           this.editedKazne = Object.assign({}, this.defaultEditedKazne)
        setTimeout(() => {
          this.editedIndex = -1
        }, 300)
      }, 
         closeEditPohvala () {
          this.editedPohvale = Object.assign({}, this.defaultEditedPohvale)
        this.dialogEditPohvala = false
         
        setTimeout(() => {
          this.editedIndex = -1
        }, 300)
      }, 
            deletePohvala (item) {
        const index = this.Pohvale.indexOf(item)
    // pitanje za potrvrdu o brisanju gde ako se odabere potvrdan odgovor vrsi se poziv HTTP delete-a i brisanje ucenika iz vue-x store-a sa splice
    // na mestu index i broj 1 predstavlja broj ucenika koji se brisu
        confirm('Da li ste sigurni da zelite da izbrisete ovu pokvalu?') && this.$store.dispatch('deletePohvala',item.id)
         && this.Pohvale.splice(index,1)
      },
            deleteKazna (item) {
        const index = this.Kazne.indexOf(item)
    // pitanje za potrvrdu o brisanju gde ako se odabere potvrdan odgovor vrsi se poziv HTTP delete-a i brisanje ucenika iz vue-x store-a sa splice
    // na mestu index i broj 1 predstavlja broj ucenika koji se brisu
        confirm('Da li ste sigurni da zelite da izbrisete ovu kaznu?') && this.$store.dispatch('deleteKazna',item.id)
         && this.Kazne.splice(index,1)
      },

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
      changedValue: function(value) {
        function broj (opstina){
          return opstina.id===value
        }
        this.editedItem.postanskiBroj.id=''
      this.brojevi=this.opstine.find(broj)
      },
      // v-data-picker generise datum u formatu DD-MM-GGGG te je neophodno prebaciti ova 3 podatka u 3 promenljive: dan,mesec i godinu
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
      // metoda koja se poziva nakon potrvrde o prijavi, shalje POST zahtev
      IzmeniUcenika () {
      
        this.formatiranjeDatuma() 
   
      
          this.editedItem.roditelji.ucenikID= this.editedItem.id
           console.log(this.editedItem)
          this.$store.dispatch('editUcenik',this.editedItem)
         this.file=''
          this.imagePreview=''
        this.$router.push('/ucenici')
      }  
      }
  }
</script>




<style>
/* Css koji iskljucuje na input poljima za brojeve HTML5 spinner za brojeve */
input[type="number"]::-webkit-outer-spin-button, 
input[type="number"]::-webkit-inner-spin-button {
    -webkit-appearance: none;
    margin: 0;
}
input[type="number"] {
    -moz-appearance: textfield;
}


.fade-enter-active, .fade-leave-active {
  transition: opacity 2s ease-out;
}

.fade-enter, .fade-leave-to {
  opacity: 0;
}
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


@keyframes slidetoleft-in {
  from {
    transform: translateX(50px)
  }
  to
  {
    transform: translateX(0)
  }
}
@keyframes slidetoleft-out {
  from {
    transform: translateX(0)
  }
  to
  {
    transform: translateX(50px)
  }
}
</style>
<style>
  div.container img{
    max-width: 200px;
    max-height: 200px;
  }

  .responsive {
    width: 100%;
    height: auto;
}
</style>