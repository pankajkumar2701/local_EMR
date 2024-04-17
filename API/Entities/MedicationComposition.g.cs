using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a medicationcomposition entity with essential details
    /// </summary>
    public class MedicationComposition
    {
        /// <summary>
        /// TenantId of the MedicationComposition 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the MedicationComposition 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Medication to which the MedicationComposition belongs 
        /// </summary>
        public Guid? MedicationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Medication
        /// </summary>
        [ForeignKey("MedicationId")]
        public Medication? MedicationId_Medication { get; set; }
        /// <summary>
        /// Foreign key referencing the Generic to which the MedicationComposition belongs 
        /// </summary>
        public Guid? GenericId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Generic
        /// </summary>
        [ForeignKey("GenericId")]
        public Generic? GenericId_Generic { get; set; }
        /// <summary>
        /// Strength of the MedicationComposition 
        /// </summary>
        public int? Strength { get; set; }
        /// <summary>
        /// Foreign key referencing the Uom to which the MedicationComposition belongs 
        /// </summary>
        public Guid? UomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Uom
        /// </summary>
        [ForeignKey("UomId")]
        public Uom? UomId_Uom { get; set; }
        /// <summary>
        /// PrimaryComposition of the MedicationComposition 
        /// </summary>
        public bool? PrimaryComposition { get; set; }
        /// <summary>
        /// CreatedBy of the MedicationComposition 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the MedicationComposition 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the MedicationComposition 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the MedicationComposition 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}