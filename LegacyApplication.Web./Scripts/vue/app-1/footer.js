$(function () {
    var vm = new Vue({
        el: '#footer',
        template: '<div>@{{currentYear}} - Fake Insurance Company</div>',
        data: {
            currentYear: new Date().getFullYear()
        },
        methods: {}
    });
});