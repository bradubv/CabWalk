using Cnt.CompositeUI.WinForms;

namespace CabWalk
{
    public class Program : FormShellApplication<ShellWorkItem, ShellForm>
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new Program().Run();
        }
    }
}