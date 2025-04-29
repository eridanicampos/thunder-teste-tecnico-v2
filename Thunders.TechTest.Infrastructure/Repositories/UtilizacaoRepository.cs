using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders.TechTest.Domain.Entities;
using Thunders.TechTest.Domain.Interfaces.Commons;
using Thunders.TechTest.Domain.Interfaces.Repositories;
using Thunders.TechTest.Infrastructure.Data;
using Thunders.TechTest.Infrastructure.Repositories.Commons;

namespace Thunders.TechTest.Infrastructure.Repositories
{
    public class UtilizacaoRepository : GenericAsyncRepository<UtilizacaoPedagio>, IUtilizacaoRepository
    {
        public UtilizacaoRepository(PedagioDbContext _dbContext) : base(_dbContext)
        {
        }

        public async Task<List<RelatorioValorHoraCidade>> GetValorHoraCidadeAsync(DateTime startDate, DateTime endDate)
        {
            return await DbSet
                            .Where(u => u.DataHoraUtilizacao >= startDate && u.DataHoraUtilizacao <= endDate)
                            .GroupBy(x => new { x.Praca.Cidade, Hora = x.DataHoraUtilizacao.Hour })
                            .Select(g => new RelatorioValorHoraCidade(
                                g.Key.Cidade,   
                                g.Key.Hora,  
                                g.Sum(x => x.ValorPago)
                            ))
                            .ToListAsync();
        }

        public async Task<List<RelatorioTopPracasMes>> GetTopPracasMesAsync(int ano, int mes, int quantidadeTop)
        {
            return await DbSet
                .Where(x => x.DataHoraUtilizacao.Year == ano && x.DataHoraUtilizacao.Month == mes)
                .GroupBy(x => x.Praca.Nome)
                .Select(g => new RelatorioTopPracasMes(
                     g.Key,
                     g.Sum(x => x.ValorPago),
                     ano,
                     mes
                ))
                .OrderByDescending(r => r.ValorTotal)
                .Take(quantidadeTop)
                .ToListAsync();
        }

        public async Task<List<RelatorioTiposVeiculosPraca>> GetTiposVeiculosPorPracaAsync(Guid pracaId)
        {
            var utilizacoes = await DbSet
                .Include(x => x.Praca)
                .Where(x => x.PracaId == pracaId)
                .ToListAsync();

            if (!utilizacoes.Any())
                return new List<RelatorioTiposVeiculosPraca>();

            var nomePraca = utilizacoes.First().Praca.Nome;

            return utilizacoes
                .GroupBy(x => x.TipoVeiculo.ToString())
                .Select(g => new RelatorioTiposVeiculosPraca(
                    nomePraca: nomePraca,
                    tipoVeiculo: g.Key,
                    quantidade: g.Count()
                ))
                .ToList();
        }


    }
}
