namespace Com.Wiseape.Tools.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegisteredApplication")]
    public partial class RegisteredApplication
    {
        [Key]
        public int IdApplication { get; set; }

        [StringLength(250)]
        public string ApplicationName { get; set; }

        [Column(TypeName = "text")]
        public string ApplicationDesc { get; set; }

        [StringLength(250)]
        public string ClientID { get; set; }

        [StringLength(250)]
        public string ClientSecret { get; set; }

        [Column(TypeName = "text")]
        public string AccessTokenRedirectURI { get; set; }

        [Column(TypeName ="text")]
        public string AuthorizationTokenRedirectURI { set; get; }

        public int? AuthenticationSourceId { get; set; }

        [Column(TypeName = "text")]
        public string AuthenticationSourceConnectionString { get; set; }

        [Column(TypeName = "text")]
        public string AuthenticationUrl { get; set; }


        public DateTime? CreatedDate { get; set; }

        public int? IsActive { get; set; }

        public virtual AuthenticationSource AuthenticationSource { get; set; }
    }
}
