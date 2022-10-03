using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BubberDinner.Application.Common.Interface.Authentication;
using Microsoft.IdentityModel.Tokens;

namespace BubberDinner.Infrastructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{

    public string GenerateToken(Guid userId, string firstName, string lastName)
    {
        var signingCredentials = new SigningCredentials(
        new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("super-secret-key")),
                SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, firstName + " " + lastName),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName ),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.UniqueName, userId.ToString()),
        };

        var securityToken = new JwtSecurityToken(
            issuer: "BubberDinner",
            expires: DateTime.Now.AddDays(1),
            claims: claims,
            signingCredentials: signingCredentials);

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }
}
