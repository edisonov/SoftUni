function solve (inputArr){
      let sorted = inputArr.sort((a, b) => a - b);
      let result = [inputArr[0], inputArr[1]];

      console.log(result.join(' '));
}

solve([30, 15, 50, 5]);