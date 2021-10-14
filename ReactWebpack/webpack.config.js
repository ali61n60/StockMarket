const path = require('path');

module.exports = {
    entry: './wwwroot/js/index.tsx',
    devtool: 'inline-source-map',
    output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, './wwwroot/dist'),
    },
    module: {
        rules: [
            { test: /\.css$/, use: 'css-loader' },
            {
                test: /\.(ts|tsx)$/,
                use: 'ts-loader',
                exclude: /node_modules/,
            },
        ],
    },
    resolve: {
        extensions: ['.tsx', '.ts', '.js'],
    },
};