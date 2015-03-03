// A Manning

import java.util.Calendar;
public class solution19
{
  public static void main(String[] args)
  {
    Calendar date = Calendar.getInstance();//create a new calendar object
    date.set(1900,0,7);//initialise the calendar to the first sunday of 1900. for some odd reason, months in java are 0-indexed. 
    while(date.get(Calendar.YEAR) != 1901)
    {
      date.add(Calendar.DATE, 7);
    }
    // We are now at the first sunday of the 20th century. 
    int sundays = 0; 
    while(date.get(Calendar.YEAR) < 2001)
    {
      if(date.get(Calendar.DATE) == 1)
      {
        sundays++;
      }
      date.add(Calendar.DATE, 7);
    }
    System.out.println(sundays);//prints the answer
  }
}