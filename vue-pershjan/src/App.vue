<template>
  <div>
    <app-header></app-header>
    <app-ninjas v-bind:ninjas="ninjas"></app-ninjas>
    <app-footer></app-footer>
  </div>
</template>

<script>
import header from './components/header.vue'
import footer from './components/footer.vue'
import ninjas from './components/ninjas.vue'
 export default {
   components: {
     'app-header': header,
     'app-footer': footer,
     'app-ninjas': ninjas
   },
data() {
  return {
      ninjas: [
        {name: 'Ryu', special: 'Vue Components', show: false},
        {name: 'Crystal', special: 'HTML Wizardry', show: false},
        {name: 'Hitoshi', special: 'Click Events', show: false},
        {name: 'Tango', special: 'Conditionals', show: false},
        {name: 'Kami', special: 'Webpack', show: false},
        {name: 'Yoshi', special: 'Data Diggin', show: false}
      ],
   }
  }
}
</script>

<style>

</style>
