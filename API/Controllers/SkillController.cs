using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace API.Controllers.Get
{
    public class SkillController : BaseApiController
    {
        private readonly DataContext _context;
        public SkillController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("Language")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Language>>> GetLanguage() 
        {
            return await _context.Language.ToListAsync();
        }

        [HttpGet("ProgramingLanguage")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProgramingLanguage>>> GetProgramingLanguage() 
        {
            return await _context.ProgramingLanguage.ToListAsync();
        }
    }
}