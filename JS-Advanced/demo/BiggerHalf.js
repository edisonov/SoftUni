function biggerHalf(inputArr) {
     return inputArr
     .sort((a, b) => a - b)
     .slice(inputArr.length / 2);
}

console.log(biggerHalf([3, 19, 14, 7, 2, 19, 6]));