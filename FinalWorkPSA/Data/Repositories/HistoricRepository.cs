using FinalWorkPSA.Models.Entities;
using FinalWorkPSA.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace CopaStefaniniBackEnd.Data.Repositories
{
    public class HistoricRepository
    {
        private readonly RegistryContext _context;

        public HistoricRepository(RegistryContext context) {
            _context = context;
        }

        //Retorna todos os times do contexto
        public List<Historic> GetAllHistoric()
        {
            return _context.Historic.ToList();
        }

        //Retorna o time vinculado ao ID
        public Historic GetHistoricById(int id)
        {
            return _context.Historic.Find(id);
        }

        //Insere um time novo
        public void PostHistoric(Historic newHistoric)
        {
            // newHistoric.IdHistoric = _context.Historic.Max(p => p.IdHistoric) + 1;

            // _context.Historic.Add(newHistoric);
            // _context.SaveChanges();
        }

        //Atualiza um time
        public void PutHistoric(int id, Historic upHistoric)
        {
            // var toUpHistoric = _context.Historic.Find(id);

            // toUpHistoric.Name = upHistoric.Name;
            // toUpHistoric.NameStadium = upHistoric.NameStadium;

            // _context.Historics.Update(toUpHistoric);
            // _context.SaveChanges();
        }

        //Deleta um time
        public void DeleteHistoric(int id)
        {
            var Historic = _context.Historic.Find(id);
            _context.Historic.Remove(Historic);
            _context.SaveChanges();
        }
    }
}
