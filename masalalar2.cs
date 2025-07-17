using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

// ===========================================
// C# COLLECTIONS SAVOL VA JAVOBLARI
// ===========================================

class CollectionsQA
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== C# COLLECTIONS SAVOL VA JAVOBLARI ===\n");
        
        // LIST JAVOBLARI
        ListQuestions();
        
        // HASHSET JAVOBLARI
        HashSetQuestions();
        
        // DICTIONARY JAVOBLARI
        DictionaryQuestions();
        
        // QUEUE JAVOBLARI
        QueueQuestions();
        
        // STACK JAVOBLARI
        StackQuestions();
        
        // AMALIY MASALALAR
        PracticalQuestions();
    }
    
    // ===========================================
    // LIST JAVOBLARI
    // ===========================================
    static void ListQuestions()
    {
        Console.WriteLine("=== LIST JAVOBLARI ===\n");
        
        // JAVOB 1: List va Array farqi
        Console.WriteLine("1. List va Array farqi:");
        Console.WriteLine("   - List: O'lchamini o'zgartirish mumkin, ko'p metodlar");
        Console.WriteLine("   - Array: Qat'iy o'lcham, kam xotira, tezroq indeksatsiya");
        
        int[] array = new int[3]; // Fixed size
        List<int> list = new List<int>(); // Dynamic size
        list.Add(1); // Array da bu mumkin emas
        Console.WriteLine($"   List elementi: {list[0]}");
        
        // JAVOB 2: Barcha 2 raqamlarini o'chirish
        Console.WriteLine("\n2. Barcha 2 raqamlarini o'chirish:");
        List<int> numbers = new List<int> {1, 2, 3, 2, 4, 2};
        Console.WriteLine($"   Original: [{string.Join(", ", numbers)}]");
        
        // Usul 1: RemoveAll()
        numbers.RemoveAll(x => x == 2);
        Console.WriteLine($"   RemoveAll dan keyin: [{string.Join(", ", numbers)}]");
        
        // Usul 2: Where() bilan
        numbers = new List<int> {1, 2, 3, 2, 4, 2};
        numbers = numbers.Where(x => x != 2).ToList();
        Console.WriteLine($"   Where dan keyin: [{string.Join(", ", numbers)}]");
        
        // JAVOB 3: Insert, Remove, RemoveAt farqi
        Console.WriteLine("\n3. Insert, Remove, RemoveAt farqi:");
        List<string> names = new List<string> {"Ali", "Vali", "Salim"};
        
        names.Insert(1, "Karim"); // Index 1 ga qo'shish
        Console.WriteLine($"   Insert(1, 'Karim'): [{string.Join(", ", names)}]");
        
        names.Remove("Vali"); // Qiymat bo'yicha o'chirish
        Console.WriteLine($"   Remove('Vali'): [{string.Join(", ", names)}]");
        
        names.RemoveAt(0); // Index bo'yicha o'chirish
        Console.WriteLine($"   RemoveAt(0): [{string.Join(", ", names)}]");
        
        // JAVOB 4: Nima uchun sekin
        Console.WriteLine("\n4. List da qidirish sekin chunki:");
        Console.WriteLine("   - O(n) complexity - har bir elementni tekshirish kerak");
        Console.WriteLine("   - Sequential search - boshidan oxirigacha");
        Console.WriteLine("   - Contains() metodi barcha elementlarni ko'radi");
    }
    
    // ===========================================
    // HASHSET JAVOBLARI
    // ===========================================
    static void HashSetQuestions()
    {
        Console.WriteLine("\n=== HASHSET JAVOBLARI ===\n");
        
        // JAVOB 5: Dublikat qo'shish
        Console.WriteLine("5. HashSet ga dublikat qo'shish:");
        HashSet<string> set = new HashSet<string>();
        
        bool result1 = set.Add("Apple");
        bool result2 = set.Add("Apple"); // Dublikat
        
        Console.WriteLine($"   Birinchi 'Apple': {result1}"); // True
        Console.WriteLine($"   Ikkinchi 'Apple': {result2}"); // False
        Console.WriteLine($"   Set elementi: {set.Count}"); // 1
        
        // JAVOB 6: Intersection va Union
        Console.WriteLine("\n6. HashSet intersection va union:");
        HashSet<int> set1 = new HashSet<int> {1, 2, 3, 4};
        HashSet<int> set2 = new HashSet<int> {3, 4, 5, 6};
        
        // Intersection (kesishma)
        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);
        Console.WriteLine($"   Intersection: [{string.Join(", ", intersection)}]"); // 3, 4
        
        // Union (birlashtirish)
        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);
        Console.WriteLine($"   Union: [{string.Join(", ", union)}]"); // 1, 2, 3, 4, 5, 6
        
        // JAVOB 7: Nima uchun tezroq
        Console.WriteLine("\n7. HashSet tezroq chunki:");
        Console.WriteLine("   - O(1) average complexity");
        Console.WriteLine("   - Hash table asosida");
        Console.WriteLine("   - GetHashCode() orqali to'g'ridan-to'g'ri joyni topadi");
        
        // JAVOB 8: Dublikat qo'shish misoli
        Console.WriteLine("\n8. HashSet dublikat test:");
        HashSet<string> testSet = new HashSet<string>();
        string[] items = {"Apple", "Banana", "Apple", "Cherry", "Banana"};
        
        foreach (string item in items)
        {
            bool added = testSet.Add(item);
            Console.WriteLine($"   '{item}' qo'shish: {added}");
        }
        Console.WriteLine($"   Final set: [{string.Join(", ", testSet)}]");
    }
    
    // ===========================================
    // DICTIONARY JAVOBLARI
    // ===========================================
    static void DictionaryQuestions()
    {
        Console.WriteLine("\n=== DICTIONARY JAVOBLARI ===\n");
        
        // JAVOB 9: Null keys va values
        Console.WriteLine("9. Dictionary da null:");
        Dictionary<string, string> dict = new Dictionary<string, string>();
        
        // Key null bo'lishi mumkin emas
        try
        {
            dict[null] = "value";
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("   Key null bo'lishi mumkin emas!");
        }
        
        // Value null bo'lishi mumkin
        dict["key"] = null;
        Console.WriteLine($"   Value null: {dict["key"] == null}"); // True
        
        // JAVOB 10: Xavfsiz element olish
        Console.WriteLine("\n10. Dictionary dan xavfsiz element olish:");
        Dictionary<string, int> scores = new Dictionary<string, int>
        {
            {"Ali", 85},
            {"Vali", 92}
        };
        
        // Xavfsiz usul 1: TryGetValue
        if (scores.TryGetValue("Ali", out int score))
        {
            Console.WriteLine($"   Ali bahosi: {score}");
        }
        
        // Xavfsiz usul 2: ContainsKey
        if (scores.ContainsKey("Salim"))
        {
            Console.WriteLine($"   Salim bahosi: {scores["Salim"]}");
        }
        else
        {
            Console.WriteLine("   Salim bahosi topilmadi");
        }
        
        // JAVOB 11: Value bo'yicha key topish
        Console.WriteLine("\n11. Value bo'yicha key topish:");
        Dictionary<string, string> countries = new Dictionary<string, string>
        {
            {"UZ", "O'zbekiston"},
            {"RU", "Rossiya"},
            {"US", "Amerika"}
        };
        
        string searchValue = "O'zbekiston";
        string foundKey = countries.FirstOrDefault(x => x.Value == searchValue).Key;
        Console.WriteLine($"   '{searchValue}' uchun key: {foundKey}");
        
        // JAVOB 12: ConcurrentDictionary
        Console.WriteLine("\n12. ConcurrentDictionary farqi:");
        Console.WriteLine("   - Thread-safe operations");
        Console.WriteLine("   - Multiple threads bir vaqtda kirishi mumkin");
        Console.WriteLine("   - Lock-free mechanisms");
        
        ConcurrentDictionary<string, int> concurrentDict = new ConcurrentDictionary<string, int>();
        concurrentDict.TryAdd("key1", 100);
        concurrentDict.TryUpdate("key1", 200, 100);
        Console.WriteLine($"   ConcurrentDictionary: {concurrentDict["key1"]}");
    }
    
    // ===========================================
    // QUEUE JAVOBLARI
    // ===========================================
    static void QueueQuestions()
    {
        Console.WriteLine("\n=== QUEUE JAVOBLARI ===\n");
        
        // JAVOB 13: FIFO misoli
        Console.WriteLine("13. FIFO (First In, First Out) misoli:");
        Queue<string> customerQueue = new Queue<string>();
        
        // Mijozlar navbatga turishi
        customerQueue.Enqueue("Ali");
        customerQueue.Enqueue("Vali");
        customerQueue.Enqueue("Salim");
        
        Console.WriteLine("   Mijozlar navbati: Ali -> Vali -> Salim");
        
        // Xizmat ko'rsatish
        while (customerQueue.Count > 0)
        {
            string customer = customerQueue.Dequeue();
            Console.WriteLine($"   Xizmat: {customer}");
        }
        
        // JAVOB 14: Enqueue va Dequeue
        Console.WriteLine("\n14. Enqueue va Dequeue:");
        Queue<int> numberQueue = new Queue<int>();
        
        // Enqueue - oxiriga qo'shish
        numberQueue.Enqueue(1);
        numberQueue.Enqueue(2);
        numberQueue.Enqueue(3);
        Console.WriteLine($"   Enqueue dan keyin: Count = {numberQueue.Count}");
        
        // Dequeue - boshidan olish
        int first = numberQueue.Dequeue();
        Console.WriteLine($"   Dequeue: {first}, Qolgan: {numberQueue.Count}");
        
        // JAVOB 15: Bo'sh queue dan dequeue
        Console.WriteLine("\n15. Bo'sh Queue dan Dequeue:");
        Queue<string> emptyQueue = new Queue<string>();
        
        try
        {
            string item = emptyQueue.Dequeue();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"   Xato: {ex.Message}");
        }
        
        // Xavfsiz usul
        if (emptyQueue.Count > 0)
        {
            string item = emptyQueue.Dequeue();
        }
        else
        {
            Console.WriteLine("   Queue bo'sh - xavfsiz tekshirish");
        }
        
        // JAVOB 16: BFS algoritmi
        Console.WriteLine("\n16. BFS algoritmi Queue bilan:");
        BFSExample();
    }
    
    static void BFSExample()
    {
        // Oddiy graf: A -> B, C; B -> D, E; C -> F
        Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>
        {
            {"A", new List<string> {"B", "C"}},
            {"B", new List<string> {"D", "E"}},
            {"C", new List<string> {"F"}},
            {"D", new List<string>()},
            {"E", new List<string>()},
            {"F", new List<string>()}
        };
        
        Queue<string> queue = new Queue<string>();
        HashSet<string> visited = new HashSet<string>();
        
        queue.Enqueue("A");
        visited.Add("A");
        
        Console.WriteLine("   BFS tartibi:");
        while (queue.Count > 0)
        {
            string current = queue.Dequeue();
            Console.WriteLine($"     {current}");
            
            foreach (string neighbor in graph[current])
            {
                if (!visited.Contains(neighbor))
                {
                    queue.Enqueue(neighbor);
                    visited.Add(neighbor);
                }
            }
        }
    }
    
    // ===========================================
    // STACK JAVOBLARI
    // ===========================================
    static void StackQuestions()
    {
        Console.WriteLine("\n=== STACK JAVOBLARI ===\n");
        
        // JAVOB 17: LIFO prinsipi
        Console.WriteLine("17. LIFO (Last In, First Out) prinsipi:");
        Stack<string> plateStack = new Stack<string>();
        
        // Plastinkalar stek ga qo'yish
        plateStack.Push("Plastinka 1");
        plateStack.Push("Plastinka 2");
        plateStack.Push("Plastinka 3");
        
        Console.WriteLine("   Plastinkalar: 3 -> 2 -> 1 (tepadan pastga)");
        
        // Plastinkalarni olish
        while (plateStack.Count > 0)
        {
            string plate = plateStack.Pop();
            Console.WriteLine($"   Olindi: {plate}");
        }
        
        // JAVOB 18: Qavs balansi
        Console.WriteLine("\n18. Qavs balansini tekshirish:");
        string[] expressions = {"()", "()[]", "([)]", "((("};
        
        foreach (string expr in expressions)
        {
            bool isBalanced = IsBalanced(expr);
            Console.WriteLine($"   '{expr}': {(isBalanced ? "Balansli" : "Balansli emas")}");
        }
        
        // JAVOB 19: Rekursiyani iterativ qilish
        Console.WriteLine("\n19. Factorial rekursiyani Stack bilan:");
        int n = 5;
        int recursiveResult = FactorialRecursive(n);
        int iterativeResult = FactorialIterative(n);
        
        Console.WriteLine($"   {n}! rekursiv: {recursiveResult}");
        Console.WriteLine($"   {n}! iterativ: {iterativeResult}");
        
        // JAVOB 20: Push, Pop, Peek farqi
        Console.WriteLine("\n20. Push, Pop, Peek farqi:");
        Stack<int> numberStack = new Stack<int>();
        
        // Push - tepaga qo'shish
        numberStack.Push(10);
        numberStack.Push(20);
        numberStack.Push(30);
        Console.WriteLine($"   Push dan keyin: Count = {numberStack.Count}");
        
        // Peek - tepagini ko'rish (o'chirmasdan)
        int top = numberStack.Peek();
        Console.WriteLine($"   Peek: {top}, Count: {numberStack.Count}");
        
        // Pop - tepagini olish va o'chirish
        int popped = numberStack.Pop();
        Console.WriteLine($"   Pop: {popped}, Count: {numberStack.Count}");
    }
    
    static bool IsBalanced(string expression)
    {
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in expression)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0) return false;
                
                char open = stack.Pop();
                if ((c == ')' && open != '(') ||
                    (c == ']' && open != '[') ||
                    (c == '}' && open != '{'))
                {
                    return false;
                }
            }
        }
        
        return stack.Count == 0;
    }
    
    static int FactorialRecursive(int n)
    {
        if (n <= 1) return 1;
        return n * FactorialRecursive(n - 1);
    }
    
    static int FactorialIterative(int n)
    {
        Stack<int> stack = new Stack<int>();
        
        // Stackga raqamlarni qo'yish
        for (int i = n; i >= 1; i--)
        {
            stack.Push(i);
        }
        
        // Stackdan olish va ko'paytirish
        int result = 1;
        while (stack.Count > 0)
        {
            result *= stack.Pop();
        }
        
        return result;
    }
    
    // ===========================================
    // AMALIY MASALALAR
    // ===========================================
    static void PracticalQuestions()
    {
        Console.WriteLine("\n=== AMALIY MASALALAR ===\n");
        
        // JAVOB 21: Takrorlanuvchi elementlarni olib tashlash
        Console.WriteLine("21. Takrorlanuvchi elementlarni olib tashlash:");
        string[] duplicates = {"apple", "banana", "apple", "cherry", "banana"};
        
        // HashSet ishlatish (eng samarali)
        HashSet<string> unique = new HashSet<string>(duplicates);
        Console.WriteLine($"   HashSet: [{string.Join(", ", unique)}]");
        
        // LINQ Distinct
        var distinctItems = duplicates.Distinct().ToArray();
        Console.WriteLine($"   LINQ Distinct: [{string.Join(", ", distinctItems)}]");
        
        // JAVOB 22: Real-time chat
        Console.WriteLine("\n22. Real-time chat xabarlari:");
        Console.WriteLine("   - Queue: FIFO tartibda ko'rsatish");
        Console.WriteLine("   - List: Index bilan kirish, sahifalash");
        Console.WriteLine("   - CircularBuffer: Cheklangan hajm");
        
        // Queue misoli
        Queue<string> chatMessages = new Queue<string>();
        chatMessages.Enqueue("Ali: Salom!");
        chatMessages.Enqueue("Vali: Qalaysiz?");
        chatMessages.Enqueue("Ali: Yaxshi!");
        
        Console.WriteLine("   Chat xabarlari:");
        foreach (string message in chatMessages)
        {
            Console.WriteLine($"     {message}");
        }
        
        // JAVOB 23: Undo/Redo
        Console.WriteLine("\n23. Undo/Redo funksiyasi:");
        UndoRedoExample();
        
        // JAVOB 24: Tez qidirish
        Console.WriteLine("\n24. Tez qidirish uchun:");
        Console.WriteLine("   - HashSet: O(1) membership test");
        Console.WriteLine("   - Dictionary: O(1) key-value lookup");
        Console.WriteLine("   - SortedDictionary: O(log n) ordered access");
        
        // JAVOB 25: Thread-safe collections
        Console.WriteLine("\n25. Thread-safe collections:");
        ThreadSafeExample();
    }
    
    static void UndoRedoExample()
    {
        Stack<string> undoStack = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();
        string currentState = "Initial";
        
        // Operatsiyalar
        undoStack.Push(currentState);
        currentState = "After Edit 1";
        Console.WriteLine($"   State: {currentState}");
        
        undoStack.Push(currentState);
        currentState = "After Edit 2";
        Console.WriteLine($"   State: {currentState}");
        
        // Undo
        redoStack.Push(currentState);
        currentState = undoStack.Pop();
        Console.WriteLine($"   Undo: {currentState}");
        
        // Redo
        undoStack.Push(currentState);
        currentState = redoStack.Pop();
        Console.WriteLine($"   Redo: {currentState}");
    }
    
    static void ThreadSafeExample()
    {
        Console.WriteLine("   Thread-safe collections:");
        Console.WriteLine("   - ConcurrentDictionary<TKey, TValue>");
        Console.WriteLine("   - ConcurrentQueue<T>");
        Console.WriteLine("   - ConcurrentStack<T>");
        Console.WriteLine("   - ConcurrentBag<T>");
        Console.WriteLine("   - BlockingCollection<T>");
        
        // ConcurrentDictionary misoli
        ConcurrentDictionary<string, int> threadSafeDict = new ConcurrentDictionary<string, int>();
        
        // Parallel operations
        Parallel.For(0, 10, i =>
        {
            threadSafeDict.TryAdd($"Key{i}", i);
        });
        
        Console.WriteLine($"   ConcurrentDictionary elements: {threadSafeDict.Count}");
        
        // ConcurrentQueue misoli
        ConcurrentQueue<string> threadSafeQueue = new ConcurrentQueue<string>();
        
        Parallel.For(0, 5, i =>
        {
            threadSafeQueue.Enqueue($"Item{i}");
        });
        
        Console.WriteLine($"   ConcurrentQueue elements: {threadSafeQueue.Count}");
        
        // Items ni olish
        while (threadSafeQueue.TryDequeue(out string item))
        {
            Console.WriteLine($"     Dequeued: {item}");
        }
    }
}

