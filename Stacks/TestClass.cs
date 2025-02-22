using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.Stacks
{
    public class TestClass
    {
        private Stack stack;

        public TestClass()
        {
            stack = new Stack(10);

            for (int i = 0; i < 10; i++)
            {
                stack.Push("Squirtle");
                stack.Push("Pikachu");
                stack.Push("Charmander");
            }

            stack.Pop();
            stack.Peek();
            while (!stack.IsEmpty())
            {
                var item = stack.Pop();
                Console.WriteLine(item);
            }
        }
    }
    Stack.Pop();
        stack.Peek();
        while (!stack.IsEmpty())
        {
          var var = stack.Pop();
    Console.WriteLine(var);
}

}   
}
