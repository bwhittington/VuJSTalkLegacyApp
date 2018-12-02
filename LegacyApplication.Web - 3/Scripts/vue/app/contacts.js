var vm = new Vue({
    el: '#company-contacts',
    data: {
        model: {},
        contacts: []
    },
    created: function () {
        this.loadData();
    },
    methods: {
        loadData: function () {
            this.$http.get('http://localhost:59129/Home/GetData').then(response => {

                // get body data
                this.model = response.body;
                if (this.model !== null) {
                    this.contacts = this.model.PolicyHolder.Contacts;
                }

            }, response => {
                // error callback
            });  
        },
    }
});
