<template>
    <div class="row">
        <div class="col-md-6">
            <account-information></account-information>
        </div>
        <div class="col-md-6">
            <policy-holder-information></policy-holder-information>
        </div>
        <div class="col-md-12">
            <contacts></contacts>
        </div>
        <div class="col-md-12">
            <policies></policies>
        </div>
    </div>
</template>
<script>
    import AccountInformation from './components/account-information.vue';
    import PolicyHolderInformation from './components/policy-holder-information.vue';
    import Contacts from './components/contacts.vue';
    import Policies from './components/policies.vue';

    export default {
        components: {
            'account-information': AccountInformation,
            'policy-holder-information': PolicyHolderInformation,
            'contacts': Contacts,
            'policies': Policies
        }
    }
</script>