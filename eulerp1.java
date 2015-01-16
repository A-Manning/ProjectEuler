import java.util.Scanner;
public class eulerp1
{
  public static void main(String[] args)
  {
    Scanner sc = new Scanner(System.in);
    System.out.println("Enter the number for which you wish to sum up to");
    int v = sc.nextInt();
    int sum = 0;
    for (int i =1 ; i < v; i++)
    {
      if( i%3 == 0 || i%5 == 0)
      {
        sum = sum + i;
      }
    }
    System.out.println("the sum of all multiples of 3 and 5 under " + v + " is " + sum + " .");
  }
}