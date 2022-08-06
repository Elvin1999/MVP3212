using MVP3212.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP3212.Data
{
    public class CarContext:DbContext
    {
        public CarContext():base("CarDb")
        {
        }
        public DbSet<Car> Cars { get; set; }
    }
}
