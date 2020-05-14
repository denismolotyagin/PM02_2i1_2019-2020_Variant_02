class Human
    {
        public string Name;         
        public byte Age;
        // Устанавливаем параметры 
        public Human(string n, byte a)
        {
            Name = n;
            Age = a;
        }
        public ~Human()
        {
            Console.WriteLine("Object was destroyed");
        }
        public void GetInfo()
        {
            Console.WriteLine("Name: {0}\nAge: {1}", Name, Age);
        }
        static void hello()
        {
            Console.WriteLine(“Hello, world!”);
         }
    }