using System;
using System.Collections.Generic;
using System.Linq;
using FinalWorkPSA.Data.Repositories;
using FinalWorkPSA.Models.Entities;

namespace FinalWorkPSA.Services
{
    public class SubjectService
    {
        private readonly SubjectRepository Repository;
        //private readonly PlayerRepository PlayerRepository;

        public SubjectService(SubjectRepository _Repository)
        {
            Repository = _Repository;
        }

        public List<Subject> GetAllSubjectWithPlayers()
        {
            //TODO
            //Listar corretamente as turmas 
            var listSubject = Repository.GetAllSubject();

            //foreach (var c in listClass)
            //{
            //    c.ListPlayers = PlayerRepository.GetAllPlayers().Where(p => p.IdTeam == team.IdTeam);
            //}

            return Repository.GetAllSubject();
        }

        public List<Subject> GetAllSubject()
        {
            return Repository.GetAllSubject();
        }

        public Subject GetClassById(int id)
        {
            return Repository.GetSubjectById(id);
        }

        public void PostSubject(Subject newSubject)
        {
            Repository.PostSubject(newSubject);
        }

        public void PutSubject(int id, Subject upSubject)
        {
            Repository.PutSubject(id, upSubject);
        }

        public void DeleteSubject(int id)
        {
            Repository.DeleteSubject(id);
        }
    }
}