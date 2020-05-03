using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Geolocalization : Default
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (Latitude.ToString().Length < 1)
            {
                AddError("O campo latitude não foi informado.");
            }

            if (Longitude.ToString().Length < 1)
            {
                AddError("O campo longitude não foi informado.");
            }
        }
    }
}