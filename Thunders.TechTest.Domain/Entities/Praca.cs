using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders.TechTest.Domain.Enum;

namespace Thunders.TechTest.Domain.Entities
{
    public class Praca : EntityGuid
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Cidade { get; private set; }
        public EEstado Estado { get; private set; }

        public override Task<(bool isValid, List<string> messages)> Validate()
        {
            throw new NotImplementedException();
        }
    }
}
