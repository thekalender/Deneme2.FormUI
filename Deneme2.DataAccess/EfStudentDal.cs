using Deneme2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deneme2.DataAccess
{
    public class EfStudentDal : IStudentDal
    {
        public List<Student> students;

        public EfStudentDal()
        {
            students = new List<Student>
            {
                new Student{Id=101, FirstName="Ali Ef", LastName="Kalender"},
                new Student{Id=102, FirstName="Talat Ef", LastName="Gem"},
                new Student{Id=103, FirstName="Yusuf Ef", LastName="Sarı"},
            };
        }
       
        public List<Student> GetAll()
        {
            return students;
        }

        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public void Remove(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
