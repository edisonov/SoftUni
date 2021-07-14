function solve(arr) {
    const towns = {};
    
    for(let town of arr){

        let[name, population] = town.split(' <-> ');
        population = Number(population);

        if (towns[name] != undefined) {
            population += towns[name];
        }

        towns[name] = population;
 
        //let tokens = town.split(' <-> ');
        //let name = tokens[0];
        //let population = Number(tokens[1]);

        //if (towns[name] == undefined) {
        //    towns[name] = population;
        //}else {
        //    towns[name] += population;
        //}


    }

    for (const name in towns) {
        
        console.log(`${name} : ${towns[name]}`);
    }
}

solve(['Sofia <-> 1200000',
'Montana <-> 20000',
'New York <-> 10000000',
'Washington <-> 2345000',
'Las Vegas <-> 1000000']);