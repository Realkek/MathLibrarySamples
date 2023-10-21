using ds.test.impl.Interfaces;

namespace ds.test.impl;
/// <summary>
/// Точка доступа к функционалу библиотеки плагинов
/// </summary>
public static class Plugins
{
    public static int PluginsCount => PluginsFactory.PluginsCount;
    private static readonly PluginsFactory PluginsFactory = new();
    
    public static IEnumerable<string> GetPluginsNames()
    {
        return PluginsFactory.GetPluginNames();
    }

    public static IPlugin GetPlugin(string name)
    {
        return PluginsFactory.GetPlugin(name);
    }
}