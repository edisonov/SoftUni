function solve(arr) {
    let rowSum = [];
    let colSum = [];

    for (let i = 0; i < arr.length; i++) {
        let row = arr[i];
        let sum = row.reduce((result, curr) => (result + curr), 0);
        rowSum.push(sum);
    }

    for (let i = 0; i < arr.length; i++) {
        let newRow = [];

        for (let y = 0; y < arr.length; y++) {
            let index = arr.length - 1 - y;
            newRow.push(arr[index][i]);
        }
        
        let sum = newRow.reduce((result, curr) => (result + curr), 0);
        colSum.push(sum);
    }
    
    return rowSum.concat(colSum).every((el, index, arr) => el === arr[0]);
    //transponirane na matrica
}

console.log(solve(
   [[4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]));