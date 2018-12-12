<template>
    <div class="col-md-12" id="company-contacts">
        <div class="row">
            <div class="col-md-12 font-weight-bold">
                <h2>Contacts</h2>
            </div>
            <div class="col-md-2 font-weight-bold">
                Company Contact Name
            </div>
            <div class="col-md-2 font-weight-bold">
                Company Contact Phone Number
            </div>
            <div class="col-md-2 font-weight-bold">
                Company Contact Email
            </div>
            <div class="col-md-2 font-weight-bold">
                Company Contact Title
            </div>
            <div class="col-md-2 font-weight-bold">
                Company Contact Address
            </div>
        </div>
        <div class="row" v-for="contact in contacts">
            <div class="col-md-2 ">
                {{contact.FirstName}} {{ contact.LastName }}
            </div>
            <div class="col-md-2">
                {{ contact.PhoneNumber}}
            </div>
            <div class="col-md-2">
                {{ contact.Email }}
            </div>
            <div class="col-md-2">
                {{ contact.Title }}
            </div>
            <div class="col-md-2">
                {{ contact.StreetAddress }} <br />
                <span v-if="contact.StreetAddress2">{{ contact.StreetAddress2 }}</span>
                {{ contact.City }}, {{ contact.State }} {{ contact.Zip }}
            </div>
        </div>
    </div>
</template>
<script>
    export default {
        data: function () {
            return {
                model: {},
                contacts: []
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
                    if (this.model !== null) {
                        this.contacts = this.model.PolicyHolder.Contacts;
                    }

                }, response => {
                    // error callback
                });
            },
        }
    }
</script>