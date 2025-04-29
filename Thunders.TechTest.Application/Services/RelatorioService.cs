using Thunders.TechTest.Application.Interfaces;
using Thunders.TechTest.Domain.Interfaces.Commons;

namespace Thunders.TechTest.Application.Services
{
    public class RelatorioService : IRelatorioService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RelatorioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task ProcessarValorHoraCidadeAsync(DateTime? inicio, DateTime? fim)
        {
            var dataInicio = inicio ?? DateTime.Today;
            var dataFim = fim ?? DateTime.Now;

            var relatorios = await _unitOfWork.UtilizacaoRepository.GetValorHoraCidadeAsync(dataInicio, dataFim);

            await _unitOfWork.RelatorioValorHoraCidadeRepository.AddListAsync(relatorios);
            await _unitOfWork.CommitAsync();
        }

        public async Task ProcessarTopPracasMesAsync(int top, int? ano, int? mes)
        {
            var dataAno = ano ?? DateTime.Now.Year;
            var dataMes = mes ?? DateTime.Now.Month;

            var relatorios = await _unitOfWork.UtilizacaoRepository.GetTopPracasMesAsync(dataAno, dataMes, top);

            await _unitOfWork.RelatorioTopPracasMesRepository.AddListAsync(relatorios);
            await _unitOfWork.CommitAsync();
        }


        public async Task ProcessarTiposVeiculosPracaAsync(Guid pracaId)
        {
            var relatorios = await _unitOfWork.UtilizacaoRepository.GetTiposVeiculosPorPracaAsync(pracaId);

            await _unitOfWork.RelatorioTiposVeiculosPracaRepository.AddListAsync(relatorios);
            await _unitOfWork.CommitAsync();
        }

    }
}
