function solve(fruit, wegiht, price) {
    const wegihtkg = wegiht/1000;
    const money = wegihtkg*price;

    return `I need $${money.toFixed(2)} to buy ${wegihtkg.toFixed(2)} kilograms ${fruit}.`
}

console.log(solve('apple', 1563, 2.35))