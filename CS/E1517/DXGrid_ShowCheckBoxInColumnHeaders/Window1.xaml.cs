// Developer Express Code Central Example:
// How to display a check box within column headers
// 
// This example demonstrates how to display a check box within column headers. If
// the check box is checked, the corresponding column is made read-only. Uncheck
// the check box to allow column values to be edited.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1517

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;

namespace DXGrid_ShowCheckBoxInColumnHeaders {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            CreateList();
            DataContext = this;
        
        }
        public List<Person> ListPerson { get; set; }
        void CreateList() {
            ListPerson = new List<Person>();
            for (int i = 0; i < 10; i++) {
                ListPerson.Add(new Person(i));
            }
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
