using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a gstsettings entity with essential details
    /// </summary>
    public class GstSettings
    {
        /// <summary>
        /// TenantId of the GstSettings 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the GstSettings 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the GstSettings 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Category of the GstSettings 
        /// </summary>
        public string? Category { get; set; }
        /// <summary>
        /// Rate of the GstSettings 
        /// </summary>
        public int? Rate { get; set; }
        /// <summary>
        /// CreatedBy of the GstSettings 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the GstSettings 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the GstSettings 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the GstSettings 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}