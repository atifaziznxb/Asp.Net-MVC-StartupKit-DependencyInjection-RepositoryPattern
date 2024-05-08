using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample_Architecutre.Core.Models;


namespace Sample_Architecutre.Service.StudentService
{
    public interface IStudentService
    {
        /// <summary>
        /// Get Entity by Primary Key
        /// </summary>
        /// <param name="id">Primary Key</param>
        /// <returns></returns>
        Student GetById(int id);

        /// <summary>
        /// Insert Entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Insert(Student entity);

        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        void InsertEntities(IEnumerable<Student> entities);

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Update(Student entity);

        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        void Update(IEnumerable<Student> entities);

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Delete(Student entity);

        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities">Entities</param>
        void Delete(IEnumerable<Student> entities);
    }
}
