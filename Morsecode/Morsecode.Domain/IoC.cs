using Microsoft.Extensions.DependencyInjection;
using Morsecode.Domain.CodeReader;
using Morsecode.Domain.CodeSplitter;
using Morsecode.Domain.Translator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Morsecode.Domain
{
    public class IoC
    {

        private static IServiceProvider _container;
        public static IServiceProvider Container
        {
            get
            {
                if (_container == null)
                { _container = BuildDefaultServiceCollection().BuildServiceProvider(); }
                return _container;
            }
        }

        private static ServiceCollection BuildDefaultServiceCollection()
        {
            var services = new ServiceCollection();

            services.AddSingleton<ITranslator, DefaultTranslator>();
            services.AddSingleton<ISplitter, DefaultSplitter>();
            services.AddSingleton<ICodeReader, DefaultCodeReader>();

            return services;
        }
    }
}



