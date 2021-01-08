using System;
using System.Threading.Tasks;
using System.Windows;
using MVVM_Lib.ViewModel;

namespace MVVM_Lib
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        DisplayRootRegistry displayRoot = new DisplayRootRegistry();

        public App()
        {
            displayRoot.RegisterWindowType<BiblioVM, MainWindow>();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            await RunProgramLogic();
            Shutdown();
        }

        private async Task RunProgramLogic()
        {
            while (true)
            {
                BiblioVM vm = new BiblioVM();
                displayRoot.ShowView(vm);
                await Task.Delay(TimeSpan.FromSeconds(2));

                while (true)
                {
                    await Task.Delay(TimeSpan.FromSeconds(2));
                    if (vm.DialogResult != null)
                        break;
                }
                displayRoot.HideView(vm);
                break;
            }
        }
    }
    
}
