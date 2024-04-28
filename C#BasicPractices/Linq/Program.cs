using Linq;
using System.Collections;

public static class Program
{
    public static void Main()
    {
        //Display the characters and frequency of character from giving string
        CharactersAndFrequency charactersAndFrequency = new CharactersAndFrequency();
        charactersAndFrequency.CharactersAndFrequencyMethod();

        /*//Display the number and frequency of number from given array
        FrequencyOfNumber frequencyOfNumber = new FrequencyOfNumber();
        frequencyOfNumber.FrequencyOfNumberMethod();*/


        /* //Array and the square of each number which is more than 20 
         MoreThan20 moreThan20 = new MoreThan20();
         moreThan20.MoreThan20Meth();*/

        /* //Select postive number
         PostiveNumbList postiveNumbList = new PostiveNumbList();
         postiveNumbList.PostiveNumbListMeth();*/

        /*  //Divided by linq
          DividedBy2 dividedBy2 = new DividedBy2();
          dividedBy2.DividedBy2Met();*/

        /* //Find the second max value
         FindSecondMax findSecondMax = new FindSecondMax();
         ArrayList listValue = new ArrayList() { -2, 20, 11, 18, 15, 10 };
         var secondMax = findSecondMax.FindSecondMaxMethod(listValue);
         Console.WriteLine(secondMax.ToString());*/

        /*Console.Write("Enter the name you want to remove: ");
        string nameToRemove = Console.ReadLine();
        ReemoveStringInList reemoveStringInList = new ReemoveStringInList();
        reemoveStringInList.ReemoveStringInListMethod(nameToRemove);*/


        /*EmployeeLeaveList employeeLeaveList = new EmployeeLeaveList();
        employeeLeaveList.GetEmployeeLeaveList();*/

    }
}