/* A Manning
 *
 * This method is relatively fast.I *think* it's O(n)!
 * Though possible to ignore the result of any sequence containing 0, I do not think that this will improve efficiency
 * It would also take longer to code!
 * 
*/
public class solution8
{
  public static void main(String[] args)
  {
    char[] arr = makearr(); // character array of the problem
    long ans = 0L; //stores the highest encountered sequence product
    for (int i = 0; i< 988; i++)//loops over every possible sequence
    {
      long charmult = 1L;//the sequence product
      for(int j = 0; j<13 ; j++)//loops over the sequence 
      {
        charmult = charmult* (arr[i+j] - 48);//multiplies charmult by the integer I+J points to, -48 for char-int conversion
      }
      if (charmult > ans)//if the sequence product is the greatest so far encountered, stores it
      {
        ans = charmult; 
      }
    }
    System.out.println(ans);//prints the answer
  }
  
  // This ugly-looking method makes a char array from the problem. Horrendous efficiency, could have done this better. 
  // It works and only needs to be called once though. 
  public static char[] makearr() 
  {
    int[] arr = new int[1000]; 
    String numbs0  = new String("73167176531330624919225119674426574742355349194934");
    String numbs1  = new String("96983520312774506326239578318016984801869478851843");
    String numbs2  = new String("85861560789112949495459501737958331952853208805511");
    String numbs3  = new String("12540698747158523863050715693290963295227443043557");
    String numbs4  = new String("66896648950445244523161731856403098711121722383113");
    String numbs5  = new String("62229893423380308135336276614282806444486645238749");
    String numbs6  = new String("30358907296290491560440772390713810515859307960866");
    String numbs7  = new String("70172427121883998797908792274921901699720888093776");
    String numbs8  = new String("65727333001053367881220235421809751254540594752243");
    String numbs9  = new String("52584907711670556013604839586446706324415722155397");
    String numbs10 = new String("53697817977846174064955149290862569321978468622482");
    String numbs11 = new String("83972241375657056057490261407972968652414535100474");
    String numbs12 = new String("82166370484403199890008895243450658541227588666881");
    String numbs13 = new String("16427171479924442928230863465674813919123162824586");
    String numbs14 = new String("17866458359124566529476545682848912883142607690042");
    String numbs15 = new String("24219022671055626321111109370544217506941658960408");
    String numbs16 = new String("07198403850962455444362981230987879927244284909188");
    String numbs17 = new String("84580156166097919133875499200524063689912560717606");
    String numbs18 = new String("05886116467109405077541002256983155200055935729725");
    String numbs19 = new String("71636269561882670428252483600823257530420752963450");
    
    String addnumb = new String(numbs0.concat(numbs1.concat(numbs2.concat(numbs3.concat(numbs4.concat(numbs5.concat(numbs6.concat(numbs7.concat(numbs8)))))))));
    String addnumb1 = new String(addnumb.concat(numbs9.concat(numbs10.concat(numbs11.concat(numbs12.concat(numbs13.concat(numbs14.concat(numbs15))))))));
    String addnumb2 = new String (addnumb1.concat(numbs16.concat(numbs17.concat(numbs18.concat(numbs19)))));
                                
    char[] arr1 = addnumb2.toCharArray();
    return arr1;
    
  }
}