// ===========================================
// QOSHIMCHA UTILITY CLASSLAR
// ===========================================

// Circular Buffer implementation
public class CircularBuffer<T>
{
    private T[] buffer;
    private int head;
    private int tail;
    private int size;
    private readonly int capacity;
    
    public CircularBuffer(int capacity)
    {
        this.capacity = capacity;
        buffer = new T[capacity];
        head = 0;
        tail = 0;
        size = 0;
    }
    
    public void Add(T item)
    {
        buffer[tail] = item;
        tail = (tail + 1) % capacity;
        
        if (size < capacity)
        {
            size++;
        }
        else
        {
            head = (head + 1) % capacity; // Overwrite oldest
        }
    }
    
    public T[] GetItems()
    {
        T[] result = new T[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = buffer[(head + i) % capacity];
        }
        return result;
    }
    
    public int Count => size;
    public bool IsFull => size == capacity;
}

// Performance comparison class
public class PerformanceComparison
{
    public static void CompareCollections()
    {
        const int iterations = 1_000_000;
        
        // List vs HashSet lookup
        List<int> list = Enumerable.Range(0, iterations).ToList();
        HashSet<int> hashSet = new HashSet<int>(list);
        
        var sw = System.Diagnostics.Stopwatch.StartNew();
        bool found = list.Contains(iterations - 1);
        sw.Stop();
        Console.WriteLine($"List lookup: {sw.ElapsedMilliseconds}ms");
        
        sw.Restart();
        found = hashSet.Contains(iterations - 1);
        sw.Stop();
        Console.WriteLine($"HashSet lookup: {sw.ElapsedMilliseconds}ms");
        
        // Dictionary vs List for key-value pairs
        var keyValueList = new List<KeyValuePair<string, int>>();
        var dictionary = new Dictionary<string, int>();
        
        for (int i = 0; i < 10000; i++)
        {
            string key = $"Key{i}";
            keyValueList.Add(new KeyValuePair<string, int>(key, i));
            dictionary[key] = i;
        }
        
        sw.Restart();
        var listResult = keyValueList.FirstOrDefault(x => x.Key == "Key9999");
        sw.Stop();
        Console.WriteLine($"List key search: {sw.ElapsedMilliseconds}ms");
        
        sw.Restart();
        dictionary.TryGetValue("Key9999", out int dictResult);
        sw.Stop();
        Console.WriteLine($"Dictionary key search: {sw.ElapsedMilliseconds}ms");
    }
}