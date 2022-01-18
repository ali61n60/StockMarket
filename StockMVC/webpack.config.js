const path = require("path");


module.exports = {   
    mode:"development",
    entry: {
       "TSDemo": "./wwwroot/js/Views/TSDemo.tsx"
    },
    devtool: "inline-source-map",
    output: {
        filename: "[name].js",
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
    }
};