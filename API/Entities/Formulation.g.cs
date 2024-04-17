using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a formulation entity with essential details
    /// </summary>
    public class Formulation
    {
        /// <summary>
        /// TenantId of the Formulation 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Formulation 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the Formulation 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Required field Sequence of the Formulation 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
    }
}