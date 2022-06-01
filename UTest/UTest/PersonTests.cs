namespace UTest
{
   [TestClass]
   public class PersonTests
   {
      [TestMethod]
      public void TestMethod1()
      {
         var person = Setup.Person()
            .WithName("Robert")
            .WithAge(42)
            .Done();

         Assert.IsNotNull(person);
      }
   }
}