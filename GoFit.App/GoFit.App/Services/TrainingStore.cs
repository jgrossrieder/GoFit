using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GoFit.App.Models;

using Xamarin.Forms;

[assembly: Dependency(typeof(GoFit.App.Services.TrainingStore))]
namespace GoFit.App.Services
{
    public class TrainingStore : ITrainingStore
    {
        private bool _isInitialized;
        private Training _currentTraining;

#pragma warning disable 1998
        public async Task InitializeAsync()
#pragma warning restore 1998
        {
            if (_isInitialized)
                return;

            _currentTraining = new Training();
            _isInitialized = true;
        }

        public async Task<Training> GetCurrentTrainingAsync()
        {
            await InitializeAsync();
            return _currentTraining;
        }
    }
}
