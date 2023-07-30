namespace NetCoreAdo.Utility
{
    public class ConnectionString
    {
        public static string cName = "Server=localhost;Database=DbCRUDDotnetCore;Trusted_Connection=True;MultipleActiveResultSets=true";

       // public static string CName { get { return cName; } }
        public static string CName { get => cName;}
    }
}
