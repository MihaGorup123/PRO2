using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KličiMe
{
    internal class TajniAgentException:ApplicationException
    {
        public TajniAgentException(string sporočilo):base(sporočilo)
        {
        }
        public TajniAgentException(string sporočilo, Exception notranja) :
            base(sporočilo, notranja)
        {
        }
    }
}
