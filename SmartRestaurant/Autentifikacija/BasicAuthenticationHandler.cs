using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SmartRestaurant.DbContext;
using SmartRestaurant.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace SmartRestaurant.Autentifikacija
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private IKorisnikService _userService;
        private AppDBContext _context;
        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IKorisnikService userService, AppDBContext context)
            : base(options, logger, encoder, clock)
        {
            _userService = userService;
            _context = context;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
         {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            Model.Korisnici user = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username="";
                var password="";
                if (credentials.Length>2)
                {
                    username = credentials[1];
                    password = credentials[3];
                }
                else
                {
                    username = credentials[0];
                    password = credentials[1];
                }
                user = _userService.Autentifikacija(username, password);
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (user == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, user.NazivKorisnika),
                new Claim(ClaimTypes.Name, user.NazivKorisnika),
            };

            var korisnikuloge = _context.KorisnikUloga.Include(a => a.Uloge).Where(a=>a.KorisniciID==user.KorisnikID).ToList();

            foreach (var uloga in korisnikuloge)
            {
                claims.Add(new Claim(ClaimTypes.Role,uloga.Uloge.NazivUloge));
            }


            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}
