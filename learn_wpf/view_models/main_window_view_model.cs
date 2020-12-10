using learn_wpf.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace learn_wpf.view_models
{
    public class main_window_view_model : NotificationObject
    {
        #region commands
        public DelegateCommand click_painting_animation_command { get; set; }

        #endregion

        public main_window_view_model()
        {
            init_data();
            init_commands();
        }

        public void init_data()
        {

        }
        public void init_commands()
        {
            click_painting_animation_command = new DelegateCommand();
            click_painting_animation_command.ExecuteAction = new Action<object>(click_painting_animation);
        }

        private void click_painting_animation(object obj)
        {
            painting_and_animation.MainWindow painting_animation_window = new painting_and_animation.MainWindow();
            painting_animation_window.ShowDialog();
        }
    }
}
