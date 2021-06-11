function solve(inputArr) {
    let result = [];

    for(let num of inputArr){
        if (num < 0) {
            result.unshift(num);
        }else{
            result.push(num);
        }
    }

    console.log(result.join('\n'));
}

solve([3, -2, 0, -1]);