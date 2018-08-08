<template>
  <v-app id="inspire">
    <v-navigation-drawer
      v-model="drawer"
      fixed
      clipped
      class="grey lighten-4"
      app
    >
      <v-list
        dense
        class="grey lighten-4"
      >
        <template v-for="(item, i) in items">
          <v-layout
            v-if="item.heading"
            :key="i"
            row
            align-center
          >
            <v-flex xs6>
              <v-subheader v-if="item.heading">
                {{ item.heading }}
              </v-subheader>
            </v-flex>
            <v-flex xs6 class="text-xs-right">
              <v-btn small flat>Dummy Edit btn</v-btn>
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
          >
            <v-list-tile-action>
              <v-icon>{{ item.icon }}</v-icon>
            </v-list-tile-action>
            <v-list-tile-content>
              <v-list-tile-title class="grey--text">
                {{ item.text }}
              </v-list-tile-title>
            </v-list-tile-content>
          </v-list-tile>
        </template>
      </v-list>
    </v-navigation-drawer>
     <v-toolbar dark class="blue-grey darken-2"  app  clipped-left>
      <v-toolbar-side-icon @click.native="drawer = !drawer"></v-toolbar-side-icon>
          <v-toolbar-title>
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

      </v-toolbar-items>
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
      drawer: null,
      items: [
        { icon: 'lightbulb_outline', text: 'Lista ucenika',link: '/ucenici' },
        { icon: 'touch_app', text: 'Dummy1' },
        { divider: true },
        { heading: 'Dummy title' },
        { icon: 'add', text: 'Prijavi novog ucenika',link: '/prijava' },
        { divider: true },
        { icon: 'archive', text: 'Dummy2' },
        { icon: 'delete', text: 'Dummy3' },
        { divider: true },
        { icon: 'settings', text: 'Dummy4' },
        { icon: 'chat_bubble', text: 'Dummy5' },
        { icon: 'help', text: 'Dummy6' },
        { icon: 'phonelink', text: 'Dummy7' },
        { icon: 'keyboard', text: 'Dummy8' }
      ], 
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