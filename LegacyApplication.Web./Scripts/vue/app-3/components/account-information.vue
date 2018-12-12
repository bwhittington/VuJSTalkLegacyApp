<template>
    <div class="col-md-6">
        <div id="account-information" class="row">
            <div class="col-md-12 font-weight-bold">
                <h2>Account Information</h2>
            </div>
            <div class="col-md-6 font-weight-bold">
                Account Number:
            </div>
            <div class="col-md-6">
                {{ model.AccountNumber }}
            </div>
            <div class="col-md-6 font-weight-bold">
                Account Creation Date:
            </div>
            <div class="col-md-6">
                {{ model.FormattedCreatedDate  }}
            </div>
        </div>
    </div>
</template>
<script>
    export default {
        data: function () {
            return {
                model: { }
            }
        },
        mounted: function () {
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

    }
</script>
