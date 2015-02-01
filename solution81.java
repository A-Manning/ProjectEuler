/* A Manning, in collaboration with Ajwad Anwar and Hannah Cohen

This code is similar to my solution 8 but checks for zeros and can skip sequences that contain 0. 
For inputs with a large amount of zeros, this will be faster than my algorithm. 
Both algorithms should run in constant time. 
It remains to be proven what percentage of zeros an algorithm must have before this is faster than mine. 

*/
public class solution81
{
  public static void main(String[] args)
  {
      int[] array = new int[1000];
      array = makeArray();
      int begin = 0;
      long greatestProduct = 1;
      while(begin < 986)
      {
        int index = checkZeros(array, begin);
        if (index == -1)
        {
          int startindex=begin;
          long tmp = getProduct(array,startindex);
          if (tmp > greatestProduct)
          {
            greatestProduct = tmp;
            startindex++;
          }
        begin++;
        }
        else
        {
          begin = index++;
        }  
      }
      System.out.println(greatestProduct);
  }
  
  
  
  public static int[] makeArray()
  {
    String number="7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
  
    int[] numberlist = new int[number.length()];
  
    for(int i=0; i<number.length() ; i++)
    {
      numberlist[i]=number.charAt(i)-'0';
    }
    return numberlist;
  }
  public static int checkZeros(int[] arr, int begin)
  {
    int x=0;
    /*The code constantly stops at 13 because it finds the first zero at 13 , index is then set to 14 but during the backwards search the index is again set at 13*/
    for(int i = begin; i < begin+13 ; i++)
    {
      if (arr[i] == 0) 
      {
        x=(i); 
      }
    
      else
        x= -1;
      
    }
  
    return x;
  }
  
 
  public static long getProduct(int[] arr, int begin)
  {
    long product = 1; 
    for (int i = begin ; i < begin + 13; i++ )
    {
      product = product * arr[i];
    }
    return product;
  }
  
}
  