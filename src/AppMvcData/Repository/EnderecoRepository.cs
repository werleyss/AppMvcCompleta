using System;
using System.Threading.Tasks;
using AppMvcBusiness.Interfaces;
using AppMvcBusiness.Models;
using AppMvcData.Context;
using Microsoft.EntityFrameworkCore;

namespace AppMvcData.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context){}

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking().FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
        
    }
}