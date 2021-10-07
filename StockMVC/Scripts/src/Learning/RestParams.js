{
    function AddWithRest(num1, num2) {
        var numbers = [];
        for (var _i = 2; _i < arguments.length; _i++) {
            numbers[_i - 2] = arguments[_i];
        }
        var total = num1 + num2;
        for (var i = 0; i < numbers.length; i++) {
            total += numbers[i];
        }
        return total;
    }
    var answer_1 = AddWithRest(14, 23, 30);
    console.log("adding three numbers: " + answer_1);
    answer_1 = AddWithRest(14, 23);
    console.log("adding two numbers: " + answer_1);
}
//# sourceMappingURL=RestParams.js.map