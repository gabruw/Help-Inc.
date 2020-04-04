using Domain.Entity;
using Domain.IRepository;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class OfficerRepository : BaseRepository<Officer>, IOfficerRepository
    {
        public OfficerRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
    
}
