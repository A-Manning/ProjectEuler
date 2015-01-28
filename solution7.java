/*A Manning
 * 
 * Runtime is a good here, but generating all of the primes is a slow process. 
 * 
 * This could be faster, but coding it would take far longer than I'd save in runtime.  
 * 
*/
public class solution7
{
  public static void main(String[] args)
  {
    int[] primes = new int[10001];
    primes[0] = 2;
    primes[1] = 3; 
    for (int i = 2; i <10001; i++)
    {
      for (int j = (primes[i-1]+2); j<214748364 ; j+=2)
      {
        if (isprime(j) == true)
        {
          primes[i] = j;
          j = 214748364;//so that the loop terminates
        }
      }
    }
    System.out.println(primes[10000]);
  }
  public static boolean isprime(int n)
  {
    if(n%2 == 0)
    {
      return false;
    }
    else if (n%3 == 0)
    {
      return false;
    }
    else 
    {
      for(int i = 5; i < (Math.sqrt(n)+1) ; i += 2)
      {
        if (i%3 != 0)
        {
          if (n%i == 0)
          {
            return false;
          }
        }
      }
    }
    return true;
  }
}