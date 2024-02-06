using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagDaemon.Ersatz.Core.Analyzers
{
    public class Class<T> : AnalyzerBase<T> where T : class
    {
        public Class() : base()
        {
        }
    }
}
