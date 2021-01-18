using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;
        public AccountController(DataContext context, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            if (await UserExists(registerDto.Email)) return BadRequest("Email est déjà utilisé.");

            using var hamc = new HMACSHA512();
            
            if (registerDto.Business) {
                var user = createBusiness(registerDto, hamc);
                _context.Business.Add(user);
                saveUser();
                return new UserDto(user.Email, _tokenService.CreateToken(user));
            } else {
                var user = createFreelance(registerDto, hamc);
                _context.Freelance.Add(user);
                saveUser();
                return new UserDto(user.Email, _tokenService.CreateToken(user));
            }
        }

        private Business createBusiness(RegisterDto registerDto, HMACSHA512 hamc) {
            return new Business {
                    NameBusiness = registerDto.NameBusiness,
                    Login = registerDto.Login,
                    Email = registerDto.Email.ToLower(),
                    PasswordHash = hamc.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                    PasswordSalt = hamc.Key,
                    Activity = registerDto.Activite,
                    Siret = registerDto.Siret,
                    LegalStatus = registerDto.StatutJuridique
                };
        }

        private Freelance createFreelance(RegisterDto registerDto, HMACSHA512 hamc) {
            return new Freelance {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    Login = registerDto.Login,
                    Email = registerDto.Email.ToLower(),
                    PasswordHash = hamc.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                    PasswordSalt = hamc.Key,
                    Ago = registerDto.Age
                };
        }

        async Task<bool> UserExists(string email)
        {
            return await _context.Users.AnyAsync(x => x.Email == email.ToLower());
        }

        private async void saveUser() {
            await _context.SaveChangesAsync();
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> login(LoginDto loginDto)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Email == loginDto.Email.ToLower());

            if (user == null) return Unauthorized("Identifiant ou mot de passe invalide");

            var computeHash = getComputeHash(user, loginDto);

            for (int index = 0; index < computeHash.Length; index++)
            {
                if (computeHash[index] != user.PasswordHash[index]) return Unauthorized("Identifiant ou mot de passe invalide");
            }

            return new UserDto(user.Email, _tokenService.CreateToken(user));
        }

        private byte[] getComputeHash(AppUser user, LoginDto loginDto) {
            using var hmac = new HMACSHA512(user.PasswordSalt);
            return hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));
        }
    }
}