using System;
using System.Threading.Tasks;
using AppMvcBusiness.Models;

namespace AppMvcBusiness.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutoEndereco(Guid id);
    }
}