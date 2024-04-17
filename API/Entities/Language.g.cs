using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a language entity with essential details
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Primary key for the Language 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the Language 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the Language 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Code of the Language 
        /// </summary>
        public string? Code { get; set; }
    }
}