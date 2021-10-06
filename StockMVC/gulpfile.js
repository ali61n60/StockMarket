var gulp = require("gulp");
var browserify = require("browserify");
var source = require("vinyl-source-stream");
var tsify = require("tsify");

var paths = {
    pages: ["src/*.html"],
};

gulp.task(
    "ali", function () {
        return browserify({
                debug: true,
                entries: ["./Scripts/src/main.ts"],
                cache: {},
                packageCache: {},
            })
            .plugin(tsify)
            .bundle()
            .pipe(source("bundle.js"))
            .pipe(gulp.dest("./Scripts/dist"));
});



gulp.task("copy-html", function () {
    return gulp.src(paths.pages).pipe(gulp.dest("dist"));
});