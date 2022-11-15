using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPBegin.ConsoleUI.Aspect
{
   public interface IAfterVoidAspect:IAspect
    {
        void OnAfter(object value);
    }
}
