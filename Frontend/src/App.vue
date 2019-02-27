<template>
<v-app id="inspire">
<v-navigation-drawer
stateless
value=""
v-model="drawer"
fixed
clipped
class="navbarcolor"
app
>
<v-list
dense
dark
class="navbarcolor"
>

<v-list-group
>
<v-list-tile slot="activator">
<v-icon>person_pin</v-icon>
<v-list-tile-title class="class-heading">Učenik</v-list-tile-title>
</v-list-tile>

<v-list-tile
v-for="(admin, i) in admins"

:key="i"
router
:to="admin.link"
active-class="redactive"
align-center

>

<v-list-tile-title class="class-title">
{{ admin.text }}
</v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="admin[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>

</v-list-group>

<v-list-group
>
<v-list-tile slot="activator">
<v-icon>library_books</v-icon>
<v-list-tile-title class="class-heading">Vaspitni rad</v-list-tile-title>
</v-list-tile>

<v-list-tile
v-for="(admin, i) in vaspitni"

:key="i"
router
:to="admin.link"
active-class="redactive"
align-center

>
<v-list-tile-title class="class-title">
{{ admin.text }}
</v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="admin[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>

</v-list-group>
<v-list-group
>
<v-list-tile slot="activator">
<v-icon>insert_chart_outlined</v-icon>
<v-list-tile-title class="class-heading">Izveštaji</v-list-tile-title>
</v-list-tile>

<v-list-tile
v-for="(admin, i) in admins"

:key="i"
router
:to="admin.link"
active-class="redactive"
align-center

>
<v-list-tile-title class="class-title">
{{ admin.text }}
</v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="admin[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>

</v-list-group>
<v-list-group
>
<v-list-tile slot="activator">
<v-icon>meeting_room</v-icon>
<v-list-tile-title class="class-heading">Sobe</v-list-tile-title>
</v-list-tile>

<v-list-tile
v-for="(admin, i) in sobe"

:key="i"
router
:to="admin.link"
active-class="redactive"
align-center

>
<v-list-tile-title class="class-title">
{{ admin.text }}
</v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="admin[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>

</v-list-group>
<v-list-group
>
<v-list-tile slot="activator">
<v-icon>accessibility</v-icon>
<v-list-tile-title class="class-heading">Sekcije</v-list-tile-title>
</v-list-tile>

<v-list-tile
v-for="(admin, i) in sekcije"

:key="i"
router
:to="admin.link"
active-class="redactive"
align-center

>

<v-list-tile-title class="class-title">
{{ admin.text }}
</v-list-tile-title>
<v-list-tile-action>
<v-icon v-text="admin[1]"></v-icon>
</v-list-tile-action>
</v-list-tile>

</v-list-group>

</v-list>
</v-navigation-drawer>
<v-toolbar color="grey" class="white" app clipped-left height=50px>
<v-toolbar-side-icon dark @click.native = "drawer = !drawer"> </v-toolbar-side-icon>
<v-toolbar-items>
<v-avatar
:tile="tile"
:size="avatarSize"
color="grey lighten-4"
>
<img src="@/assets/logo3.png" alt="avatar">
</v-avatar>
</v-toolbar-items>
<v-toolbar-title class="toolbar-title-1" flat>Dom učenika poljoprivredno-veterinarske škole – Svilajnac</v-toolbar-title>
</v-toolbar>
<v-content>
<v-container fluid fill-height class="grey lighten-4">
<v-layout justify-center align-center>
<v-flex xs12>
<main>
<router-view></router-view>
</main>
</v-flex>
</v-layout>
</v-container>
</v-content>
</v-app>
</template>

<script>
/* eslint-disable */


export default {
data: () => ({
// promenljiva koja sluzi za rad sa navigacionim barom sa strane, true - false za paljenje i gasenje
drawer: true,
// kolekcija opcija za side-navbar
items: [
//require koriscen za prikaz slike, srcmain promenljiva za cuvanje putanje slike
{ heading: 'Učenik' ,mainicon: 'person',srcmain: require('./assets/ucenikikonica.png')},
{ icon: 'group', text: 'Pregled učenika u domu'},
{ icon: 'group_add', text: 'Novi učenik - prijava',link: '/prijava' },
{ icon: 'list_alt', text: 'Pregled svih prijavljenih',link: '/ucenici' },
{ icon: 'group_work', text: 'Vaspitne grupe',link: '/vaspitnegrupe' },
{ divider: true },
{ heading: 'Vaspitni rad' ,mainicon: 'book',srcmain: require('./assets/vaspitnirad.png') },
{ icon: 'timer', text: 'Godišnji program rada' },
{ icon: 'insert_invitation', text: 'Mesečni plan rada' },
{ icon: 'ballot', text: 'Evidencija ostvarivanja programa'},
{ divider: true },
{ heading: 'Izveštaji' ,mainicon: 'bar_chart',srcmain: require('./assets/izvestaji.png')},
{ divider: true },
{ heading: 'Sobe' ,mainicon: 'book',srcmain: require('./assets/vaspitnirad.png') },
{ icon: 'insert_invitation', text: 'Spisak soba' },
{ icon: 'insert_invitation', text: 'Dodaj sobu' },
{ divider: true },
],
admins: [
{ icon: 'group', text: 'Pregled učenika u domu'},
{ icon: 'group_add', text: 'Novi učenik - prijava',link: '/prijava' },
{ icon: 'list_alt', text: 'Pregled svih prijavljenih',link: '/ucenici' },
{ icon: 'group_work', text: 'Vaspitne grupe',link: '/vaspitnegrupe' },
{ divider: true },
],
vaspitni: [
{ icon: 'timer', text: 'Godišnji program rada' },
{ icon: 'insert_invitation', text: 'Mesečni plan rada' },
{ icon: 'ballot', text: 'Evidencija ostvarivanja programa'},
{ divider: true },
],
sobe:[
{ icon: 'timer', text: 'Dodaj sobu', link: '/novasoba' },
{ icon: 'timer', text: 'Spisak soba', link: '/spisaksoba' }
],

cruds: [
['Create', 'add'],
['Read', 'insert_drive_file'],
['Update', 'update'],
['Delete', 'delete']
],
sekcije:[
{ icon: 'timer', text: 'nesto1', link: '' },
{ icon: 'timer', text: 'nesto2', link: '' },
],
// opcije koje se nalaze na glavnom toolbaru (na vrhu ekrana)
menuItems: [
{icon: 'supervisor_account', title: 'Lista ucenika',link: '/ucenici'},
{icon: 'pets', title: 'Prijavi ucenika',link: '/prijava'},
// {icon: 'person', title: 'Profil',link: '/profil'},
// {icon: 'face', title: 'Registruj se',link: '/registracija'},
// {icon: 'lock_open', title: 'Uloguj se',link: '/logovanje'}
]
}),
props: {
source: String
}
}
</script>

<style>
#keep main .container {
height: 660px;
}
.v-navigation-drawer__border {
display: none;
}
.text {
font-weight: 400;
}

.icon material-icons{
background: red;
}
.class-heading{
padding-left: 9%;
font-size: 20px;
}
.class-title{
padding-left: 15%;
font-size: 15px;
}
.toolbar-title-1{
color: aliceblue;
font-size: 15px;
cursor: pointer;
}
</style>