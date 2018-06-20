import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'

import EditUcenik from '@/components/Ucenik/EditUcenik'
import NoviUcenik from '@/components/Ucenik/NoviUcenik'
import Ucenici from '@/components/Ucenik/Ucenici'
import Ucenik from '@/components/Ucenik/Ucenik'

import Profile from '@/components/User/Profile'
import Register from '@/components/User/Register'
import SignIn from '@/components/User/SignIn'

Vue.use(Router)

export default new Router({
  routes: [
    { path:'/', component: Home},

    { path:'/ucenici', component: Ucenici},
    { path:'/prijava', component: NoviUcenik},
    { path:'/detalji/:id', component: Ucenik},
    { path:'/izmena_ucenika/:id', component: EditUcenik},

    { path:'/profil/', component: Profile},
    { path:'/registracija/', component: Register},
    { path:'/logovanje/', component: SignIn}

   ],
    mode:'history'
})

