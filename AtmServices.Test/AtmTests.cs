namespace AtmServices.Test;

using AtmServices;

public class AtmTests
{
    Atm testAtm;

    int initialBalance = 100;

    public AtmTests() {
        testAtm = new Atm(initialBalance);
    }

    [Fact]
    public void Test_Withdraw()
    {
        var result = testAtm.withdraw(25);
        Assert.True(result);
        Assert.Equal(75,testAtm.getBalance());
    }

    [Fact]
    public void Test_Deposit_Failure()
    {
        var result = testAtm.deposit(-5);
        Assert.False(result);
        Assert.Equal(100,testAtm.getBalance());
    }

    [Fact]
    public void Test_Withdraw_Failure()
    {
        var result = testAtm.withdraw(125);
        Assert.False(result);
        Assert.Equal(100,testAtm.getBalance());
    }

    [Fact]
    public void Test_Withdraw_And_Deposit()
    {
        var result = testAtm.withdraw(25);
        Assert.True(result);

        var resultOfDeposit = testAtm.deposit(25);
        Assert.True(resultOfDeposit);
        
        Assert.Equal(100,testAtm.getBalance());
    }
}