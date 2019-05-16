Vue.component ('greeting', {
    template: '<p>Hey there, I am {{name}} . <button v-on:click="changeName">Change Name</button></p>',
    data: function() {
        return {
            name: 'Per A'
        }
    },
    methods: {
        changeName: function() {
            this.name = 'Malario';
        }
    }
    })
    
new Vue({
    el: '#vue-app',
    data: {
        ages: 25,
        x: 0,
        y: 0,
        available: false,
        nearby: false,
        error: false,
        success: false,
        chars: ['Mario', 'Luigi', 'Yoshi', 'Bowser'],
        ninjas: [
            {name: 'Ryu', age: 23},
            {name: 'Yoshi', age: 24},
            {name: 'Ken', age: 25},
        ]
    },
    methods: {
        add: function(inc){
            this.ages += inc;
        },
        subtract: function(dec){
            this.ages -= dec;
        },
        updateXY: function(event){
            this.x = event.offsetX;
            this.y = event.offsetY;
        },
    },
    computed: {
        compClasses: function(){
            return {
                available: this.available,
                nearby: this.nearby
            }
        }
    }
});
new Vue ({
    el: '#vue-app-one'
    
    });

new Vue ({
    el: '#vue-app-two'
    
});
new Vue({
el: '#vue-app-refs',
data: {
output: 'Your fav food'
},
methods: {
    readRefs: function() {
        console.log(this.$refs.test.innerText)
        this.output = this.$refs.input.value
    }
}
});