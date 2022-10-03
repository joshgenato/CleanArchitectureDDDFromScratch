using BubberDinner.Application.Common.Interface.Authentication;

namespace BubberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationRequest Register(string firstName, string lastName, string email, string password)
    {
        // Check if user already exist

        // Create user (generate unique ID)

        // Create JWT Token
        Guid userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

        return new AuthenticationRequest(
           Guid.NewGuid(),
           firstName,
           lastName,
           email,
           token
       );
    }

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


}
