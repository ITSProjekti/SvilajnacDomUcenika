<template>
 <v-container>
     <v-layout row wrap>
         <v-flex xs12 sm6 class="text-sm-left" absolute> 
             <v-btn large router to="/ucenici" class="orange darken-4">Prikazi sve ucenike</v-btn>
         </v-flex>
         <v-flex xs12 sm6 class="text-sm-left" absolute>
             <v-btn large router to="/prijava" class="orange darken-4">Prijavi novog ucenika</v-btn>
         </v-flex>
     </v-layout>
 </v-container>
</template>
