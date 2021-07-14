function solve(input) {
    function getEngine(power) {
        const engine = [
            { power: 90, volume: 1800 },
            { power: 120, volume: 2400 },
            { power: 200, volume: 3500 },
        ].sort((a, b) => a.power - b.power);

        // let result;
        // for (let i = 0; i < engine.length; i++) {
        //     if (engine[i].power >= power) {
        //         result = engine[i];
        //         break;
        //     }
        // }
        return engine.find(el => el.power >= power);
    }

    function getCarriage(type, color) {
        return {
            type,
            color
        }
    }

    function getWheels(wheelsize) {
        let wheel = Math.floor(wheelsize) % 2 === 0
            ? Math.floor(wheelsize) - 1
            : Math.floor(wheelsize);

        return [wheel, wheel, wheel, wheel];
        //return Array(4).fill(wheel, 0, 4);
    }

    return {
        model: input.model,
        engine: getEngine(input.power),
        carriage: getCarriage(input.carriage, input.color),
        wheels: getWheels(input.wheelsize),
    }
}

console.log(solve({
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
}));