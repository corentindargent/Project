using AppLabo4.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabo4.ViewModel
{
    
    public class MainViewModel : ViewModelBase,INotifyPropertyChanged
    {
        private ObservableCollection<Student>_students;
        private Student _selectedStudent;


        //cons

        private INavigationService _navigationService;
        [PreferredConstructor]
        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            //Init liste
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents());
        }




        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                 //Signale faire attention au changements
                RaisePropertyChanged("Students");
            }
        }

        public Student SelectedStudent {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                if(_selectedStudent != null)
                {
                    RaisePropertyChanged("SelectedStudents");
                }
            }
        }


      


    }
}
