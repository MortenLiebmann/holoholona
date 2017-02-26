using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holoholona.Models
{
    interface IAnimal
    {
        int Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
    }
}
