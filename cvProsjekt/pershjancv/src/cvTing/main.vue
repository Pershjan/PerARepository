<template>
<div>
    <table>
    <th @click="toggleJobb" class="titler">Jobberfaring </th>
    <tr v-if="jobbToggle" v-for="jobb in jobbErfaring">
        <td>{{jobb.dato}}</td><td>{{jobb.info}}</td>
    </tr>
    <th @click="toggleUtdanning" class="titler">Utdanning </th>
        <tr v-if="utdanningToggle" v-for="utdanning in utdanningYo">
        <td>{{utdanning.dato}}</td><td>{{utdanning.info}}</td>
    </tr>
    <th class="titler">Nøkkelkompetanse </th>
        <tr v-if="nokkelToggle">
        <td></td>
    </tr>
    </table>
</div>
</template>

<script>

export default {
    data(){
    return {
            jobbToggle: false,
            utdanningToggle: false,
            nokkelToggle: false,
            jobbErfaring: 
            [
            {dato: '01.2017-07.2017:', info:' Deltidsjobb hos Posten Stokke'},
            {dato: '02.2016 – 07.2017:', info:' Deltidsjobb hos Posten Larvik'},
            {dato: '12.2015 – 02.2016:', info:' Arbeidsrettet tiltak hos Fønix'},
            {dato: '06.2014 – 02.2015:', info:' Amedia Distribusjon AS'},
            {dato: '08.2013 – 06.2014:', info:' Peppes, Bakersmia, Hotell Norge og Bakers (utplassering)'},
            {dato: '06.2011 – 08.2011:', info:' Mot Vold AS'},
            {dato: '08.2009 – 06.2011:', info:' Skolekantinen Hedrum ungdomsskole.'},
            ],
            utdanningYo:
            [
            {dato: '01.2019-D.D:', info: ' Get Academy StartIT'},
            {dato: '08.2013 - 06.2014:', info: ' VK2 Kokk- og servitørfag, Thor Heyerdahl VGS.'},
            {dato: '08.2012 – 06.2013:', info: ' VK1 Restaurant- og matfag, Thor Heyerdahl VGS.'},
            {dato: '08.2011 – 06.2012:', info: ' VK1 Teknikk og industriell produksjon, Thor Heyerdahl VGS.'},
            {dato: '08.2001 – 06.2010:', info: ' 10 årlig Grunnskole, Byskogen Barneskole og Hedrum Ung.skole'},
            {dato: 'Språk:', info: ' Norsk-Morsmål | Engelsk-Flytende'}
            ],
        }
    },
    methods: {
        toggleJobb(){
            if (!this.jobbToggle){
                this.jobbToggle=true;
            }
            else{
                this.jobbToggle=false;
            }
        },
            toggleUtdanning(){
            if (!this.utdanningToggle){
                this.utdanningToggle=true;
            }
            else{
                this.utdanningToggle=false;
            }
    }
},
}
</script>

<style scoped>
table {
    font-size: 50px;
    text-align: center;
    cursor: pointer;
}
#titler {
    padding: 0;
    text-align: center;
    font-size: 3rem;
}
tr{
    text-align: center;
    padding: 30px;
    display: flex;
    flex-wrap: wrap;
    list-style-type: none;
    padding: 0;
}
th{
    flex-grow: 1;
    flex-basis: 300px;
    text-align: center;
    padding: 30px;
    border: 1px solid #222;
    margin: 10px;
}
</style>