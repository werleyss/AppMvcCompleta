using System;
using System.Threading.Tasks;
using AppMvcBusiness.Models;

namespace AppMvcBusiness.Interfaces
{
    public interface IProdutoService
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}