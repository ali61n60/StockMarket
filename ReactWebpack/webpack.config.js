const path = require("path");
const HtmlWebpackPlugin = require("html-webpack-plugin");

module.exports = {
    mode: "development",
    entry: {
        main: "./wwwroot/js/index.tsx"
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
                exclude: /node_modules/,
                use: ["babel-loader"],
            },
            {
            test: /\.(ts|tsx)?$/,
            include: path.resolve(__dirname, "./wwwroot/js"),
            exclude: /node_modules/,
            use: "ts-loader"
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
    resolve: {
        extensions: [".tsx", ".ts", ".js"]
    },
    devServer: { contentBase: path.join(__dirname, "dist") },
};      