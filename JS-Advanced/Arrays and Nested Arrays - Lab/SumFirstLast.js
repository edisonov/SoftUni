function solve(arr) {
    let firtsElement = Number(arr.shift());
    let lastElement = Number(arr.pop());

    const sum = firtsElement + lastElement;

    console.log(sum);
} 

console.log(solve(['20', '30', '40']));