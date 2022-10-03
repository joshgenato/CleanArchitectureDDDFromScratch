namespace BubberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationRequest Login(string email, string password)
    {
        return new AuthenticationRequest(
            Guid.NewGuid(),
            "firstName",
            "lastName",
            email,
            "token"
        );
    }

    public AuthenticationRequest Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticationRequest(
           Guid.NewGuid(),
           firstName,
           lastName,
           email,
           "token"
       );
    }
}
