function solve(inputArr) {
    let soted = inputArr.sort((a, b) => b - a).reverse();

    console.log(soted);
}

solve([3, -2, 0, -1]);