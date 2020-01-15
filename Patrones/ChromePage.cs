using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    class ChromePage
    {
        ISearchStrategy searchStrategy;
        public void Search(string searchFor)
        {
            searchStrategy.Search(searchFor);
        }

    }
}
