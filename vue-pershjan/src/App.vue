<template>
  <div>
  <h1>{{title}}</h1>
  <ninjas></ninjas>
  </div>
</template>

<script>
import ninjas from './ninja.vue'
 export default {
   components: {
     'ninjas': ninjas
   },
  data() {
    return {
      title: 'Ninja App',
    value: ''
    }
  }
}



</script>

<style>

</style>
