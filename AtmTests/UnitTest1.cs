using System;
using Xunit;
using Unit_Testing;

namespace AtmTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanDeposit()
        {
            Program.balance = 50;
            Assert.Equal(100, Program.Deposit(50));
        }

        [Fact]
        public void CanWithdraw()
        {
            Program.balance = 500;
            Assert.Equal(200, Program.Withdraw(300));
        }

        [Fact]
        public void CannotGoNegative()
        {
            Program.balance = 100;
            Assert.Equal(100, Program.Withdraw(150));
        }

        [Fact]
        public void CannotDepositNegative()
        {
            Program.balance = 100;
            Assert.Equal(100, Program.Deposit(-50));
        }
    }
}

//Fact or Theory
//Fact always hase to be true, no parameters
//Theory is conditionally true, has to have parameters
