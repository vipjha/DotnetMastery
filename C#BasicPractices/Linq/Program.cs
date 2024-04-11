using Linq;

public static class Program
{
    public static void Main()
    {
        Console.Write("Enter the name you want to remove: ");
        string nameToRemove = Console.ReadLine();
        ReemoveStringInList reemoveStringInList = new ReemoveStringInList();
        reemoveStringInList.ReemoveStringInListMethod(nameToRemove);
       
       /*
       EmployeeLeaveList employeeLeaveList = new EmployeeLeaveList();
       employeeLeaveList.GetEmployeeLeaveList();
       */
    }
}