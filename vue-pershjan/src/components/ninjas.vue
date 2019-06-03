<template>
<div id="ninjas">
   <ul>
       <li v-for="ninja in ninjas" v-on:click="ninja.show =!ninja.show">
           <h2>{{ninja.name}}</h2>
           <h3 v-show="ninja.show">{{ninja.special}}</h3>
       </li>
    </ul> 
</div>
</template>

<script>
 export default {
     props: ['ninjas'],
data() {
  return {

   }
  }
}
</script>

<style scoped>
#ninjas {
    width: 100%;
    max-width: 1200px;
    margin: 40px auto;
    padding: 0 20px;
    box-sizing: border-box;
}
ul {
    display: flex;
    flex-wrap: wrap;
    list-style-type: none;
    padding: 0;
}
li{
    flex-grow: 1;
    flex-basis: 300px;
    text-align: center;
    padding: 30px;
    border: 1px solid #222;
    margin: 10px;
}
li:hover {
    box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24), 0 17px 50px 0 rgba(0,0,0,0.19);
}
</style>
