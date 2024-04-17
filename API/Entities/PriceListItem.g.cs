using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a pricelistitem entity with essential details
    /// </summary>
    public class PriceListItem
    {
        /// <summary>
        /// TenantId of the PriceListItem 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PriceListItem 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the PriceListItem 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the PriceList to which the PriceListItem belongs 
        /// </summary>
        public Guid? PriceListId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PriceList
        /// </summary>
        [ForeignKey("PriceListId")]
        public PriceList? PriceListId_PriceList { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the PriceListItem belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// Price of the PriceListItem 
        /// </summary>
        public int? Price { get; set; }
        /// <summary>
        /// MarkUpMarkDownValue of the PriceListItem 
        /// </summary>
        public int? MarkUpMarkDownValue { get; set; }
        /// <summary>
        /// MarkUpMarkDownUnit of the PriceListItem 
        /// </summary>
        public int? MarkUpMarkDownUnit { get; set; }
        /// <summary>
        /// Modified of the PriceListItem 
        /// </summary>
        public bool? Modified { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductUom to which the PriceListItem belongs 
        /// </summary>
        public Guid? ProductUomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductUom
        /// </summary>
        [ForeignKey("ProductUomId")]
        public ProductUom? ProductUomId_ProductUom { get; set; }
        /// <summary>
        /// BasePrice of the PriceListItem 
        /// </summary>
        public int? BasePrice { get; set; }
    }
}