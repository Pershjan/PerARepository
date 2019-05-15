new Vue ({
el: '#punch-app',
data:{
hp: 100,
 ended: false
},
methods: {
 punch: function(){
     this.hp -= 10;
     if (this.hp<= 0){
         this.ended = true;
     }
 },
 restart: function (){
     this.hp = 100;
     this.ended = false;
 }
},
})