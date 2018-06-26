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
            
        },
        deleteUcenik(state,payload)
        {
            state.ucenici.splice(payload.id)
        },
        editUcenik(state,payload)
        {

        }
    },
    
    actions: {
        loadedUcenici( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:18941/api/ucenik').then((response) => {
              
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
            commit('setLoading', true)
            axios.post('http://localhost:18941/api/ucenik',ucenik).then(function(response){
                console.log(response.data, this)
                
                commit('createUcenik', ucenik)
                commit('setLoading', false)
                 })
  
        },
        deleteUcenik( {commit },payload ) {
            commit('setLoading', true)
           
            axios.delete('http://localhost:18941/api/ucenik/'+payload).then((response) => {
              
              commit('deleteUcenik', response.data)
              commit('setLoading', false)
            })
          }
    }, editUcenik ({commit}, payload) {
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
        axios.put('http://localhost:18941/api/ucenik/',+payload.id).then(function(response){
            commit('editUcenik', response.body)
            
             })

    },

    getters: {
        loadedUcenici (state)
    {
       
        return state.ucenici 
       
    }, 
    loadedUceniciID (state) {
        return (id) => {
            return state.ucenici.find((id) => {
                return ucenik.id===id
            })
        }
    }, loading(state){
        return state.loading
    }
    
    }
})