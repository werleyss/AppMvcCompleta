using System.Data;
using AppMvcBusiness.Models;
using AppMvcBusiness.Validations.Documento;
using FluentValidation;

namespace AppMvcBusiness.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O Campo {PropertyName} precisa ser fornecido")
                .Length(2, 100)
                .WithMessage("O Campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () =>
                {
                    RuleFor(f => f.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                        .WithMessage("O Campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}");

                    RuleFor(f => CpfValidacao.Validar(f.Documento)).Equal(true)
                        .WithMessage("O Documento fornecido é inválido.");
                });
            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
                    .WithMessage("O Campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}");

                RuleFor(f => CnpjValidacao.Validar(f.Documento)).Equal(true)
                    .WithMessage("O Documento fornecido é inválido.");
            });
        }
    }
}