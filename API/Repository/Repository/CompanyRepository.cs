using Domain.Entity;
using Domain.IRepository;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}
