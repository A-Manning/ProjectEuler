// A Manning
// This will throw an error for Prime N!
// Otherwise, this code is highly efficient, unlike my first solution which had huge runtime

import java.util.*;
public class betterSolution3
{
  public static void main(String[] args)
  {
    //This solution will have better runtime and relies on the fact that prime factorisation is unique
    //Most other solutions of this problem mistakenly only check primes up to the root of the input
    //This is mistaken as it is the SMALLEST prime that is less than the root of the input
    //The LARGEST prime factor may well be larger, such as in the case of 15.
    //Most other solutions fail for the 15 case. 
    long n = 600851475143L; 
    long finaln = n;
    //I will use a linkedlist to hold prime factors, because I do not know how many prime factors n will have
    LinkedList<Long> factors = new LinkedList<Long>();
    long i = 2; //I is our divisor
    while (n != 1)//We will divide n by it's factors and add those factors to the factors list. 
    // factors that are multiples of 2 or 3 will not be considered to improve runtime. 
    {
      if (n%i == 0)
      {
        if(i == 2 || i==3 ||(i%2 != 0 && i%3 != 0 && i != finaln))
        {
          factors.add(i);
          n = (n/i);
        }
      }
      else 
      {
        i++;
      }
    }
    System.out.println(greatestPrime(factors));
    
  }
  public static Boolean isPrime(long num){ //method signature. returns Boolean, true if number isPrime, false if not
    if(num==2){ //for case num=2, function returns true. detailed explanation underneath
      return(true);
    }
    for(long i=2;i<=(long)Math.sqrt(num)+1;i++){ //loops through 2 to sqrt(num). All you need to check- efficient
      if(num%i==0){ //if a divisor is found, its not prime. returns false
        return(false);
      }
    }
    return(true); //if all cases don't divide num, it is prime.
  }
  public static long greatestPrime(LinkedList<Long> L)
  {
    if(isPrime(L.getLast()) == true)
    {
      return L.getLast();
    }
    else
    {
      L.removeLast();
      return greatestPrime(L);
    }
  }
}