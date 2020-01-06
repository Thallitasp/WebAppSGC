using Microsoft.EntityFrameworkCore;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SGC.Infrastructure.Repository
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        protected readonly ClienteContext DbContext;

        public EFRepository(ClienteContext dbContext)
        {
            DbContext = dbContext;
        }

        public virtual T Adicionar(T entity)
        {
            DbContext.Set<T>().Add(entity);
            DbContext.SaveChanges();
            return entity;
        }

        public virtual void Atualizar(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            DbContext.SaveChanges();
        }

        public IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado)
        {
            return DbContext.Set<T>().Where(predicado).AsEnumerable();
        }

        public virtual T ObterPorId(int id)
        {
            return DbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> ObterTodos()
        {
            return DbContext.Set<T>().AsEnumerable();
        }

        public void Remover(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            DbContext.SaveChanges();
        }
    }
}
