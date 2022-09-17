using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class sortingalgorithms{
  public static void insertionsort () {
    
  }

  public static void bubblesort () {
    List<int> values = new List<int>();
    values.Add(10);
    values.Add(4);
    values.Add(16);
    values.Add(9);
    values.Add(47);


    while ((values[0] < values[1] && values[1] < values[2] && values[2] < values[3] && values[3] < values[4]) != true){
      int a = 0;
      while(a < values.Count - 1){
        if(values[a] >= values[a+1]){
          int val1 = values[a];
          int val2 = values[a+1];

          values[a] = val2;
          values[a+1] = val1;
        }
        a++;
      }
    }
    values.Reverse();
    for(int a = 0; a <= 4; a++){
      Console.WriteLine(values[a]);
    }
  }

  public static void Main(string[] args)
  {
    sortingalgorithms.bubblesort();
  }

}
