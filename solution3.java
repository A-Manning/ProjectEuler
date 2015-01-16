import java.util.Scanner;
public class solution3
{
  //This code will find the largest prime factor of a number n
  public static void main(String[] args)
  {
    Scanner sc = new Scanner(System.in);
    System.out.println("Enter a number to find the largest prime factor.");
    long n = sc.nextLong();
    long prime = 0;
    for(long i = 2; i < (n/2) ; i++)
    {
      if( n % i == 0)//if n is divisible by i
      {
        if(isPrime(i) == true)
        {
          prime = i;
          System.out.println(i);//for debugging
        }
      }
    }
    if (prime != 0)
    {
      System.out.println("The largest prime factor is " + prime);
    }
    else
    {
       System.out.println("The input is prime");
    }
  }
  public static boolean isPrime(Long i) // checks for primality , relatively efficient
  {
    if (i == 2 || i == 3)
    {
      return true;
    }
    if( i%2 ==0 || i%3 ==0)
    {
      return false;
    }
    double rootI = Math.sqrt(i);
    for (double j = 2; j < (Math.sqrt(i)+1);j++)
    {
      if(i%j ==0)
      {
        return false;
      }
    }
    return true;
  }
}

  