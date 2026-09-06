namespace Cashier_Queuing_Application_TP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
            cashierWindow.Show();

            CustomerView cv = new CustomerView();
            cv.Show();

            Application.Run(new QueuingForm());
        }
    }
}