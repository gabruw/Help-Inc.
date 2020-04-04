using Domain.Entity;
using Domain.IRepository;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class LoginRepository : BaseRepository<LoginUser>, ILoginRepository
    {
        public LoginRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}
