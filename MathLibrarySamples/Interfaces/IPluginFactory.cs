namespace ds.test.impl.Interfaces;
/// <summary>
/// Описание типичной фабрики плагинов
/// </summary>
 interface IPluginFactory
{
    int  PluginsCount { get; }
    string[] GetPluginNames();
    IPlugin GetPlugin(string pluginName);
}