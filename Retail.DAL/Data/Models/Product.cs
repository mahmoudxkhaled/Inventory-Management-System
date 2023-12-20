namespace Retail.DAL;

public class Product
{
    public Guid ID { get; set; }
    public string NAME { get; set; }
    public string DESCRIPTION { get; set; }
    public decimal PRICE { get; set; }
    public int QTY { get; set; }
    public string? PIC { get; set; }
    public Guid CATEGORY_ID { get; set; }
    public Category CATEGORY { get; set; }

}
