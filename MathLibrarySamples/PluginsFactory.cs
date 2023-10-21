using System.Drawing;
using ds.test.impl.Interfaces;
using ds.test.impl.PluginsImplementation;

namespace ds.test.impl;
/// <summary>
/// Фабрика предоставляющая плагины
/// </summary>
internal class PluginsFactory : IPluginFactory
{
    private static readonly IPlugin[] Plugins =
    {
        new AdditionPlugin(),
        new DivisionPlugin(),
        new MultiplicationPlugin(),
        new SubtractionPlugin()
    };

    public int PluginsCount
    {
        get { return Plugins.Length; }
    }

    public string[] GetPluginNames()
    {
        string[] names = new string[Plugins.Length];
        for (int i = 0; i < Plugins.Length; i++)
        {
            names[i] = Plugins[i].PluginName;
        }

        return names;
    }

    public IPlugin GetPlugin(string name)
    {
        return Plugins.FirstOrDefault(plugin => plugin.PluginName == name) ?? throw new InvalidOperationException();
    }
}