using Tyuiu.GoryaevTT.Sprint6.TaskReview.Lib;
namespace Tyuiu.GoryaevTT.Sprint6.TaskReview.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
        public void ValidGetMatrix()
        {
        DataService ds = new DataService();
        var matrix = new int[,] {
            { 1,2,3 }
            , { 4, 5, 6} 
            , {7,8,9 } };
        int n1 = 1;
        int n2 = 9;
        int c = 1;
        int k = 0;
        int l = 2;
        int res = ds.result_GetMatrix(matrix, n1, n2, c, k, l);
        Assert.AreEqual(res, res);
        }
}

