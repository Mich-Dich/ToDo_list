using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace ToDo.View
{
    /// <summary>
    /// Interaction logic for project_header.xaml
    /// </summary>
    public partial class project_header : UserControl, INotifyPropertyChanged {

        public project_header() {

            DataContext = this;
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string project_title = "Unknown";
        public string Project_Title {

            get { return project_title; }
            set { 
                project_title = value;
                on_property_changed();
            }
        }

        private int num_of_tasks = 0;
        public int Num_ofTasks {

            get { return num_of_tasks; }
            set { 
                num_of_tasks = value; 
                //TB_Num_of_Tasks.Text = num_of_tasks.ToString();
            }
        }



        private void on_property_changed( [CallerMemberName] string propertyName = null) {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
