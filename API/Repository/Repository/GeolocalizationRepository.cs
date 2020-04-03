using Domain.Entity;
using Domain.IRepository;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class GeolocalizationRepository : BaseRepository<Geolocalization>, IGeolocalizationRepository
    {
        public GeolocalizationRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}
