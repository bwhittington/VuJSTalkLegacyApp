<template>
    <div class="col-md-12">
        <h2>Policies</h2>
        <table class="table table-striped" id="policies">
            <thead>
                <tr>
                    <th scope="col">Policy Type</th>
                    <th scope="col">Policy Number</th>
                    <th scope="col">Renewal Number</th>
                    <th scope="col">Endorsement Number</th>
                    <th scope="col">Effective Date</th>
                    <th scope="col">Expiration Date</th>
                    <th scope="col">Cost</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="policy in model.Policies">
                    <th scope="row">{{ policy.PolicyType }}</th>
                    <td scope="row">{{ policy.PolicyNumber }}</td>
                    <td scope="row">{{ policy.RenewalNumber }}</td>
                    <td scope="row">{{ policy.EndorsementNumber }}</td>
                    <td scope="row">{{ formatDate(policy.EffectiveDate) }}</td>
                    <td scope="row">{{ formatDate(policy.ExpirationDate) }}</td>
                    <td scope="row">{{ policy.Cost }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>
<script>
    export default {
        data: function () {
            return {
                model: {}
            }
        },
        mounted: function () {
            this.loadData();
        },
        methods: {
            loadData: function () {
                this.$http.get('http://localhost:59129/Services/GetData').then(response => {
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

    }
</script>