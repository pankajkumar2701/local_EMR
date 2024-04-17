using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a visitmode entity with essential details
    /// </summary>
    public class VisitMode
    {
        /// <summary>
        /// Default of the VisitMode 
        /// </summary>
        public bool? Default { get; set; }
        /// <summary>
        /// TenantId of the VisitMode 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the VisitMode 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the VisitMode 
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}