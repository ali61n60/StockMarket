function EnumDemo() {
    var Temerature;
    (function (Temerature) {
        Temerature[Temerature["Cold"] = 0] = "Cold";
        Temerature[Temerature["Hot"] = 1] = "Hot";
    })(Temerature || (Temerature = {}));
    ;
    var temp = Temerature.Hot;
    switch (+temp) {
        case Temerature.Cold:
            console.log("Brrr...");
            break;
        case Temerature.Hot:
            console.log("yikes!");
            break;
    }
}
EnumDemo();
//# sourceMappingURL=EnumDemo.js.map