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
            this.model = window.serverData;
        },
        formatDate: function (unformattedDate) {
            var date = unformattedDate.replace(/\D/g, '');
            var formattedDate = new Date(Number(date));
            return formattedDate.toLocaleDateString();
        }
    }
});
