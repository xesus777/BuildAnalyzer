using BuildAnalyzer.Core;

public class Program
{
    public static void Main()
    {

        Unit unit = new Unit();
        Console.WriteLine("введите имя: ");
        unit.name = Console.ReadLine();
        Console.WriteLine("введите базовую атаку: ");
        unit.baseAttack = double.Parse(Console.ReadLine());
        Console.WriteLine("введите атаку оружия: ");
        unit.weaponAttack = double.Parse(Console.ReadLine());
        Console.WriteLine("введите шанс крит урона: ");
        unit.critDamageChanse = int.Parse(Console.ReadLine());
        Console.WriteLine("введите крит урон в процентах: ");
        unit.critDamageProc = int.Parse(Console.ReadLine());

        Console.WriteLine("-------------------------------------------- ");
        Console.WriteLine("итоговая атака: ");
        Console.WriteLine(unit.finalAttack());
        Console.WriteLine("сред урон: ");
        Console.WriteLine(unit.avgDamage());
        Console.WriteLine("шанс крит урона: ");
        Console.WriteLine(unit.critDamageChanse);
        Console.WriteLine("крит урон: ");
        Console.WriteLine(unit.critDamage());
        Console.WriteLine("рейтинг сборки: ");
        Console.WriteLine(unit.getRate());
    
    
    
    }
}