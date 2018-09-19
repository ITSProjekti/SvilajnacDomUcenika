<template>
<v-container>
    <v-flex xs12>
                <v-layout row wrap>
            <v-flex
              v-for="grupa in vaspitneGrupe"
              :key="grupa.id"
              xs4 

                        >
              <v-card class="mb-2 mr-2" tile>
          <v-card-title primary-title class="ml-1">
              <div>
                  <h3>{{grupa.naziv}} </h3>
              </div>
              
          </v-card-title>
          <v-card-text>
             <div>
                 Broj učenika: 
            </div> 
            <div>
                Vaspitač: {{grupa.vaspitac.ime}} {{grupa.vaspitac.prezime}}
            </div>
              
          </v-card-text>
          <v-card-actions>
                  <v-btn flat icon>
                        <v-icon color="grey">search</v-icon>
                  </v-btn>
                  <v-btn flat icon>
                    <v-icon color="grey">edit</v-icon>
                  </v-btn>
                  <v-btn flat icon>
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





      }),
      computed: {
          vaspitneGrupe() {
              const x=this.$store.getters.loadedVaspitneGrupe
              console.log(x)
              return this.$store.getters.loadedVaspitneGrupe
          }
      }
}
</script>
