namespace Password.Validdator;

public class UnitTest1
{
    [Theory]
    [InlineData("shahad2022")]
    [InlineData("Elin123")]

    public void GetPassword (string password)
    {
    

        //Assert 

        Assert.True(PasswordValidator.Validate(password));


    }
}
