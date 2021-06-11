function solve(arr) {

    return arr.reduce(function(result, curentNumber, index, initialArr) {
        if (curentNumber >= result[result.length - 1] || result.length === 0) {
            result.push(curentNumber);
        }
        return result;
    }, []);
    //let result = [];

    //for (let i = 0; i < arr.length; i++) {
    //    let element = arr[i];

    //    if (element >= result[result.length - 1] || result.length === 0) {
    //       result.push(element);
    //   }
    //}
    //return result;
}

console.log(solve([1, 3, 8, 4, 10, 12, 3, 2, 24]));