using Minha1Conexao.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minha1Conexao.Data.Repository.Base
{
   public  class BaseRepositorio<T> where T : class, IEntity
    {
        protected readonly Contexto contexto;

        public BaseRepositorio() {
            contexto = new Contexto();
        }
        public void Incluir(T entity)
        {
            contexto.Set<T>().Add(entity);
            contexto.SaveChanges();
        }

        public T Selecionar(Guid id)
        {
            return contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> SelecionarTudo()
        {
            return contexto.Set<T>();
        }

        public void Alterar(T entity)
        {
            contexto.Set<T>().Update(entity);
            contexto.SaveChanges();
        }

        public void Excluir(Guid id)
        {
            var entity = Selecionar(id);
            if (entity != null)
                contexto.Set<T>().Remove(entity);
            contexto.SaveChanges();
        }
    }
}
