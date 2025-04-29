using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders.TechTest.Domain.Entities;
using Thunders.TechTest.Domain.Interfaces.Commons;

namespace Thunders.TechTest.Domain.Interfaces.Repositories
{
    public interface IUtilizacaoRepository : IGenericAsyncRepository<UtilizacaoPedagio>
    {
        Task<List<RelatorioValorHoraCidade>> GetValorHoraCidadeAsync(DateTime startDate, DateTime endDate);

        Task<List<RelatorioTopPracasMes>> GetTopPracasMesAsync(int ano, int mes, int quantidadeTop);
        Task<List<RelatorioTiposVeiculosPraca>> GetTiposVeiculosPorPracaAsync(Guid pracaId);
    }
}
