using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public interface ICoreModule
    {
        //burada bagimliliklari yukleyecek
        void Load(IServiceCollection serviceCollection);
    }
}
