using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInheritance
{
    public class Inheritance
    {
        private readonly int _number1;
        private readonly int _number2;

        public Inheritance()
        {
        }

        public Inheritance(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        internal void Addition()
        {
            throw new NotImplementedException();
        }

        public int Addition(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }
        internal void Subtraction()
        {
            throw new NotImplementedException();
        }

        public int Subtraction(int number1, int number2)
        {
            int answer = number1 - number2;
            return answer;
        }
    }
}
