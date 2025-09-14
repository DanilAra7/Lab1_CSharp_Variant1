using System;
using System.Windows.Forms;
using Lab1_WinForms; // Додайте, якщо відсутня

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }
}