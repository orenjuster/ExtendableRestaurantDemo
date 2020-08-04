using Castle.Windsor;
using ExtensibleRestaurant.Api;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ExtensibleRestaurant.Core.Server
{
    class PluginLoader
    {
        public void Load(WindsorContainer windsorContainer)
        {
            var registrar = new CastleWindsorRegistrar(windsorContainer);

            var plugins = GetPlugIns();

            foreach (var plugin in plugins)
                plugin.RegisterPlugins(registrar);
        }

        private static List<Assembly> LoadPlugInAssemblies()
        {
            DirectoryInfo dInfo = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "Plugins"));
            FileInfo[] files = dInfo.GetFiles("*.dll", SearchOption.AllDirectories);
            List<Assembly> plugInAssemblyList = new List<Assembly>();

            if (null != files)
            {
                foreach (FileInfo file in files)
                {
                    plugInAssemblyList.Add(Assembly.LoadFile(file.FullName));
                }
            }

            return plugInAssemblyList;
        }

        private static List<IExtendableRestaurantPlugin> GetPlugIns()
        {
            var assemblies = LoadPlugInAssemblies();
            List<Type> availableTypes = new List<Type>();

            foreach (Assembly currentAssembly in assemblies)
                availableTypes.AddRange(currentAssembly.GetTypes());

            List<Type> pluginList = availableTypes.FindAll(delegate (Type t)
            {
                List<Type> interfaceTypes = new List<Type>(t.GetInterfaces());
                return interfaceTypes.Contains(typeof(IExtendableRestaurantPlugin));
            });

            return pluginList.ConvertAll(delegate (Type t) { return Activator.CreateInstance(t) as IExtendableRestaurantPlugin; });
        }
    }
}
