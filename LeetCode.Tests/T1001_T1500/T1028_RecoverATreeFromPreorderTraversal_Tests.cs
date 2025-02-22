using LeetCode.T1001_T1500.T1028_RecoverATreeFromPreorderTraversal;

namespace LeetCode.Tests.T1001_T1500;

public class T1028_RecoverATreeFromPreorderTraversal_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_RecoverATreeFromPreorderTraversal();

        var result = taskClass.RecoverFromPreorder("1-2--3--4-5--6--7");
    }
}
