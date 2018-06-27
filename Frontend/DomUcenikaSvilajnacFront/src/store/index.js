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
        opstine: [],
        drzave: [],
        loading: false,
        error: null
    },
    mutations: {
        setLoadedUcenike (state,payload){
            state.ucenici=payload
          
        },
        setLoadedOpstine (state,payload){
            state.opstine=payload
           
        },
        setLoadedDrzave (state,payload){
            state.drzave=payload
           
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
            console.log(payload)
            const ucenikEdit = state.ucenici.find(ucenikEdit => {
                return ucenikEdit.id === payload.id
              })
              ucenikEdit.ime= payload.ime,
              ucenikEdit.prezime= payload.prezime,
              ucenikEdit.jmbg= payload.jmbg,
              ucenikEdit.pol= payload.pol,
              ucenikEdit.dan= payload.dan,
              ucenikEdit.mesec= payload.mesec,
              ucenikEdit.godina= payload.godina,
              ucenikEdit.mestoRodjenja= payload.mestoRodjenja,
              ucenikEdit.mestoPrebivalista= payload.mestoPrebivalista,
              ucenikEdit.opstina= {
                   id: payload.opstina.id,
                   nazivOpstine: payload.opstina.nazivOpstine,
                   postanskiBroj: payload.opstina.postanskiBroj
              },
              ucenikEdit.drzavaRodjenja={
                    id: payload.drzavaRodjenja.id,
                    nazivDrzave: payload.drzavaRodjenja.nazivDrzave
              }
             
              
        }
        
    },
    
    actions: {
        loadedUcenici( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:57665/api/ucenik').then((response) => {
              
              commit('setLoadedUcenike', response.data)
              commit('setLoading', false)
              
            })
          },
          loadedOpstine( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:57665/api/opstine').then((response) => {
             
              commit('setLoadedOpstine', response.data)
            
              commit('setLoading', false)
              
            })
          },
          loadedDrzave( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:57665/api/drzave').then((response) => {
             
              commit('setLoadedDrzave', response.data)
            
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
                mestoRodjenja: payload.mestoRodjenja,
                mestoPrebivalista: payload.mestoPrebivalista,
                opstina: {
                     id: payload.opstina.id,
                },
                drzavaRodjenja: {
                     id: payload.drzavaRodjenja.id
                }
                
            }
            commit('setLoading', true)
            console.log(ucenik, this)
            axios.post('http://localhost:57665/api/ucenik',ucenik).then(function(response){
                console.log(response.data, this)
                
                commit('createUcenik',response.data)
                commit('setLoading', false)
                 })
  
        },
        deleteUcenik( {commit },payload ) {
            commit('setLoading', true)
           
            axios.delete('http://localhost:57665/api/ucenik/'+payload).then((response) => {
              
              commit('deleteUcenik', response.data)
              commit('setLoading', false)
            })
          },editUcenik ({commit}, payload) {
            const ucenik = {
                ime: payload.ime,
                prezime: payload.prezime,
                jmbg: payload.jmbg,
                pol: payload.pol,
                dan: payload.dan,
                mesec: payload.mesec,
                godina: payload.godina,
                mestoRodjenja: payload.mestoRodjenja,
                mestoPrebivalista: payload.mestoPrebivalista,
                opstina: {
                     id: payload.opstina.id,
                },
                drzavaRodjenja: {
                     id: payload.drzavaRodjenja.id
                }
                
            }
            console.log(ucenik)
            commit('setLoading', true)
            axios.put('http://localhost:57665/api/ucenik/'+payload.id, ucenik).then(function(response){
                commit('editUcenik', response.data)
                commit('setLoading', false)
                 })
    
        }
    },

    getters: {
        loadedUcenici (state)
    {
       
        return state.ucenici 
       
    }, loadedOpstine (state)
    {
       
        return state.opstine 
       
    }, loadedDrzave (state)
    {
       
        return state.drzave 
       
    },
    loadedUceniciID (state) {
        return (id) => {
            return state.ucenici.find((id) => {
                return ucenik.id===id
            })
        }
    }, loading(state){
        return state.loading
        console.log(state.loading)
    }
    
    }
})