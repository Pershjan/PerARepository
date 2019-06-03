<template>
  <div>
      <header>
      <h1>{{title}}</h1>
      <h3>{{info}}</h3>
      </header>
    <router-view/>
  </div>
</template>

<script>

export default {
  components: {
  },
  data(){
  return {
        title: 'Per André Strande Nesset',
        info: 'Velkommen til min CV',
  }
}
}
</script>

<style> 
header {
    background: lightgreen;
    padding: 10px;
    width: 100%;
    text-align: center;

}
h1{
    color: black;
    font-size: 3rem;
}
h3{
  font-size: 1.5rem;
}
</style>
