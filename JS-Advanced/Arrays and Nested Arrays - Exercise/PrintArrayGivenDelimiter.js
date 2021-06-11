const solve = (inputArr, delimeter) => {
    let result = '';

    for (let i = 0; i < inputArr.length; i++) {
        result += i == inputArr.length - 1 ? inputArr[i] : (inputArr[i] + delimeter);
    }
    return result;
}

//const solve = (inputArr, delimeter) => inputArr.join(delimeter);

console.log(solve(['One', 'Two', 'Three', 'Four', 'Five'], '-'));