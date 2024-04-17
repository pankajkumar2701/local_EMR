using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a specialisation entity with essential details
    /// </summary>
    public class Specialisation
    {
        /// <summary>
        /// Primary key for the Specialisation 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the Specialisation 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the Specialisation 
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}