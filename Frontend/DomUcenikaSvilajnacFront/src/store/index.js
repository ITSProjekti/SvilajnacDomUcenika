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
        postanskiBrojevi: [],
        loading: false,
        error: null
    },
    mutations: {
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
              ucenikEdit.postanskiBroj= {
                    id:payload.postanskiBroj.id,
                    broj:payload.postanskiBroj.broj,
                    opstinaId:payload.postanskiBroj.opstinaId
              },
              ucenikEdit.pol= {
                    id:payload.pol.id,
                    nazivPola:payload.pol.nazivPola
              },
              ucenikEdit.telefon= {
                    id:payload.telefon.id,
                    mobilni:payload.telefon.mobilni,
                    kucni:payload.telefon.kucni
              },
              ucenikEdit.dan= payload.dan,
              ucenikEdit.mesec= payload.mesec,
              ucenikEdit.godina= payload.godina,
              ucenikEdit.mestoRodjenja= payload.mestoRodjenja,
              ucenikEdit.mestoPrebivalista= payload.mestoPrebivalista,
              ucenikEdit.prethodnaSkola=payload.prethodnaSkola,
              ucenikEdit.mestoZavrsenseSkole=payload.mestoZavrsenseSkole,
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
        loadedPostanskiBrojevi( {commit } ) {
        commit('setLoading', true)
        axios.get('http://localhost:52888/api/postanskiBrojevi').then((response) => {
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
            axios.get('http://localhost:52888/api/polovi').then((response) => {
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
            axios.get('http://localhost:52888/api/ucenik').then((response) => {
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
            axios.get('http://localhost:52888/api/opstine').then((response) => {
             
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
            axios.get('http://localhost:52888/api/drzave').then((response) => {
             
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
                pol: {
                    id: payload.pol.id
                },
                dan: payload.dan,
                mesec: payload.mesec,
                godina: payload.godina,
                mestoRodjenja: payload.mestoRodjenja,
                mestoPrebivalista: payload.mestoPrebivalista,
                prethodnaSkola:payload.prethodnaSkola,
                mestoZavrsenseSkole:payload.mestoZavrsenseSkole,
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
            axios.post('http://localhost:52888/api/ucenik',ucenik).then(function(response){
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
           
            axios.delete('http://localhost:52888/api/ucenik/'+payload).then((response) => {
              
              commit('deleteUcenik', response.data)
              commit('setLoading', false)
            })
          },editUcenik ({commit}, payload) {
            const ucenik = {
                ime: payload.ime,
                prezime: payload.prezime,
                jmbg: payload.jmbg,
                pol: {
                    id: payload.pol.id
                },
                dan: payload.dan,
                mesec: payload.mesec,
                godina: payload.godina,
                mestoRodjenja: payload.mestoRodjenja,
                mestoPrebivalista: payload.mestoPrebivalista,
                prethodnaSkola:payload.prethodnaSkola,
                mestoZavrsenseSkole:payload.mestoZavrsenseSkole,
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
            axios.put('http://localhost:52888/api/ucenik/'+payload.id, ucenik).then(function(response){
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