using System;
using System.Threading.Tasks;
using AppMvcBusiness.Models;

namespace AppMvcBusiness.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);

    }
}