using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace DataBinding
{
    class PersonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected internal void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
            //MessageBox.Show("The Value of " + propertyname + " changed");
        }

        private Person _personModel;

        public PersonViewModel(Person person)
        {
            _personModel = person;
            //IncreaseAgeCommand = new Command(IncreaseAge);
        }

        public string Name
        {
            get
            {
                return _personModel.Name;
            }
            set
            {
                _personModel.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Age
        {
            get
            {
                return _personModel.Age;
            }
            set
            {
                _personModel.Age = value;
                //if (_personModel.Age >= 40)
                //{
                //    IncreaseAgeCommand.CanExecute() = false;
                //}
                //else
                //{
                //    IncreaseAgeCommand.CanExecute() = true;
                //}

                OnPropertyChanged("Age");
            }
        }

        //private void IncreaseAge()
        //{
        //    Age++;
        //}

        public ICommand IncreaseAgeCommand
        {
            get;
            private set;
        }

        
    }
}
