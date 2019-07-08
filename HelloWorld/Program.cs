using System;

namespace HelloWorld {
    class Program {
    static void Main(string[] args) {
      MyClass myClass = new MyClass();
      Console.WriteLine($"Hello World! {myClass.ReturnMessage()}");
    }
  }
}
