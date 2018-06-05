namespace Com.Wiseape.Tools.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuthenticationSession")]
    public partial class AuthenticationSession
    {
        [Key]
        public long IdAuthenticationSession { get; set; }

        [StringLength(250)]
        public string AuthenticationSessionString { get; set; }

        [StringLength(250)]
        public string ClientID { get; set; }

        public DateTime? SessionCreatedDate { get; set; }

        public DateTime? SessionExpiredDate { get; set; }
    }
}
