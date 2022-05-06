using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cigit.Controls {
    public partial class SlideMenu : UserControl {
        public List<Button> Buttons => _buttons;

        private List<Button> _buttons;

        private const int BUTTON_HEIGTH = 30;
        

        public SlideMenu(params string[] buttons) {
            _buttons = new List<Button>();

            int count = 1;
            foreach (string s in buttons) {
                _buttons.Add(new Button() {
                    Text = s,
                    Width = this.Width,
                    Height = BUTTON_HEIGTH,
                    Location = new Point(0, 100 + 30 * count),
                    Size = new Size(this.Width, 30)
                });

                count++;
            }

            _buttons.ForEach((b) => this.Controls.Add(b));

            InitializeComponent();
        }

        public void SetBackColor(Color color) => SidePanel.BackColor = color;

    }
}
