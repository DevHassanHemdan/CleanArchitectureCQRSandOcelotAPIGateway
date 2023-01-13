using Application.Interfaces;
using Domain;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using Application.DTOs;
using Microsoft.Extensions.Options;

namespace Infrastructure.Security
{
    public class JWTGenerator : IJWTGenerator
    {
        private readonly SymmetricSecurityKey _key;
        private readonly JWT _jWT;
        public JWTGenerator(IConfiguration config, IOptions<JWT> jWT)
        {
            _jWT = jWT.Value;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jWT.key));

        }
        public string CreateToken(Users user)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim("uid",user.Id),
                new Claim("userName",user.UserName),
            };

            //Generate signing credentials
            SymmetricSecurityKey key = _key;
            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jWT.Issuer,
                audience: _jWT.Audience,
                claims: claims,
                expires: DateTime.Now.AddDays(_jWT.DurationInDays),
                signingCredentials: creds
                );


            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(claims),
            //    Expires = DateTime.Now.AddDays(7),
            //    SigningCredentials = creds,
            //};

            var tokenHandler = new JwtSecurityTokenHandler();
            //var token = tokenHandler.CreateToken(jwtSecurityToken);

            return tokenHandler.WriteToken(jwtSecurityToken);
        }
    }
}
