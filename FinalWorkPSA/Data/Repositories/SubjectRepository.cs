using FinalWorkPSA.Models.Entities;
using FinalWorkPSA.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace CopaStefaniniBackEnd.Data.Repositories
{
    public class SubjectRepository
    {
        private readonly RegistryContext _context;

        public SubjectRepository(RegistryContext context) {
            _context = context;
        }

        //Retorna todos os times do contexto
        public List<Subject> GetAllSubject()
        {
            return _context.Subject.ToList();
        }

        //Retorna o time vinculado ao ID
        public Subject GetSubjectById(int id)
        {
            return _context.Subject.Find(id);
        }

        //Insere um time novo
        public void PostSubject(Subject newSubject)
        {
            // newSubject.IdSubject = _context.Subject.Max(p => p.IdSubject) + 1;

            // _context.Subject.Add(newSubject);
            // _context.SaveChanges();
        }

        //Atualiza um time
        public void PutSubject(int id, Subject upSubject)
        {
            // var toUpSubject = _context.Subject.Find(id);

            // toUpSubject.Name = upSubject.Name;
            // toUpSubject.NameStadium = upSubject.NameStadium;

            // _context.Subjects.Update(toUpSubject);
            // _context.SaveChanges();
        }

        //Deleta um time
        public void DeleteSubject(int id)
        {
            var Subject = _context.Subject.Find(id);
            _context.Subject.Remove(Subject);
            _context.SaveChanges();
        }
    }
}
