using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a comorbidity entity with essential details
    /// </summary>
    public class Comorbidity
    {
        /// <summary>
        /// TenantId of the Comorbidity 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Comorbidity 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the Comorbidity 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// NoKnownComorbidity of the Comorbidity 
        /// </summary>
        public bool? NoKnownComorbidity { get; set; }

        /// <summary>
        /// Required field Sequence of the Comorbidity 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// Favourite of the Comorbidity 
        /// </summary>
        public bool? Favourite { get; set; }
        /// <summary>
        /// IsDeleted of the Comorbidity 
        /// </summary>
        public bool? IsDeleted { get; set; }
    }
}