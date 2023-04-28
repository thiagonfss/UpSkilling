using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUPSKILLINGGAMA.Services.Interfaces
{
    public interface IBaseService<T>
    {
        bool Recuperar(T entity);
        bool Cadastrar(T entity);
        bool Excluir(T entity);
        bool Alterar(T entity);
    }
}
