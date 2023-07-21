using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MinimaApi.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MinimaApi.Endpoints;

public static class AuthenticationEndpoints
{
    public static void AddAuthenticationEndPoints(this WebApplication app)
    {
        app.MapPost("api/token", (IConfiguration config,[FromBody] AuthenticationData data) =>
        {
            var user = ValidateCredentials(data);

            if (user is null)
            {
                return Results.Unauthorized();
            }
            var token = GenerateToken(user,config);
            return Results.Ok(token);
        });
    }

    private static string GenerateToken(UserData user,IConfiguration config)
    {
        var secretKey = new SymmetricSecurityKey(
                Encoding.ASCII.GetBytes(
                config.GetValue<string>("Authentication:SecretKey")));
        var signingCreadentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        List<Claim> claims = new();
        claims.Add(new(JwtRegisteredClaimNames.Sub, user.Id.ToString()));
        claims.Add(new(JwtRegisteredClaimNames.UniqueName, user.UserName));
        claims.Add(new(JwtRegisteredClaimNames.GivenName, user.FirstName));
        claims.Add(new(JwtRegisteredClaimNames.FamilyName, user.LastName));

        var token = new JwtSecurityToken(
        config.GetValue<string>("Authentication:Issuer"),
        config.GetValue<string>("Authentication:Audience"),
        claims,
        DateTime.UtcNow,
        DateTime.UtcNow.AddMinutes(5),
        signingCreadentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private static UserData? ValidateCredentials(AuthenticationData data)
    {
        // THIS IS NOT PRODUCTION CODE - REPLACE THIS WITH A CALL TO YOUR AUTH SYSTEM
        if (CompareValue(data.UserName, "dns") &&
            CompareValue(data.Password, "dns123"))
        {
            return new UserData(1, "Darshit", "Shah", data.UserName!);
        }
        if (CompareValue(data.UserName, "bb") &&
            CompareValue(data.Password, "bb123"))
        {
            return new UserData(2, "Burhan", "Bharmal", data.UserName!);
        }
        return null;
    }
    private static bool CompareValue(string? actual, string expected)
    {
        if (actual is not null)
        {
            if (actual.Equals(expected))
            {
                return true;
            }
        }
        return false;
    }

}
