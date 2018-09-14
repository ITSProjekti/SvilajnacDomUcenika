<template>
  <v-app id="inspire">



    <v-navigation-drawer
      v-model="drawer"
      fixed
      clipped
      class="navbarcolor"
      app
      
    >
   
      <v-list
        dense
        dark
       
        class="navbarcolor"
      >
        <template v-for="(item, i) in items">
          <v-layout
            v-if="item.heading"
            :key="i"
            row
            align-center
          >
            <v-flex xs6>
              
              <v-subheader class="white--text"  v-if="item.heading">
                <v-icon class="mr-3" > {{ item.mainicon }}</v-icon>
                
                {{ item.heading }}
              </v-subheader>
            </v-flex>
        
          </v-layout>
          <v-divider
            v-else-if="item.divider"
            :key="i"
            dark
            class="my-3"
          ></v-divider>
          <v-list-tile
            v-else
            :key="i"
              router
           :to="item.link"
           active-class="redactive"
          >
            <v-list-tile-action>
              <v-icon class="ml-4">{{ item.icon }}</v-icon>
            </v-list-tile-action>
            <v-list-tile-content>
              <v-list-tile-title  class="text-xs-ml3">
                {{ item.text }}
              </v-list-tile-title>
            </v-list-tile-content>
          </v-list-tile>
        </template>
      </v-list>
    </v-navigation-drawer>
     <v-toolbar  class="white"  app  clipped-left height=30px>
      <v-toolbar-side-icon @click.native="drawer = !drawer"></v-toolbar-side-icon>
      <!--
          <v-breadcrumbs icons divider="chevron_right">
   
    <breadcrumbs >
    </breadcrumbs>
    </v-breadcrumbs> -->
        <!--  <v-toolbar-title>
        <router-link to="/" tag="span" style="cursor: pointer">Dom učenika Svilajnac</router-link>
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

      </v-toolbar-items> -->
    </v-toolbar> 
    <v-content>
      <v-container fluid fill-height class="grey lighten-4">
        <v-layout justify-center align-center>
          <v-flex xs12>
<main>


  <router-view></router-view>

</main>
          </v-flex>
        </v-layout>
      </v-container>
    </v-content>
  </v-app>
</template>

<script>
/* eslint-disable */


  export default {
    data: () => ({
     
      // promenljiva koja sluzi za rad sa navigacionim barom sa strane, true - false za paljenje i gasenje
      drawer: null,
      // kolekcija opcija za side-navbar
      
      items: [
        
        { heading: 'Učenik' ,mainicon: 'person'},        
        { icon: 'group', text: 'Pregled učenika u domu',link: '/ucenici' },
        { icon: 'group_add', text: 'Novi učenik - prijava',link: '/prijava' },
        { icon: 'list_alt', text: 'Pregled svih prijavljenih',link: '/ucenici' },

        { divider: true },
        { heading: 'Vaspitni rad' ,mainicon: 'book' },
        { icon: 'timer', text: 'Godišnji program rada' },
        { icon: 'insert_invitation', text: 'Mesečni plan rada' },
        { icon: 'ballot', text: 'Evidencija ostvarivanja programa'},
        
        { divider: true },
        { heading: 'Izveštaji' ,mainicon: 'bar_chart'}
        
      ], 
      // opcije koje se nalaze na glavnom toolbaru (na vrhu ekrana)
      menuItems: [
        {icon: 'supervisor_account', title: 'Lista ucenika',link: '/ucenici'},
        {icon: 'pets', title: 'Prijavi ucenika',link: '/prijava'},
      //  {icon: 'person', title: 'Profil',link: '/profil'},
       // {icon: 'face', title: 'Registruj se',link: '/registracija'},
      //  {icon: 'lock_open', title: 'Uloguj se',link: '/logovanje'}
      ]
    }),
    props: {
      source: String
    }
  }
</script>

<style>
  #keep main .container {
    height: 660px;
  }
  .v-navigation-drawer__border {
    display: none;
  }
  .text {
    font-weight: 400;
  }

  
</style>