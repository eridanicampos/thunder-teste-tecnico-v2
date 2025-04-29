using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunders.TechTest.Domain.Entities
{
    public class RelatorioValorHoraCidade : EntityGuid
    {
        public string Cidade { get; private set; } = null!;
        public int Hora { get; private set; }
        public decimal ValorTotal { get; private set; }
        public DateTime DataRelatorio { get; private set; }

        public RelatorioValorHoraCidade(string cidade, int hora, decimal valorTotal)
        {
            Id = Guid.NewGuid();
            Cidade = cidade;
            Hora = hora;
            ValorTotal = valorTotal;
            DataRelatorio = DateTime.UtcNow;
        }

        public override Task<(bool isValid, List<string> messages)> Validate()
        {
            throw new NotImplementedException();
        }
    }
}
