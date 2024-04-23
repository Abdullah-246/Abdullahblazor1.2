using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdullah_Models.LearnBlazorModels
{
    public class Demo_ProductProp
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string? Name { get; set; }

        public double Price { get; set; }
        public bool IsActive { get; set; }

        public List<Demo_ProductProp> ProductProperties { get; set; }

    }
}
