namespace WinFormsControlTest {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textEditor1 = new Cigit.Controls.TextEditor();
            this.slideMenu1 = new Cigit.Controls.SlideMenu("test1", "テスト2");
            this.SuspendLayout();
            // 
            // slideMenu1
            // 
            this.slideMenu1.BackColor = System.Drawing.Color.Gray;
            this.slideMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.slideMenu1.Location = new System.Drawing.Point(0, 0);
            this.slideMenu1.Name = "slideMenu1";
            this.slideMenu1.Size = new System.Drawing.Size(200, 450);
            this.slideMenu1.TabIndex = 0;
            // 
            // textEditor1
            // 
            this.textEditor1.Location = new System.Drawing.Point(206, 0);
            this.textEditor1.Name = "textEditor1";
            this.textEditor1.Size = new System.Drawing.Size(800, 800);
            this.textEditor1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textEditor1);
            this.Controls.Add(this.slideMenu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Cigit.Controls.SlideMenu slideMenu1;
        private Cigit.Controls.TextEditor textEditor1;
    }
}
