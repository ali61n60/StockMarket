const path = require("path");
const HtmlWebpackPlugin = require("html-webpack-plugin");

module.exports = {
    mode: "development",
    entry: {
        main: "./wwwroot/js/index.jsx"
    },
    output: {
        path: path.resolve(__dirname, "./wwwroot/js/dist"),
        filename: "bundle.js",
        publicPath: "dist/"
    },
    module: {
        rules: [
            {
                test: /\.(js|jsx)$/,
                include: path.resolve(__dirname, "./wwwroot/js"),
                exclude: /node_modules/,
                use: "babel-loader",
                resolve: {
                    extensions: [".jsx", ".js", ".json"]
                }
            },
            {
            test: /\.(ts|tsx)?$/,
            include: path.resolve(__dirname, "./wwwroot/js"),
            exclude: /node_modules/,
            use: "ts-loader",
            resolve: {
                extensions: [".tsx", ".ts"]
            },
            },
            {
                test: /\.(css|scss)$/,
                use: ["style-loader", "css-loader"]
            },
            {
                test: /\.(jpg|jpeg|png|gif|mp3|svg)$/,
                use: ["file-loader"]
            }
        ]
    },
   
    devServer: { contentBase: path.join(__dirname, "dist") },
};      