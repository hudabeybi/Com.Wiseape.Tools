namespace Com.Wiseape.Tools.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessToken")]
    public partial class AccessToken
    {
        [Key]
        public long IdAccessToken { get; set; }

        [StringLength(250)]
        public string AccessTokenString { get; set; }

        [StringLength(250)]
        public string RefreshToken { get; set; }

        [StringLength(250)]
        public string ClientID { get; set; }

        [StringLength(250)]
        public string ClientSecret { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public string UserID { get; set; }
    }
}
