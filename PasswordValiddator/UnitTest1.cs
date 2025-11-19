namespace Password.Validdator;

public class UnitTest1
{
    [Theory]
    [InlineData("shahad2022")]
    [InlineData("Elin1238")]
    [InlineData("wwe83ufl")]

    public void GetPassword (string password)
    {
    

        //Assert 

        Assert.True(PasswordValidator.Validate(password));


    }
}
