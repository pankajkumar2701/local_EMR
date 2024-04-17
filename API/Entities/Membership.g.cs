using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a membership entity with essential details
    /// </summary>
    public class Membership
    {
        /// <summary>
        /// Primary key for the Membership 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the Membership 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Code of the Membership 
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Required field Name of the Membership 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// SerialNumber of the Membership 
        /// </summary>
        public int? SerialNumber { get; set; }
        /// <summary>
        /// Notes of the Membership 
        /// </summary>
        public string? Notes { get; set; }
    }
}