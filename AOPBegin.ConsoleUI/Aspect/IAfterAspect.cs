using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPBegin.ConsoleUI.Aspect
{
    public interface IAfterAspect:IAspect
    {
        object OnAfter(object value);
    }
}
