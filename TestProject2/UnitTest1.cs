using graficNS;
namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<double>result= new List<double>();
            List<double> actual = new List<double> () { 201.71563612245589, 74.209948524787848, 27.308232836016487, 10.067661995777765, 3.7621956910836314, 1.5430806348152437, 1, 1.5430806348152437, 3.7621956910836314 };
            result = grafic.function_test(-6, 2, 1, 1);
            CollectionAssert.AreEqual(result, actual);

            actual = new List<double>() { 3.7621956910836314, 2.3524096152432472, 1.5430806348152437, 1.1276259652063807, 1, 1.1276259652063807, 1.5430806348152437, 2.3524096152432472, 3.7621956910836314 };
            result= grafic.function_test(-2, 2, 0.5, 1);
            CollectionAssert.AreEqual(result, actual); 
            
            actual = new List<double>() { 8.2250484799613872, 11.286587073250894, 15.613845703785259, 21.692099319559041, 30.202985987333296};
            result = grafic.function_test(5, 9, 1, 3);
            CollectionAssert.AreEqual(result, actual);

            actual = new List<double>() { 107334.91460984045, 30751.967911074025, 8810.58633608266, 2524.2753066201403};
            result = grafic.function_test(-10, -7, 1, 0.8);
            CollectionAssert.AreEqual(result, actual);

            actual = new List<double>() { 1.0050041680558035, 1.0200667556190759, 1.0453385141288605, 1.081072371838455, 1.1276259652063807, 1.1854652182422676};
            result = grafic.function_test(0.1, 0.6, 0.1, 1);
            CollectionAssert.AreEqual(result, actual);
        }
    }
}