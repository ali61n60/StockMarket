const path = require('path');

module.exports = {
    mode: 'development',
    entry: {
        main: "./wwwroot/js/index.ts"
    },
    devServer: {
        static: './wwwroot/dist',
        hot: true,
    },
    output: {
        path: path.resolve(__dirname, "./wwwroot/js/dist"),
        filename: "bundle.js",
        publicPath: "dist/",
        libraryTarget: "var",
        library: "EntryPoint"
    },
    module: {
        rules: [{
            test: /\.tsx?$/,
            exclude: /node_modules/,
            use: "ts-loader"
            }]
    },
    resolve: {
        extensions: [".tsx", ".ts", ".js"]
    }   
};
   
