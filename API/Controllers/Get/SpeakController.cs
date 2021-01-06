using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Get
{
    public class SpeakController : BaseApiController
    {
        private readonly DataContext _context;
        public SpeakController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult<IEnumerable<LanguageSpeak>> GetComputerLanguage() 
        {
            return _context.LanguageSpeak;
        }
    }
}