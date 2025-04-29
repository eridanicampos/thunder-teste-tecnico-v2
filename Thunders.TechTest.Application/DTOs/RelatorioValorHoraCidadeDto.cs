using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunders.TechTest.Application.DTOs
{
    public class RelatorioValorHoraCidadeDto
    {
        public string Cidade { get; set; } = default!;
        public int Hora { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
