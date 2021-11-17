using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent.Builders
{
    interface IBuilder<T>
    {
        void Reset();
        T GetResult();
    }
}
