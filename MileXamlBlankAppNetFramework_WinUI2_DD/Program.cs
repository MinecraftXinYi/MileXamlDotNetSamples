using MileXamlBlankAppNetFramework;
using System;
using System.Windows.Forms;
using Windows.Gaming.XboxLive;
using Windows.Win32.Foundation;
using Windows.Win32.Storage.Packaging.Appx;

namespace MileXamlBlankAppNetFrameworkModern
{
    public static class Program
    {
        [STAThread]
        static unsafe void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //PACKAGE_VERSION winuilibver = new PACKAGE_VERSION();
            //winuilibver.Anonymous.Anonymous.Major = 2;
            //winuilibver.Anonymous.Anonymous.Minor = 24007;
            //winuilibver.Anonymous.Anonymous.Build = 9001;
            //winuilibver.Anonymous.Anonymous.Revision = 0;
            //Windows.Win32.PInvoke.TryCreatePackageDependency(null, "Microsoft.UI.Xaml.2.4_8wekyb3d8bbwe",
            //    winuilibver, PackageDependencyProcessorArchitectures.PackageDependencyProcessorArchitectures_X64,
            //    PackageDependencyLifetimeKind.PackageDependencyLifetimeKind_Process, null,
            //    CreatePackageDependencyOptions.CreatePackageDependencyOptions_ScopeIsSystem,
            //    out PWSTR packageDependencyId);
            PWSTR* p = (PWSTR*)0;
            Windows.Win32.Storage.Packaging.Appx.AddPackageDependencyOptions addPackageDependencyOptions = new();
            PACKAGEDEPENDENCY_CONTEXT* pACKAGEDEPENDENCY_CONTEXT = (PACKAGEDEPENDENCY_CONTEXT*)1027428;
            HRESULT hRESULT = Windows.Win32.PInvoke.AddPackageDependency("Microsoft.UI.Xaml.2.4_2.42007.9001.0_x64__8wekyb3d8bbwe",
                1, addPackageDependencyOptions, out PACKAGEDEPENDENCY_CONTEXT packageDependencyContext, p);

            App app = new();

            Application.Run(new Form1());

            app.Close();
        }
    }
}
