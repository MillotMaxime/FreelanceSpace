using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace API.Controllers
{
    public class OffersController : BaseApiController
    {
        private readonly DataContext _context;
        public OffersController(DataContext context)
        {
            _context = context;
        }

        
        [HttpPost]
        public async Task<Boolean> CreateOffre(OfferDto offreDto)
        {
            UserDto user = offreDto.Creator;

            Business business = await _context.Business.SingleOrDefaultAsync(
                x => x.Email.ToLower() == user.Email.ToLower()
            );

            if (business != null && user.Token != null)
            {
                Offer offre = new Offer {
                    Creator = business,
                    Create = DateTime.Now,
                    Name = offreDto.Name,
                    Description = offreDto.Description,
                    Salary = createSalary(offreDto),
                    Penalty = createPenalty(offreDto),
                    Terms = createTerms(offreDto),
                    BusinessValidation = offreDto.BusinessValidation,
                    FreelanceValidation = offreDto.FreelanceValidation
                };

                await _context.Salary.AddAsync(offre.Salary);
                await _context.SalaryPenalty.AddAsync(offre.Penalty);
                await _context.Terms.AddAsync(offre.Terms);
                await _context.Offre.AddAsync(offre);

                await _context.SaveChangesAsync();

                saveAndCreateOffreLanguagesComputer(offreDto, offre);


                saveAndCreateOffreLanguagesSpeak(offreDto, offre);
                
                return true;
            } else {
                Unauthorized("Votre compte ne vous permet pas de créer une offre");
                return false;
            }
        }

        private void saveAndCreateOffreLanguagesComputer(OfferDto offreDto, Offer offre) {
            offreDto.ComputerLanguage.ForEach(language => {
                OfferProgramingLanguages offreLanguagesComputer = new OfferProgramingLanguages();
                
                Task<ProgramingLanguage> computerLanguage = _context.ComputerLanguage.SingleOrDefaultAsync(
                    x => x.Name.ToLower() == language.Name.ToLower()
                );
                
                offreLanguagesComputer.ProgramingLanguage = computerLanguage.Result;
                offreLanguagesComputer.Offre = offre;
                offreLanguagesComputer.Favoris = language.Favoris;

                _context.OffreLanguagesComputer.Add(offreLanguagesComputer);
                
                _context.SaveChanges();
            });
        }

        private void saveAndCreateOffreLanguagesSpeak(OfferDto offreDto, Offer offre) {
            offreDto.LanguageSpeak.ForEach(language => {
                OfferLanguages offreLanguagesSpeak = new OfferLanguages();
                
                Task<Language> speak = _context.LanguageSpeak.SingleOrDefaultAsync(
                    x => x.Name.ToLower() == language.Name.ToLower()
                );

                offreLanguagesSpeak.Language = speak.Result;
                offreLanguagesSpeak.Offre = offre;
                offreLanguagesSpeak.Favoris = language.Favoris;

                _context.OffreLanguagesSpeak.Add(offreLanguagesSpeak);
                
                _context.SaveChanges();
            });
        }

        private Salary createSalary(OfferDto offreDto) {
            TauxHorraire TauxHorraire = new TauxHorraire {
                    Valeur = offreDto.Salary.TauxHorraire.Valeur,
                    TypeTaux = offreDto.Salary.TauxHorraire.TypeTaux
                };
            _context.TimeLimit.Add(TauxHorraire);

            return new Salary {
                TauxHorraire = TauxHorraire
            };
        }

        private Penalty createPenalty(OfferDto offreDto) {
            TauxHorraire TauxHorraire = new TauxHorraire {
                    Valeur = offreDto.Penalty.TauxHorraire.Valeur,
                    TypeTaux = offreDto.Penalty.TauxHorraire.TypeTaux
                };
            _context.TimeLimit.Add(TauxHorraire);

            return new Penalty {
                TauxHorraire = TauxHorraire
            };
        }

        private Terms createTerms(OfferDto offreDto) {
            return new Terms {
                Begin = null,
                End = new Time {
                    Valeur = offreDto.Terms.End.Valeur,
                    TypeTaux = offreDto.Terms.End.TypeTaux
                }
            };
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Offer>>> GetOffres() 
        {
            IQueryable<Offer> offres =  _context.Offre
            .Include(offre => offre.Creator)
            .Include(Offre => Offre.Salary).ThenInclude(salary => salary.TauxHorraire)
            .Include(Offre => Offre.Penalty).ThenInclude(penalty => penalty.TauxHorraire)
            .Include(Offre => Offre.Terms).ThenInclude(terms => terms.End);
            return await offres.ToListAsync();
        }

        [HttpGet("{id}")]
        public Offer GetOffre(int id) 
        {
            IQueryable<Offer> offre =  _context.Offre
            .Include(offre => offre.Creator)
            .Include(Offre => Offre.Salary).ThenInclude(salary => salary.TauxHorraire)
            .Include(Offre => Offre.Penalty).ThenInclude(penalty => penalty.TauxHorraire)
            .Include(Offre => Offre.Terms).ThenInclude(terms => terms.End);

            return offre.SingleOrDefault(x => x.Id == id);
        }
    }
}