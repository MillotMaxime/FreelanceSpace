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
        public async Task<Boolean> CreateOffre(OfferDto offerDto)
        {
            UserDto user = offerDto.Creator;

            Business business = await _context.Business.SingleOrDefaultAsync(
                x => x.Email.ToLower() == user.Email.ToLower()
            );

            if (business != null && user.Token != null)
            {
                Offer offer = new Offer {
                    Creator = business,
                    Create = DateTime.Now,
                    Name = offerDto.Name,
                    But = offerDto.But,
                    Description = offerDto.Description,
                    DescriptionFreelance = offerDto.DescriptionFreelance,
                    TypeOffer = createTypeOffer(offerDto),
                    Salary = createSalary(offerDto),
                    Terms = createTerms(offerDto),
                    BusinessValidation = false,
                    FreelanceValidation = false
                };

                await _context.Salary.AddAsync(offer.Salary);
                await _context.Terms.AddAsync(offer.Terms);
                await _context.Offre.AddAsync(offer);

                await _context.SaveChangesAsync();

                saveAndCreateOffreLanguagesComputer(offerDto, offer);

                saveAndCreateOffreLanguagesSpeak(offerDto, offer);
                
                return true;
            } else {
                Unauthorized("Votre compte ne vous permet pas de créer une offre");
                return false;
            }
        }

        private string nameLanguage;
        private Boolean favorisLanguage;

        private void saveAndCreateOffreLanguagesComputer(OfferDto offreDto, Offer offre) {
            offreDto.ProgramingLanguages.ForEach(language => {
                nameLanguage = language.Name.ToLower();
                favorisLanguage = language.Favoris;
            });

            OfferProgramingLanguages offreLanguagesComputer = new OfferProgramingLanguages();
                
            Task<ProgramingLanguage> computerLanguage = _context.ProgramingLanguage.SingleOrDefaultAsync(
                x => x.Name.ToLower() == nameLanguage.ToLower()
            );
            
            
            offreLanguagesComputer.ProgramingLanguage = computerLanguage.Result;
            offreLanguagesComputer.Offre = offre;
            offreLanguagesComputer.Favoris = favorisLanguage;

            _context.OffreLanguagesComputer.Add(offreLanguagesComputer);
            
            _context.SaveChanges();
        }

        private void saveAndCreateOffreLanguagesSpeak(OfferDto offreDto, Offer offre) {
            offreDto.Language.ForEach(language => {
                OfferLanguages offreLanguagesSpeak = new OfferLanguages();
                
                Task<Language> speak = _context.Language.SingleOrDefaultAsync(
                    x => x.Name.ToLower() == language.Name.ToLower()
                );

                offreLanguagesSpeak.Language = speak.Result;
                offreLanguagesSpeak.Offre = offre;
                offreLanguagesSpeak.Favoris = language.Favoris;

                _context.OffreLanguagesSpeak.Add(offreLanguagesSpeak);
                
                _context.SaveChanges();
            });
        }

        private TypeOffer createTypeOffer(OfferDto offerDto) {
            TypeOffer typeOffer = new TypeOffer();
            typeOffer = offerDto.TypeOffer;
            return typeOffer;
        }

        private Salary createSalary(OfferDto offerDto) {

            return new Salary {
                TotalAmount = offerDto.Salary.TotalAmount
            };
        }


        private Terms createTerms(OfferDto offreDto) {
            return new Terms {
                Begin = null,
                End = new Time {
                    Valeur = offreDto.Terms.End.Valeur,
                    TypeTime = offreDto.Terms.End.TypeTaux
                }
            };
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Offer>>> GetOffres() 
        {
            IQueryable<Offer> offres =  _context.Offre
            .Include(offre => offre.Creator)
            .Include(Offre => Offre.Salary)
            .Include(Offre => Offre.Terms).ThenInclude(terms => terms.End);
            return await offres.ToListAsync();
        }

        [HttpGet("OfferProgramingLanguage")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<OfferProgramingLanguages>>> GetOffreProgramingLanguage() 
        {
            IQueryable<OfferProgramingLanguages> offreLanguagesComputer =  _context.OffreLanguagesComputer
            .Include(offreLanguagesComputer => offreLanguagesComputer.Offre)
            .Include(offreLanguagesComputer => offreLanguagesComputer.ProgramingLanguage);

            return await offreLanguagesComputer.ToListAsync();
        }

        [HttpGet("{id}")]
        public Offer GetOffre(int id) 
        {
            IQueryable<Offer> offre =  _context.Offre
            .Include(offre => offre.Creator)
            .Include(Offre => Offre.Salary)
            .Include(Offre => Offre.Terms).ThenInclude(terms => terms.End);

            return offre.SingleOrDefault(x => x.Id == id);
        }
    }
}