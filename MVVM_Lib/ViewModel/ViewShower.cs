using System;
using System.Windows;
using System.Windows.Controls;

namespace MVVM_Lib.ViewModel
{
    public static class ViewShower
    {
        public static void Show(Control view, bool isModal, Action<bool?> closeAction)
        {
            if (view != null)
            {
                Window w = new Window() { SizeToContent = SizeToContent.WidthAndHeight, ResizeMode = ResizeMode.NoResize, Title = "DialogWindow"};                
                StackPanel mainSp = new StackPanel() { Orientation = Orientation.Vertical };
                StackPanel sp = new StackPanel();
                sp.Children.Add(view);
                Button applyBtn = new Button() { Content = "Принять", Margin = new Thickness(10) };
                applyBtn.Click += (s, e) => { if (isModal) w.DialogResult = true; else w.Close(); };
                StackPanel buttonPanel = new StackPanel() { Orientation = Orientation.Horizontal };
                buttonPanel.Children.Add(applyBtn);
                w.Closed += (s, e) => closeAction(w.DialogResult);
                mainSp.Children.Add(sp);
                mainSp.Children.Add(buttonPanel);
                w.Content = mainSp;
                if (isModal)
                {
                    Button cancelBtn = new Button() { Content = "Отменить", Margin = new Thickness(10) };
                    cancelBtn.Click += (s, e) => w.DialogResult = false;
                    buttonPanel.Children.Add(cancelBtn);
                    w.ShowDialog();
                }
                else
                {
                    w.Show();
                }
            }
        }
    }
}
