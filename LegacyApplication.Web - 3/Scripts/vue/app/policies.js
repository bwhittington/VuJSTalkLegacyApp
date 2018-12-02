var vm = new Vue({
    el: '#policies',
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
        formatDate: function (unformattedDate) {
            var date = unformattedDate.replace(/\D/g, '');
            var formattedDate = new Date(Number(date));
            return formattedDate.toLocaleDateString();
        }
    }
});
