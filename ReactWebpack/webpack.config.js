const path = require("path");

module.exports = {
    mode:"development",
    entry: "./wwwroot/js/index.tsx",
    devtool: "inline-source-map",
    output: {
        filename: "bundle.js",
        path: path.resolve(__dirname, "./wwwroot/dist"),
    },
    module: {
        rules: [
            { test: /\.css$/, use: "css-loader" },
            {
                test: /\.(js|jsx)$/,
                exclude: /node_modules/,
                use: {
                    loader: "babel-loader",
                    options: {
                        presets: ["@babel/preset-react"]
                    }
                    
                }
            },
            {
                test: /\.(ts|tsx)$/,
                use: "ts-loader",
                exclude: /node_modules/,
            },
        ],
    },
    resolve: {
        extensions: [".js","jsx", ".ts", ".tsx" ],
    },
};