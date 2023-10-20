namespace ds.test.impl.Interfaces;

 interface IPluginFactory
{
    int PluginsCount { get; }
    string[] GetPluginNames();
    IPlugin GetPlugin(string pluginName);
}