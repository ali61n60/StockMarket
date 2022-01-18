function Add(num1: number, num2: number, num3?: number) :number{
    let total = num1 + num2;
    if (num3 != undefined) {
        total += num3;
    }

    return total;
}

let answer = Add(14, 23, 30);
console.log("adding three numbers: " + answer);
answer = Add(14, 23);
console.log(`adding two numbers: ${answer}`);