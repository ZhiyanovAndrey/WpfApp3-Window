using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp3_Window
{
    class MyCommands
    {
         public static RoutedUICommand Exit { get; set; } 

        static MyCommands ()  //статический конструктор класса без параметров
        {
            InputGestureCollection input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.T, ModifierKeys.Control,"Ctrl+T")); //установка горячей клавиши 
            Exit = new RoutedUICommand("Закрыть","Exit", typeof(MyCommands),input); //Инициализирует новый экземпляр System.Windows.Input.RoutedUICommand
                                                                                    //класс с помощью  описательный текст,
                                                                                    //объявленное имя, тип владельца и входных жестов.
                                                                                    //если добавленно имя, то его можно удалить из header
        }
    }
}
