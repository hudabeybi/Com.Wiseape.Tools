namespace Com.Wiseape.Tools.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OAuthSetting")]
    public partial class OAuthSetting
    {
        [Key]
        public int IdOAuthSetting { get; set; }

        [StringLength(250)]
        public string SettingKey { get; set; }

        [Column(TypeName = "text")]
        public string SettingValue { get; set; }
    }
}
