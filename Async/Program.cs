namespace Async
{
    class Program
    {
        static async Task Main(string[] args)
        {

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = await MainMenu();
            }

        }

        private static async Task<bool> MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Sync");
            Console.WriteLine("2) Non Blocking");
            Console.WriteLine("3) Async");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    SyncBreakfast.Make();
                    return true;
                case "2":
                    await NonBlockingBreakfast.MakeAsync();
                    return true;
                case "3":
                    await AsyncBreakfast.MakeAsync();
                    return true;
                default:
                    return true;
            }
        }
    }
}
