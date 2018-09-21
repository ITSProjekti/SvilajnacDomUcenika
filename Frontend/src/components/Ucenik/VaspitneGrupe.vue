<template>
<v-container>
    <v-flex  xs12>
        <v-btn @click="dialogNewGrupa = true">
            Nova vaspitna grupa
        </v-btn >
         <v-btn  @click="dialogNewVaspitac = true">
            Novi vaspitac
        </v-btn>
    </v-flex>
        <v-dialog v-model="dialogNewVaspitac" max-width="800">
        <v-card>
             <v-card-title>
          <span class="headline">Kreiranje novog vaspitača</span>
        </v-card-title>
        <v-card-text>
            <v-container>  
                      <v-flex offset-sm1 xs12>
              <v-flex xs8 class="ml-1" >
                <v-text-field
                 v-model="editedVaspitac.ime"
                  label="Ime vaspitača"               
                  ></v-text-field>
              </v-flex>
              </v-flex>
                          <v-flex offset-sm1 xs12>
              <v-flex xs8 class="ml-1" >
                <v-text-field
                 v-model="editedVaspitac.prezime"
                  label="Prezime vaspitača"               
                  ></v-text-field>
              </v-flex>
              </v-flex>
                          <v-flex offset-sm1 xs12>
              <v-flex xs8 class="ml-1" >
                <v-text-field
                 v-model="editedVaspitac.brojTelefona"
                  label="Broj telefona vaspitača"               
                  ></v-text-field>
              </v-flex>
              </v-flex>
    
      <v-flex xs8 class="px-5 ml-4">
                 <v-card class="px-5">
                <v-card-text>
                          <input type="file" id="file" ref="file" accept="image/*" v-on:change="handleFileUpload()"/>
                  <transition name="fade" appear  mode="in-out">
                        <img v-bind:src="imagePreview" class="responsive" v-show="showPreview"/>
                         </transition>
                       <!-- <button v-show="this.file!==''" v-on:click="ClearPicture()">Reset</button> -->
                       <v-card-actions>
                        <v-btn dark left class="navbarcolor"  small
                        v-show="this.file!==''" v-on:click="ClearPicture()"
                        >
                            Resetuj
                        </v-btn>
                        </v-card-actions>
                  </v-card-text>
                    </v-card>
</v-flex>

            </v-container>
        </v-card-text>
                <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" flat @click.native="closeCV()">
            Otkaži
            </v-btn>
          <v-btn color="blue darken-1" flat @click.native="kreiarjVaspitaca()"  
          >Sačuvaj
          </v-btn>
        </v-card-actions>
        </v-card>



    </v-dialog>
    <v-dialog v-model="dialogNewGrupa" max-width="400">
        <v-card>
                    <v-card-title>
          <span class="headline">Kreiranje nove vaspitne grupe</span>
        </v-card-title>
        <v-card-text>
            <v-container>  
                      <v-flex offset-sm1 xs12>
              <v-flex xs8 class="ml-1" >
                <v-text-field
                 v-model="editedItem.naziv"
                  label="Naziv vaspitne grupe"               
                  ></v-text-field>
              </v-flex>
              </v-flex>

            </v-container>
        </v-card-text>
                <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" flat @click.native="closeC()">
            Otkaži
            </v-btn>
          <v-btn color="blue darken-1" flat @click.native="kreiarjGrupu()"  
          >Sačuvaj
          </v-btn>
        </v-card-actions>
        </v-card>
    </v-dialog>
        <v-dialog v-model="dialogEditGrupa" max-width="800">
        <v-card>
                    <v-card-title>
          <span class="headline">Izmena podataka vaspitne grupe</span>
        </v-card-title>
        <v-card-text>
            <v-container>  
                      <v-flex offset-sm1 xs12>
              <v-flex xs8 md5 class="ml-1" >
                <v-text-field
                 v-model="editedItem.naziv"
                  label="Naziv vaspitne grupe"               
                  ></v-text-field>
              </v-flex>
              </v-flex>

                  <template>
                 <v-container fluid>
                    <v-layout row wrap>
                    <v-flex offset-sm1  xs12 sm3 class="mt-4 ">
                     <p>Vaspitac vaspitne grupe</p>
                    </v-flex>
                           <v-flex xs12 sm6>
                               <v-select
                            
                                :items="vaspitaci"
                                v-model="editedItem.vaspitac.id"
                                label="Vaspitac vaspitne grupe"
                                item-text="ime"
                                item-value="id"
                   
                              ></v-select>
                            </v-flex>
                          </v-layout>
                        </v-container>
                      </template>

            </v-container>
        </v-card-text>
                <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" flat @click.native="closeE">
            Otkaži
            </v-btn>
          <v-btn color="blue darken-1" flat @click.native="izmeniGrupu()"  
          >Sačuvaj
          </v-btn>
        </v-card-actions>
        </v-card>
    </v-dialog>
    <v-flex xs12>
                <v-layout row wrap>
            <v-flex
              v-for="grupa in vaspitneGrupe"
              :key="grupa.id"
              xs4    >
              <v-card class="mb-2 mr-2"  >
                  <v-layout row>
