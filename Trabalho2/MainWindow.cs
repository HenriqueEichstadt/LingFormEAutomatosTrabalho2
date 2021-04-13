using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho2
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// change this to whatever margin you want the line numbers to show in
        /// </summary>
        private const int NUMBER_MARGIN = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Configurações básicas
            CampoEditor.TextChanged += OnTextChanged;

            // Adicionando número da linha
            CarregarEditor();
        }

        private void CarregarEditor()
        {
            var margem = CampoEditor.Margins[NUMBER_MARGIN];
            margem.Width = 40;
            margem.Type = MarginType.Number;
            margem.Sensitive = true;
            margem.Mask = 0;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {

        }

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }
    }
}
