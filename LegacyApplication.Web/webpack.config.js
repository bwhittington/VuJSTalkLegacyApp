"use strict";
var path = require('path');
var webpack = require('webpack');

const { VueLoaderPlugin } = require('vue-loader');

module.exports = {
    mode: 'development',
    entry: "./scripts/vue/app-3/index.js",
    context: __dirname,
    output: {
        path: path.resolve(__dirname ,'scripts/vue/app-3/'),
        filename: "bundle.js"
    },

    module: {
        rules: [{
            test: /\.vue$/,
            loader: 'vue-loader',
            options: {
                loaders: {
                    scss: 'vue-style-loader!css-loader!sass-loader'
                }
            }
        }],
    },

    plugins: [
        new VueLoaderPlugin()
    ]
};