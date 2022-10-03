namespace BubberDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationRequest Login(string email, string password);
    AuthenticationRequest Register(string firstName, string lastName, string email, string password);

}