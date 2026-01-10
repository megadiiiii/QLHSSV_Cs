using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Licensing;

namespace BTL_QLHSSV_NETFW
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JFaF1cXGtCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdlWX5fcHRURmRYV01+XEdWYEg=");
            //Application.EnableVisualStyles();
            ToolStripManager.RenderMode = ToolStripManagerRenderMode.Professional;
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QLHSSV());
        }
    }
}
