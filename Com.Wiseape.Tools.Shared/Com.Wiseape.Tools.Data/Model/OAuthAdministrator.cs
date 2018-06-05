namespace Com.Wiseape.Tools.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OAuthAdministrator")]
    public partial class OAuthAdministrator
    {
        [Key]
        public int IdAdmin { get; set; }

        [StringLength(50)]
        public string AdminUsername { get; set; }

        [StringLength(250)]
        public string AdminPassword { get; set; }
    }
}
