using System.Drawing;

namespace ds.test.impl.PluginsImplementation;
/// <summary>
/// Плагин для вычитания 
/// </summary>
public class SubtractionPlugin: PluginBase
{
    public override string PluginName => "SubtractionPlugin";
    public override string Version => "1.0";
    public override Image Image => null;
    public override string Description => "Plugin for subtraction operation";

    /// <summary>
    /// Вычитание второго целого числа из первого
    /// </summary>
    /// <param name="input1"></param>
    /// <param name="input2"></param>
    /// <returns></returns>
    public override int Run(int input1, int input2)
    {
        return input1 - input2;
    }
}