using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ContractController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;
        public ContractController(DataContext context, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("CreateOffre")]
        public async Task<Boolean> CreateOffre(OffreDto offreDto)
        {
            UserDto user = offreDto.Creator;

            Business business = await _context.Business.SingleOrDefaultAsync(
                x => x.Email.ToLower() == user.Email.ToLower()
            );

            if (business != null && user.Token != null)
            {
                Offre offre = new Offre {
                    Creator = business,
                    Create = DateTime.Now,
                    Name = offreDto.Name,
                    Description = offreDto.Description,
                    Salary = createSalary(offreDto),
                    Penalty = createSalaryPenalty(offreDto),
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

        private void saveAndCreateOffreLanguagesComputer(OffreDto offreDto, Offre offre) {
            offreDto.ComputerLanguage.ForEach(language => {
                OffreLanguagesComputer offreLanguagesComputer = new OffreLanguagesComputer();
                
                Task<ComputerLanguage> computerLanguage = _context.ComputerLanguage.SingleOrDefaultAsync(
                    x => x.Name.ToLower() == language.Name.ToLower()
                );
                
                offreLanguagesComputer.ComputerLanguage = computerLanguage.Result;
                offreLanguagesComputer.Offre = offre;
                offreLanguagesComputer.Favoris = language.Favoris;

                _context.OffreLanguagesComputer.Add(offreLanguagesComputer);
                
                _context.SaveChanges();
            });
        }

        private void saveAndCreateOffreLanguagesSpeak(OffreDto offreDto, Offre offre) {
            offreDto.LanguageSpeak.ForEach(language => {
                OffreLanguagesSpeak offreLanguagesSpeak = new OffreLanguagesSpeak();
                
                Task<LanguageSpeak> speak = _context.LanguageSpeak.SingleOrDefaultAsync(
                    x => x.Name.ToLower() == language.Name.ToLower()
                );

                offreLanguagesSpeak.Speak = speak.Result;
                offreLanguagesSpeak.Offre = offre;
                offreLanguagesSpeak.Favoris = language.Favoris;

                _context.OffreLanguagesSpeak.Add(offreLanguagesSpeak);
                
                _context.SaveChanges();
            });
        }

        private Salary createSalary(OffreDto offreDto) {
            TimeLimit recurence = new TimeLimit {
                    Nombre = offreDto.Salary.Recurence.Nombre,
                    TypeTime = offreDto.Salary.Recurence.TypeTime
                };
            _context.TimeLimit.Add(recurence);

            return new Salary {
                Montant = offreDto.Salary.Montant,
                Recurence = recurence
            };
        }

        private SalaryPenalty createSalaryPenalty(OffreDto offreDto) {
            TimeLimit recurence = new TimeLimit {
                    Nombre = offreDto.Penalty.Recurence.Nombre,
                    TypeTime = offreDto.Penalty.Recurence.TypeTime
                };
            _context.TimeLimit.Add(recurence);

            return new SalaryPenalty {
                Montant = offreDto.Penalty.Montant,
                Recurence = recurence
            };
        }

        private Terms createTerms(OffreDto offreDto) {
            return new Terms {
                Begin = null,
                End = new TimeLimit {
                    Nombre = offreDto.Terms.End.Nombre,
                    TypeTime = offreDto.Terms.End.TypeTime
                }
            };
        }
    }
}