namespace Tests;

using System.Reflection;
using knightmoves;
using Xunit;

public class AutogradingTest
{

    [Fact]
    public void Should_Create_A_Public_Class_Level_String_Variable_Named_Name(){
      Account account = new Account();
      string Name = account.Name;
    }

    [Fact]
    public void Should_Create_A_Private_Method_Named_ChangeName_That_Takes_A_New_Name_Sets_Name_With_The_New_Value_And_Returns_The_New_Name(){
      Account account = new Account();
      var method = typeof(Account).GetMethod("ChangeName", BindingFlags.NonPublic | BindingFlags.Instance);
      var result = method.Invoke(account, new object[]{"Nancy"});
      Assert.Equal("Nancy", result);
      Assert.Equal("Nancy", account.Name);
    }
}