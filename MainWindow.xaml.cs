using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp11._4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Инициализация компонентов
            Style buttonStyle = new Style(); // Создание нового стиля для кнопок
            // Добавление сеттеров для свойств стиля
            // Добавление обработчика события клика
            buttonStyle.Setters.Add(new Setter { Property = Control.FontFamilyProperty, Value = new FontFamily("Verdana") });
            buttonStyle.Setters.Add(new Setter { Property = Control.MarginProperty, Value = new Thickness(10) });
            buttonStyle.Setters.Add(new Setter { Property = Control.BackgroundProperty, Value = new SolidColorBrush(Colors.Black) });
            buttonStyle.Setters.Add(new Setter { Property = Control.ForegroundProperty, Value = new SolidColorBrush(Colors.White) });
            buttonStyle.Setters.Add(new EventSetter { Event = Button.ClickEvent, Handler = new RoutedEventHandler(Button_Click) });
            // Применение стиля к кнопкам
            button1.Style = buttonStyle;
            button2.Style = buttonStyle;
        }
        // Обработчик события клика по кнопке
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender; // Получение нажатой кнопки
            MessageBox.Show(clickedButton.Content.ToString()); // Вывод содержимого кнопки в MessageBox
        }
    }
}
