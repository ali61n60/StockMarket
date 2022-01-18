function EnumDemo() {
    enum Temerature {
        Cold,
        Hot
    };

    let temp = Temerature.Hot;

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