using System.Drawing;
using ds.test.impl.Interfaces;

namespace ds.test.impl;
/// <summary>
/// Базовое описание любого плагина
/// </summary>
public abstract class PluginBase : IPlugin
{ 
    public abstract string PluginName { get; }
    public abstract string Version { get; }
    public abstract Image Image { get; }
    public abstract string Description { get; }

    public abstract int Run(int input1, int input2);
}