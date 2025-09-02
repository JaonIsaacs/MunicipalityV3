namespace MunicipalityV3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Configure application styles
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start with the main form
            Application.Run(new MainForm());
        }
    }
}