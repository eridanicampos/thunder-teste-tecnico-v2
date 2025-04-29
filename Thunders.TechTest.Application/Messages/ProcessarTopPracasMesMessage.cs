using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunders.TechTest.Application.Messages
{
    public record ProcessarTopPracasMesMessage(int QuantidadeTop = 5, int? Ano = null, int? Mes = null);

}
