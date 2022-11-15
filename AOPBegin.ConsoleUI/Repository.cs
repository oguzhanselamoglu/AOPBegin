using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AOPBegin.ConsoleUI
{
    public class Repository
    {
        public G Run<T, G>(Expression<Func<T, G>> expression) where T : class where G: class
        {
            var instance = Activator.CreateInstance<T>();
            var action = expression.Compile();
            
            return action(instance);
        }
    }

    
}
