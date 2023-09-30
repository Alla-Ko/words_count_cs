using System.Windows.Forms;
namespace WinFormsApp1_ui
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        static DialogResult ShowMessageBoxes()
        {
            String caption = "Заголовок";
            String message = "Текстове повідомлення";
            MessageBox.Show(message);
            message = "Щось інше";
            DialogResult result= MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);
            String button = result.ToString();
            result = MessageBox.Show("Щось відбулося "+button+" і ще щось ", button, MessageBoxButtons.AbortRetryIgnore);
            return result;
        }
        [STAThread]
        static void Main()
        {   
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            /*
            DialogResult result;
            do
            {
                result = ShowMessageBoxes();    
            }while(result == DialogResult.Retry);
            */
        }
    }
}