using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PInvokeSample
{

    public partial class MainWindow : Window
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetDllDirectory(string lpPathName);

        [DllImport("UnmanagedDll.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int add(int a, int b);

        [DllImport("UnmanagedDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern IntPtr concat([MarshalAs(UnmanagedType.LPStr)]string c);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            setDllDirectry();
            var sum = add(1, 2);
            Console.WriteLine("1 + 2 = {0}", sum);

            var str = Marshal.PtrToStringAnsi(concat("world!"));
            Console.WriteLine(str);
        }



        private void setDllDirectry()
        {
            // Get exe file path
            String assemblyLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            //You can detect x64 or x86 via IntPtr.Size
            if (8 == IntPtr.Size)
            {
                assemblyLocation += @"\x64";
            }
            else
            {
                assemblyLocation += @"\Win32";
            }

            //Specify DLL path
            bool status = SetDllDirectory(assemblyLocation);
        }

    }
}
