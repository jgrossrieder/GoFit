using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GoFit.App.Models;

using Xamarin.Forms;

[assembly: Dependency(typeof(GoFit.App.Services.TrainingStore))]
namespace GoFit.App.Services
{
    public class TrainingStore : IDataStore<Training>
    {
        bool _isInitialized;
        List<Training> _items;

        public async Task<bool> AddItemAsync(Training item)
        {
            await InitializeAsync();

            _items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Training newItem)
        {
            await InitializeAsync();

            Training item = _items.FirstOrDefault(arg => arg.Id == newItem.Id);
            _items.Remove(item);
            _items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Training itemToDelete)
        {
            await InitializeAsync();

            Training item = _items.FirstOrDefault(arg => arg.Id == itemToDelete.Id);
            _items.Remove(item);

            return await Task.FromResult(true);
        }

        public async Task<Training> GetItemAsync(string id)
        {
            await InitializeAsync();

            return await Task.FromResult(_items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Training>> GetItemsAsync(bool forceRefresh = false)
        {
            await InitializeAsync();

            return await Task.FromResult(_items);
        }

        public Task<bool> PullLatestAsync()
        {
            return Task.FromResult(true);
        }


        public Task<bool> SyncAsync()
        {
            return Task.FromResult(true);
        }

#pragma warning disable 1998
        public async Task InitializeAsync()
#pragma warning restore 1998
        {
            if (_isInitialized)
                return;

            _items = new List<Training>();
            _isInitialized = true;
        }
    }
}
