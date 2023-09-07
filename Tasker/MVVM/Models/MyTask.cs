using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.MVVM.Models
{
    public class MyTask : INotifyPropertyChanged
    {
        private string _taskName;
        private string _taskColor;
        private bool _completed;
        private int _categoryId;
        public string TaskName 
        {
            get => _taskName;
            set
            {
                _taskName = value;
                OnPropertyChanged();
            }
        }
        public bool Completed 
        { 
            get => _completed;
            set
            {
                _completed = value;
                OnPropertyChanged();
            }
        }
        public int CategoryId 
        { 
            get => _categoryId;
            set
            {
                _categoryId = value;
                OnPropertyChanged();
            }
        }
        public string TaskColor 
        { 
            get => _taskColor;
            set
            {
                _taskColor = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
