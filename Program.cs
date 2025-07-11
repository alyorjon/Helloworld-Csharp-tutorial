using System;
using System.Collections;
using System.Net.Mime;
using HELLOWORLD;
class Program
{
    static void Main()
    {
        PrintToConsole();
        VariablesAndDataTypes();
        MathOperators();
        ComparisonOperators();
        LogicalOperators();
        ConditionalStatetments();
        LoopMethods();
        Arrays();
        Collactions();
        TalabaInfo();
        Queues();
        // RestoranNavbati();
        Stackes();
        Methods();
        Classes();

    }
    static void Classes()
    {
        
    }
    static void Methods()
    {
        SayHello();
        int a = 1;
        int b = 2;
        int sum = Add(a, b);
        Console.WriteLine($"Sum of two numbers is: " + sum);
        Person p = new Person("Alyor", 29);
        Console.WriteLine(p.Name);
        p.Great();
    }
    private static int Add(int a, int b) {
        return a + b;
    }
    private static void SayHello()
    {
        Console.WriteLine("Say Hello functions");
    }
    static void Stackes()
    {
        Stack<string> stack = new Stack<string>();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");
        while (stack.Count > 0)
        {
            string item = stack.Pop();
            Console.WriteLine($"Stack item: " + item);
        }
    }
    static void Queues()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");
        while (queue.Count > 0)
        {
            string item = queue.Dequeue();
            Console.WriteLine(item);
        }
        Queue<int> raqamlar = new Queue<int>();

        // Enqueue() - navbat oxiriga qo'shish
        raqamlar.Enqueue(10);  // [10]
        raqamlar.Enqueue(20);  // [10, 20]
        raqamlar.Enqueue(30);  // [10, 20, 30]

        // Dequeue() - navbat boshidan olish va o'chirish
        int birinchi = raqamlar.Dequeue();  // 10 (navbatda [20, 30] qoladi)
        int ikkinchi = raqamlar.Dequeue(); // 20 (navbatda [30] qoladi)

        Console.WriteLine($"Birinchi: {birinchi}");  // 10
        Console.WriteLine($"Ikkinchi: {ikkinchi}"); // 20
        Queue<string> ismlar = new Queue<string>();
        ismlar.Enqueue("Ali");
        ismlar.Enqueue("Vali");
        ismlar.Enqueue("Salim");

        // Peek() - birinchi elementni ko'rish (o'chirmasdan)
        string birinchiIsm = ismlar.Peek();  // "Ali" (navbat o'zgarmaydi)
        Console.WriteLine(birinchiIsm);      // Ali

        // Count - elementlar soni
        Console.WriteLine(ismlar.Count);     // 3

        // Contains() - element bor-yo'qligini tekshirish
        bool aliBormi = ismlar.Contains("Ali");     // true
        bool ahmadBormi = ismlar.Contains("Ahmad"); // false

