
    var vm = new Vue({
        el: '#account-information',
        data: {
            accountNumber: '1234567890',
            accountCreateDate: new Date().getMonth() + '/' + new Date().getDay() + '/' + new Date().getFullYear()
        },
    });
