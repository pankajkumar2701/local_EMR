using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a requisition entity with essential details
    /// </summary>
    public class Requisition
    {
        /// <summary>
        /// Primary key for the Requisition 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the Requisition 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// RequisitionDate of the Requisition 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RequisitionDate { get; set; }
        /// <summary>
        /// Code of the Requisition 
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Required field Name of the Requisition 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the Requisition belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// Foreign key referencing the RequisitionFile to which the Requisition belongs 
        /// </summary>
        public Guid? RequisitionFile { get; set; }

        /// <summary>
        /// Navigation property representing the associated RequisitionFile
        /// </summary>
        [ForeignKey("RequisitionFile")]
        public RequisitionFile? RequisitionFile_RequisitionFile { get; set; }
        /// <summary>
        /// StatusReason of the Requisition 
        /// </summary>
        public string? StatusReason { get; set; }
        /// <summary>
        /// CreatedBy of the Requisition 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the Requisition 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Requisition 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Requisition 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// AttachmentCount of the Requisition 
        /// </summary>
        public int? AttachmentCount { get; set; }
    }
}