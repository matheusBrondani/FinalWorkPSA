using System;
using System.Collections.Generic;
using System.Linq;
using FinalWorkPSA.Data.Repositories;
using FinalWorkPSA.Models.Entities;

namespace FinalWorkPSA.Services
{
    public class RequirementService
    {
        private readonly RequirementRepository Repository;
        //private readonly PlayerRepository PlayerRepository;

        public RequirementService(RequirementRepository _Repository)
        {
            Repository = _Repository;
        }

        public List<Requirement> GetAllRequirementWithPlayers()
        {
            //TODO
            //Listar corretamente as turmas 
            var listRequirement = Repository.GetAllRequirement();

            //foreach (var c in listClass)
            //{
            //    c.ListPlayers = PlayerRepository.GetAllPlayers().Where(p => p.IdTeam == team.IdTeam);
            //}

            return Repository.GetAllRequirement();
        }

        public List<Requirement> GetAllRequirement()
        {
            return Repository.GetAllRequirement();
        }

        public Requirement GetClassById(int id)
        {
            return Repository.GetRequirementById(id);
        }

        public void PostRequirement(Requirement newRequirement)
        {
            Repository.PostRequirement(newRequirement);
        }

        public void PutRequirement(int id, Requirement upRequirement)
        {
            Repository.PutRequirement(id, upRequirement);
        }

        public void DeleteRequirement(int id)
        {
            Repository.DeleteRequirement(id);
        }
    }
}