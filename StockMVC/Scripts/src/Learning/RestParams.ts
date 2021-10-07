{
    function AddWithRest(num1: number, num2: number, ...numbers: number[]): number {
        let total = num1 + num2;
        for (var i = 0; i < numbers.length; i++) {
            total += numbers[i];
        }
        return total;
    }

    let answer = AddWithRest(14, 23, 30);
    console.log("adding three numbers: " + answer);
    answer = AddWithRest(14, 23);
    console.log(`adding two numbers: ${answer}`);

}