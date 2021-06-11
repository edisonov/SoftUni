function solve (n, k) {
    let result = [1];
    let startIndex = 0;
    let currentIndex = [];

    for (let i = 1; i < n; i++) {
         startIndex = i;
         currentIndex = result.slice(i, i - k);
         result.push()
         
    } 

    console.log(result.join(' '));
}

solve(6, 3);