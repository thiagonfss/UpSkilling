using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsUPSKILLINGGAMA.Models;
using WindowsFormsUPSKILLINGGAMA.Services.Interfaces;

namespace WindowsFormsUPSKILLINGGAMA.Services
{
    public class ClienteService<T> : IBaseService<T> where T : ClienteModel
    {
        public bool Alterar(T entity)
        {
            // _persistencia.Alterar(entity);
            throw new NotImplementedException();
        }

        public bool Cadastrar(T entity)
        {
            entity.Id = 0; //_persistencia.GetNewId();
            // _persistencia.Cadastrar(entity);
            throw new NotImplementedException();
        }

        public bool Excluir(T entity)
        {
            // _persistencia.Excluir(entity);
            throw new NotImplementedException();
        }

        public bool Recuperar(T entity)
        {
            // _persistencia.Recuperar(entity);
            throw new NotImplementedException();
        }
    }
}
