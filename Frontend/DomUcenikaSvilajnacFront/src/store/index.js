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
        loading: false,
        error: null
    },
    mutations: {
        setLoadedUcenike (state,payload){
            state.ucenici=payload
            console.log(state.ucenici)
        },
        setLoadedOpstine (state,payload){
            state.opstine=payload
            console.log(state.opstine)
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
              ucenikEdit.opstina= {
                   id: payload.opstina.id,
              }
             
              
        }
        
    },
    
    actions: {
        loadedUcenici( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:41280/api/ucenik').then((response) => {
              
              commit('setLoadedUcenike', response.data)
              commit('setLoading', false)
              
            })
          },
          loadedOpstine( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:41280/api/opstine').then((response) => {
             
              commit('setLoadedOpstine', response.data)
            
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
                opstina: {
                     id: payload.opstina.id,
                }
                
            }
            commit('setLoading', true)
            axios.post('http://localhost:41280/api/ucenik',ucenik).then(function(response){
                console.log(response.data, this)
                
                commit('createUcenik',response.data)
                commit('setLoading', false)
                 })
  
        },
        deleteUcenik( {commit },payload ) {
            commit('setLoading', true)
           
            axios.delete('http://localhost:41280/api/ucenik/'+payload).then((response) => {
              
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
            mestoRodjenja: payload.mestoRodjenja,
            opstina: {
                 id: payload.opstina.id,
            }
            
        }
        commit('setLoading', true)
        axios.put('http://localhost:41280/api/ucenik/',+payload.id).then(function(response){
            commit('editUcenik', response.data)
            commit('setLoading', false)
             })

    },

    getters: {
        loadedUcenici (state)
    {
       
        return state.ucenici 
       
    }, loadedOpstine (state)
    {
       
        return state.opstine 
       
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