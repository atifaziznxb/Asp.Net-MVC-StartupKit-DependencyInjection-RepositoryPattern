using Sample_Architecutre.Core.Models;
using Sample_Architecutre.Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Architecutre.Service.StudentService
{
    public class StudentService : IStudentService
    {
        #region Fields

        private IGenericRepository<Student> _studentRepo;

        #endregion

        #region Constructor

        public StudentService(IGenericRepository<Student> studentRepo)
        {
            this._studentRepo = studentRepo;
        }

        #endregion

        #region Methods

        public Student GetById(int id)
        {
            return _studentRepo.GetById(id);
        }

        public void Insert(Student entity)
        {
            _studentRepo.Insert(entity);
        }

        public void Update(Student entity)
        {
            _studentRepo.Update(entity);
        }

        public void Update(IEnumerable<Student> entities)
        {
            _studentRepo.Update(entities);
        }

        public void Delete(Student entity)
        {
            _studentRepo.Delete(entity);
        }

        public void Delete(IEnumerable<Student> entities)
        {
            _studentRepo.Delete(entities);
        }
        
        public void InsertEntities(IEnumerable<Student> entities)
        {
            _studentRepo.InsertEntities(entities);
        }

        public List<Student> GetAll()
        {
            return new List<Student>(); ;
        }

        #endregion

    }
}
