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
        polovi: [],
        mesta: [],
        osnovneSkole: [],
        srednjeSkole: [],
        smer: [],
        postanskiBrojevi: [],
        loading: false,
        error: null
    },
    mutations: {
        setLoadedMesta (state,payload)
        {
            state.mesta=payload
        },

        setLoadedOS (state,payload){
            state.osnovneSkole=payload
          
        },
        setLoadedSS (state,payload){
            state.srednjeSkole=payload
          
        },
        setLoadedSmerovi (state,payload){
            state.smer=payload
          
        },
        setLoadedPolove (state,payload){
            state.polovi=payload
          
        },
        setLoadedPostanskeBrojeve (state,payload){
            state.postanskiBrojevi=payload
          
        },
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
              ucenikEdit.adresa = payload.adresa,
              ucenikEdit.postanskiBroj= {
                    id:payload.postanskiBroj.id,
                    broj:payload.postanskiBroj.broj,
                    opstinaId:payload.postanskiBroj.opstinaId
              },
              ucenikEdit.pol= {
                    id:payload.pol.id,
                    nazivPola:payload.pol.nazivPola
              },
              smer= {
                    id: payload.smer.id,
                    nazivSmera: payload.smer.nazivSmera
              },            
              ucenikEdit.telefon= {
                    id:payload.telefon.id,
                    mobilni:payload.telefon.mobilni,
                    kucni:payload.telefon.kucni
              },
              ucenikEdit.dan= payload.dan,
              ucenikEdit.mesec= payload.mesec,
              ucenikEdit.godina= payload.godina,
              ucenikEdit.mestoRodjenja= {
                    id: payload.mestoRodjenja.id,
                    nazivMesta: payload.mestoRodjenja.nazivMesta
              },
              ucenikEdit.mestoPrebivalista= {
                    id: payload.mestoPrebivalista.id,
                    nazivMesta: payload.mestoPrebivalista.nazivMesta
              },
              ucenikEdit.prethodnaSkola={
                  id: payload.prethodnaSkola.id,
                  nazivPrethodneSkole: payload.prethodnaSkola.nazivPrethodneSkole,
                  opstinaId: payload.prethodnaSkola.opstinaId,
                  opstina: payload.prethodnaSkola.opstina
              },
              ucenikEdit.prethodnaSkola={
                id: payload.prethodnaSkola.id,
                nazivPrethodneSkole: payload.prethodnaSkola.nazivPrethodneSkole,
                opstinaId: payload.prethodnaSkola.opstinaId,
                opstina: payload.prethodnaSkola.opstina
              },
              ucenikEdit.upisanaSkola={
                id: payload.prethodnaSkola.id,
                nazivSrednjeSkole: payload.prethodnaSkola.nazivPrethodneSkole,
                opstinaId: payload.prethodnaSkola.opstinaId,
                opstina: payload.prethodnaSkola.opstina
              },
              ucenikEdit.mestoZavrsenseSkole={
                    id: payload.mestoZavrsenseSkole.id,
                    nazivMesta: payload.mestoZavrsenseSkole.id
              },
              ucenikEdit.opstina= {
                   id: payload.opstina.id,
                   nazivOpstine: payload.opstina.nazivOpstine,
                   postanskiBroj: payload.opstina.postanskiBroj
              },
              ucenikEdit.opstinaPrebivalista= {
                id: payload.opstinaPrebivalista.id,
                nazivOpstine: payload.opstinaPrebivalista.nazivOpstine,
                postanskiBroj: payload.opstinaPrebivalista.postanskiBroj
             },
              ucenikEdit.drzavaRodjenja={
                    id: payload.drzavaRodjenja.id,
                    nazivDrzave: payload.drzavaRodjenja.nazivDrzave
              }
             
              
        }
        
    },
    
    actions: {
        loadedMesta( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:7688/api/mesta').then((response) => {
              console.log(response.data)
              commit('setLoadedMesta', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
        loadedOS( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:7688/api/osnovneskole').then((response) => {
              console.log(response.data)
              commit('setLoadedOS', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
          loadedSS( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:7688/api/srednjeskole').then((response) => {
              console.log(response.data)
              commit('setLoadedSS', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
        
        loadedSmerovi( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:7688/api/smerovi').then((response) => {
              console.log(response.data)
              commit('setLoadedSmerovi', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
        loadedPostanskiBrojevi( {commit } ) {
        commit('setLoading', true)
        axios.get('http://localhost:7688/api/postanskiBrojevi').then((response) => {
          console.log(response.data)
          commit('setLoadedPostanskeBrojeve', response.data)
          commit('setLoading', false)
          
        }).catch(
            (error) => {
              console.log(error)
              commit('setLoading', false)
                    }
                )
      },
        loadedPolovi( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:7688/api/polovi').then((response) => {
              console.log(response.data)
              commit('setLoadedPolove', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
        loadedUcenici( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:7688/api/ucenik').then((response) => {
              console.log(response.data)
              commit('setLoadedUcenike', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
          loadedOpstine( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:7688/api/opstine').then((response) => {
                console.log(response.data)
              commit('setLoadedOpstine', response.data)
            
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                }
                     )
          },
          loadedDrzave( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:7688/api/drzave').then((response) => {
                console.log(response.data)
              commit('setLoadedDrzave', response.data)
            
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                }
      )
      
          },

        createUcenik ({commit}, payload) {
            const ucenik = {
                ime: payload.ime,
                prezime: payload.prezime,
                jmbg: payload.jmbg,
                adresa: payload.adresa,
                pol: {
                    id: payload.pol.id
                },
                smer: {
                    id: payload.smer.id
                },
                dan: payload.dan,
                mesec: payload.mesec,
                godina: payload.godina,
                mestoRodjenja: {
                    id: payload.mestoRodjenja.id
                },
                mestoPrebivalista: {
                    id: payload.mestoPrebivalista.id
                },
                prethodnaSkola:{
                    id: payload.prethodnaSkola.id
                },
                upisanaSkola:{
                    id: payload.upisanaSkola.id
                },
                mestoZavrsenseSkole:{
                    id: payload.mestoZavrsenseSkole.id
                },
                opstina: {
                    id: payload.opstina.id,
                },
                drzavaRodjenja: {
                    id: payload.drzavaRodjenja.id
                },
                postanskiBroj: {
                    id: payload.postanskiBroj.id
                },
                telefon: {
                    kucni:payload.telefon.kucni,
                    mobilni:payload.telefon.mobilni
                },
                opstinaPrebivalista: {
                    id: payload.opstinaPrebivalista.id,
               }
                
            }
            commit('setLoading', true)
            console.log(ucenik, this)
            axios.post('http://localhost:7688/api/ucenik',ucenik).then(function(response){
                console.log(response.data, this)
                
                commit('createUcenik',response.data)
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
  
        },
        deleteUcenik( {commit },payload ) {
            commit('setLoading', true)
           
            axios.delete('http://localhost:7688/api/ucenik/'+payload).then((response) => {
              
              commit('deleteUcenik', response.data)
              commit('setLoading', false)
            })
          },editUcenik ({commit}, payload) {
            const ucenik = {
                ime: payload.ime,
                prezime: payload.prezime,
                jmbg: payload.jmbg,
                adresa: payload.adresa,
                pol: {
                    id: payload.pol.id
                },
                smer: {
                    id: payload.smer.id
                },
                dan: payload.dan,
                mesec: payload.mesec,
                godina: payload.godina,
                mestoRodjenja: {
                    id: payload.mestoRodjenja.id
                },
                mestoPrebivalista: {
                    id: payload.mestoPrebivalista.id
                },
                prethodnaSkola:{
                    id: payload.prethodnaSkola.id
                },
                upisanaSkola:{
                    id: payload.upisanaSkola.id
                },
                mestoZavrsenseSkole:{
                    id: payload.mestoZavrsenseSkole.id
                },
                opstina: {
                    id: payload.opstina.id,
                },
                drzavaRodjenja: {
                    id: payload.drzavaRodjenja.id
                },
                postanskiBroj: {
                    id: payload.postanskiBroj.id
                },
                telefon: {
                    kucni:payload.telefon.kucni,
                    mobilni:payload.telefon.mobilni
                },
                opstinaPrebivalista: {
                    id: payload.opstinaPrebivalista.id,
               }
                
            }
            console.log(ucenik)
            commit('setLoading', true)
            axios.put('http://localhost:7688/api/ucenik/'+payload.id, ucenik).then(function(response){
                commit('editUcenik', response.data)
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
    
        }
    },

    getters: {
        loadedSmer (state)
        {
            return state.osnovneSkole  
        },
      
        loadedSrednjeSkole (state)
        {
            return state.srednjeSkole  
        },
        loadedOsnovneSkole (state)
        {
            return state.osnovneSkole  
        },
        loadedPolovi (state)
        {          
            return state.polovi  
        },
        loadedPostanskiBrojevi (state)
        {          
            return state.postanskiBrojevi           
        },
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