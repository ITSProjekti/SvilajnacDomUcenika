<template>
  <div class="details container">
    
    <h1 class="page-header">
        <span class="pull-right">
           
         
            </span>
    </h1>
    <ul class="list-group">
         <li class="list-group-item">Ime: {{ucenik.ime}}</li>
          <li class="list-group-item">Prezime: {{ucenik.prezime}}</li>
            <li class="list-group-item">JMBG: {{ucenik.jmbg}}</li>
            <li class="list-group-item">Pol: {{ucenik.pol}}</li>
            <li class="list-group-item">Datum Rodjenja: {{ucenik.dan}}.{{ucenik.mesec}}.{{ucenik.godina}}</li>

        </ul>
         <router-link class="btn btn-primary" v-bind:to="'/detalji/'+ucenik.id">Detalji</router-link>
  </div>
</template>

 <script>
    export default {
        props: ['ucenik']
    }
 
 </script>