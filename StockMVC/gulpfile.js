// <binding AfterBuild='default' Clean='clean' />
/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require("gulp");
var del = require("del");
var browserify = require("browserify");
var source = require("vinyl-source-stream");
var tsify = require("tsify");
var paths = {
    src: ["scripts/**/*.js", "scripts/**/*.ts", "scripts/**/*.map"],
    dist: ["scripts/dist/bundle.js"],
    pages: ["src/*.html"]
};
//gulp.task("copy-html", function () {
//    return gulp.src(paths.pages).pipe(gulp.dest("dist"));
//});
gulp.task("default", function () {
        return browserify({
                basedir: ".",
                debug: true,
                entries: ["Scripts/src/main.ts"],
                cache: {},
                packageCache: {},
            })
            .plugin(tsify)
            .bundle()
            .pipe(source("bundle.js"))
            .pipe(gulp.dest("Scripts/dist"));
    });


gulp.task("clean", function () {
    return del(["wwwroot/scripts/**/*"]);
});
gulp.task("copy-to-wwwroot", function () {
    gulp.src(paths.dist).pipe(gulp.dest("wwwroot/scripts"));
});