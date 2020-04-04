using Domain.Entity;
using Domain.IRepository;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class SkillLevelRepository : BaseRepository<SkillLevel>, ISkillLevelRepository
    {
        public SkillLevelRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}
