using System.Windows;

public partial class App : Application
{
    //Запуск одной копии приложения
    System.Threading.Mutex mutex;
    private void Button1_Click(object sender, RoutedEventArgs e)
    {
        foreach (Window window in Application.Current.Windows)
        {
            MessageBox.Show(window.ToString());
        }
    }
}
