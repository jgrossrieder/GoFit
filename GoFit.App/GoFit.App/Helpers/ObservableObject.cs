using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GoFit.App.Helpers
{
    /// <summary>
    /// Observable object with INotifyPropertyChanged implemented
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
    {
        private readonly Dictionary<String, object> m_backingFields = new Dictionary<string, object>();

        /// <summary>
        /// Sets the property.
        /// </summary>
        /// <returns><c>true</c>, if property was set, <c>false</c> otherwise.</returns>
        /// <param name="value">Value.</param>
        /// <param name="propertyName">Property name.</param>
        /// <param name="onChanged">On changed.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        protected bool SetProperty<T>(T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            object currentValue;
            if (m_backingFields.TryGetValue(propertyName,out currentValue) && EqualityComparer<T>.Default.Equals((T)currentValue, value))
            {
                return false;
            }

            m_backingFields[propertyName] = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        protected T GetProperty<T>([CallerMemberName] string propertyName = "")
        {
            object currentValue;
            if (m_backingFields.TryGetValue(propertyName, out currentValue) )
            {
                return (T) currentValue;
            }
            return default(T);
        }
        /// <summary>
        /// Occurs when property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the property changed event.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChangedEventHandler changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}