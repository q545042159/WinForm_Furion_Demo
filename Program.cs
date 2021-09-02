using Furion;
using Furion.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var service = Inject.Create();
            
            service.Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

    public interface IHelloService
    {
        string SayHello();
    }

    public class HelloService:IHelloService,ITransient
    {
        public string SayHello()
        {
            return "Hello";
        }
    }
}
