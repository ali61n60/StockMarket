const path = require("path");
module.exports = {
    mode: "development",
    entry: "./ wwwroot / js / app.js",
    output: {
        path: path.resolve(__dirname, "./ wwwroot / js / dist"),
        filename: "bundle.js"
    }
};