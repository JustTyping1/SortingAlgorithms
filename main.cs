using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class sortingalgorithms{

  public bubblesort () {
    Random rnd = new Random();
    List<int> values = new List<int>();
    for(int b; b <= 10; b++) {
      values.Add(rnd.next(100));
    }
    int i = 0;
    while (i <= values.length) {
      if (values[i] > values[i + 1]) {
        int val1 = values[i];
        int val2 = values[i+1];

      }
      i += 1;
    }
  }

  public static void Main(string[] args)
  {
  }

}
