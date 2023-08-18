using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Entites
{
    public class BusinessPartner : EntityBase
    {
        public string? Name { get; set; }
        public override string ToString() => $"Id: {Id}, FirstName{Name}";
    }
}
