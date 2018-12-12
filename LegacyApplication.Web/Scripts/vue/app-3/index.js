import Vue from 'vue';
import vueResource from 'vue-resource';
import App from './webpack.vue';

Vue.use(vueResource);

new Vue({
    el: '#app',
    render: h => h(App)
})