using Sample_Architecutre.Core;
using Sample_Architecutre.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Architecutre.Service.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        #region Fields

        private readonly Sample_Architecture_Context _context;
        private IDbSet<T> _entities;

        private IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }

        public IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        public IQueryable<T> TableNoTracking
        {
            get
            {
                return this.Entities.AsNoTracking();
            }
        }

        #endregion

        #region Constructor

        public GenericRepository(Sample_Architecture_Context context)
        {
            this._context = context;
        }

        #endregion

        #region Methods
        
        public T GetById(object id)
        {
            return this.Entities.Find(id);
        }

        public void Insert(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");
                this.Entities.Add(entity);
                this._context.SaveChanges();
            }
            catch(DbEntityValidationException ex)
            {
                throw new Exception(GetFullErrorText(ex),ex);
            }
        }
        
        public void InsertEntities(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");
                foreach (var entity in entities)
                    this._entities.Add(entity);
                this._context.SaveChanges();
            }
            catch(DbEntityValidationException ex)
            {
                throw new Exception(GetFullErrorText(ex), ex);
            }
        }
        
        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");
                this._context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw new Exception(GetFullErrorText(ex), ex);
            }
        }

        public void Update(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");

                this._context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }

        public void Delete(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");

                this.Entities.Remove(entity);

                this._context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }

        public void Delete(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");

                foreach (var entity in entities)
                    this.Entities.Remove(entity);

                this._context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }
        
        private string GetFullErrorText(DbEntityValidationException dbEx)
        {
            string message = string.Empty;
            foreach (var validationErrors in dbEx.EntityValidationErrors)
                foreach (var error in validationErrors.ValidationErrors)
                    message += string.Format("Property: {0} Error: {1}", error.PropertyName, error.ErrorMessage) + Environment.NewLine;
            return message;
        }

        #endregion

    }
}
