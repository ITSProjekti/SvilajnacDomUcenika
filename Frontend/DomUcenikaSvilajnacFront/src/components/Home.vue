<template>
 <v-container>
     <v-layout row wrap>
         <v-flex xs12 sm6 class="text-sm-left" absolute> 
             <v-btn large router to="/ucenici" dark class="blue-grey darken-2">Prikazi sve ucenike</v-btn>
         </v-flex>
         <v-flex xs12 sm6 class="text-sm-right" absolute>
             <v-btn large router to="/prijava" dark class="blue-grey darken-2">Prijavi novog ucenika</v-btn>
         </v-flex>
     </v-layout>
 </v-container>
</template>
