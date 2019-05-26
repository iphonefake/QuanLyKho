using BaiVeNhaQuanLyKhoHang.Helper;
using BaiVeNhaQuanLyKhoHang.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Services
{
    public interface IUserService
    {
        BaiVeNhaQuanLyKhoHang.Models.QuanTri Authenticate(string username, string password);
    }
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        private readonly DataContext _context;
        public UserService(IOptions<AppSettings> appSettings, DataContext context)
        {
            _appSettings = appSettings.Value;
            _context = context;
        }

        public QuanTri Authenticate(string username, string password)
        {
            var user = _context.QuanTris.SingleOrDefault(x => x.Username == username && x.Password == password); // Thay cho nay bang cau truy van Store Procidure

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.UserToken = tokenHandler.WriteToken(token);

            // remove password before returning
            user.Password = null;

            return user;
        }
    }
}
