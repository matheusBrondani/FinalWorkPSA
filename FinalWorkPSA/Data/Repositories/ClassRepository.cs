using FinalWorkPSA.Models.Entities;
using FinalWorkPSA.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace FinalWorkPSA.Data.Repositories
{
    public class ClassRepository
    {
        private readonly RegistryContext _context;

        public ClassRepository(RegistryContext context) {
            _context = context;
        }

        //Retorna todos os times do contexto
        public List<Class> GetAllClass()
        {
            return _context.Class.ToList();
        }

        //Retorna o time vinculado ao ID
        public Class GetClassById(int id)
        {
            return _context.Class.Find(id);
        }

        //Insere um time novo
        public void PostClass(Class newClass)
        {
            // newClass.IdClass = _context.Class.Max(p => p.IdClass) + 1;

            // _context.Class.Add(newClass);
            // _context.SaveChanges();
        }

        //Atualiza um time
        public void PutClass(int id, Class upClass)
        {
            // var toUpClass = _context.Class.Find(id);

            // toUpClass.Name = upClass.Name;
            // toUpClass.NameStadium = upClass.NameStadium;

            // _context.Classs.Update(toUpClass);
            // _context.SaveChanges();
        }

        //Deleta um time
        public void DeleteClass(int id)
        {
            var Class = _context.Class.Find(id);
            _context.Class.Remove(Class);
            _context.SaveChanges();
        }
    }
}
