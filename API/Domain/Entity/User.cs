using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class User : Actor
    {
        public long CellPhone { get; set; }
        public long Rg { get; set; }
        public long Cpf { get; set; }

    }
}
