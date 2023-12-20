using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Shared;

public class ProductUpdateDto
{

    public Guid ID { get; set; }
    public string NAME { get; set; }
    public string DESCRIPTION { get; set; }
    public decimal PRICE { get; set; }
    public int QTY { get; set; }
    public Guid CATEGORY_ID { get; set; }
}
