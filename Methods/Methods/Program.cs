namespace Methods
{
	class MyClass
	{
		static void Main(string[] args)
		{
			Add();
            Add();
            Add();
           var result =  Add2(10,20);

            //int number1 = 20;						// out yerine refde kullanılabilir
            //int number2 = 1000;						// ref kullanıldığında kullanılan değer daha önceden atanmış olması gerekir
            //var result2 = Add3(out number1,number2);// out ta ise ilk kulanılan yerde değer ataması yapılmalıdır..

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(mutiply(2,4));
            Console.WriteLine(mutiply(2, 4,8));
			Console.WriteLine(Add4(2,3,3,6,4));



            Console.ReadLine();

		}
		static void Add()
		{
			Console.WriteLine("Added !!");
		}
		static int Add2(int num1 , int num2)
		{
			return num1 + num2;	
		}
		static int Add3(out int num1, int num2)
		{
			num1 = 30;
			return num1 + num2;
        }
        static int mutiply(int num1, int num2)
		{
			return num1 * num2;
        }
        static int mutiply(int num1, int num2,int number3)
        {
            return num1 * num2;
        }
		static int Add4(int num1,params int[] numbers)//params birden fazla parametre göndermek içinkullanmakta params en sola yazılır.
        {
			return numbers.Sum();
		}
    }
}