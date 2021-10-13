const path = require('path');

module.exports = {
    mode: 'development',
    entry: {
        main: "./wwwroot/js/app.tsx"
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
            test: /\.ts|.\tsx$/,
            exclude: /node_modules/,
            use:[ {
                loader: "babel-loader",
                options: {
                    "presets": ["@babel/preset-env", "@babel/preset-react","@babel/preset-typescript"]
                }
            }]
        }]
    },
    resolve: {
        extensions: ["*", ".js", ".jsx",".tsx"]
    },   
};

 

    
    
