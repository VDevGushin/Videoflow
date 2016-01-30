using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestUniversalApp
{
    public class A
    {
        public int MyProperty { get; set; }
    }

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            EngineWriperUniversal.ManagedDllWrapperImp wraper = new EngineWriperUniversal.ManagedDllWrapperImp();
            var value = wraper.DivideWrapper(2, 0);

            this.InitializeComponent();

            A a = new A() { MyProperty = 12 };
            int a1 = 12;
            mod(a,a1);
            var b1 = a1;
            var b = a;
        }

        public void mod(A a, int b)
        {
            b = 160;
            a.MyProperty = 160;
        }
    }
}
