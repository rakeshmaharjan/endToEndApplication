using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using Core.Common.Utils;

namespace Core.Common.Core
{
    public class TempObjectBase : INotifyPropertyChanged
    {
        private event PropertyChangedEventHandler _PropertyChanged;

        List<PropertyChangedEventHandler> _PropertyChangedSubscribers = new List<PropertyChangedEventHandler>();

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                if (!_PropertyChangedSubscribers.Contains(value))
                {
                    _PropertyChanged += value;
                    _PropertyChangedSubscribers.Add(value);
                }
            }
            remove
            {
                _PropertyChanged -= value;
                _PropertyChangedSubscribers.Remove(value);
            }
        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            //if (PropertyChanged!=null)
            //{
            //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            //}
            OnPropertyChanged(propertyName, true);
        }

        protected virtual void OnPropertyChanged(string propertyName, bool makeDirty)
        {
            if (_PropertyChanged != null)
            {
                _PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
            if (makeDirty)
            {
                _IsDirty = true;
            }

        }


        protected virtual void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            string propertyName = PropertySupport.ExtractPropertyName(propertyExpression);
            OnPropertyChanged(propertyName);
        }


        bool _IsDirty;

        public bool IsDirty
        {
            get { return _IsDirty; }
        }
    }

    public class MyClass : TempObjectBase
    {

    }

    public class TestClient
    {
        public TestClient()
        {
            MyClass obj = new MyClass();
            obj.PropertyChanged += obj_PropertyChanged;
        }

        void obj_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

        }
    }
}
