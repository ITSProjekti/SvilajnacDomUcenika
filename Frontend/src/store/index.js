
import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'
import VueAxios from 'vue-axios'
// axios sluzi da upotrbu HTTP requestova
Vue.use(VueAxios, axios)
// Vuex sluzi za rad sa vue-store-om koji sluzi da stvaranje "baze" podataka za front
Vue.use(Vuex)
// linija ispod sluzi da iskljuci eslint korekciju pisanja koda
/* eslint-disable */
export const store = new Vuex.Store({
    // veliki objekat koji sadrzi atribute neophodne za rad programa state-baza, mutatori-menjanje baze,
    // getteri-uzimanje podataka iz baze, actions -metode koje se pozivaju van store-a za rad sa store-om
    state:{
        ucenici: [],
        opstine: [],
        drzave: [],
        polovi: [],
        mesta: [],
        vaspitaci: [],
        osnovneSkole: [],
        srednjeSkole: [],
        smer: [],
        razred: [],
        kazne: [],
        pohvale: [],
        statusiprijave: [],
        sastanci: [],
        vaspitnegrupe: [],
        stepeniStrucneSpreme: [],
        postanskiBrojevi: [],
        tipoviPorodice: [],
        // atribut za ukljucivanje stanja ucitavanja prilikom rada sa bazom, obicno za prikazivanje loading stvari
        loading: false,
        // atribut za prikazivanje gresaka prilikom HTTP zahteva sa bazom
        error: null
    },
    // mutacije su metode koje imaju direktan kontakt sa bazom, obicno sluze za cuvanje podataka u bazu
    mutations: {
         // sve setLoaded metode sluze za ubacivanje podataka u State sa backend-a, kreiranje front baze
        setLoadedSastanci (state,payload)
        {
            state.sastanci=payload
        },
        setLoadedStatusiPrijave (state,payload)
        {
            state.statusiprijave=payload
        },



       
        setLoadedVaspitac (state,payload)
        {
            state.vaspitaci=payload
        },
        setLoadedKazne (state,payload)
        {
            state.kazne=payload
        },
        setLoadedPohvale (state,payload)
        {
            state.pohvale=payload
        },
        setLoadedVaspitneGrupe (state,payload)
        {
            state.vaspitnegrupe=payload
        },
        setLoadedTipovePorodice (state,payload)
        {
            state.tipoviPorodice=payload
        },
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
        setLoading(state, payload) {
            state.loading = payload
        },
        setError(state, payload) {
            state.error = payload
        },
        clearError(state) {
            state.error=null
        },
        
        createSastanci(state,payload)
        {
            state.sastanci.push(payload)
        },
        createUcenik(state,payload)
        {
            // JSON kopiranje objekata gde je payload podatak koji stize sa backend-a
            var novi = JSON.parse(JSON.stringify(payload))
        
            // roditelji u payload-u su u drugacijem formatu te se ovde vrsi mapiranje iz tog resursa u objekat koji sadrzi 2 roditelja
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
            state.ucenici.push(novi)               
        },
        createVaspitnaGrupa(state,payload)
        {
            state.vaspitnegrupe.push(payload)
        },
        createVaspitac(state,payload)
        {
            state.vaspitaci.push(payload)
        },
        createPohvala(state,payload)
        {
            state.pohvale.push(payload)
        },
        createKazna(state,payload)
        {
            state.kazne.push(payload)
        },
        // brisanje ucenika iz state-a
        deleteUcenik(state,payload)
        {
            state.ucenici.splice(payload.id)
        },
        deleteVaspitnaGrupa(state,payload)
        {
            state.vaspitnegrupe.splice(payload.id)
        },
        deleteKazna(state,payload)
        {
            state.kazne.splice(payload.id)
        },
        deletePohvala(state,payload)
        {
            state.pohvale.splice(payload.id)
        },
        deleteSastanci(state,payload)
        {
            state.sastanci.splice(payload.id)
        },
        deleteVaspitac(state,payload)
        {
            state.vaspitaci.splice(payload.id)
        },
        editKazne(state,payload){
            const kazneEdit = state.kazne.find(kazneEdit =>{
                return kazneEdit.id ===payload.id
            })
            kazneEdit.opis=payload.opis,
            kazneEdit.bodoviKazne=payload.bodoviKazne,
            kazneEdit.ucenikId=payload.ucenikId
        },
        editPohvale(state,payload) {
            const pohvalaEdit = state.pohvale.find(pohvalaEdit => {
                return pohvalaEdit.id===payload.id
            })
            pohvalaEdit.opis = payload.opis,
            pohvalaEdit.bodoviPohvale = payload.bodoviPohvale,
            pohvalaEdit.ucenikId=payload.ucenikId
        },
        editSastanci(state,payload)
        {
            const sastanciEdit = state.sastanci.find(sastanciEdit =>{
                return sastanciEdit.id ===payload.id
            })
            sastanciEdit.brojPrisutnihUcenika= payload.brojPrisutnihUcenika,
            sastanciEdit.vaspitnaGrupa= {
                    id: payload.vaspitnaGrupa.id
                        },
            sastanciEdit.opisDnevnogRada= payload.opisDnevnogRada,
            sastanciEdit.odlukeDoneseneNaSastanku= payload.odlukeDoneseneNaSastanku,
            sastanciEdit.zakljucciSastanka= payload.zakljucciSastanka
        },
        editVaspitneGrupe(state,payload)
        {
            const vaspitnaGrupaEdit = state.vaspitnegrupe.find(vaspitnaGrupaEdit =>{
                return vaspitnaGrupaEdit.id === payload.id
            })
            vaspitnaGrupaEdit.naziv=payload.naziv,
            vaspitnaGrupaEdit.vaspitac = {
                id: payload.vaspitac.id,
                ime: payload.vaspitac.ime,
                prezime: payload.vaspitac.prezime,
                slika: payload.vaspitac.slika
            }
      
        },
        editVaspitaca(state,payload)
        {
            const vaspitacEdit = state.vaspitaci.find(vaspitacEdit =>{
                return vaspitacEdit.id=== payload.id
            })
           
            vaspitacEdit.ime = payload.ime,
            vaspitacEdit.prezime = payload.prezime,
            vaspitacEdit.brojTelefona = payload.brojTelefona,
            vaspitacEdit.slika = payload.slika
        },
          // mutacija za promenu podataka ucenika iz state-a nakon PUT HTTP zahteva
        editUcenik(state,payload)
        {
            // mapiranje koje vrsi celokupni edit, mozda je moglo da se napravi da se menjaju samo promenjeni podaci
            const ucenikEdit = state.ucenici.find(ucenikEdit => {
                return ucenikEdit.id === payload.id
              })
              ucenikEdit.ime= payload.ime,
              ucenikEdit.prezime= payload.prezime,
              ucenikEdit.jmbg= payload.jmbg,
              ucenikEdit.brojPutaUDomu= payload.brojPutaUDomu,
              ucenikEdit.adresa = payload.adresa,
              ucenikEdit.statusPrijave ={
                id:  payload.statusPrijave.id,
                status:  payload.statusPrijave.status
              },
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
                nazivSrednjeSkole: payload.upisanaSkola.nazivSrednjeSkole,
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
             ucenikEdit.tipPorodice={
                id: payload.tipPorodice.id,
                nazivTipaPorodice: payload.tipPorodice.nazivTipaPorodice
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

             ],
             ucenikEdit.vaspitnaGrupa={
                 id:payload.vaspitnaGrupa.id,
                 naziv:payload.vaspitnaGrupa.naziv
             }
             ucenikEdit.tipPorodice={
                id: payload.tipPorodice.id,
                nazivTipaPorodice: payload.tipPorodice.nazivTipaPorodice
             },
             ucenikEdit.staratelji= {
             id: payload.staratelji.id,
             ime: payload.staratelji.ime,
             prezime: payload.staratelji.prezime,
             ucenikId: payload.staratelji.ucenikId
             },
             ucenikEdit.slika= payload.slika,
             ucenikEdit.materijalniPrihodi=payload.materijalniPrihodi            
        }
    
    },
    // actions su metode koje se pozivaju van store-a da bi se nesto radilo sa store-om primer : this.$store.dispatch('loadedSSS')
    actions: {
       LoadedStatusiPrijave( {commit } ) {         
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/statusiprijave').then((response) => {       
              commit('setLoadedStatusiPrijave', response.data)        
              commit('setLoading', false)        
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
        loadedSastanci( {commit } ) {        
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/sastanci').then((response) => {   
              commit('setLoadedSastanci', response.data)       
              commit('setLoading', false)       
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
        // HTTP GET zahtev za stepene strucne spreme 
        loadedSSS( {commit } ) {
            // commit sluzi za pozivanje mutatacija (mutations) metoda
            // podesavanjem loading na true ulazi se u fazu ucitavanja te se na odgovarajucem mesto prikazuje neki vid loading stanja
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/stepenistrucnespreme').then((response) => {
            // pozivanje mutatora za popunjavanje State-a sa zeljenim podacima, response.data je ono sto stize sa backend-a
              commit('setLoadedSSS', response.data)
              // nakon ucitanih podataka skinuti prikaz stanja loading-a sa odgovarajucih mesta
              commit('setLoading', false)
              // catch greske i prikazi ih na konzoli
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },loadedVaspitneGrupe( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/vaspitnegrupe').then((response) => {
              
              commit('setLoadedVaspitneGrupe', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },loadedVaspitac( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/vaspitaci').then((response) => {
           
              commit('setLoadedVaspitac', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
          loadedKazne( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/kazne').then((response) => {
           
              commit('setLoadedKazne', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
          loadedPohvale( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/pohvale').then((response) => {
           
              commit('setLoadedPohvale', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
          loadedTipoviPorodice( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/tipoviporodice').then((response) => {
           
              commit('setLoadedTipovePorodice', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
          // HTTP GET zahtev za razrede koje ucenik moze da upise
        loadedRazred( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/razredi').then((response) => {
           
              commit('setLoadedRazred', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
          // HTTP GET zahtev za sva mesta u Srbiji
        loadedMesta( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/mesta').then((response) => {
           
              commit('setLoadedMesta', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
          // HTTP GET zahtev za sve osnovne skole u Srbiji
        loadedOS( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/osnovneskole').then((response) => {
              
              commit('setLoadedOS', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
          // HTTP GET zahtev za sve srednje skole u Srbiji
          loadedSS( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/srednjeskole').then((response) => {
            
              commit('setLoadedSS', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
        // HTTP GET zahtev za sve smerove koje ucenik moze upisati u Svilajncu
        loadedSmerovi( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/smerovi').then((response) => {
          
              commit('setLoadedSmerovi', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
          // HTTP GET zahtev za sve postanske brojeve u srbiji
        loadedPostanskiBrojevi( {commit } ) {
        commit('setLoading', true)
        axios.get('http://localhost:50146/api/postanskiBrojevi').then((response) => {
         
          commit('setLoadedPostanskeBrojeve', response.data)
          commit('setLoading', false)
          
        }).catch(
            (error) => {
              console.log(error)
              commit('setLoading', false)
                    }
                )
      },
      // HTTP GET zahtev za prikaz polova
        loadedPolovi( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/polovi').then((response) => {
           
              commit('setLoadedPolove', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
          // HTTP GET zahtev za sve prijavljene ucenike
        loadedUcenici( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/ucenik').then((response) => {
            
              commit('setLoadedUcenike', response.data)
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                        }
                    )
          },
          // HTTP GET zahtev za sve opstine u Srbiji
          loadedOpstine( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/opstine').then((response) => {
               
              commit('setLoadedOpstine', response.data)
            
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                }
                     )
          },
          // HTTP GET zahtev za sve drzave na svetu
          loadedDrzave( {commit } ) {
            commit('setLoading', true)
            axios.get('http://localhost:50146/api/drzave').then((response) => {
               
              commit('setLoadedDrzave', response.data)
            
              commit('setLoading', false)
              
            }).catch(
                (error) => {
                  console.log(error)
                  commit('setLoading', false)
                }
      )
      
          },   
          createSastanak ({commit},payload) {
            const sastanak ={
             
                brojPrisutnihUcenika: payload.brojPrisutnihUcenika,
               
                vaspitnaGrupa: {
                id: payload.vaspitnaGrupa.id
                },
                opisDnevnogRada: payload.opisDnevnogRada,
                odlukeDoneseneNaSastanku: payload.odlukeDoneseneNaSastanku,
                zakljucciSastanka: payload.zakljucciSastanka
            }
            commit('setLoading', true)
            console.log(sastanak)
            axios.post('http://localhost:50146/api/sastanci',sastanak, {
                onUploadProgress: uploadEvent =>{
                    console.log('Post request progress:' + Math.round(uploadEvent.loaded / uploadEvent.total * 100) + '%'  )                    
                }
            }).then(function(response){

               
                commit('createSastanci', response.data)
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
        },
          createKazna ({commit},payload) {
            const kazna ={
                opis: payload.opis,
                bodoviKazne: payload.bodoviKazne,
                ucenikId: payload.ucenikId
            }
            commit('setLoading', true)
            console.log(kazna)
            axios.post('http://localhost:50146/api/kazne',kazna, {
                onUploadProgress: uploadEvent =>{
                    console.log('Post request progress:' + Math.round(uploadEvent.loaded / uploadEvent.total * 100) + '%'  )                    
                }
            }).then(function(response){

               
                commit('createKazna', response.data)
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
        },
          createPohvala ({commit},payload) {
              console.log(payload)
          const pohvala = {
              opis: payload.opis,
              bodoviPohvale: payload.bodoviPohvale,
              ucenikId: payload.ucenikId
          }
            commit('setLoading', true)
            console.log(pohvala)
            axios.post('http://localhost:50146/api/pohvale',pohvala, {
                onUploadProgress: uploadEvent =>{
                    console.log('Post request progress:' + Math.round(uploadEvent.loaded / uploadEvent.total * 100) + '%'  )                    
                }
            }).then(function(response){

               
                commit('createPohvala', response.data)
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
        },
        
          createVaspitnaGrupa ({commit},payload) {
            const vaspitnaGrupa ={
                naziv: payload.naziv
          
            }
            commit('setLoading', true)
   
            axios.post('http://localhost:50146/api/vaspitnegrupe',vaspitnaGrupa, {
                onUploadProgress: uploadEvent =>{
                    console.log('Post request progress:' + Math.round(uploadEvent.loaded / uploadEvent.total * 100) + '%'  )                    
                }
            }).then(function(response){

               console.log(response.data)
                commit('createVaspitnaGrupa', response.data)
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
        },
        createVaspitac ({commit},payload) {
            const vaspitac ={
                ime: payload.ime,
                prezime: payload.prezime,
                brojTelefona: payload.brojTelefona,
                slika: payload.slika
            }
            commit('setLoading', true)
            console.log(vaspitac)
            axios.post('http://localhost:50146/api/vaspitaci',vaspitac, {
                onUploadProgress: uploadEvent =>{
                    console.log('Post request progress:' + Math.round(uploadEvent.loaded / uploadEvent.total * 100) + '%'  )                    
                }
            }).then(function(response){
                console.log(response.data)
               
                commit('createVaspitac', response.data)
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
        },
          // HTTP POST zahtev za prijavu novog ucenika
        createUcenik ({commit}, payload) {
            // payload je objekat koji stize sa nekih od komponenti zaduzenih za prijavu novog ucenika
            // kreira sa objekat adekvatan za slanje na HTTP POST
            const ucenik = {
                ime: payload.ime,
                prezime: payload.prezime,
                jmbg: payload.jmbg,
                adresa: payload.adresa,
                brojPutaUDomu: payload.brojPutaUDomu,
                prethodniUspeh: payload.prethodniUspeh,
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
               // post resurs zahteva roditelje u objektu koji nije kolekcija vec ima atribute za oca i majku
               roditelji:{
                 
                ImeOca: payload.roditelji[0].ime,
                PrezimeOca: payload.roditelji[0].prezime,
                ImeMajke: payload.roditelji[1].ime,
                PrezimeMajke: payload.roditelji[1].prezime,
                StrucnaSpremaMajkeId: payload.roditelji[1].stepenObrazovanjaId,
                StrucnaSpremaOcaId:  payload.roditelji[0].stepenObrazovanjaId,
                BrojTelefonaMajke: payload.roditelji[0].brojTelefona,
                BrojTelefonaOca: payload.roditelji[1].brojTelefona
               },
               tipPorodice:{
                   id: payload.tipPorodice.id
               },
               staratelji:{
                   ime: payload.staratelji.ime,
                   prezime:  payload.staratelji.prezime
                 
               },
               slika: payload.slika,
               materijalniPrihodi: payload.materijalniPrihodi,
               
               }
               
               
            commit('setLoading', true)
          
            axios.post('http://localhost:50146/api/ucenik',ucenik, {
                onUploadProgress: uploadEvent =>{
                    console.log('Post request progress:' + Math.round(uploadEvent.loaded / uploadEvent.total * 100) + '%'  )                    
                }
            }).then(function(response){

                console.log(response.data)
                commit('createUcenik', response.data)
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
  
        },
        deleteVaspitnaGrupa( {commit },payload ) {
            commit('setLoading', true)
           
            axios.delete('http://localhost:50146/api/vaspitneGrupe/'+payload).then((response) => {
              
              commit('deleteVaspitnaGrupa', response.data)
              store.dispatch('loadedUcenici')
              store.dispatch('loadedVaspitneGrupe')
              commit('setLoading', false)
            })
          },
          deleteKazna( {commit },payload ) {
            commit('setLoading', true)
           
            axios.delete('http://localhost:50146/api/kazne/'+payload).then((response) => {
              
              commit('deleteKazna', response.data)
              commit('setLoading', false)
            })
          },
          deletePohvala( {commit },payload ) {
            commit('setLoading', true)
           
            axios.delete('http://localhost:50146/api/pohvale/'+payload).then((response) => {
              
              commit('deletePohvala', response.data)
              commit('setLoading', false)
            })
          },
          deleteVaspitac( {commit },payload ) {
            commit('setLoading', true)
           
            axios.delete('http://localhost:50146/api/vaspitaci/'+payload).then((response) => {
              
              commit('deleteVaspitac', response.data)
              commit('setLoading', false)
            })
          },
        // HTTP DELETE zahtev za brisanje prijavljenog ucenika, zahteva ID ucenika koji se brise
        deleteUcenik( {commit },payload ) {
            commit('setLoading', true)
           
            axios.delete('http://localhost:50146/api/ucenik/'+payload).then((response) => {
              
              commit('deleteUcenik', response.data)
              commit('setLoading', false)
            })
            
          },
          editVaspitneGrupe ({commit}, payload) {
                const vaspitneGrupe = {
                naziv: payload.naziv,
                vaspitac: {
                    id:payload.vaspitac.id
                }
            }
            commit('setLoading', true)
            axios.put('http://localhost:50146/api/vaspitnegrupe/'+payload.id, vaspitneGrupe).then(function(response){
               
                commit('editVaspitneGrupe', response.data)
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
          },
          editVaspitaca ({commit}, payload) {
            const vaspitac = {
                ime: payload.ime,
                prezime: payload.prezime,
                brojTelefona: payoad.brojTelefona,
                slika: payload.slika
            }
            commit('setLoading', true)
            axios.put('http://localhost:50146/api/vaspitaci/'+payload.id, vaspitac).then(function(response){
               
                commit('editVaspitaca', response.data)
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
          },
          editKazne ({commit}, payload) {
            const kazna = {
                opis : payload.opis,
                bodoviKazne : payload.bodoviKazne,
                ucenikId: payload.ucenikId
            }
            commit('setLoading', true)
            axios.put('http://localhost:50146/api/kazne/'+payload.id, kazna).then(function(response){
               
                commit('editKazne', response.data)
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
          },
          editPohvale ({commit}, payload) {
            const pohvala = {
                opis : payload.opis,
                bodoviPohvale : payload.bodoviPohvale,
                ucenikId: payload.ucenikId
            }
            commit('setLoading', true)
            axios.put('http://localhost:50146/api/pohvale/'+payload.id, pohvala).then(function(response){
               
                commit('editPohvale', response.data)
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
          },
          // HTTP PUT zahtev za menjanje podataka prijavljenog ucenika
          editUcenik ({commit}, payload) {
            const ucenik = {
                ime: payload.ime,
                prezime: payload.prezime,
                jmbg: payload.jmbg,
                brojPutaUDomu: payload.brojPutaUDomu,
                adresa: payload.adresa,
                statusPrijave: {
                    id: payload.statusPrijave.id
                },
                prethodniUspeh: payload.prethodniUspeh,
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
               },
               tipPorodice:{
                   id: payload.tipPorodice.id
               },
               staratelji:{
                   ime: payload.staratelji.ime,
                   prezime:  payload.staratelji.prezime,
                   ucenikId:  payload.staratelji.ucenikId
               },
               slika:payload.slika,
               materijalniPrihodi: payload.materijalniPrihodi,
               vaspitnaGrupa:{
                            id:payload.vaspitnaGrupa.id
               } 
            }
            console.log('yo')
            console.log(ucenik)
            commit('setLoading', true)
            axios.put('http://localhost:50146/api/ucenik/'+payload.id, ucenik).then(function(response){
               console.log(response.data)
                commit('editUcenik', response.data)
                commit('setLoading', true)
                axios.get('http://localhost:50146/api/vaspitnegrupe').then((response) => {
                  
                  commit('setLoadedVaspitneGrupe', response.data)
                  commit('setLoading', false)
                  
                }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                            }
                        )
                commit('setLoading', false)
                 }).catch(
                    (error) => {
                      console.log(error)
                      commit('setLoading', false)
                    }
          )
   
        }
    },
    // getteri su metode koje sluze za preuzimanje (get-ovanje) podataka iz State-a
    getters: {
        getUcenikById: (state )  => (id) =>{ 
            console.log(id)
            const ucenikEdit = state.ucenici.find(ucenikEdit => {               
                 ucenikEdit.id === id
              })            
        },
        loadedSastanci (state) {
            return state.sastanci
        },
        LoadedStatusiPrijave (state) {
            return state.statusiprijave
        },
        loadedVaspitneGrupe (state) {
            return state.vaspitnegrupe
        },
        loadedVaspitac (state) {
            return state.vaspitaci
        },
        loadedKazne (state) {
            return state.kazne
        },
        loadedPohvale (state) {
            return state.pohvale
        },
        loadedTipoviPorodice (state) {
            return state.tipoviPorodice
        },
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
        console.log(state.ucenici)
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
         return state.ucenici.find((ucenik) =>
     {
         return ucenik.id===id
     })
     }
        },
     loading(state){
        return state.loading
        console.log(state.loading)
    }
    
    }
})