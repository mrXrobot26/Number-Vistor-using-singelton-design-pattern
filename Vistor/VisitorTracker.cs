using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vistor
{
    public class VisitorTracker
    {
        private static VisitorTracker _vistor;
        private static int visitorCount;

        private VisitorTracker()
        {
            visitorCount = 0;
        }

        public static VisitorTracker GetInstance()
        {
         
                if (_vistor == null)
                {
                    _vistor = new VisitorTracker();
                }
                visitorCount++;
                return _vistor;
        }

        public int GetVisitorCount()
        {
            return visitorCount;
        }
    }

}
