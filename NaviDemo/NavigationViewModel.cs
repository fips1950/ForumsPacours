using System.Windows.Input;

namespace NaviDemo
{
  class NavigationViewModel
  {
    public NavigationViewModel()
    {
      _helloWorld = new TextBlockSetter();
    }

    TextBlockSetter _helloWorld;
    public TextBlockSetter helloWorld
    {
      get
      {
        return _helloWorld;
      }
      set
      {
        _helloWorld = value;
      }
    }

    public ICommand NavigationCommand { get { return new RelayCommand(navigationCommand); } }

    private void navigationCommand(object destination)
    {
      switch (destination.ToString())
      {
        case "SecondPage":
          {
            //CurrentViewModel = SecondPage; ///Navigiert zu "SecondPageView"
            helloWorld.Counter++;
            break;
          }
      }
    }
  }
}
