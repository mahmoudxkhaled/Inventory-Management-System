namespace Retail.Shared;

public class ProductDto
{
    public Guid ID { get; set; }
    public string NAME { get; set; }
    public string? PIC { get; set; }
    public string DESCRIPTION { get; set; }
    public decimal PRICE { get; set; }
    public int QTY { get; set; }
    public Guid CATEGORY_ID { get; set; }
    public string? CATEGORY_NAME { get; set; }
    public string? CATEGORY_DESCRIPTION { get; set; }

}
