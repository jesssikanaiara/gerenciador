using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace GerenciadorApi.Helpers
{
    public class JwtAuthenticationHelper
    {
        public const string SECURITY_KEY = "dfaljdsfkljasdklfjklasdjkfhad943839043";

        public static void ValidationToken(JwtBearerOptions options)
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "gerenciador",
                ValidAudience = "gerenciador",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECURITY_KEY))
            };

            options.Events = new JwtBearerEvents
            {
                OnAuthenticationFailed = context => 
                {
                    Console.WriteLine("Token inválido... " + context.Exception.Message);
                    return Task.CompletedTask;
                },
                OnTokenValidated = context => 
                {
                    Console.WriteLine("Token válido...: ", context.SecurityToken);
                    return Task.CompletedTask;
                }
            };
        }
    }
}