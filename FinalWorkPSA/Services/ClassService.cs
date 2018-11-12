using System;
using System.Collections.Generic;
using System.Linq;
using FinalWorkPSA.Data.Repositories;
using FinalWorkPSA.Models.Entities;

using System.Threading.Tasks;

namespace FinalWorkPSA.Services
{
    public class ClassService
    {
        private readonly ClassRepository Repository;
        //private readonly PlayerRepository PlayerRepository;

        public ClassService(ClassRepository _Repository)
        {
            Repository = _Repository;
        }

        public List<Class> GetAllClassWithPlayers()
        {
            //TODO
            //Listar corretamente as turmas 
            var listClass = Repository.GetAllClass();

            //foreach (var c in listClass)
            //{
            //    c.ListPlayers = PlayerRepository.GetAllPlayers().Where(p => p.IdTeam == team.IdTeam);
            //}

            return Repository.GetAllClass();
        }

        public List<Class> GetAllClass()
        {
            return Repository.GetAllClass();
        }

        public Class GetClassById(int id)
        {
            return Repository.GetClassById(id);
        }

        public void PostClass(Class newClass)
        {
            Repository.PostClass(newClass);
        }

        public void PutClass(int id, Class upClass)
        {
            Repository.PutClass(id, upClass);
        }

        public void DeleteClass(int id)
        {
            Repository.DeleteClass(id);
        }
    }
}