using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace niruranpieshop.Models
{
    public interface IPieRepository
    {

        IEnumerable<Pie> GetAllPies();
        Pie GetPieByID(int pieid);
    }
}
