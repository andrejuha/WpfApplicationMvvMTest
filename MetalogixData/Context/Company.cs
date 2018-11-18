namespace MetalogixData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        public int Id { get; set; }

        public int? Company_Type { get; set; }

        public int? Country_Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual Company_Type Company_Type1 { get; set; }
    }
}
