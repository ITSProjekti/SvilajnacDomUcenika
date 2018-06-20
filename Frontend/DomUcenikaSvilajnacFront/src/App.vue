<template>
  <v-app>
  
    <v-toolbar dark class="blue darken-2">
      <v-toolbar-side-icon
       @click.stop="sideNav = !sideNav"
       class="hidden-sm-and-up"
       > </v-toolbar-side-icon>
      <v-toolbar-title>Dom ucenika Svilajnac</v-toolbar-title>
      
      <v-spacer></v-spacer>
      <v-toolbar-items class="hidden-xs-only">
        <v-btn flat>
          <v-icon left>list</v-icon>
          Lista Ucenika</v-btn>
            <v-btn flat>
          <v-icon left>pets</v-icon>
          Prijava ucenika</v-btn>
      </v-toolbar-items>
       </v-toolbar >   
         <v-navigation-drawer v-model="sideNav" temporary fixed>
      <v-list>
         <v-list-tile @click=true >
               <v-list-tile-action>
                   <v-icon>supervisor_account</v-icon>
              </v-list-tile-action>
           <v-list-tile-content>View Opcije</v-list-tile-content>
      </v-list-tile>
</v-list>
    </v-navigation-drawer> 
    <main>
    </main>
  </v-app>
</template>

<script>
export default {
  data () {
    return {
      sideNav: null
    }
  },
  name: 'App'
}
</script>
