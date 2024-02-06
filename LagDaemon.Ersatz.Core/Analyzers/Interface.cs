using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagDaemon.Ersatz.Core.Analyzers
{
    public class Interface<T> : AnalyzerBase<T> where T : class
    {
        public Interface() : base()
        {
        }

    }
}
