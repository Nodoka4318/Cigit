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
            this.slideMenu1 = new SlideMenu("test1", "test2", "test3");
            slideMenu1.SetBackColor(Color.AliceBlue);
        }
    }
}
