using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a dispenseitemdosage entity with essential details
    /// </summary>
    public class DispenseItemDosage
    {
        /// <summary>
        /// TenantId of the DispenseItemDosage 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DispenseItemDosage 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the DispenseItemDosage 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the DispenseItem to which the DispenseItemDosage belongs 
        /// </summary>
        public Guid? DispenseItemId { get; set; }

        /// <summary>
        /// Navigation property representing the associated DispenseItem
        /// </summary>
        [ForeignKey("DispenseItemId")]
        public DispenseItem? DispenseItemId_DispenseItem { get; set; }
        /// <summary>
        /// Dosage of the DispenseItemDosage 
        /// </summary>
        public int? Dosage { get; set; }
        /// <summary>
        /// Frequency of the DispenseItemDosage 
        /// </summary>
        public int? Frequency { get; set; }
        /// <summary>
        /// SingleDosage of the DispenseItemDosage 
        /// </summary>
        public bool? SingleDosage { get; set; }
        /// <summary>
        /// Duration of the DispenseItemDosage 
        /// </summary>
        public int? Duration { get; set; }
        /// <summary>
        /// Foreign key referencing the Uom to which the DispenseItemDosage belongs 
        /// </summary>
        public Guid? UomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Uom
        /// </summary>
        [ForeignKey("UomId")]
        public Uom? UomId_Uom { get; set; }
        /// <summary>
        /// Ongoing of the DispenseItemDosage 
        /// </summary>
        public bool? Ongoing { get; set; }
        /// <summary>
        /// Stat of the DispenseItemDosage 
        /// </summary>
        public bool? Stat { get; set; }
        /// <summary>
        /// Quantity of the DispenseItemDosage 
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// StartDate of the DispenseItemDosage 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the DispenseItemDosage 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Sequence of the DispenseItemDosage 
        /// </summary>
        public int? Sequence { get; set; }
        /// <summary>
        /// DosageFormType of the DispenseItemDosage 
        /// </summary>
        public int? DosageFormType { get; set; }
        /// <summary>
        /// DosageFormat of the DispenseItemDosage 
        /// </summary>
        public string? DosageFormat { get; set; }
    }
}