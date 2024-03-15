using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;

/*class Student
{
    public string surname;
    public DateOnly birthday;
    public string numberGroup; 
    public int[] grade = new int[5];
    public void changingSurname(string newSurname)
    {
        surname = newSurname;
    }
    public void changingBirthday(DateOnly newBirthday)
    {  
        birthday = newBirthday; 
    }
    public void changingNumberGroup(string newNumberGroup)
    {  
        numberGroup = newNumberGroup; 
    }
    public void outputInformationAboutStudents()
    {
        Console.WriteLine($"Информация о студенте: \nФамилия: {surname} \nДата рождения: {birthday} \nНомер группы: {numberGroup} \nУспеваемость: {string.Join(", ", grade)}");
           
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        Console.Write("Введите фамилию студента: ");
        student.surname = Console.ReadLine();
        Console.Write("Введите дату рождения студента(гггг.мм.дд): ");
        student.birthday = DateOnly.Parse( Console.ReadLine() );
        Console.Write("Введите номер группы студента: ");
        student.numberGroup = Console.ReadLine();

        Console.WriteLine("Введите успеваемость студента(5 чисел через пробел)");
        string[] gradeInput = Console.ReadLine().Split(' ');
        for (int i = 0; i < 5; ++i)
        {
            student.grade[i] = int.Parse(gradeInput[i]);
        }
        student.outputInformationAboutStudents();
        
        Console.WriteLine("\nВведите цифру того, что вы хотите изменить");
        Console.WriteLine("1 - фамилия");
        Console.WriteLine("2 - день рождения");
        Console.WriteLine("3 - номер группы");
        int change = int.Parse(Console.ReadLine());
        switch (change)
        {
            case 1:
                Console.WriteLine("Введите новую фамилию:");
                student.changingSurname(Console.ReadLine());
                break;
            case 2:
                Console.WriteLine("Введите новую дату рождения (гггг.мм.дд):");
                student.changingBirthday(DateOnly.Parse(Console.ReadLine()));
                break;
            case 3:
                Console.WriteLine("Введите новый номер группы:");
                student.changingNumberGroup(Console.ReadLine());
                break;
        }

        Console.WriteLine("\nИзмененная информация о студенте:");
        student.outputInformationAboutStudents();
    }
}
*/

/*class train
{
    public string direction;
    public int trainNumber;
    public DateTime departureTime;
    public void outputInformationTrain()
    {
        Console.WriteLine($"Номер поезда: {trainNumber}");
        Console.WriteLine($"Направление: {direction}");
        Console.WriteLine($"Время отправления: {departureTime}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество поездов, которые хотите добавить:");
        int quantityTrain = int.Parse(Console.ReadLine());
        train[] trains = new train[quantityTrain];

        for (int i = 0; i < quantityTrain; i++)
        {
            train train = new train();

            Console.WriteLine($"Введите информацию о поезде {i + 1}:");
            Console.Write("Направление: ");
            train.direction = Console.ReadLine();
            Console.Write("Номер поезда: ");
            train.trainNumber = int.Parse(Console.ReadLine());
            Console.Write("Время отправления (гггг-мм-дд чч:мм:сс): ");
            train.departureTime = DateTime.Parse(Console.ReadLine());

            trains[i] = train;
            Console.WriteLine();
            Console.WriteLine("Информация о поезде добавлена.");
        }

        Console.WriteLine("Введите номер поезда, чтобы получить информацию:");
        int numberTrains = int.Parse(Console.ReadLine());

        train SelectedTrain = null;

        foreach (var train in trains)
        {
            if (train.trainNumber == numberTrains)
            {
                SelectedTrain = train;
                break;
            }
        }

            Console.WriteLine("Информация о поезде:");
            SelectedTrain.outputInformationTrain();
     }
}*/



/*class Numbers
{
    public int Number1;
    public int Number2;

    public void OutputNumbers()
    {
        Console.WriteLine($"Число 1: {Number1}");
        Console.WriteLine($"Число 2: {Number2}");
    }

    public void ModifyNumbers(int newNumber1, int newNumber2)
    {
        Number1 = newNumber1;
        Number2 = newNumber2;
    }
    public int Sum()
    {
        return Number1 + Number2;
    }

    public int Max()
    {
        return Math.Max(Number1, Number2);
    }
}
class Program
{
    static void Main()
    {
        Numbers numbers = new Numbers();

        Console.WriteLine("Введите первое число:");
        numbers.Number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        numbers.Number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Исходные числа:");
        numbers.OutputNumbers();
        Console.WriteLine($"Сумма чисел: {numbers.Sum()}");
        Console.WriteLine($"Наибольшее число: {numbers.Max()}");
        
        Console.WriteLine("\nВведите новые значения для чисел:");
        Console.WriteLine("Введите первое число:");
        int newNumber1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int newNumber2 = int.Parse(Console.ReadLine());
        numbers.ModifyNumbers(newNumber1, newNumber2);
        Console.WriteLine($"\nИзмененные числа:");
        numbers.OutputNumbers();
        Console.WriteLine($"Сумма чисел: {numbers.Sum()}");
        Console.WriteLine($"Наибольшее число: {numbers.Max()}");
    }
}*/


/*class counter
{
    public int value;

    public counter()
    {
        value = 0; 
    }

    public counter(int num)
    {
        value = num; 
    }

    public void increment()
    {
        ++value;
    }

    public void decrement()
    {
        --value;
    }
    public int Value => value;


}

class Program
{
    static void Main()
    {
        counter counter1 = new counter();
        Console.WriteLine($"Значение по умолчанию счетчика 1: {counter1.Value}");
        counter1.increment();
        Console.WriteLine($"Cчетчик 1 после увеличения: {counter1.Value}");  
        counter1.decrement();
        Console.WriteLine($"Cчетчик 1 после увеличения: {counter1.Value}");
        
        Console.Write("Введите произвольное значение счетчика 2: ");
        int num = Convert.ToInt32(Console.ReadLine());
        counter counter2 = new counter(num);
        Console.WriteLine($"\nСчетчик 2 с произвольным значением: {counter2.Value}");
        counter2.increment();
        Console.WriteLine($"Счетчик 2 после увеличения: {counter2.Value}");
        counter2.decrement();
        Console.WriteLine($"Счетчик 2 после уменьшения: {counter2.Value}");
    }
}*/


class MyClass
{
    public int property1;
    public string property2;
    public MyClass(int value1 = 0, string value2 = "Default")
    {
        property1 = value1;
        property2 = value2;
    }
    ~MyClass()
    {
        Console.WriteLine("Объект удален");
    }
    public void conclusion()
    {
        Console.WriteLine($"Свойство 1: {property1}");
        Console.WriteLine($"Свойство 2: {property2}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение для свойства 1(число):");
        int value1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение для свойства 2:");
        string value2 = Console.ReadLine();
        MyClass obj1 = new MyClass(value1, value2);
        MyClass obj2 = new MyClass();
        Console.WriteLine("Объект 1:");
        obj1.conclusion();
        Console.WriteLine("\nОбъект 2:");
        obj2.conclusion();
    }
}
       

       