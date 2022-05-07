using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            slideMenu1.BindAction("button1", () => {
                MessageBox.Show("hello, world");
                slideMenu1.SetButtonColor(Color.LimeGreen);
            });

            slideMenu1.BindAction("ボタン2", () => {
                MessageBox.Show("ほげ");
                slideMenu1.SetPanelColor(Color.Aqua);
            });
        }

    }
}
