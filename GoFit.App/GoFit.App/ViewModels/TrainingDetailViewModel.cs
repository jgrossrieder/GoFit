using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFit.App.Models;

namespace GoFit.App.ViewModels
{
    public class TrainingDetailViewModel : BaseViewModel
    {
        private readonly Training _training;


        public String Title
        {
            get => "TOT";
        }

        public TrainingDetailViewModel(Training training)
        {
            _training = training;
        }
    }

}
