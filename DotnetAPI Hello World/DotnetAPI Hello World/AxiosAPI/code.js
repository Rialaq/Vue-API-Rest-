new Vue({
    el: '#app',
    data () {
      return {
          arr: []
      }
    },
    methods: {
        TEST(){
            for (let i = 0; i < this.arr.data.length; i++) {
                console.log(this.arr.data[i].name);                
            }
        }
  
},
mounted () {
    axios
    .get('https://localhost:44398/api/True')
    .then(response => (this.arr = response))
    },
})