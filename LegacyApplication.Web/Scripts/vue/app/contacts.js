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
            this.model = window.serverData;
            this.contacts = this.model.PolicyHolder.Contacts;
        },
    }
});
