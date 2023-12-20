using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Shared;

public class CategoryUpdateDto
{

    public Guid ID { get; set; }
    public string NAME { get; set; } = string.Empty;
    public string DESCRIPTION { get; set; } = string.Empty;

}
