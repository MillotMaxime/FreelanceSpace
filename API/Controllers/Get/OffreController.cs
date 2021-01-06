using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace API.Controllers
{
    public class OffreController : BaseApiController
    {
        private readonly DataContext _context;
        public OffreController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Offre>>> GetOffres() 
        {
            IQueryable<Offre> offres =  _context.Offre
            .Include(offre => offre.Creator)
            .Include(Offre => Offre.Salary).ThenInclude(salary => salary.Recurence)
            .Include(Offre => Offre.Penalty).ThenInclude(penalty => penalty.Recurence)
            .Include(Offre => Offre.Terms).ThenInclude(terms => terms.End);
            return await offres.ToListAsync();
        }

        [HttpGet("{id}")]
        public Offre GetOffre(int id) 
        {
            IQueryable<Offre> offre =  _context.Offre
            .Include(offre => offre.Creator)
            .Include(Offre => Offre.Salary).ThenInclude(salary => salary.Recurence)
            .Include(Offre => Offre.Penalty).ThenInclude(penalty => penalty.Recurence)
            .Include(Offre => Offre.Terms).ThenInclude(terms => terms.End);

            return offre.SingleOrDefault(x => x.Id == id);
        }
    }
}