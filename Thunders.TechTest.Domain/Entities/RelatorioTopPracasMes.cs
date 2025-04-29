using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunders.TechTest.Domain.Entities
{
    public class RelatorioTopPracasMes : EntityGuid
    {
        public string NomePraca { get; private set; } = null!;
        public decimal ValorTotal { get; private set; }
        public int Ano { get; private set; }
        public int Mes { get; private set; }
        public DateTime DataRelatorio { get; private set; }

        public RelatorioTopPracasMes(string nomePraca, decimal valorTotal, int ano, int mes)
        {
            Id = Guid.NewGuid();
            NomePraca = nomePraca;
            ValorTotal = valorTotal;
            Ano = ano;
            Mes = mes;
            DataRelatorio = DateTime.UtcNow;
        }

        public override Task<(bool isValid, List<string> messages)> Validate()
        {
            throw new NotImplementedException();
        }
    }
}
