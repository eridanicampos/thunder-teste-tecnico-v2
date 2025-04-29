using Rebus.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders.TechTest.Application.Interfaces;
using Thunders.TechTest.Application.Messages;

namespace Thunders.TechTest.Application.Handlers
{
    public class TopPracasMesHandler : IHandleMessages<ProcessarTopPracasMesMessage>
    {
        private readonly IRelatorioService _relatorioService;

        public TopPracasMesHandler(IRelatorioService relatorioService)
        {
            _relatorioService = relatorioService;
        }

        public async Task Handle(ProcessarTopPracasMesMessage message)
        {
            await _relatorioService.ProcessarTopPracasMesAsync(message.QuantidadeTop, message.Ano, message.Mes);
        }
    }
}
