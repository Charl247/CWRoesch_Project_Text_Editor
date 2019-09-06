#region Namespaces Used
using System;
using System.Windows.Forms;
#endregion

#region Documentation

/* Author       :   Charl Roesch
 * Date         :   29/08/2019
 * Description  :   The Program class contains the Main() method which will be the 
 *                  entry point of the of the program and instantiates the mainForm()
 *                  class when the application is executed/started.
 *                                    
 */

#endregion
namespace OMyWord
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
