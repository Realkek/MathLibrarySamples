using System.Drawing;

namespace ds.test.impl.PluginsImplementation;

/// <summary>
/// Плагин для сложения 
/// </summary>
internal class AdditionPlugin : PluginBase
{
    public override string PluginName => "AdditionPlugin";
    public override string Version => "1.0";
    public override Image Image => null;
    public override string Description => "Plugin for addition operation";

    /// <summary>
    /// Сложение двух целых чисел
    /// </summary>
    /// <param name="a">Первое слагаемое</param>  
    /// <param name="b">Второе слагаемое</param>
    /// <returns>Результат сложения</returns>
    public override int Run(int input1, int input2)
    {
        // Проверка входных данных
        if (input1 >= int.MaxValue || input2 >= int.MaxValue)
            throw new ArgumentOutOfRangeException();

        // Проверка переполнения
        if (input1 + input2 < input1 || input1 + input2 < input2)
            throw new OverflowException();

        try
        {
            return input1 + input2;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            // Возврат ошибочного результата
            return -1;
        }
    }
}