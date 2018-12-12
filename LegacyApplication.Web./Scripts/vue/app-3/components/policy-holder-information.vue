<template>
    <div class="col-md-6">
        <div id="policy-holder-information" class="row">
            <div class="col-md-12">
                <h2>Policy Holder Information</h2>
            </div>
            <div class="col-md-6 font-weight-bold">
                Company Name:
            </div>
            <div class="col-md-6">
                {{ (model.PolicyHolder !== undefined ? model.PolicyHolder.CompanyName : "") }}
            </div>
            <div class="col-md-6 font-weight-bold">
                Company Address:
            </div>
            <div class="col-md-6">
                <span v-if="model.PolicyHolder !== undefined">
                {{ model.PolicyHolder.StreetAddress }}<br />
                <span v-if="model.PolicyHolder.StreetAddress2">{{ model.PolicyHolder.StreetAddress2 }}</span>
                {{ model.PolicyHolder.City }}, {{ model.PolicyHolder.State }} {{ model.PolicyHolder.Zip }}
                    </span>
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
            loadData: function () {
                this.$http.get('http://localhost:59129/Services/GetData').then(response => {
                    // get body data
                    this.model = response.body;

                }, response => {
                    // error callback
                });
            },
        }

    }
</script>