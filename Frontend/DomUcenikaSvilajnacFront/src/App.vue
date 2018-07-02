<template>
  <v-app>
 
    <v-toolbar dark class="orange darken-4">
      <v-toolbar-side-icon
       @click.stop="sideNav = !sideNav"
       class="hidden-sm-and-up"
       > </v-toolbar-side-icon>
      <v-toolbar-title>
        <router-link to="/" tag="span" style="cursor: pointer">Dom ucenika Svilajnac</router-link>
        </v-toolbar-title>
      
      <v-spacer></v-spacer>
      <v-toolbar-items class="hidden-xs-only">
        <v-btn flat
         v-for="item in menuItems"
          :key="item.title"
          router
           :to="item.link">
          <v-icon left>{{item.icon}}</v-icon>
         {{item.title}}
          </v-btn>

      </v-toolbar-items>
       </v-toolbar >  
         <main>
      <router-view></router-view>
    </main> 
         <v-navigation-drawer v-model="sideNav" temporary>
      <v-list>
         <v-list-tile @click="true"
          v-for="item in menuItems"
           :key="item.title"
           router
           :to="item.link">
               <v-list-tile-action>
                   <v-icon>{{item.icon}}</v-icon>
              </v-list-tile-action>
           <v-list-tile-content>{{item.title}}</v-list-tile-content>
      </v-list-tile>
</v-list>
    </v-navigation-drawer> 
   
  </v-app>
</template>

<script>
/* eslint-disable */
export default {
  data () {
    return {
      sideNav: null,
      menuItems: [
        {icon: 'supervisor_account', title: 'Lista ucenika',link: '/ucenici'},
        {icon: 'pets', title: 'Prijavi ucenika',link: '/prijava'},
      //  {icon: 'person', title: 'Profil',link: '/profil'},
       // {icon: 'face', title: 'Registruj se',link: '/registracija'},
      //  {icon: 'lock_open', title: 'Uloguj se',link: '/logovanje'}
      ]
    }
  },
  name: 'App'
}
</script>

