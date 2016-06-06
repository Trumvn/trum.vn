using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trumvn
{
    public interface IDbContextProvider<out TDbContext>
    {
        TDbContext DbContext { get; }
    }
}
