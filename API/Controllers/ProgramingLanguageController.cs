using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.Get
{
    public class ProgramingLanguageController : BaseApiController
    {
        private readonly DataContext _context;
        public ProgramingLanguageController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProgramingLanguage>>> GetComputerLanguage() 
        {
            return await _context.ComputerLanguage.ToListAsync();
        }
    }
}