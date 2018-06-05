namespace Com.Wiseape.Tools.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RefreshToken")]
    public partial class RefreshToken
    {
        [Key]
        public long IdRefreshToken { get; set; }

        [StringLength(250)]
        public string ClientID { get; set; }

        [StringLength(250)]
        public string ClientSecret { get; set; }

        [StringLength(250)]
        public string AuthenticationCode { get; set; }

        [StringLength(250)]
        public string RefreshTokenString { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ExpiredDate { get; set; }
    }
}
