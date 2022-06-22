using System.Collections.ObjectModel;
using System.Windows;

namespace DXGrid_ShowCheckBoxInColumnHeaders {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            ObservableCollection<Person> people = new ObservableCollection<Person>();
            for (int i = 0; i < 10; i++) {
                people.Add(new Person(i));
            }
            grid.ItemsSource = people;
        }
    }
    public class Person {
        public Person(int i) {
            FirstName = "FirstName" + i;
            LastName = "LastName" + i;
            Age = i * 10;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}