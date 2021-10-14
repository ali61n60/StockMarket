const path = require("path");

module.exports = {
    mode: "development",
    entry: {
        main: "./wwwroot/js/index.ts"
    },
    devServer: {
        static: "./wwwroot/dist",
        hot: true,
    },
    output: {
        path: path.resolve(__dirname, "./wwwroot/js/dist"),
        filename: "bundle.js",
        publicPath: "dist/"
    },
    module: {
        rules:[ {
            test: /\.ts?$/,
            include: path.resolve(__dirname, "./wwwroot/js"),
            exclude: /node_modules/,
            use: "ts-loader"
            }]
    },
    resolve: {
        extensions: [".tsx", ".ts", ".js"]
    }   
};
   
