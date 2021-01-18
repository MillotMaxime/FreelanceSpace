using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace API.Controllers.Get
{
    public class LanguageController : BaseApiController
    {
        private readonly DataContext _context;
        public LanguageController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Language>>> GetComputerLanguage() 
        {
            return await _context.LanguageSpeak.ToListAsync();
        }
    }
}