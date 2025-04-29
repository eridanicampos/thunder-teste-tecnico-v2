using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders.TechTest.Domain.Interfaces.Commons;
using Thunders.TechTest.Domain.Interfaces.Repositories;
using Thunders.TechTest.Infrastructure.Data;

namespace Thunders.TechTest.Infrastructure.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly PedagioDbContext _context;
        private readonly IServiceProvider _services;
        private bool _disposed = false;

        public UnitOfWork(PedagioDbContext context, IServiceProvider services)
        {
            _context = context;
            _services = services;
        }

        public IUtilizacaoRepository UtilizacaoRepository => _services.GetRequiredService<IUtilizacaoRepository>();
        public IPracaRepository PracaRepository => _services.GetRequiredService<IPracaRepository>();
        public IRelatorioValorHoraCidadeRepository RelatorioValorHoraCidadeRepository => _services.GetRequiredService<IRelatorioValorHoraCidadeRepository>();
        public IRelatorioTopPracasMesRepository RelatorioTopPracasMesRepository => _services.GetRequiredService<IRelatorioTopPracasMesRepository>();
        public IRelatorioTiposVeiculosPracaRepository RelatorioTiposVeiculosPracaRepository => _services.GetRequiredService<IRelatorioTiposVeiculosPracaRepository>();

        public async Task CommitAsync()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(UnitOfWork));

            await _context.SaveChangesAsync();
        }

        public void Commit()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(UnitOfWork));

            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context?.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
