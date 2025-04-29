using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunders.TechTest.Application.DTOs
{
    public class RelatorioTopPracasDto
    {
        public string Praca { get; set; } = default!;
        public decimal Total { get; set; }
    }
}
