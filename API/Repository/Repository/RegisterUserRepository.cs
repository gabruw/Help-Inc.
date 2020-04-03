using Domain.Entity;
using Domain.IRepository;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class RegisterUserRepository : BaseRepository<RegisterUser>, IRegisterRepository
    {
        public RegisterUserRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}
