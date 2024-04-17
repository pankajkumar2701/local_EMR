using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a uom entity with essential details
    /// </summary>
    public class Uom
    {
        /// <summary>
        /// TenantId of the Uom 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Uom 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the Uom 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// IsDefault of the Uom 
        /// </summary>
        public bool? IsDefault { get; set; }
        /// <summary>
        /// Supportnumeric of the Uom 
        /// </summary>
        public bool? Supportnumeric { get; set; }
        /// <summary>
        /// Abbreviation of the Uom 
        /// </summary>
        public string? Abbreviation { get; set; }
        /// <summary>
        /// Flagged of the Uom 
        /// </summary>
        public bool? Flagged { get; set; }
    }
}