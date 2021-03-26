using NUnit.Framework;
using System;

namespace Bank.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void When_AccountInitalizedWithPositiveValue_AmountShould_BeChanged()
        {

            decimal amount = 5;
            BankAccount bankAccount = new BankAccount(amount);

            Assert.That(bankAccount.Amount, Is.EqualTo(amount));
        }
    }
}
