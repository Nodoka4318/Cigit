using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cigit.Controls {
    public partial class SlideMenu : UserControl {
        public List<Button> Buttons => _buttons.Select(b => b.Button).ToList();
        public Color PanelColor { get; private set; } = Color.Gray;
        public Color ButtonColor { get; private set; } = Color.White;

        private List<SlideMenuButton> _buttons;

        private const int BUTTON_HEIGTH = 30;
        

        public SlideMenu(params string[] buttons) {
            _buttons = new List<SlideMenuButton>();

            int count = 1;
            foreach (string s in buttons) {
                var btn = new Button() {
                    Text = s,
                    BackColor = ButtonColor,
                    // Width = this.Width,
                    // Height = BUTTON_HEIGTH,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(0, 100 + BUTTON_HEIGTH * count),
                    Size = new Size(this.Width, BUTTON_HEIGTH)
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.MouseClick += Btn_MouseClick;
                _buttons.Add(new SlideMenuButton(btn));

                count++;
            }

            _buttons.ForEach((b) => this.Controls.Add(b.Button));
            InitializeComponent();

            _buttons.ForEach((b) => b.Button.Width = this.Width); // 横幅
            BackColor = PanelColor;
        }

        private void Btn_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                return;

            var loc = e.Location;            
            foreach (var b in _buttons) {
                if (b.Button == sender) {
                    if (b.Action != null) {
                        b.Action();
                    }
                    return;
                }
            }
        }

        public void SetPanelColor(Color color) {
            PanelColor = color;
            SidePanel.BackColor = color; 
        }

        public void SetButtonColor(Color color) {
            ButtonColor = color;
            foreach (var b in _buttons) {
                b.Button.BackColor = color;
            }
        }

        public void BindAction(string buttonName, Action action) {
            foreach (var b in _buttons) {
                if (b.Button.Text == buttonName) {
                    b.Action = action;
                    return;
                }
            }
            throw new InvalidOperationException($"ボタン, {buttonName} は存在していません。");
        }
    }

    public class SlideMenuButton {
        public Button Button { get; set; }
        public Action Action { get; set; }

        public SlideMenuButton(Button button) {
            Button = button;
        }

        public SlideMenuButton(Button button, Action action) {
            Button = button;
            Action = action;
        }
    }
}
