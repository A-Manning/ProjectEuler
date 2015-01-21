import java.util.Arrays;
public class solution4
{
  public static void main(String args[])
  {
    // assume the largest number has 6 digits;
    // 999*999 = 99801,the nearest palindrome to this is 997799
    // thus, we will initialise the palindrome from 101 to 799 (palindromes cannot end in 0)
    // this property will not be strictly checked when initialising the array. it will be checked later. 
    int[] palindromes = new int[699];
    for (int i = 0; i < 699; i++)
    {
      palindromes[i] = palindromise(i + 101);
    }
    //palindromes[] is not sorted, so this must be done. 
    Arrays.sort(palindromes);
    System.out.println(greatest(palindromes)); // 
  }
  public static int palindromise(int i) //Takes a 3 digit number, eg 123, and outputs a 6 digit palindrome eg 321123
  {
    i = i + ((i%10)*100000);
    i = i + (((i%100)-(i%10))*1000);
    i = i + (((i%1000)-(i%100))*10);
    return i; 
  }
  public static boolean findDiv(int n)//checks if a number has two three-digit divisors
  {
    for (int i = 100; i < 1000; i++)
    {
      if (n%i == 0 && ((n/i) > 99 ) && ((n/i)<1000))
      {
        return true;
      }
    }
    return false;
  }
  public static int greatest(int[] palindromes) 
  {
  // takes a sorted, low-to-high array of palindrome integers
  // returns the largest element that has two three-digit divisors. 
    for (int i = 0; i < 699; i++)
    {
      if (findDiv(palindromes[698-i])==true)
      {
        return palindromes[698-i];
      }
    }
    return 0;
  }
}
