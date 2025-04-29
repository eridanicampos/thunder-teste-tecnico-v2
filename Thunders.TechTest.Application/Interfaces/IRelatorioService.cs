using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders.TechTest.Application.DTOs;

namespace Thunders.TechTest.Application.Interfaces
{
    public interface IRelatorioService
    {
        Task ProcessarValorHoraCidadeAsync(DateTime? inicio, DateTime? fim);
        Task ProcessarTopPracasMesAsync(int top, int? ano, int? mes);
        Task ProcessarTiposVeiculosPracaAsync(Guid pracaId);
    }
}
