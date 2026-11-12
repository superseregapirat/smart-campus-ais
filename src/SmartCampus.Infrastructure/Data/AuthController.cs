namespace SmartCampus.WebAPI.Controllers;

public class AuthController
{
    public string Login(string studentCardNumber, string password)
    {
        return "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.mock_jwt_token";
    }
}
