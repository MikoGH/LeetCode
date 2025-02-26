namespace LeetCode.T1001_T1500.T1115_PrintFooBarAlternately;

public class T_PrintFooBarAlternately
{
    public class FooBar
    {
        private int n;
        private object locker;
        private bool fooTurn = true;

        public FooBar(int n)
        {
            this.n = n;
            locker = new object();
        }

        public void Foo(Action printFoo)
        {
            lock (locker)
            {
                for (int i = 0; i < n; i++)
                {
                    printFoo();
                    fooTurn = false;
                    Monitor.Pulse(locker);
                    if (i < n - 1)
                        while (!fooTurn) Monitor.Wait(locker);
                }
            }
        }

        public void Bar(Action printBar)
        {
            lock (locker)
            {
                for (int i = 0; i < n; i++)
                {
                    while(fooTurn) Monitor.Wait(locker);
                    printBar();
                    fooTurn = true;
                    Monitor.Pulse(locker);
                }
            }
        }
    }
}
