using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a goodsreceiptfile entity with essential details
    /// </summary>
    public class GoodsReceiptFile
    {
        /// <summary>
        /// Primary key for the GoodsReceiptFile 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the GoodsReceiptFile 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the GoodsReceiptFile 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReceipt to which the GoodsReceiptFile belongs 
        /// </summary>
        public Guid? GoodsReceiptId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceipt
        /// </summary>
        [ForeignKey("GoodsReceiptId")]
        public GoodsReceipt? GoodsReceiptId_GoodsReceipt { get; set; }
        /// <summary>
        /// GoodsReceiptCode of the GoodsReceiptFile 
        /// </summary>
        public string? GoodsReceiptCode { get; set; }
        /// <summary>
        /// Title of the GoodsReceiptFile 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// FileName of the GoodsReceiptFile 
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// FileExtension of the GoodsReceiptFile 
        /// </summary>
        public string? FileExtension { get; set; }
        /// <summary>
        /// MimeType of the GoodsReceiptFile 
        /// </summary>
        public string? MimeType { get; set; }
        /// <summary>
        /// AzureFilePath of the GoodsReceiptFile 
        /// </summary>
        public string? AzureFilePath { get; set; }
        /// <summary>
        /// CreatedBy of the GoodsReceiptFile 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the GoodsReceiptFile 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Print of the GoodsReceiptFile 
        /// </summary>
        public bool? Print { get; set; }
    }
}