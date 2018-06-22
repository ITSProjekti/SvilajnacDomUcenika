/* eslint-disable */
import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'
import VueAxios from 'vue-axios'

Vue.use(VueAxios, axios)

Vue.use(Vuex)


export const store = new Vuex.Store({
    state:{
        ucenici: [],
        loading: false,
        error: null
    },
    mutations: {
        setLoadedUcenike (state,payload){

            state.ucenici=payload
        },
        createUcenik (state,payload) {
            state.ucenici.push(payload)
        },
        setLoading(state, payload) {
            state.loading = payload
        },
        setError(state, payload) {
            state.error = payload
        },
        clearError(state) {
            state.error=null
        },
        createUcenik(state,payload)
        {
            state.ucenici.push(payload)
        }

    },
    
    actions: {
        loadedUcenici( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:2549/api/ucenik').then((response) => {
              console.log(response.data, this)
              commit('setLoadedUcenike', response.data)
              commit('setLoading', false)
            })
          },
        createUcenik ({commit}, payload) {
            const ucenik = {
                ime: payload.ime,
                prezime: payload.prezime,
                jmbg: payload.jmbg,
                pol: payload.pol,
                dan: payload.dan,
                mesec: payload.mesec,
                godina: payload.godina,
                mesto: {
                     id: payload.mesto.id,
                     mesto: payload.mesto.naziv
                }
                
            }
            axios.post('http://localhost:2549/api/ucenik',ucenik).then(function(response){
                commit('createUcenik', response.body)
                this.$router.push('/ucenici')
                 })
                 
           
        }
    },
    getters: {
        loadedUcenici (state)
    {
        console.log(state.ucenici)
        return state.ucenici 
       
    }, 
    loadedUceniciID (state) {
        return (id) => {
            return state.ucenici.find((id) => {
                return ucenik.id===id
            })
        }
    }
    
    }
})