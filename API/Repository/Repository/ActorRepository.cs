using Domain.Entity;
using Domain.IRepository;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class ActorRepository : BaseRepository<Actor>, IActorRepository
    {
        public ActorRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}
