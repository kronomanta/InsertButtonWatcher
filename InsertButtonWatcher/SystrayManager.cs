using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InsertButtonWatcher
{
    public class SystrayManager : IDisposable
    {
        private event Action closeClicked;
        public event Action CloseClicked
        {
            add
            {
                if (closeClicked == null || !closeClicked.GetInvocationList().Contains(value))
                {
                    closeClicked += value;
                }
            }

            remove
            {
                closeClicked -= value;
            }
        }

        private NotifyIcon ni;

        public SystrayManager()
        {
            ni = new NotifyIcon();

            ni.Icon = new Icon(SystemIcons.Application, 40,40);

            //menü
            ni.ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem(Properties.Strings.SystrayExitButton, HandleExitClick)
            });

            //ami megjelenik, mikor felé viszem az egeret
            ni.Text = Properties.Strings.SystrayText;

            ni.BalloonTipIcon = ToolTipIcon.Info;
            ni.BalloonTipTitle = Properties.Strings.SystrayTipTitle;
            ni.BalloonTipText = Properties.Strings.SystrayTipText;
        }

        private void HandleExitClick(object sender, EventArgs e)
        {
            if (closeClicked != null)
                closeClicked();
        }

        public void Dispose()
        {
            if (closeClicked != null)
            {
                //kitakarítok
                Delegate[] clientList = closeClicked.GetInvocationList();
                foreach (var x in clientList)
                    closeClicked -= (x as Action);
            }

            ni.Visible = false;
            ni.Dispose();
        }

        public void Display()
        {
            ni.Visible = true;
            ni.ShowBalloonTip(3000);
        }


    }
}
