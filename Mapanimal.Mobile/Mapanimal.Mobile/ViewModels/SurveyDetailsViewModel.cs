using Mapanimal.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mapanimal.Mobile.ViewModels
{
    public class SurveyDetailsViewModel : NotificationObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string question;

        public string Question
        {
            get { return question; }
            set { question = value; }
        }


        public ICommand SaveCommand { get; set; }

        public SurveyDetailsViewModel()
        {
            SaveCommand = new Command(() =>
            {
                MessagingCenter.Send(this, "SaveSurvey", new Survey
                {
                    Name = this.Name,
                    Question = this.Question
                });
            });
        }
    }
}
