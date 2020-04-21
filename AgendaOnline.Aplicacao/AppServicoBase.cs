using AgendaOnline.Aplicacao.Interface;
using AgendaOnline.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace AgendaOnline.Aplicacao
{
    public class AppServicoBase<TEntity> : IDisposable, IAppServicoBase<TEntity> where TEntity : class
    {
        private readonly IServicoBase<TEntity> _ServicoBase;
        public AppServicoBase(IServicoBase<TEntity> ServicoBase)
        {
            _ServicoBase = ServicoBase;
        }

        public void Add(TEntity obj)
        {
            _ServicoBase.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _ServicoBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _ServicoBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _ServicoBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _ServicoBase.Update(obj);
        }

        public void Dispose()
        {
            _ServicoBase.Dispose();
        }

    }
}
