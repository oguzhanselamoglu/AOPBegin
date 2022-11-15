using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPBegin.ConsoleUI.Aspect.Attributes
{
    public class LogAttribute : AspectBase, IBeforeVoidAspect, IAfterVoidAspect
    {
        public void OnAfter(object value)
        {
            // sonrasında log tutmak istenirse.
        }

        public void OnBefore()
        {
            StringBuilder sbLogMessage = new StringBuilder();

            sbLogMessage.AppendLine(string.Format("Method Name: {0}", AspectContext.Instance.MethodName));
            sbLogMessage.AppendLine(string.Format("Arguments: {0}", string.Join(",", AspectContext.Instance.Arguments)));

            // log işlemini gerçekleştir.
            Console.WriteLine("Loging: {0}", sbLogMessage.ToString());
        }
    }
}
