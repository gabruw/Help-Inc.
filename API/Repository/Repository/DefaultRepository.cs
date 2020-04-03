using Domain.Entity;
using Domain.IRepository;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class DefaultRepository : BaseRepository<Default>, IDefaultRepository
    {
        public DefaultRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}
