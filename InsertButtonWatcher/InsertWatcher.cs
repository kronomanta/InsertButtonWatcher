using InsertButtonWatcher.Logging;
using System;
using System.Windows.Forms;
using System.Windows.Input;

namespace InsertButtonWatcher
{
    public class InsertWatcher
    {
        private LowLevelKeyboardListener lowLevelKeyboardListener;
        
        public void Start()
        {
            try
            {
                lowLevelKeyboardListener = new LowLevelKeyboardListener();
                lowLevelKeyboardListener.OnKeyPressed += LowLevelKeyboardListener_OnKeyPressed;
                lowLevelKeyboardListener.HookKeyboard();
            }
            catch (Exception ex)
            {
                LogHelper.LogException(ex);
                Stop();
            }
        }

        private void LowLevelKeyboardListener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            if (e.KeyPressed == Key.Insert)
            {
                MessageBox.Show(
                    Properties.Strings.AlertMessage,
                    Properties.Strings.AlertTitle, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }

        public void Stop()
        {
            try
            {
                //unsubscribe
                if (lowLevelKeyboardListener != null)
                {
                    lowLevelKeyboardListener.OnKeyPressed -= LowLevelKeyboardListener_OnKeyPressed;
                    lowLevelKeyboardListener.UnHookKeyboard();
                    lowLevelKeyboardListener = null;
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogException(ex);
            }
        }
    }
}
