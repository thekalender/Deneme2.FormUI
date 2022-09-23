using Deneme2.DataAccess;
using Deneme2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deneme2.Business
{
    public class StudentManager : IStudentDal
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        void Add(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public void Remove(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }

        void IEntityRepostory<Student>.Add(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
