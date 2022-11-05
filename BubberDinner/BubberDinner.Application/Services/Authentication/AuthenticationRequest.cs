using BubberDinner.Domain.Entities;

namespace BubberDinner.Application.Services.Authentication;

public record AuthenticationRequest(
    User User,
    string Token
);