using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmSkeletonCloset.ViewModel
{
  public class EditorVM : ObservableObject
  {
    public EditorVM()
    {
      InitProcessCommand();
    }
    public string Text
    {
      get { return text; }
      set
      {
        if (value != text)
        {
          text = value;
          OnPropertyChanged("Text");
        }
      }
    }

    public bool IsEnabled { get { return Text != null; }  }

    public ICommand ProcessCommand
    {
      get
      {    
        return processCommand;
      }
    }

    private void ProcessText()
    {

    }

    private void InitProcessCommand()
    {
      if (processCommand == null)
      {
        processCommand = new RelayCommand(
            param => ProcessText(),
            param => true
        );
      }
    }

    private ICommand processCommand;
    private string text;
  }
}
