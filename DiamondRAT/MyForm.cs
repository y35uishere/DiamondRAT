using System.Windows.Forms;

namespace DiamondRAT
{
    enum FormType
    {
        AudioCapture,
        Miscellaneous,
        RemoteDesktop,
        SystemInformation
    }

    class MyForm : Form
    {
        public FormType FormType;
        public Connection Connection;

        public virtual void ProcessMsg(string msg)
        {

        }
    }
}