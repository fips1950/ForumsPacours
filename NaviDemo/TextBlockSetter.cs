using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NaviDemo
{
  public class TextBlockSetter : INotifyPropertyChanged
  {
    // boiler-plate
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "") => 
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    protected bool SetField<T>(ref T field, T value, string propertyName)
    {
      if (EqualityComparer<T>.Default.Equals(field, value)) return false;
      field = value;
      OnPropertyChanged(propertyName);
      return true;
    }

    // props
    private int _Counter;
    public int Counter
    {
      get { return _Counter; }
      set { SetField(ref _Counter, value, "Counter"); }
    }
  }
}
