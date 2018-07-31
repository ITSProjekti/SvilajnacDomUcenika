// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'
import Vuetify from 'vuetify'
import 'vuetify/dist/vuetify.min.css'
import {store} from './store'
import axios from 'axios'
import VueAxios from 'vue-axios'

Vue.use(VueAxios, axios)
Vue.use(Vuetify)

Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  store,
  components: { App },
  template: '<App/>',
  created () {
    this.$store.dispatch('loadedUcenici')
    this.$store.dispatch('loadedDrzave')
    this.$store.dispatch('loadedPostanskiBrojevi')
    this.$store.dispatch('loadedPolovi')
    this.$store.dispatch('loadedSmerovi')
    this.$store.dispatch('loadedSS')
    this.$store.dispatch('loadedOS')
    this.$store.dispatch('loadedMesta')
    this.$store.dispatch('loadedRazred')
    return this.$store.dispatch('loadedOpstine')
  }
})
