function Person(value) {
    switch (typeof value) {
        case "string":
            return "My name is " + value;
        case "number":
            return "My age is " + value;
        case "boolean":
            return value ? "I'm married" : "I'm not married";
    }
    return "";
}
console.log(Person("Ali Nejati"));
console.log(Person(37));
console.log(Person(true));
//# sourceMappingURL=Overloading.js.map