using System.Drawing;

namespace ds.test.impl.PluginsImplementation;

/// <summary>
/// Плагин для деления
/// </summary>
internal class DivisionPlugin : PluginBase
{
    public override string PluginName => "DivisionPlugin";
    public override string Version => "1.0";
    public override Image Image => null;
    public override string Description => "Plugin for division operation";

    /// <summary>
    /// Деление двух целых чисел
    /// </summary>
    /// <param name="input1">Делимое</param>
    /// <param name="input2">Делитель</param>
    /// <returns>Результат деления</returns>
    /// <exception cref="ArgumentException">Генерируется, если делитель равен нулю</exception>
    public override int Run(int input1, int input2)
    {
        if (input2 == 0) throw new ArgumentException("Division by zero is not allowed.");
        // Добавляем проверку на возможное переполнение при делении
        if (input1 == int.MinValue && input2 == -1)
        {
            throw new OverflowException("Division results in integer underflow.");
        }

        return input1 / input2;
    }
}