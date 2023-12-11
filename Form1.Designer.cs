namespace Hasan.Badr_harjoitus6
{
    partial class SalasanaForm
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
            SalasanaPanel = new Panel();
            VirheviestiLB = new Label();
            TarkistaBT = new Button();
            SalasanaTB = new TextBox();
            KayttajaTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SalasanaOikeinPanel = new Panel();
            label3 = new Label();
            SalasanaPanel.SuspendLayout();
            SalasanaOikeinPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SalasanaPanel
            // 
            SalasanaPanel.BackColor = Color.MidnightBlue;
            SalasanaPanel.Controls.Add(VirheviestiLB);
            SalasanaPanel.Controls.Add(TarkistaBT);
            SalasanaPanel.Controls.Add(SalasanaTB);
            SalasanaPanel.Controls.Add(KayttajaTB);
            SalasanaPanel.Controls.Add(label2);
            SalasanaPanel.Controls.Add(label1);
            SalasanaPanel.Dock = DockStyle.Fill;
            SalasanaPanel.Location = new Point(0, 0);
            SalasanaPanel.Name = "SalasanaPanel";
            SalasanaPanel.Size = new Size(592, 209);
            SalasanaPanel.TabIndex = 0;
            // 
            // VirheviestiLB
            // 
            VirheviestiLB.AutoSize = true;
            VirheviestiLB.Location = new Point(12, 157);
            VirheviestiLB.Name = "VirheviestiLB";
            VirheviestiLB.Size = new Size(74, 34);
            VirheviestiLB.TabIndex = 5;
            VirheviestiLB.Text = "Virhe";
            VirheviestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            TarkistaBT.ForeColor = Color.Black;
            TarkistaBT.Location = new Point(12, 103);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.Size = new Size(125, 34);
            TarkistaBT.TabIndex = 4;
            TarkistaBT.Text = "Tarkista";
            TarkistaBT.UseVisualStyleBackColor = true;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // SalasanaTB
            // 
            SalasanaTB.Location = new Point(278, 96);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.Size = new Size(276, 41);
            SalasanaTB.TabIndex = 3;
            // 
            // KayttajaTB
            // 
            KayttajaTB.Location = new Point(278, 26);
            KayttajaTB.Name = "KayttajaTB";
            KayttajaTB.Size = new Size(276, 41);
            KayttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 103);
            label2.Name = "label2";
            label2.Size = new Size(120, 34);
            label2.TabIndex = 1;
            label2.Text = "Salasana:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 33);
            label1.Name = "label1";
            label1.Size = new Size(205, 34);
            label1.TabIndex = 0;
            label1.Text = "kääyttäjätunnus:";
            // 
            // SalasanaOikeinPanel
            // 
            SalasanaOikeinPanel.BackColor = Color.Maroon;
            SalasanaOikeinPanel.Controls.Add(label3);
            SalasanaOikeinPanel.Dock = DockStyle.Fill;
            SalasanaOikeinPanel.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SalasanaOikeinPanel.ForeColor = Color.Snow;
            SalasanaOikeinPanel.Location = new Point(0, 0);
            SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            SalasanaOikeinPanel.Size = new Size(592, 209);
            SalasanaOikeinPanel.TabIndex = 1;
            SalasanaOikeinPanel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(574, 80);
            label3.TabIndex = 0;
            label3.Text = "Tervetuloa sivuilleni";
            // 
            // SalasanaForm
            // 
            AutoScaleDimensions = new SizeF(14F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 209);
            Controls.Add(SalasanaOikeinPanel);
            Controls.Add(SalasanaPanel);
            Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Gold;
            Margin = new Padding(6, 7, 6, 7);
            Name = "SalasanaForm";
            Text = "Salasanan tarkastus";
            SalasanaPanel.ResumeLayout(false);
            SalasanaPanel.PerformLayout();
            SalasanaOikeinPanel.ResumeLayout(false);
            SalasanaOikeinPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SalasanaPanel;
        private Label label2;
        private Label label1;
        private TextBox KayttajaTB;
        private Button TarkistaBT;
        private TextBox SalasanaTB;
        private Label VirheviestiLB;
        private Panel SalasanaOikeinPanel;
        private Label label3;
    }
}