//A Manning

public class solution2
{
  /* This code will find the sum of all even fibonacci numbers less than 4,000,000
  / This code is very modular. changing the value of n will always give the correct answer for n =/= 0
  /
  / To avoid having to change the code whenever one wants a different upper bound , one should implement
  / the util.scanner method as seen in the problem 1 java solution. 
  */
  public static void main(String[] args)
  {
    int n = 4000000;
    int last = 1; //This line and the next 2 initialise the solution. 
    int current = 2; 
    int sum = 2; 
    while (current < n)
    {
      current = current + last; // makes current the next element in the fibonacci sequence
      last = current - last; // makes last the previous element in the sequence
      {
        if (current %2 == 0) //if current is even
        {
          if (current < n)//implemented as a nested loop here to improve runtime 
          {
            sum = sum + current;
          }
        }
      }
    }
    System.out.println("The sum is " + sum);
  }
}
       
      
    