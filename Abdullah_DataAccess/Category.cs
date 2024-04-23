using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdullah_DataAccess
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedData { get; set; }
    }
}
