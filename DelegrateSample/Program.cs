

using System;

namespace DelegrateSample
{
    class Program
    {
        //Using Delegate for Callback

        //Delegate Definition
        public delegate void IceCreamDelegate();

        static void Main(string[] args)
        {
	    //Pointer to Method
            IceCreamDelegate icecreamDelegate = Program.CallMeBack;
            Console.WriteLine("I Think you Like IceCream.");

	    //Pass to Method as Parameter
            MetMyIceCream(icecreamDelegate);
            Console.Read();
        }

        public static void CallMeBack()
        {
            Console.WriteLine("There are several Instructions to make IceCream or you can order? ");
            Console.WriteLine("Instructions are simple and fast. ");
        }
        public static void MetMyIceCream(IceCreamDelegate IcecreamDelegate)
        {
            char j;
            Console.WriteLine("Do You Like IceCream N/Y?");
            var i = Console.ReadLine();
            if (char.TryParse(i, out j))
            {
		
                var interested = (j == 'N') ? false : true;
		//Event decision
                if(interested)
                {
                    IcecreamDelegate();
                }
                else
                {
                    Console.WriteLine("Why Not?");
                }
            }
        }
    }
}

//==============An Action Delegate
// class Program
//    {

//       static void Main(string[] args)
//        {
//            Action<int, string> DoGetData = GetData;
//            Console.WriteLine("Enter a Number : ");
//            string number = Console.ReadLine();
//            string input = "Hi Ghadir, Your Number is: ";
//            DoGetData(int.Parse(number), input);
//            Console.Read();
//        }
//        public static void GetData(int i, string input)
//        {
//            Console.Write(input + i);
//        }
//    }
