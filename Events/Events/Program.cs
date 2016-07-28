using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Events.EventTest;

namespace Events
{
    class EventTest
    {
        private int value;

        public delegate void NumManipulationHandler();
        public event NumManipulationHandler ChangeNum;

        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("Event Fired!!!");
            }
        }

        public EventTest(int n)
        {
            SetValue(n);
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }
        }
    }

    class Program
    {
        static void ChangeNumHandler()
        {
            Console.WriteLine("I handled the callback!!!");
        }

        static void Main(string[] args)
        {
            EventTest e = new EventTest(5);

            e.SetValue(7);

            e.ChangeNum += new NumManipulationHandler(ChangeNumHandler);

            e.SetValue(11);
            Console.ReadKey();
        }
    }
}