        // Clear() - hammasini o'chirish
        ismlar.Clear();
        Console.WriteLine(ismlar.Count);     // 0



    }
        class Buyurtma
    {
        public int Raqam { get; set; }
        public string Taom { get; set; }
        public DateTime Vaqt { get; set; }
        public string Mijoz { get; set; }
    }

    static void RestoranNavbati()
    {
    Queue<Buyurtma> oshxonaNavbat = new Queue<Buyurtma>();
    
    // Buyurtmalar qabul qilish
    oshxonaNavbat.Enqueue(new Buyurtma 
    { 
        Raqam = 1, 
        Taom = "Osh", 
        Mijoz = "Stol #5",
        Vaqt = DateTime.Now 
    });
    
    oshxonaNavbat.Enqueue(new Buyurtma 
    { 
        Raqam = 2, 
        Taom = "Manti", 
        Mijoz = "Stol #3",
        Vaqt = DateTime.Now.AddMinutes(2) 
    });
    
    oshxonaNavbat.Enqueue(new Buyurtma 
    { 
        Raqam = 3, 
        Taom = "Shashlik", 
        Mijoz = "Stol #8",
        Vaqt = DateTime.Now.AddMinutes(5) 
    });
    
    Console.WriteLine("Oshxona buyurtmalarni tayyorlayapti:");
    
    while (oshxonaNavbat.Count > 0)
    {
        Buyurtma buyurtma = oshxonaNavbat.Dequeue();
        Console.WriteLine($"#{buyurtma.Raqam}: {buyurtma.Taom} - {buyurtma.Mijoz}");
        Console.WriteLine("Tayyorlanmoqda...");
        
        // Tayyorlash vaqti
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("Tayyor!\n");
    }
}
    static void TalabaInfo()
    {
        Dictionary<int, Dictionary<string, object>> talabalar =
            new Dictionary<int, Dictionary<string, object>>();

        // Talaba qo'shish
        talabalar[1001] = new Dictionary<string, object>()
    {
        {"ism", "Ali Valiyev"},
        {"yosh", 20},
        {"kurs", 2},
        {"ball", 4.5}
    };

        talabalar[1002] = new Dictionary<string, object>()
    {
        {"ism", "Malika Karimova"},
        {"yosh", 19},
        {"kurs", 1},
        {"ball", 4.8}
    };

        // Ma'lumot chiqarish
        foreach (var talaba in talabalar)
        {
            Console.WriteLine($"ID: {talaba.Key}");
            Console.WriteLine($"Ism: {talaba.Value["ism"]}");
            Console.WriteLine($"Ball: {talaba.Value["ball"]}");
            Console.WriteLine("---");
        }
    }
    static void Collactions()
    {
        List<string> cities = new List<string>();
        cities.Add("New York");
        cities.Add("Toshkent");
        cities.Add("Tokyo");
        cities.Add("Berlin");
        Console.WriteLine(cities[2]);
        Console.WriteLine(cities.Count);
        foreach (string name in cities)
        {
            Console.WriteLine(name);

        }

        HashSet<string> countries = new HashSet<string>();
        countries.Add("Germany");
        countries.Add("Japan");
        countries.Add("USA");
        countries.Add("Uzbekistan");
        countries.Add("Kanada");
        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }
        Dictionary<string, int> ageDict = new Dictionary<string, int>();
        string dictKey = "Alice";
        ageDict[dictKey] = 30;
        Console.WriteLine(ageDict);
        if (ageDict.ContainsKey(dictKey))
        {
            Console.WriteLine($"{dictKey}'s age is : {ageDict[dictKey]}");
        }
        Dictionary<string, string> countrycodes = new Dictionary<string, string>();
        countrycodes.Add("UZ", "Uzbekistan");
        countrycodes.Add("RU", "Russia");
        countrycodes.Add("US", "USA");

        if (countrycodes.TryGetValue("UZ", out string nomi))
        {
            Console.WriteLine($"Country name is {nomi}");
        }
        foreach (string name in countrycodes.Keys)
        {
            Console.WriteLine(name);
        }
        foreach (string name in countrycodes.Values)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine(countrycodes.Count);
        countrycodes.Remove("US");
        foreach (string name in countrycodes.Values)
        {
            Console.WriteLine(name);
        }

    }
    static void Arrays()
    {
        string[] names = new string[3];
        names[0] = "Ron";
        names[1] = "Katie";
        names[2] = "Jack";
        Console.WriteLine(names.Length);
    }
    static void LoopMethods()
    {
        for (int i = 0; i < 50000; i++)
        {
            Console.WriteLine(i + 1);
        }
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine(count + 4);
            count++;
        }
        count = 0;
        do
        {
            Console.WriteLine("Do -while count:" + count);
            count++;
        }
        while (count < 10);

        int[] numbers = { 1, 2, 3, 45, 5, 6 };
        foreach (int i in numbers)
        {
            Console.WriteLine("Number in array is: " + i);
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Using standard for loop-numbers is : " + numbers[i]);
        }
    }
    static void PrintToConsole()
    {
        Console.WriteLine("Welcome to crash course");

    }

    static void ConditionalStatetments()
    {
        int age = 3;
        if (age < 18)
        {
            Console.WriteLine("You are a minor");
        }
        else if (age >= 18 && age < 60)
        {
            Console.WriteLine("Your age is an adult");
        }
        else
        {
            Console.WriteLine("You are an older");

        }

        int day = 3;
        string dayName;
        switch (day)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thuersday";
                break;
            default:
                dayName = "Weekend";
                break;

        }
        Console.WriteLine("today is "+dayName );

    }   
    static void LogicalOperators()
    {
        bool x = true;
        bool y = false;
        bool andResult = (x && y);
        bool orResult = (x || y);
        bool notResult = (x || !y);
        Console.WriteLine(andResult);
        Console.WriteLine(orResult);
        Console.WriteLine(notResult);
        bool notResult2 = !x;
        Console.WriteLine(notResult2);
    }
    static void ComparisonOperators()
    {
        int a = 10;
        int b = 5;
        bool isEqual = (a == b);
        Console.WriteLine(isEqual);
        bool isNotEqual = (a != b);
        Console.WriteLine(isNotEqual);
        bool isGreater = (a > b);
        bool isLess = (a < b);
        bool isGreaterThanOrEqual = (a >= b);
        bool isLessThanOrEqual = (a <= b);
        Console.WriteLine(isGreater);
        Console.WriteLine(isLess);
        Console.WriteLine(isGreaterThanOrEqual);
        Console.WriteLine(isLessThanOrEqual);
    }
    static void MathOperators()
    {
        int num1 = 10;
        int num2 = 5;
        int addition = num1 + num2;
        Console.WriteLine(addition);
        int subtraction = num1 - num2;
        Console.WriteLine(subtraction);

        int num3 = 0;
        try
        {
            int devision1 = num2 / num3;
            Console.WriteLine(devision1);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Excaption :{ex.Message}");
        }
    }
    static void VariablesAndDataTypes()
    {
        int age = 40;
        Console.WriteLine(age);
        float temperature = 20.4f;
        Console.WriteLine(temperature);
        double interest = 5.53;
        Console.WriteLine("interest:" + interest);

        decimal stockPrice = 4.535353M;
        Console.WriteLine(stockPrice);

        char grade = 'A';
        Console.WriteLine(grade);
        string name = "Alyor";
        Console.WriteLine(name);
        Console.WriteLine($"My name is {name}.");
        bool isStudent = true;
        int quantity;
        string products;
        quantity = 5;
        products = "Apple";
        Console.WriteLine(quantity);
        Console.WriteLine($"Quantity:{quantity}. Products:{products}");


        const double Pi = 3.14;
        Console.WriteLine(Pi);
    }
}