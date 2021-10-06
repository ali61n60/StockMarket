// <binding AfterBuild='default' Clean='clean' />
/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require("gulp");
var del = require("del");
var browserify = require("browserify");
var source = require("vinyl-source-stream");
var watchify = require("watchify");
var tsify = require("tsify");
var fancy_log = require("fancy-log");
var paths = {
    src: ["scripts/**/*.js", "scripts/**/*.ts", "scripts/**/*.map"],
    dist: ["scripts/dist/bundle.js"],
    pages: ["src/*.html"]
};
var watchedBrowserify = watchify(
    browserify({
        basedir: ".",
        debug: true,
        entries: ["Scripts/src/main.ts"],
        cache: {},
        packageCache: {},
    }).plugin(tsify)
);

function bundle() {
    watchedBrowserify
        .bundle()
        .on("error", fancy_log)
        .pipe(source("bundle.js"))
        .pipe(gulp.dest("Scripts/dist"));

    return gulp.src(paths.dist).pipe(gulp.dest("wwwroot/scripts"));
}
gulp.task("default", bundle);
watchedBrowserify.on("update", bundle);
watchedBrowserify.on("log", fancy_log);




//gulp.task("copy-html", function () {
//    return gulp.src(paths.pages).pipe(gulp.dest("dist"));
//});


gulp.task("clean-wwwroot", function () {
    return del(["wwwroot/scripts/**/*"]);
});
gulp.task("copy-bundle-to-wwwroot", function () {
    return  gulp.src(paths.dist).pipe(gulp.dest("wwwroot/scripts"));
});