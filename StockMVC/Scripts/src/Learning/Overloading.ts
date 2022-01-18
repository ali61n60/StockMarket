function Person(name: string): string;
function Person(age: number): string;
function Person(isMarried: boolean): string;
function Person(value: (string | number | boolean)): string{
    switch (typeof value) {
        case "string":
            return `My name is ${value}`;
        case "number":
            return `My age is ${value}`;
        case "boolean":
            return value? "I'm married" : "I'm not married";
    }
    return "";
}

console.log(Person("Ali Nejati"));
console.log(Person(37));
console.log(Person(true));