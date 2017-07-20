using EFatura.Core.EntityBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EFatura.Core.RepositoryBase.EntityFramework
{
    public class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity> where TEntity : BaseEntity, new() //class, IEntity
                                                                            where TContext : DbContext, new()
    {

        private TContext _context;


        public EFRepositoryBase(TContext context)
        {
            _context = context;
        }


        public TEntity Add(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Added;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //LOOK HERE
                return null; //Unsuccesfull add, returns null
            }

            return entity; //If its succesfully added it will be the added entity
        }

        public bool AddMore(params TEntity[] entities)
        {
            bool isAdded;

            try
            {
                _context.Set<TEntity>().AddRange(entities);
                _context.SaveChanges();
                isAdded = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isAdded = false; //Unsuccesfull add, returns false
            }

            return isAdded; //If Entity List is successfully added, returns true 
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter != null)
                return _context.Set<TEntity>().SingleOrDefault(filter);
            else
                return null;
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter != null)
                return _context.Set<TEntity>().Where(filter).ToList();
            else
                return null;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public bool Update(TEntity entity)
        {
            bool isUpdated;
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();

                isUpdated = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //LOOK HERE
                isUpdated = false;
            }

            return isUpdated; //returns true if its successfully added, if not returns false
        }

        public TEntity Delete(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; //Unsuccessfull update, returns null
            }

            return entity; //When the entity is successfully added
        }

        public long GetMaxID()
        {
            try
            {
                return _context.Set<TEntity>().Max(q => q.ID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1L; //If there is no record, it will return -1
            };
        }




        /*--------- ASYNC METHOD IMPLEMENTATIONS ----------*/

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Added;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; //Unsuccesfull add, returns null
            }

            return entity; //Succesfully added, returns entity
        }

        public async Task<bool> AddMoreAsync(params TEntity[] entities)
        {
            bool isAdded;

            try
            {
                await _context.Set<TEntity>().AddRangeAsync(entities);
                await _context.SaveChangesAsync();

                isAdded = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isAdded = false;
            }

            return isAdded; //Unsuccessfull add returns false, successfull add returns true
        }

        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter != null)
                return await _context.Set<TEntity>().SingleOrDefaultAsync(filter);
            else
                return null;
        }

        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter != null)
                return await _context.Set<TEntity>().Where(filter).ToListAsync();
            else
                return null;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            bool isUpdated;

            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                isUpdated = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isUpdated = false;
            }

            return isUpdated; //returns true when the entity was successfully updated, otherwise returns false
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; //if the deletion was failed, the method is returned null
            }

            return entity; //returns entity if the process is successfull
        }

        public async Task<long> GetMaxIDAsync()
        {
            try
            {
                return await _context.Set<TEntity>().MaxAsync(q => q.ID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1L; //If there is no record, it will return -1
            }
        }
    }
}
