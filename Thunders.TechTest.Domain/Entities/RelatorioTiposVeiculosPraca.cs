using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunders.TechTest.Domain.Entities
{
    public class RelatorioTiposVeiculosPraca : EntityGuid
    {
        public string NomePraca { get; private set; } = null!;
        public string TipoVeiculo { get; private set; } = null!;
        public int Quantidade { get; private set; }
        public DateTime DataRelatorio { get; private set; }

        public RelatorioTiposVeiculosPraca(string nomePraca, string tipoVeiculo, int quantidade)
        {
            Id = Guid.NewGuid();
            NomePraca = nomePraca;
            TipoVeiculo = tipoVeiculo;
            Quantidade = quantidade;
            DataRelatorio = DateTime.UtcNow;
        }

        public override Task<(bool isValid, List<string> messages)> Validate()
        {
            throw new NotImplementedException();
        }
    }
}
