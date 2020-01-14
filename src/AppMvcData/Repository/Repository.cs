using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AppMvcBusiness.Interfaces;
using AppMvcBusiness.Models;
using AppMvcData.Context;

namespace AppMvcData.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly MeuDbContext Db;
        public Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> ObeterTodos()
        {
            throw new NotImplementedException();
        }

        public Task Adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }


        public Task Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        

        public Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}