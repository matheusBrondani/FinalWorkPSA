using FinalWorkPSA.Models.Entities;
using FinalWorkPSA.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace FinalWorkPSA.Data.Repositories
{
    public class RequirementRepository
    {
        private readonly RegistryContext _context;

        public RequirementRepository(RegistryContext context) {
            _context = context;
        }

        //Retorna todos os times do contexto
        public List<RequirementService> GetAllRequirement()
        {
            return _context.Requirement.ToList();
        }

        //Retorna o time vinculado ao ID
        public RequirementService GetRequirementById(int id)
        {
            return _context.Requirement.Find(id);
        }

        //Insere um time novo
        public void PostRequirement(RequirementService newRequirement)
        {
            // newRequirement.IdRequirement = _context.Requirement.Max(p => p.IdRequirement) + 1;

            // _context.Requirement.Add(newRequirement);
            // _context.SaveChanges();
        }

        //Atualiza um time
        public void PutRequirement(int id, RequirementService upRequirement)
        {
            // var toUpRequirement = _context.Requirement.Find(id);

            // toUpRequirement.Name = upRequirement.Name;
            // toUpRequirement.NameStadium = upRequirement.NameStadium;

            // _context.Requirements.Update(toUpRequirement);
            // _context.SaveChanges();
        }

        //Deleta um time
        public void DeleteRequirement(int id)
        {
            var Requirement = _context.Requirement.Find(id);
            _context.Requirement.Remove(Requirement);
            _context.SaveChanges();
        }
    }
}
