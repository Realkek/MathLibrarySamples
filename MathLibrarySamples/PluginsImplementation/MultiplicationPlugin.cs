using System.Drawing;

namespace ds.test.impl.PluginsImplementation;
/// <summary>
/// Плагин для умножения 
/// </summary>
internal class MultiplicationPlugin : PluginBase
{
    public override string PluginName => "MultiplicationPlugin";
    public override string Version => "1.0";
    public override Image Image => null;
    public override string Description => "Plugin for multiplication operation";

    /// <summary>
    /// Умножение двух целых чисел
    /// </summary>
    /// <param name="input1">Первый множитель</param>
    /// <param name="input2">Второй множитель</param>
    /// <returns>Произведение двух чисел</returns>
    public override int Run(int input1, int input2)
    {
        if (input1 == 0 || input2 == 0)
        {
            throw new ArgumentException("Multiplication by zero is not allowed.");
        }
        // Добавляем проверку на возможое переполнение при умножении
        checked
        {
            try
            {
                return input1 * input2;
            }
            catch (OverflowException)
            {
                throw new ArithmeticException("Overflow during multiplication.");
            }
        }
    }
}