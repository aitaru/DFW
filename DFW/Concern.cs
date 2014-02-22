using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFW
{
    public class Concern
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Contact { get; set; }
        public string District { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
