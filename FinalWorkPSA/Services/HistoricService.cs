using System;
using System.Collections.Generic;
using System.Linq;
using FinalWorkPSA.Data.Repositories;
using FinalWorkPSA.Models.Entities;

namespace FinalWorkPSA.Services
{
    public class HistoricService
    {
        private readonly HistoricRepository Repository;
        //private readonly PlayerRepository PlayerRepository;

        public HistoricService(HistoricRepository _Repository)
        {
            Repository = _Repository;
        }

        public List<Historic> GetAllHistoricWithPlayers()
        {
            //TODO
            //Listar corretamente as turmas 
            var listHistoric = Repository.GetAllHistoric();

            //foreach (var c in listClass)
            //{
            //    c.ListPlayers = PlayerRepository.GetAllPlayers().Where(p => p.IdTeam == team.IdTeam);
            //}

            return Repository.GetAllHistoric();
        }

        public List<Historic> GetAllHistoric()
        {
            return Repository.GetAllHistoric();
        }

        public Historic GetClassById(int id)
        {
            return Repository.GetHistoricById(id);
        }

        public void PostHistoric(Historic newHistoric)
        {
            Repository.PostHistoric(newHistoric);
        }

        public void PutHistoric(int id, Historic upHistoric)
        {
            Repository.PutHistoric(id, upHistoric);
        }

        public void DeleteHistoric(int id)
        {
            Repository.DeleteHistoric(id);
        }
    }
}