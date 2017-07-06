namespace Starsea.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BASE_ACCOUNT
    {
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(100)]
        public string ACCOUNT { get; set; }

        [StringLength(100)]
        public string PASSWORD { get; set; }

        [StringLength(100)]
        public string PERSONNAME { get; set; }

        public decimal? AGE { get; set; }

        [StringLength(10)]
        public string SEX { get; set; }
    }
}
