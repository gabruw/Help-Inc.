using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Company : Actor
    {
        public string TraddingName { get; set; }
        public long Cnpj { get; set; }
    }
}
