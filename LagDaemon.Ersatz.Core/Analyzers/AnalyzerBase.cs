using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagDaemon.Ersatz.Core.Analyzers
{
    public class AnalyzerBase<T> where T : class
    {
        readonly Type type;
        public AnalyzerBase() 
        { 
            type = typeof(T);
        }

        public Type Type => type;
    }
}
