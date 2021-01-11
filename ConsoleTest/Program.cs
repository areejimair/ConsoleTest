using System;

namespace ConsoleTest
{
    class Stack<T>
    {
        T[] StackArray;
        int size;
        int counter;
        public Stack(int capcity)
        {
            counter = 0;
            this.size = capcity;
            this.StackArray = new T[capcity];
        }
        public int push(T value)
        {

            if (counter == size - 1)
            {
                return -1;//OVERFLOW 
            }
            else

            {
                StackArray[counter] = value;
                counter++;//check for the last element index at the array
            }

            return 0;

        }
        public T pop()

        {
            T RemovedElement;
            T Tpop = default(T);
            if (counter >= 1) { 
                RemovedElement = StackArray[counter-1];
                counter--;
                return RemovedElement;

            }

            Console.WriteLine("UNDERFlOW");
            return Tpop;
        }
        public T[] printAll()
        {
            if (StackArray==null) {
                Console.WriteLine("Empty Stack");
            }
            T[] values= new T[counter ];

            Array.Copy(StackArray, 0, values, 0, counter );
            return values;

        }
        public T peak()
        {
            T topStack = this.StackArray[counter-1];
            return topStack; ;
        }
        public void removeAll()
        {
            Array.Clear(StackArray, 0, StackArray.Length);
        }
    }
    class Program
    {
        static void Main(string[] args)

        {
            int size;
            Console.Write("Enter size of Stack :");
            size = int.Parse(Console.ReadLine());
           Stack<int> stack = new Stack<int>(size);//take String type
            while (true)
            {
                Console.WriteLine("1-push");
                Console.WriteLine("2-pop");
                Console.WriteLine("3-Print all Stack Objects:");
                Console.WriteLine("4-Peak");
                Console.WriteLine("5-RemoveAll");
                Console.WriteLine("6-Exit");
                Console.Write("Enter your Choice :");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        { 
                            Console.Write("Enter Integer number to Push :");

                            int temp = int.Parse(Console.ReadLine());
                            int result = stack.push(temp);
                            if (result != -1) { 
                                Console.WriteLine("pushed to the STACK");
                            }
                            else
                            { 
                                Console.WriteLine("STACK OVERFLOW");

                            }

                            break;

                        }

                    case 2:
                        {
                            int Result = stack.pop();
                            if (Result == 0) { break; }
                                Console.WriteLine("Delete Element :" + Result);
                            
                            break;
                        }
                        

                    case 3:

                        {

                            int[] Elements = stack.printAll();

                            Console.WriteLine("Stack Elements:");

                            foreach (int intvalue in Elements)

                            {
                                Console.WriteLine(intvalue);
                            }

                            break;

                        }
                    case 4: { int topStack=stack.peak();
                            Console.Write("Top of the Stack is :");
                            Console.WriteLine(topStack);
                            break; }
                    case 5: { stack.removeAll(); break; }
                    case 6:{
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                            break;

                        }

                    default:

                        {
                            Console.WriteLine("You have Entered Wrong Choice ");
                            break;

                        }
                }
            }
        }
    }
}
