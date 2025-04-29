using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders.TechTest.Domain.Interfaces.Repositories;

namespace Thunders.TechTest.Domain.Interfaces.Commons
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();

        IUtilizacaoRepository UtilizacaoRepository { get; }
        IPracaRepository PracaRepository { get; }
        IRelatorioValorHoraCidadeRepository RelatorioValorHoraCidadeRepository { get; }
        IRelatorioTopPracasMesRepository RelatorioTopPracasMesRepository { get; }
        IRelatorioTiposVeiculosPracaRepository RelatorioTiposVeiculosPracaRepository { get; }


    }
}
