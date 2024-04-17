using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a title entity with essential details
    /// </summary>
    public class Title
    {
        /// <summary>
        /// Primary key for the Title 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the Title 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the Title 
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}