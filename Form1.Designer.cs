namespace GetOrdinalRequeteSQL
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            ListBox1 = new ListBox();
            txtSQL = new TextBox();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(ListBox1);
            groupBox1.Controls.Add(txtSQL);
            groupBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            groupBox1.Location = new Point(9, 7);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(935, 391);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            linkLabel2.Location = new Point(362, 4);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(71, 22);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "&Effacer";
            linkLabel2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            linkLabel1.Location = new Point(766, 4);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(166, 22);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Copier en mémoire";
            linkLabel1.Click += button5_Click;
            // 
            // ListBox1
            // 
            ListBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 22;
            ListBox1.Location = new Point(439, 28);
            ListBox1.Margin = new Padding(3, 2, 3, 2);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(484, 356);
            ListBox1.TabIndex = 1;
            // 
            // txtSQL
            // 
            txtSQL.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            txtSQL.Location = new Point(6, 28);
            txtSQL.Margin = new Padding(3, 2, 3, 2);
            txtSQL.Multiline = true;
            txtSQL.Name = "txtSQL";
            txtSQL.Size = new Size(418, 354);
            txtSQL.TabIndex = 0;
            txtSQL.TextChanged += textBox1_TextChanged;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            linkLabel3.Location = new Point(661, 403);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(92, 22);
            linkLabel3.TabIndex = 5;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Én&umérer";
            linkLabel3.Click += button1_Click;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            linkLabel4.Location = new Point(759, 400);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(114, 22);
            linkLabel4.TabIndex = 6;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "&Sauvegarder";
            linkLabel4.Click += button3_Click;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            linkLabel5.LinkColor = Color.FromArgb(0, 64, 0);
            linkLabel5.Location = new Point(864, 400);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(69, 22);
            linkLabel5.TabIndex = 7;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "&Quitter";
            linkLabel5.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 434);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox ListBox1;
        private TextBox txtSQL;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
    }
}
