using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp22
{
    public class BaseModel
    {
        public string Code { get; set; }
    }

    public class NameModel : BaseModel
    {
        public string Name { get; set; }
    }
}
