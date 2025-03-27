namespace Proiect_BD_Bun
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            textBoxInfoAdmin = new TextBox();
            button1 = new Button();
            tabPage2 = new TabPage();
            Afis_Tabele = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 11);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 376);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Afis_Tabele);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxInfoAdmin);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 348);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Administrare";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 195);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Output";
            // 
            // textBoxInfoAdmin
            // 
            textBoxInfoAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxInfoAdmin.Location = new Point(6, 213);
            textBoxInfoAdmin.Multiline = true;
            textBoxInfoAdmin.Name = "textBoxInfoAdmin";
            textBoxInfoAdmin.ReadOnly = true;
            textBoxInfoAdmin.Size = new Size(258, 132);
            textBoxInfoAdmin.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(6, 5);
            button1.Name = "button1";
            button1.Size = new Size(182, 22);
            button1.TabIndex = 0;
            button1.Text = "Creare Tabele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 348);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Afis_Tabele
            // 
            Afis_Tabele.Location = new Point(6, 33);
            Afis_Tabele.Name = "Afis_Tabele";
            Afis_Tabele.Size = new Size(182, 28);
            Afis_Tabele.TabIndex = 3;
            Afis_Tabele.Text = "Afiseaza Tabele";
            Afis_Tabele.UseVisualStyleBackColor = true;
            Afis_Tabele.Click += Afis_Tabele_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 397);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBoxInfoAdmin;
        private Button button1;
        private TabPage tabPage2;
        private Label label1;
        private Button Afis_Tabele;
    }
}