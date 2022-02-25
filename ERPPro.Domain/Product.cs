using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPPro.Domain
{
    public class Product
    {
        [Column("product_id")]
        [Description("ID")]
        [DisplayName("ID")]
        public int Id { get; set; }


        [Column("product_name")]
        [Description("Product Name")]
        [DisplayName("Product Name")]
        public string? Name { get; set; }


        [Column("product_description")]
        [Description("Description")]
        [DisplayName("Description")]
        public string? ProductDescription { get; set; }


        [Column("product_logo")]
        [Description("Logo")]
        [DisplayName("Logo")]
        public string? ProductLogo { get; set; }


        [Column("created_by")]
        [Description("Created By")]
        [DisplayName("Created By")]
        public string? CreatedBy { get; set; }


        [Column("row_created_date")]
        [Description("Row Created Date")]
        [DisplayName("Row Created Date")]
        public string? RowCreatedDate { get; set; }


        [Column("row_updated_date")]
        [Description("Row Updated Date")]
        [DisplayName("Row Updated Date")]
        public string? RowUpdatedDate { get; set; }
    }
}
