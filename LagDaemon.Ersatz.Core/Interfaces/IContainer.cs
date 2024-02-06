using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagDaemon.Ersatz.Core.Interfaces
{
    public interface IContainer
    {
        void Register(object instanct);
        void Register<Tiface, Tinst>();

    }
}
