var one = new Vue ({
el: '#vue-app-one',

data: {
 title: 'Vue App One'
},
methods: {
    changeTitle: function() {
        two.title = "HAHAAHA Changed your title!"
},
},
computed: {
greet: function() {
    return 'Hello from app one!!'
},
}

});
var two = new Vue ({
    el: '#vue-app-two',
    
    data: {
        title: 'Vue App Two'
    },
    methods: {
    changeTitle: function() {
        one.title = "I changed yours aswell! xDxDxD"
    },
    },
    computed: {
        greet: function () {
            return 'Yo mah dudes, app two here lzm!'
        },
    }
    
    });