using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace MailbirdFix
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                foreach (Process process in Process.GetProcessesByName("mailbird"))
                {
                    process.Kill();
                    process.WaitForExit();
                }
            } catch { }

            string searchKey = "Mailbird";
            string regBaseKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Installer\Products";

            using (RegistryKey baseKey = Registry.LocalMachine.OpenSubKey(regBaseKey))
            {
                if (baseKey != null)
                {
                    foreach (string subKeyName in baseKey.GetSubKeyNames())
                    {
                        using (RegistryKey subKey = baseKey.OpenSubKey(subKeyName))
                        {
                            object productName = subKey.GetValue("ProductName");
                            if (productName != null && productName.ToString().Equals(searchKey, StringComparison.OrdinalIgnoreCase))
                            {
                                try
                                {
                                    baseKey.DeleteSubKeyTree(subKeyName);
                                }
                                catch { }
                            }
                        }
                    }
                }
            }

            MessageBox.Show("You can now run the Mailbird installer, with no issues.", "Installation fixed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();

        }
    }
}
