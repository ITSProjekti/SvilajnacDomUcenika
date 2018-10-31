import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import NoviUcenik from '@/components/Ucenik/NoviUcenik'
import Ucenici from '@/components/Ucenik/Ucenici'
import Ucenik from '@/components/Ucenik/Ucenik'
import VaspitnaGrupa from '@/components/Ucenik/VaspitnaGrupa'
import VaspitneGrupe from '@/components/Ucenik/VaspitneGrupe'
import Vasitac from '@/components/Ucenik/Vaspitac'
import Profile from '@/components/User/Profile'
import Register from '@/components/User/Register'
import SignIn from '@/components/User/SignIn'
import Breabcrumbs from 'vue-2-breadcrumbs'
 /* eslint-disable */
Vue.use(Breabcrumbs)

Vue.use(Router)
// podesavanja vue routera, komponente za navigaciju/rutiranje programa
export default new Router({
  routes: [
    {path:'/', component: Home, name:'',
    meta: {
      //pokusaj podesavanja breadcrumb-a, TO-DO
      breadcrumb: 'Pocetna'  
    }},
    {path:'/ucenici', component: Ucenici, name:'Ucenici',
    meta: {
      breadcrumb: 'Prijavljeni ucenici'  
    }},
    {path:'/prijava', component: NoviUcenik, name:'Prijava',
    meta: {
      breadcrumb: 'Prijava ucenika'  
    }},
    {path:'/detalji/:id', component: Ucenik},
    {path:'/vaspitaci', component: Vasitac},
   
    {path:'/vasptinagrupa/:id', component: VaspitnaGrupa},
    {path:'/vaspitnegrupe/', component: VaspitneGrupe},
    {path:'/profil/', component: Profile},
    {path:'/registracija/', component: Register},
    {path:'/logovanje/', component: SignIn}
   ],
    mode:'history'
})

