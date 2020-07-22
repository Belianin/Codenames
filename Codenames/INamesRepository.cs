using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codenames
{
    interface INamesRepository
    {
        IEnumerable<Name> GetByDate(DateTime dateTime);
    }
}
