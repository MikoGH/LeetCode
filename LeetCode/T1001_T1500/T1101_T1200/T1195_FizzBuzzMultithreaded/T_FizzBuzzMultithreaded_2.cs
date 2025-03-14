namespace LeetCode.T1001_T1500.T1101_T1200.T1195_FizzBuzzMultithreaded;

public class T_FizzBuzzMultithreaded_2
{
    private int n;
    private int currentIndex = 1;

    public T_FizzBuzzMultithreaded_2(int n)
    {
        this.n = n;
    }

    // printFizz() outputs "fizz".
    public void Fizz(Action printFizz)
    {
        for (int index = 1; index <= n; index++)
        {
            if (index % 3 == 0 && index % 5 != 0)
            {
                SpinWait.SpinUntil(() => currentIndex == index);
                printFizz();
                currentIndex++;
            }
        }
    }

    // printBuzzz() outputs "buzz".
    public void Buzz(Action printBuzz)
    {
        for (int index = 1; index <= n; index++)
        {
            if (index % 3 != 0 && index % 5 == 0)
            {
                SpinWait.SpinUntil(() => currentIndex == index);
                printBuzz();
                currentIndex++;
            }
        }
    }

    // printFizzBuzz() outputs "fizzbuzz".
    public void Fizzbuzz(Action printFizzBuzz)
    {
        for (int index = 1; index <= n; index++)
        {
            if (index % 15 == 0)
            {
                SpinWait.SpinUntil(() => currentIndex == index);
                printFizzBuzz();
                currentIndex++;
            }
        }
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Number(Action<int> printNumber)
    {
        for (int index = 1; index <= n; index++)
        {
            if (index % 3 != 0 && index % 5 != 0)
            {
                SpinWait.SpinUntil(() => currentIndex == index);
                printNumber(index);
                currentIndex++;
            }
        }
    }
}
