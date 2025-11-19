using System.Net.Http.Headers;


public class PasswordValidator
{
    public static void Main()
    {

    }

    public static bool Validate(string password)
    {
        string specialChar = "!#&/()?[]";

        foreach (char item in password)
        {
            if (char.IsDigit(item) && password.Length >= 8)
            {

                foreach (char c in specialChar)

                {
                    if (password.Contains(c))
                        return true;
                }
            }

        }
        return false;
    }
}


