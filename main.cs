using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class sortingalgorithms{

  public static void bubblesort () {
    List<int> values = new List<int>();
    values.Add(3);
    values.Add(5);
    values.Add(2);
    values.Add(4);
    values.Add(1);
    foreach(var value in values) {
      Console.WriteLine(value);
    }

  }

  public static void Main(string[] args)
  {
    sortingalgorithms.bubblesort();
  }

}
