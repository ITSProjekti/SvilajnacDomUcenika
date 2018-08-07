
import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'
import VueAxios from 'vue-axios'

Vue.use(VueAxios, axios)

Vue.use(Vuex)

/* eslint-disable */
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
        razred: [],
        stepeniStrucneSpreme: [],
        postanskiBrojevi: [],
        loading: false,
        error: null
    },
    mutations: {
        setLoadedSSS (state,payload)
        {
            state.stepeniStrucneSpreme=payload
        },
        setLoadedRazred (state,payload)
        {
            state.razred=payload
        },
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
            var novi = JSON.parse(JSON.stringify(payload))
           // novi.roditelji=null
  
            novi.roditelji=[
                {
                    id:payload.roditelji.idMajke,
                    ime: payload.roditelji.imeMajke,
                    prezime: payload.roditelji.prezimeMajke,
                    brojTelefona: payload.roditelji.brojTelefonaMajke,
                    stepenObrazovanjaId:payload.roditelji.strucnaSpremaMajkeId
                 },
                 {
                    id:payload.roditelji.id,
                    ime: payload.roditelji.imeOca,
                    prezime: payload.roditelji.prezimeOca,
                    brojTelefona: payload.roditelji.brojTelefonaOca,
                    stepenObrazovanjaId:payload.roditelji.strucnaSpremaOcaId
                 }
        
            ]
            console.log(novi)
            state.ucenici.push(novi)

               
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
              ucenikEdit.adresa = payload.adresa,
              ucenikEdit.prethodiUspeh = payload.prethodiUspeh,
              ucenikEdit.smer = {
                    id: payload.smer.id,
                    nazivSmera: payload.smer.nazivSmera
              },
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
                  opstinaId: payload.prethodnaSkola.opstinaId

              },
            
              ucenikEdit.upisanaSkola={
                id: payload.upisanaSkola.id,
                nazivSrednjeSkole: payload.upisanaSkola.nazivPrethodneSkole,
                opstinaId: payload.upisanaSkola.opstinaId

              },
              ucenikEdit.mestoZavrseneSkole={
                    id: payload.mestoZavrseneSkole.id,
                    nazivMesta: payload.mestoZavrseneSkole.nazivMesta
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
              },
             ucenikEdit.razred={
                 id: payload.razred.id,
                 brojRazreda: payload.razred.brojRazreda
             },
             ucenikEdit.roditelji=[
             
                 {
                    id:payload.roditelji.idMajke,
                    ime: payload.roditelji.imeMajke,
                    prezime: payload.roditelji.prezimeMajke,
                    brojTelefona: payload.roditelji.brojTelefonaMajke,
                    stepenObrazovanjaId:payload.roditelji.strucnaSpremaMajkeId
                 },
                 {
                    id:payload.roditelji.id,
                    ime: payload.roditelji.imeOca,
                    prezime: payload.roditelji.prezimeOca,
                    brojTelefona: payload.roditelji.brojTelefonaOca,
                    stepenObrazovanjaId:payload.roditelji.strucnaSpremaOcaId
                 }

             ]
               
           
             
              
        }
        
    },
    
    actions: {
        loadedSSS( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:17044/api/stepenistrucnespreme').then((response) => {
           
              commit('setLoadedSSS', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
        loadedRazred( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:17044/api/razredi').then((response) => {
           
              commit('setLoadedRazred', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
        loadedMesta( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:17044/api/mesta').then((response) => {
           
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
            axios.get('http://localhost:17044/api/osnovneskole').then((response) => {
              
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
            axios.get('http://localhost:17044/api/srednjeskole').then((response) => {
            
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
            axios.get('http://localhost:17044/api/smerovi').then((response) => {
          
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
        axios.get('http://localhost:17044/api/postanskiBrojevi').then((response) => {
         
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
            axios.get('http://localhost:17044/api/polovi').then((response) => {
           
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
            axios.get('http://localhost:17044/api/ucenik').then((response) => {
            
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
            axios.get('http://localhost:17044/api/opstine').then((response) => {
               
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
            axios.get('http://localhost:17044/api/drzave').then((response) => {
               
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
                prethodiUspeh: payload.prethodiUspeh,
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
                mestoZavrseneSkole:{
                    id: payload.mestoZavrseneSkole.id
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
               },
               razred:{
                   id: payload.razred.id
               },
               roditelji:{
                 
                ImeOca: payload.roditelji[0].ime,
                PrezimeOca: payload.roditelji[0].prezime,
                ImeMajke: payload.roditelji[1].ime,
                PrezimeMajke: payload.roditelji[1].prezime,
                StrucnaSpremaMajkeId: payload.roditelji[1].stepenObrazovanjaId,
                StrucnaSpremaOcaId:  payload.roditelji[0].stepenObrazovanjaId,
                BrojTelefonaMajke: payload.roditelji[0].brojTelefona,
                BrojTelefonaOca: payload.roditelji[1].brojTelefona
               }
            }
        
            commit('setLoading', true)
            console.log(ucenik)
            axios.post('http://localhost:17044/api/ucenik',ucenik).then(function(response){
               

                   
                commit('createUcenik', response.data)
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
           
            axios.delete('http://localhost:17044/api/ucenik/'+payload).then((response) => {
              
              commit('deleteUcenik', response.data)
              commit('setLoading', false)
            })
          }
          ,editUcenik ({commit}, payload) {
            const ucenik = {
                ime: payload.ime,
                prezime: payload.prezime,
                jmbg: payload.jmbg,
                adresa: payload.adresa,
                prethodiUspeh: payload.prethodiUspeh,
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
                mestoZavrseneSkole:{
                    id: payload.mestoZavrseneSkole.id
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
               },
               razred:{
                   id: payload.razred.id
               },
               roditelji:{
                   ucenikID: payload.id,
                   ImeOca: payload.roditelji[1].ime,
                   PrezimeOca: payload.roditelji[1].prezime,
                   ImeMajke: payload.roditelji[0].ime,
                   PrezimeMajke: payload.roditelji[0].prezime,
                   StrucnaSpremaMajkeId: payload.roditelji[1].stepenObrazovanjaId,
                   StrucnaSpremaOcaId:  payload.roditelji[0].stepenObrazovanjaId,
                   BrojTelefonaMajke: payload.roditelji[0].brojTelefona,
                   BrojTelefonaOca: payload.roditelji[1].brojTelefona
               }
                
            }
            console.log(ucenik)
            commit('setLoading', true)
            axios.put('http://localhost:17044/api/ucenik/'+payload.id, ucenik).then(function(response){
               
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
        loadedSSS (state) {
            return state.stepeniStrucneSpreme
        },
        loadedRazredi (state) {
            return state.razred
        },
        loadedMesta (state) {
            return state.mesta
        },
        loadedSmer (state)
        {
            return state.smer 
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