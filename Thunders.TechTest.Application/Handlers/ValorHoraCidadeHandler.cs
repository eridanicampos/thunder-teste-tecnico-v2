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
    public class ValorHoraCidadeHandler : IHandleMessages<ProcessarValorHoraCidadeMessage>
    {
        private readonly IRelatorioService _relatorioService;

        public ValorHoraCidadeHandler(IRelatorioService relatorioService)
        {
            _relatorioService = relatorioService;
        }

        public async Task Handle(ProcessarValorHoraCidadeMessage message)
        {
            await _relatorioService.ProcessarValorHoraCidadeAsync(message.DataInicio, message.DataFim);
        }
    }
}
