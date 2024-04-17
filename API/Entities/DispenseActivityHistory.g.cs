using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a dispenseactivityhistory entity with essential details
    /// </summary>
    public class DispenseActivityHistory
    {
        /// <summary>
        /// TenantId of the DispenseActivityHistory 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DispenseActivityHistory 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the DispenseActivityHistory 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Dispense to which the DispenseActivityHistory belongs 
        /// </summary>
        public Guid? DispenseId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Dispense
        /// </summary>
        [ForeignKey("DispenseId")]
        public Dispense? DispenseId_Dispense { get; set; }
        /// <summary>
        /// Step of the DispenseActivityHistory 
        /// </summary>
        public int? Step { get; set; }

        /// <summary>
        /// TransactionDate of the DispenseActivityHistory 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? TransactionDate { get; set; }
        /// <summary>
        /// TransactionBy of the DispenseActivityHistory 
        /// </summary>
        public Guid? TransactionBy { get; set; }
        /// <summary>
        /// Description of the DispenseActivityHistory 
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Active of the DispenseActivityHistory 
        /// </summary>
        public bool? Active { get; set; }
        /// <summary>
        /// Reason of the DispenseActivityHistory 
        /// </summary>
        public string? Reason { get; set; }
    }
}