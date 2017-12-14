using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RenameFiles
{
  [DataContract(Name = "BasePropertyBag", Namespace = Program.Namespace)]
  public abstract class BasePropertyBag : INotifyPropertyChanged
  {
    const string EmptyString = "";

    private Dictionary<string, object> mBag;

    private void EnsureBag()
    {
      if (mBag == null)
      {
        mBag = new Dictionary<string, object>();
      }
    }

    protected void SetField<T>(T value, [CallerMemberName]string propertyName = EmptyString)
    {
      EnsureBag();
      mBag[propertyName] = value;
      OnPropertyChanged(propertyName);
    }

    protected T GetField<T>([CallerMemberName]string propertyName = EmptyString)
    {
      EnsureBag();
      if (!mBag.TryGetValue(propertyName, out object value) || !(value is T fieldValue))
      {
        fieldValue = default(T);
        mBag[propertyName] = fieldValue;
      }
      return fieldValue;
    }

    #region INotifyPropertyChanged Implementation

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = EmptyString)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
  }
}
