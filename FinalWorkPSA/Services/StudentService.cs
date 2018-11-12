using System;
using System.Collections.Generic;
using System.Linq;
using FinalWorkPSA.Data.Repositories;
using FinalWorkPSA.Models.Entities;

namespace FinalWorkPSA.Services
{
    public class StudentService
    {
        private readonly StudentRepository Repository;
        //private readonly PlayerRepository PlayerRepository;

        public StudentService(StudentRepository _Repository)
        {
            Repository = _Repository;
        }

        public List<Student> GetAllStudentWithPlayers()
        {
            //TODO
            //Listar corretamente as turmas 
            var listStudent = Repository.GetAllStudent();

            //foreach (var c in listClass)
            //{
            //    c.ListPlayers = PlayerRepository.GetAllPlayers().Where(p => p.IdTeam == team.IdTeam);
            //}

            return Repository.GetAllStudent();
        }

        public List<Student> GetAllStudent()
        {
            return Repository.GetAllStudent();
        }

        public Student GetClassById(int id)
        {
            return Repository.GetStudentById(id);
        }

        public void PostStudent(Student newStudent)
        {
            Repository.PostStudent(newStudent);
        }

        public void PutStudent(int id, Student upStudent)
        {
            Repository.PutStudent(id, upStudent);
        }

        public void DeleteStudent(int id)
        {
            Repository.DeleteStudent(id);
        }
    }
}