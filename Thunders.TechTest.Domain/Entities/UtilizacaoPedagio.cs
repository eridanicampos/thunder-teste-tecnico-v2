using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders.TechTest.Domain.Enum;

namespace Thunders.TechTest.Domain.Entities
{
    public class UtilizacaoPedagio : EntityGuid
    {
        public DateTime DataHoraUtilizacao { get; set; }
        public virtual Guid PracaId { get; set; }
        public virtual Praca Praca { get; set; }
        public decimal ValorPago { get; set; }
        public ETipoVeiculo TipoVeiculo { get; set; }

        public override Task<(bool isValid, List<string> messages)> Validate()
        {
            throw new NotImplementedException();
        }
    }
}