<v-flex xs8>
          <v-card-title primary-title >
              <div>
              <div class="headline">
                  {{grupa.naziv}} 
              </div>
                    <div>
                Broj učenika: {{grupa.brojUcenika}}
            </div> 
            <div>
                Ime v. : {{grupa.vaspitac.ime}}
            </div>
             <div>
                Prezime v. : {{grupa.vaspitac.prezime}}
            </div>
              </div>
          </v-card-title>
        </v-flex>
       
                <v-flex xs4 class="mt-3 mr-2">
                    <v-card-media :src="grupa.vaspitac.slika" height="100px" contain>
                        
                    </v-card-media>
                    
                </v-flex>
         </v-layout>
          <v-card-actions>
                  <v-btn flat icon>
                        <v-icon color="grey">search</v-icon>
                  </v-btn>
                  <v-btn flat icon @click="editVaspitnaGrupa(grupa)">
                    <v-icon color="grey">edit</v-icon>
                  </v-btn>
                  <v-btn flat icon @click="delGrupa(grupa)">
                    <v-icon color="grey">cancel</v-icon>
                  </v-btn>
          </v-card-actions>
        
              </v-card>
                </v-flex>
                </v-layout>
    </v-flex>
</v-container>
</template>



<script>
/* eslint-disable */
export default {
     data: () => ({ 
  
       dialogNewGrupa: false,
       dialogEditGrupa: false,
       dialogNewVaspitac: false,
       dialogEditVaspitac: false,
                 file: '',
        showPreview: false,
        imagePreview: '',
      editedVaspitac: {
        id: '',
        ime: '',
        prezime: '',
        brojTelefona: '',
        slika: ''
      },
      defaultVaspitac: {
        id: '',
        ime: '',
        prezime: '',
        brojTelefona: '',
        slika: ''
      },
      editedItem: {
          id: '',
          naziv: '',
          vaspitac: {
              id: '',
        ime: '',
        prezime: '',
        brojTelefona: '',
        slika: ''
          },
            defaultItem: {
          id: '',
          naziv: '',
          vaspitac: {
              id: '',
        ime: '',
        prezime: '',
        brojTelefona: '',
        slika: ''
          }
}

      },
      previousItem: ''
      }),
      computed: {
          
          vaspitneGrupe() {
                const x = this.$store.getters.loadedVaspitneGrupe
                console.log(x)
              return this.$store.getters.loadedVaspitneGrupe
          },
          vaspitaci(){
              const x = this.$store.getters.loadedVaspitac
              console.log(x)
              return this.$store.getters.loadedVaspitac
          }
      }, watch: {
      dialog (val) {

        val || this.close()
      }
      },
      methods: {
                ClearPicture(){
       this.file=''
      this.imagePreview=''
      this.editedVaspitac.slika= ''
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
          this.editedVaspitac.slika= reader.result
        }.bind(this), false);
        console.log(this.editedVaspitac.slika)
        if( this.file ){
          if ( /\.(jpe?g|png|gif)$/i.test( this.file.name ) ) {
            reader.readAsDataURL( this.file );
          }
        }
      },
      editVaspitnaGrupa (item) {
        this.editedIndex = this.vaspitneGrupe.indexOf(item)
        this.editedItem = Object.assign({}, item)
        this.previousItem = Object.assign({}, item)
        this.dialogEditGrupa = true
      },
      closeCV () {
        
        this.dialogNewVaspitac = false
        
        setTimeout(() => {
          this.editedIndex = -1
        }, 300)
      }, 
        closeEV () {
        
        this.dialogEditVaspitac = false
        setTimeout(() => {
          this.editedIndex = -1
        }, 300)
      },
            closeC () {
        
        this.dialogNewGrupa = false
          this.editedItem.naziv=''
        setTimeout(() => {
          this.editedIndex = -1
        }, 300)
      }, 
        closeE () {
        
        this.dialogEditGrupa = false
        setTimeout(() => {
          this.editedIndex = -1
        }, 300)
      },
           kreiarjVaspitaca () {                
              console.log(this.editedVaspitac)                       
          this.$store.dispatch('createVaspitac',this.editedVaspitac)   

        this.closeCV()
      }, izmeniVaspitaca () {                
              console.log(this.editedVaspitac)
   
                             
          this.$store.dispatch('editVaspitaca',this.editedVaspitac)     
        
        this.closeEV()
      },

      delVaspitaca (item){
               const index = this.vaspitaci.indexOf(item)
        confirm('Da li ste sigurni da želite da izbrisete ovog vaspitača?') && this.$store.dispatch('deleteVaspitac',item.id)
         && this.vaspitaci.splice(index,1) &&   this.$store.dispatch('loadedUcenici') 
      },
         kreiarjGrupu () {                
              console.log(this.editedItem)                       
          this.$store.dispatch('createVaspitnaGrupa',this.editedItem)   
         this.editedItem.naziv=''
         this.$store.dispatch('loadedUcenici')
        this.closeC()
      }, izmeniGrupu () {                
              console.log(this.editedItem)
   
                             
          this.$store.dispatch('editVaspitneGrupe',this.editedItem)     

           this.$store.dispatch('loadedUcenici')  
        this.closeE()
      },

      delGrupa (item){
               const index = this.vaspitneGrupe.indexOf(item)
        confirm('Da li ste sigurni da želite da izbrisete ovu grupu?') && this.$store.dispatch('deleteVaspitnaGrupa',item.id)
         && this.vaspitneGrupe.splice(index,1)

     
      }
      }
}
</script>
