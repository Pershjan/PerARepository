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