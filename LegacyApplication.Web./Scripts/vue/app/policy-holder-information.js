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
            this.model = window.serverData;
        },
    }
});
