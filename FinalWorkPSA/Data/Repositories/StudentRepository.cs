using FinalWorkPSA.Models.Entities;
using FinalWorkPSA.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace CopaStefaniniBackEnd.Data.Repositories
{
    public class StudentRepository
    {
        private readonly RegistryContext _context;

        public StudentRepository(RegistryContext context) {
            _context = context;
        }

        //Retorna todos os times do contexto
        public List<Student> GetAllStudent()
        {
            return _context.Student.ToList();
        }

        //Retorna o time vinculado ao ID
        public Student GetStudentById(int id)
        {
            return _context.Student.Find(id);
        }

        //Insere um time novo
        public void PostStudent(Student newStudent)
        {
            // newStudent.IdStudent = _context.Student.Max(p => p.IdStudent) + 1;

            // _context.Student.Add(newStudent);
            // _context.SaveChanges();
        }

        //Atualiza um time
        public void PutStudent(int id, Student upStudent)
        {
            // var toUpStudent = _context.Student.Find(id);

            // toUpStudent.Name = upStudent.Name;
            // toUpStudent.NameStadium = upStudent.NameStadium;

            // _context.Students.Update(toUpStudent);
            // _context.SaveChanges();
        }

        //Deleta um time
        public void DeleteStudent(int id)
        {
            var Student = _context.Student.Find(id);
            _context.Student.Remove(Student);
            _context.SaveChanges();
        }
    }
}
