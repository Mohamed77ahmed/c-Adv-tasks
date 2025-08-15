
namespace assignment3
{

   
    internal class Program
    {

        static void Requeue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0) 
            stack.Push(queue.Dequeue());
            while (stack.Count > 0)
            queue.Enqueue(stack.Pop());


        }

        static bool balanced(string str)

        {
            Stack<char > stack = new Stack<char>();

            foreach (char c in str)
            { 
                //if (stack.Count == 0) return true;

                if (c =='{' || c == '(' || c == '[')
                    stack.Push(c);
                else if (c == '}'|| c == ']'|| c == ')')
                {
                    if (stack.Count == 0) return false;

                    char last =stack.Pop();

                    if ((c == ')' && last != '(') ||
                    (c == '}' && last != '{') ||
                    (c == ']' && last != '['))  return false; 

                }

            }

            return stack.Count == 0; 
        }

        static void Main(string[] args)
        {

            #region question1
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //Requeue(queue);

            //foreach (var item in queue)
            //    Console.WriteLine(item);
            #endregion


            #region question2

            //bool isbalanced= balanced("{[()}]}");
            //Console.WriteLine(isbalanced);
            //bool isbalanced01 = balanced("[()]{}");
            //Console.WriteLine(isbalanced01);


            #endregion


        }
    }
}
