namespace ds.test.impl.Interfaces
{
    /// <summary>
    /// базовый интерфейс любого плагина
    /// </summary>
    public interface IPlugin
    {
        string PluginName { get; }
        string Version { get; }
        System.Drawing.Image Image { get; }
        string Description { get; }
        int Run(int input1, int input2);
    }
}