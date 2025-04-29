using Microsoft.AspNetCore.Mvc;
using Thunders.TechTest.Application.Messages;
using Thunders.TechTest.OutOfBox.Queues;

namespace Thunders.TechTest.ApiService.Controllers
{
    [ApiController]
    [Route("api/relatorios")]
    public class RelatorioController : ControllerBase
    {
        private readonly IMessageSender _messageSender;

        public RelatorioController(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        [HttpPost("valor-hora-cidade")]
        public async Task<IActionResult> ProcessarValorHoraCidade([FromQuery] DateTime? inicio, [FromQuery] DateTime? fim)
        {
            var message = new ProcessarValorHoraCidadeMessage(inicio, fim);
            await _messageSender.SendLocal(message);

            return Accepted("Processamento do relatório de valor por hora e cidade iniciado.");
        }

        [HttpPost("top-pracas-mes")]
        public async Task<IActionResult> ProcessarTopPracasMes([FromQuery] int quantidadeTop = 5, [FromQuery] int? ano = null, [FromQuery] int? mes = null)
        {
            var message = new ProcessarTopPracasMesMessage(quantidadeTop, ano, mes);
            await _messageSender.SendLocal(message);

            return Accepted("Processamento do relatório de top praças iniciado.");
        }

        [HttpPost("tipos-veiculos-praca/{pracaId}")]
        public async Task<IActionResult> ProcessarTiposVeiculosPraca([FromRoute] Guid pracaId)
        {
            var message = new ProcessarTiposVeiculosPracaMessage(pracaId);
            await _messageSender.SendLocal(message);

            return Accepted("Processamento do relatório de tipos de veículos por praça iniciado.");
        }
    }
}
