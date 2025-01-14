using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SmartRestaurantAutomationn
{
       public static class Program
    {
        public static int SelectedTableId = 0; // 0: Genel satış yapılmıyor, 1-20: Masa numaraları
        public static Dictionary<int, List<string>> MasaSiparisler = new Dictionary<int, List<string>>(); // Masaların siparişlerini tutar

       
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new anasayfa());
        }
    }
}
