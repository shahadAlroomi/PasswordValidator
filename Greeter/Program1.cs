using System.Net.Http.Headers;


public class PasswordValidator
{ 
    public static void Main()
    {
        
    }

public static bool Validate(string password)
    {
        if (password.Length >= 8) 
        {
            Console.WriteLine("Password should be more than 8 ");
            return true;
        }
        else 
        return false;

       
    }    
}


