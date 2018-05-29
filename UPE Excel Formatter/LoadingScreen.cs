using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPE_Excel_Formatter
{
    public partial class LoadingScreen : Form
    {

        private delegate void CloseDelegate();

        private static LoadingScreen loadingScreen;

        static public void ShowLoadingScreen()
        {
            if (loadingScreen != null)
            {
                return;
            }
            Thread thread = new Thread(new ThreadStart(LoadingScreen.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private static void ShowForm()
        {
            loadingScreen = new LoadingScreen();
            Application.Run(loadingScreen);
        }

        static public void LoadForm()
        {
            loadingScreen.Invoke(new CloseDelegate(LoadingScreen.CloseFormInternal));
        }

        static public void CloseForm()
        {
            loadingScreen.Invoke(new CloseDelegate(LoadingScreen.CloseFormInternal));
        }
        private static void CloseFormInternal()
        {
            loadingScreen.Close();
            loadingScreen = null;
        }


        //public Action Worker { get; set; }

        //public LoadingScreen(Action worker)
        //{
        //    InitializeComponent();
        //    if (worker == null)
        //    {
        //        throw new ArgumentNullException();

        //    }
        //    Worker = worker;
        //}

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        //}




        ////Delegate for cross thread call to close
        //private delegate void CloseDelegate();

        ////The type of form to be displayed as the splash screen.
        //private static LoadingScreen loadingScreen;

        //static public void ShowLoadingScreen()
        //{
        //    // Make sure it is only launched once.

        //    if (loadingScreen != null)
        //        return;
        //    Thread thread = new Thread(new ThreadStart(LoadingScreen.ShowForm));
        //    thread.IsBackground = true;
        //    thread.SetApartmentState(ApartmentState.STA);
        //    thread.Start();
        //}

        //static private void ShowForm()
        //{
        //    loadingScreen = new LoadingScreen();
        //    Application.Run(loadingScreen);
        //}

        //static public void CloseForm()
        //{
        //    loadingScreen.Invoke(new CloseDelegate(LoadingScreen.CloseFormInternal));
        //}

        //static private void CloseFormInternal()
        //{
        //    loadingScreen.Close();
        //    loadingScreen = null;
        //}
    }
}