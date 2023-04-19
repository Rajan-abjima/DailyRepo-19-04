using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Library
{
    public static class TargetExtensions
    {
        static void ExtendInternal(this InternalTarget target)
        {
            //Whatever  
        }

        /*
        static void ExtendInternalProtected(this InternalTarget.ProtectedSubClass target)
        {
            //Whatever  
        }
        */

        public static string GetStandardized(this Target target)
        {
            return target.GetId().ToUpper();
        }

        
    }
}
