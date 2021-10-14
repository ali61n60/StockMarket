function Add(num1, num2, num3) {
    var total = num1 + num2;
    if (num3 != undefined) {
        total += num3;
    }
    return total;
}
var answer = Add(14, 23, 30);
console.log("adding three numbers: " + answer);
answer = Add(14, 23);
console.log("adding two numbers: " + answer);
//# sourceMappingURL=OptionalParams.js.map