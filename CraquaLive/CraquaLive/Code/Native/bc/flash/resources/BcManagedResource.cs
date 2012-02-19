using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bc.flash.resources
{
    public interface BcManagedResource : IDisposable
    {
        void Dispose();
    }
}
