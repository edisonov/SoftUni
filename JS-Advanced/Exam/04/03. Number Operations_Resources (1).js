const describe = require('mocha').describe;
const assert = require('chai').assert;


describe("powNumber", function () {
    it("returns the power of the given number", function () {
        assert.equal(numberOperations.powNumber(3), 9, 'message')
    });
});

describe("numberChecker", function () {

    
    it("The number is greater or equal to 100", function () {
        assert.equal(numberOperations.numberChecker('102'), 'The number is greater or equal to 100!', 'message')
    });

    it("The number is lower than 100!", function () {
        assert.equal(numberOperations.numberChecker('95'), 'The number is lower than 100!', 'message')
    });

    it("isNaN", function () {
        assert.throw(() => numberOperations.numberChecker('aaa'), 'The input is not a number!')
    });

    
});

describe("sumArrays", function () {
    it("array 1", function () {
        let array1 = [1, 2, 3];
        let array2 = [1, 2, 3];
        assert.deepEqual(numberOperations.sumArrays(array1, array2), [2, 4, 6], 'message')
    });
});




const numberOperations = {
    powNumber: function (num) {
        return num * num;
    },
    numberChecker: function (input) {
        input = Number(input);

        if (isNaN(input)) {
            throw new Error('The input is not a number!');
        }

        if (input < 100) {
            return 'The number is lower than 100!';
        } else {
            return 'The number is greater or equal to 100!';
        }
    },
    sumArrays: function (array1, array2) {

        const longerArr = array1.length > array2.length ? array1 : array2;
        const rounds = array1.length < array2.length ? array1.length : array2.length;

        const resultArr = [];

        for (let i = 0; i < rounds; i++) {
            resultArr.push(array1[i] + array2[i]);
        }

        resultArr.push(...longerArr.slice(rounds));

        return resultArr
    }
};