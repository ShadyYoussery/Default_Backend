using System;
using Default_Backend.Entities.Entities.Base;

namespace Default_Backend.Entities.Entities.Location
{
    public class District : BaseEntity<Guid>
    {
        #region Property

        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public Guid CityId { get; set; }
        public virtual City City { get; set; }

        #endregion Property
    }
}