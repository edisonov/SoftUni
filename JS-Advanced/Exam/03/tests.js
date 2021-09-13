const chai = require('chai')
, assert = chai.assert
, expect = chai.expect
, should = chai.should();

describe('String', () => {
    let name = 'John'
    it('should be of type string', () => {
        name.should.be.a('string')
        expect(name).to.be.a('string')
        assert.typeOf(name, 'string')
    })

    it('should contain John', () => {
        name.should.equal('John')
        expect(name).to.equal('John')
        assert.equal(name, 'John')
    })
})