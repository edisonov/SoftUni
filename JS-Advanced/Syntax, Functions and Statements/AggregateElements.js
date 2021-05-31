function slove(arr){
    let result = 0;
    for (let i = 0; i < arr.length; i++) {
        result += arr[i];
    }
    console.log(result);
    
    let result1 = 0;
    for (let i = 0; i < arr.length; i++) {
      result1 += 1 / arr[i];
    }
    console.log(result1)

    let result2 = "";
    for (let i = 0; i < arr.length; i++) {
      result2 = result2 + arr[i];
    }
    console.log(result2)
}

slove([1, 2, 3]);