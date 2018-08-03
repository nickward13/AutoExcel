using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Identity.Client;

namespace AutoExcel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string AzureAdClientId = System.Environment.GetEnvironmentVariable("AppId");
        public static PublicClientApplication PublicClientApp = new PublicClientApplication(AzureAdClientId);
    }
}
