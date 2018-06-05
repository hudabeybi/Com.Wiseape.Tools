namespace Com.Wiseape.Tools.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuthenticationSource")]
    public partial class AuthenticationSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AuthenticationSource()
        {
            RegisteredApplications = new HashSet<RegisteredApplication>();
        }

        [Key]
        public int IdAuthenticationSource { get; set; }

        [StringLength(250)]
        public string AuthenticationSourceName { get; set; }

        [Column(TypeName = "text")]
        public string AuthenticationLibrary { get; set; }

        [StringLength(250)]
        public string AuthenticationClassname { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegisteredApplication> RegisteredApplications { get; set; }
    }
}
