using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class sortingalgorithms{

  public static void bubblesort () {
    List<int> values = new List<int>();
    values.Add(5);
    values.Add(3);
    values.Add(2);
    values.Add(4);
    values.Add(1);

    if(values[0] >= values[1]){
      int val1 = values[0];
      int val2 = values[1];

      values[0] = val2;
      values[1] = val1;

      foreach(var value in values){
        Console.WriteLine(value);
      }
    }

  }

  public static void Main(string[] args)
  {
    sortingalgorithms.bubblesort();
  }

}
