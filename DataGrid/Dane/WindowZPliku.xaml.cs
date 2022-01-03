using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace DataGrid.Dane
{
    /// <summary>
    /// Logika interakcji dla klasy WindowZPliku.xaml
    /// </summary>
    public partial class WindowZPliku : Window
    {
        // plik z danymi
        private string plik1 = @"..\Dane\Produkty.xml";
        // plik na wyniki
        private string plik2 = @"..\Dane\Produkty2.xml";
        private XElement wykazProduktow;
        
        public WindowZPliku()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            if (File.Exists(plik1))
            {
                wykazProduktow = XElement.Load(plik1);
                gridProdukty.DataContext = wykazProduktow;
            }
        }
    }
}
