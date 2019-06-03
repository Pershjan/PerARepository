<template>
<div>
  <header>
      <h1>{{title}}</h1>
      <img :src="image"/>
      <h3>{{info}}</h3>
  </header>
  </div>
</template>

<script>
import image from './perandre.jpg'
export default {
    data(){
    return {
        title: 'Per André Strande Nesset',
        info: 'Velkommen til min CV',
        image : image
    }
}
}
</script>

<style scoped>
header {
    background: lightgreen;
    padding: 10px;
    width: 100%;
    text-align: center;
}
h1{
    color: black;
}
img{
    float: right;
}
</style>
