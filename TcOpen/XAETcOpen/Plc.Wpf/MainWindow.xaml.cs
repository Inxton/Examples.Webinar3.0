using PlcConnector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TcoCore;
using Vortex.Connector;
using Vortex.Connector.ValueTypes;

namespace Plc.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dc = new TcoDiagnosticsViewViewModel(Entry.PlcController.MAIN._station001);
            DiagnosticsView.DataContext = dc;                        
            Entry.PlcController.MAIN._station001._sequence._currentStep.ID.Subscribe(ChangeImage);

        }

        TcoDiagnosticsViewViewModel dc;
        FileInfo rootPath = new FileInfo(Assembly.GetExecutingAssembly().Location);
        Dictionary<short, double> scrollPosition = new Dictionary<short, double>() { 
            {100,0.0},
            {200,243},
            {300,483},
            {400,819},
            {500,1011},
            {600,1203},
            {700,1395},
            {800,1504}
        };
        void ChangeImage(IValueTag sender, ValueChangedEventArgs args)
        {
            try
            {
                dc.UpdateMessagesCommand.Execute(null);
               // var fileName = @$"{rootPath.DirectoryName}\images\{args.NewValue}.png";
                var fileName = @$"{rootPath.DirectoryName}\images\100-800.png";
                if (File.Exists(fileName))
                {
                    this.Dispatcher.Invoke(() =>
                        {
                            if(scrollPosition.ContainsKey((dynamic)args.NewValue))
                            { 
                                scrollImage.ScrollToVerticalOffset(scrollPosition[(dynamic)args.NewValue]);                         
                            }

                        });
                }
            }
            catch (Exception)
            {

                //++Swallow
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Entry.PlcController.MAIN._station001._sequence._stepModeControler._State.Cyclic == (short)TcoCore.eSequencerMode.StepMode)
            {
                Entry.PlcController.MAIN._station001._sequence._stepModeControler._State.Cyclic = (short)TcoCore.eSequencerMode.CyclicMode;
            }
            else
            {
                Entry.PlcController.MAIN._station001._sequence._stepModeControler._State.Cyclic = (short)TcoCore.eSequencerMode.StepMode;
            }
        }

        private void StepBackward_Click(object sender, RoutedEventArgs e)
        {
            Entry.PlcController.MAIN._station001._sequence._stepModeControler._stepBackward._invokeRequest.Cyclic = true;
        }

        private void StepForward_Click(object sender, RoutedEventArgs e)
        {
            Entry.PlcController.MAIN._station001._sequence._stepModeControler._stepForward._invokeRequest.Cyclic = true;
        }

        private void StepIn_Click(object sender, RoutedEventArgs e)
        {
            Entry.PlcController.MAIN._station001._sequence._stepModeControler._stepIn._invokeRequest.Cyclic = true;
        }
    }
}
