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

namespace WpfApp14._8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonModel Tom;// Создание экземпляра модели данных
        public MainWindow()
        {
            InitializeComponent();
            Tom = new PersonModel();
            this.DataContext = Tom;// Установка контекста данных для привязки
        }
    }
    public class PersonModel : IDataErrorInfo // Модель данных пользователя с реализацией интерфейса валидации
    {
        public string Name { get; set; }// Свойства модели
        public int Age { get; set; }
        public string Position { get; set; }
        public string this[string columnName] // Реализация индексатора для проверки ошибок по имени свойства
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Age":// Валидация возраста
                        if ((Age < 0) || (Age > 100))
                        {
                            error = "Возраст должен быть больше 0 и меньше 100";
                        }// Обработка ошибок для свойства Name
                        break;
                    case "Name":
                        //Обработка ошибок для свойства Name
                        break;
                    case "Position":
                        //Обработка ошибок для свойства Position
                        break;
                }
                return error;
            }
        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }
    }
    public interface IDataErrorInfo
    {
        string Error { get; }
        string this[string columnName] { get; }
    }

}
