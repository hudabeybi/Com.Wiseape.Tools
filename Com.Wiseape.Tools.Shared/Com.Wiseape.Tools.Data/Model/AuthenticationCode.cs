namespace Com.Wiseape.Tools.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuthenticationCode")]
    public partial class AuthenticationCode
    {
        [Key]
        public long IdAuthenticationCode { get; set; }

        [StringLength(250)]
        public string AuthenticationCodeString { get; set; }

        [StringLength(250)]
        public string ClientID { get; set; }

        [StringLength(250)]
        public string AuthorizationSessionID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public string UserID { get; set; }
    }
}
