namespace LeetCode.T1001_T1500.T1101_T1200.T1195_FizzBuzzMultithreaded;

public class T_FizzBuzzMultithreaded
{
    private int n;
    private int currentIndex = 1;

    public T_FizzBuzzMultithreaded(int n)
    {
        this.n = n;
    }

    private void WaitAndPrint(int index, Action action)
    {
        SpinWait.SpinUntil(() => currentIndex == index);
        action();
        currentIndex++;
    }

    // printFizz() outputs "fizz".
    public void Fizz(Action printFizz)
    {
        for (int index = 1; index <= n; index++)
        {
            if (index % 3 == 0 && index % 5 != 0)
                WaitAndPrint(index, printFizz);
        }
    }

    // printBuzzz() outputs "buzz".
    public void Buzz(Action printBuzz)
    {
        for (int index = 1; index <= n; index++)
        {
            if (index % 3 != 0 && index % 5 == 0)
                WaitAndPrint(index, printBuzz);
        }
    }

    // printFizzBuzz() outputs "fizzbuzz".
    public void Fizzbuzz(Action printFizzBuzz)
    {
        for (int index = 1; index <= n; index++)
        {
            if (index % 15 == 0)
                WaitAndPrint(index, printFizzBuzz);
        }
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Number(Action<int> printNumber)
    {
        for (int index = 1; index <= n; index++)
        {
            if (index % 3 != 0 && index % 5 != 0)
                WaitAndPrint(index, () => printNumber(index));
        }
    }
}
