
var vm = new Vue({
    el: '#account-information',
    data: {
        model: {}
    },
    created: function () {
        this.loadData();
    },
    methods: {
        //TODO: Add Account Information
        loadData: function () {
            // GET /someUrl
            this.$http.get('http://localhost:59129/Services/GetData').then(response => {

                // get body data
                this.model = response.body;
                this.formatDate(this.model.CreatedDate);

            }, response => {
                // error callback
            });            
        },
        //TODO: Add Account Information
        formatDate: function (unformattedDate) {
            var date = unformattedDate.replace(/\D/g, '');
            var formattedDate = new Date(Number(date));
            this.model.FormattedCreatedDate = formattedDate.toLocaleDateString();
        }
    }

});
