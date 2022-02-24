using Mapanimal.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mapanimal.Mobile.ViewModels
{
    public class MainPageViewModel : NotificationObject
    {
        private ObservableCollection<Survey> surveys;

        public ObservableCollection<Survey> Surveys
        {
            get { return surveys; }
            set 
            { 
                surveys = value;
                OnPropertyChanged();
            }   
        }

        public ICommand AddCommand { get; set; }

        public MainPageViewModel()
        {
            surveys = new ObservableCollection<Survey>();
            AddCommand = new Command(AddCommandExecute);
            MessagingCenter.Subscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey", (a, s) =>
            {
                Surveys.Add(s);
            });
        }

        private void AddCommandExecute()
        {
            MessagingCenter.Send(this, "AddSurvey");
        }
    }
}
