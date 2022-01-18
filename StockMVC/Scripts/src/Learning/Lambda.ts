var MultiplyIt = function (num1: number, num2: number): number {
    return num1 * num2;
}


var MultiplyItLambda = (num1: number, num2: number) => num1 * num2;


var SayFirstNumber: (firstNumber: number) => void;
SayFirstNumber = function (first: number) {
    console.log(first);
}

console.log(MultiplyIt(7, 8));
console.log(MultiplyItLambda(7, 8));

SayFirstNumber(897);