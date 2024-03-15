using System;
using System.Diagnostics.Metrics;

/*class Worker
{
    public string Name;
    public string Surname;
    public double Rate;
    public int Days;
    public Worker(string name, string surname, double rate, int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
    }
    public double Salary()
    {
        return Rate * Days;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите имя работника:");
        string name = Console.ReadLine();
        Console.WriteLine("Введите фамилию работника:");
        string surname = Console.ReadLine();
        Console.WriteLine("Введите ставку за день работы:");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите количество отработанных дней:");
        int days = Convert.ToInt32(Console.ReadLine());
        Worker worker = new Worker(name, surname, rate, days);
        Console.WriteLine($"\nЗарплата работника {worker.Name} {worker.Surname} составляет: {worker.Salary()}");

    }
}*/


/*class Worker
{
    private string Name { get; set; }
    private string Surname { get; set; }
    private double Rate { get; set; }
    private int Days { get; set; }
    public Worker(string name, string surname, double rate, int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
    }
    public string GetName()
    {
        return Name;
    }
    public string GetSurname()
    {
        return Surname;
    }
    public double GetRate()
    {
        return Rate;
    }
    public int GetDays()
    {
        return Days;
    }

    public double Salary()
    {
        return Rate * Days;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите имя работника:");
        string name = Console.ReadLine();
        Console.WriteLine("Введите фамилию работника:");
        string surname = Console.ReadLine();
        Console.WriteLine("Введите ставку за день работы:");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите количество отработанных дней:");
        int days = Convert.ToInt32(Console.ReadLine());
        Worker worker = new Worker(name, surname, rate, days);
        Console.WriteLine($"\nЗарплата работника {worker.GetName()} {worker.GetSurname()} составляет: {worker.Salary()}");
    }
}*/




   public class Calculation
    {
        public string CalculationLine { get; set; }
        public Calculation(string calculationLine)
        {
            CalculationLine = calculationLine;
        }
        public void SetCalculationLine()
        {
            CalculationLine = Console.ReadLine();
        }
        public void SetLastSymbolCalculationLine()
        {
            char endLine = Convert.ToChar(Console.ReadLine());
            CalculationLine += endLine;
        }
        public void GetCalculationLine()
        {
            Console.WriteLine(CalculationLine);
        }
        public void GetLastSymbol()
        {
            if (!string.IsNullOrEmpty(CalculationLine))
            {
                Console.WriteLine(CalculationLine[CalculationLine.Length - 1]);
            }
        }
        public void DeleteLastSymbol()
        {
            if (!string.IsNullOrEmpty(CalculationLine))
            {
                CalculationLine = CalculationLine.Remove(CalculationLine.Length - 1);
            }
        }
    }

class Program 
{  
    static void Main()
    {
        Calculation calculation = new Calculation("Privet");
        Console.WriteLine("Исходная строка:");
        calculation.GetCalculationLine();
        Console.WriteLine("Хотите изменить строку? да/нет:");
        string choice = Console.ReadLine();
        if (choice == "да")
        {
            Console.WriteLine("Введите новую строку:");
            calculation.SetCalculationLine();
            Console.WriteLine("Измененная строка:");
            calculation.GetCalculationLine();
        }
        else 
        {
            return;
        }
        
        Console.WriteLine("Введите один символ:");
        calculation.SetLastSymbolCalculationLine();
        Console.WriteLine("Строка с добавленным символом в конце:");
        calculation.GetCalculationLine();
        calculation.DeleteLastSymbol();
        Console.WriteLine("Строка с удаленным последним символом:");
        calculation.GetCalculationLine();
        Console.WriteLine("Полученный символ в конце строки:");
        calculation.GetLastSymbol();
    }
}