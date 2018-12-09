
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
            this.model = window.serverData;
            this.formatDate(this.model.CreatedDate);
        },
        //TODO: Add Account Information
        formatDate: function (unformattedDate) {
            var date = unformattedDate.replace(/\D/g, '');
            var formattedDate = new Date(Number(date));
            this.model.FormattedCreatedDate = formattedDate.toLocaleDateString();
        }
    }

});
