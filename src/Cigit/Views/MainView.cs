using Cigit.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cigit.Views {
    public partial class MainView : Form {
        public MainView() {            
            InitializeComponent();

            //slideMenu1.SetPanelColor(Color.AliceBlue);

            slideMenu1.BindAction("test1", () => {
                MessageBox.Show("it works!");
            });
        }
    }
}
