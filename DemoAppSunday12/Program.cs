namespace DemoAppSunday12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAccess dataAccess = new DataAccess();
            DataAccessUsingNosql dataAccessUsingNosql = new DataAccessUsingNosql();
            IBusiness obj = new Business(dataAccess);

            UserInterface userInterface = new UserInterface(obj);
            userInterface.getData();
        }
    }
}
