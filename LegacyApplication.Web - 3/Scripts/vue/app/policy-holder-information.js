var vm = new Vue({
    el: '#policy-holder-information',
    data: {
        model: {}
    },
    created: function () {
        this.loadData();
    },
    methods: {
        loadData: function () {
            this.$http.get('http://localhost:59129/Home/GetData').then(response => {
                // get body data
                this.model = response.body;

            }, response => {
                // error callback
            });   
        },
    }
});
