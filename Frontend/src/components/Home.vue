<template>
 <v-container>
     <v-layout row wrap>
         <v-flex xs12 sm6 class="text-sm-left" absolute> 
             <transition name="fade" appear mode="out-in" >
             <v-btn large router to="/ucenici" dark class="blue-grey darken-2">Prikazi sve ucenike</v-btn>
               </transition >
         </v-flex>
         <v-flex xs12 sm6 class="text-sm-right" absolute>
              <transition name="fade" appear  mode="in-out">
             <v-btn large router to="/prijava" dark class="blue-grey darken-2">Prijavi novog ucenika</v-btn>
              </transition >
         </v-flex>
<transition name="fade" appear  mode="in-out">

    </transition >
         
     </v-layout>
 </v-container>
</template>

<style>
.fade-enter-active, .fade-leave-active {
  transition: opacity 2s ease-out;
}

.fade-enter, .fade-leave-to {
  opacity: 0;
}





</style>

