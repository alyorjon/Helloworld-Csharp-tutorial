using System;
using System.Collections;
using System.Net.Mime;
using HELLOWORLD;
{
    // Foydalanish misoli
    static void StudentMisol()
    {
        // Talabalar yaratish
        Student talaba1 = new Student(1001, "Ali", "Valiyev", new DateTime(2000, 5, 15));
        Student talaba2 = new Student(1002, "Malika", "Karimova", new DateTime(1999, 8, 22));
        
        // Ma'lumot qo'shish
        talaba1.PhoneNumber = "+998901234567";
        talaba1.Address = "Toshkent, Chilonzor";
        
        // Ballar qo'shish
        talaba1.AddGrade(85);
        talaba1.AddGrade(92);
        talaba1.AddGrade(78);
        talaba1.AddGrade(88);
        
        talaba2.AddGrade(95);
        talaba2.AddGrade(87);
        talaba2.AddGrade(91);
        
        // Ma'lumotlarni ko'rish
        Console.WriteLine(talaba1.GetGradeReport());
        Console.WriteLine(talaba2.GetGradeReport());
        
        // Taqqoslash
        Console.WriteLine($"Ali honor talabami? {talaba1.IsHonorStudent()}");
        Console.WriteLine($"Malika GPA: {talaba2.GPA}");
        
        // Status tekshirish
        if (talaba1.CompareGPA(talaba2) > 0)
            Console.WriteLine($"{talaba1.FullName} yuqori GPA ga ega");
        else
            Console.WriteLine($"{talaba2.FullName} yuqori GPA ga ega");
    }
    static void KitobMisol()
    {
        // Ob'ektlar yaratish
        Book kitob1 = new Book("978-123456789", "C# Dasturlash", "John Smith", 450, new DateTime(2023, 1, 15));
        Book kitob2 = new Book("978-987654321", "Python Asoslari", "Jane Doe", 320, new DateTime(2022, 6, 10));

        // Properties bilan ishlash
        Console.WriteLine($"Birinchi kitob: {kitob1.Title}");
        Console.WriteLine($"Sahifalar soni: {kitob1.Pages}");
        Console.WriteLine($"Kitob yoshi: {kitob1.BookAge} yil");

        // Methods chaqirish
        kitob1.Borrow("Ali Valiyev");
        kitob1.Return();

        Console.WriteLine(kitob1.GetBookInfo());

        // Static members
        Book.PrintTotalBooks();
        Console.WriteLine($"Umumiy kitoblar: {Book.TotalBooks}");
    }
    static void Classes()
    {
        Car car = new Car("Mers", "J2");
        Console.WriteLine(car.Model);
        BankAccount bankAccount = new BankAccount("1234", "Alyorjon", "C");
        bankAccount.Balance = 3;
        Console.WriteLine(bankAccount.Balance);
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
}