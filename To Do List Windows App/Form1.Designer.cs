namespace To_Do_List_Windows_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            Menudosya = new ToolStripMenuItem();
            Menucikis = new ToolStripMenuItem();
            Menukaydet = new ToolStripMenuItem();
            MenuTodo = new ToolStripMenuItem();
            Menutodoyenigorev = new ToolStripMenuItem();
            Menutododuzelt = new ToolStripMenuItem();
            Menutodosyasil = new ToolStripMenuItem();
            Menuhakkimdahakkimizda = new ToolStripMenuItem();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            Menuhakkımdayardım = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnyenigorev = new ToolStripButton();
            btnduzelt = new ToolStripButton();
            btnsil = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator = new ToolStripSeparator();
            btnkes = new ToolStripButton();
            btnkopyala = new ToolStripButton();
            btnyapistir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnyardim = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            Clbyapilacaklarlistesi = new CheckedListBox();
            Yapilacaklarlistesititle = new Label();
            label1 = new Label();
            panel1 = new Panel();
            GrpYenigorevekle = new GroupBox();
            textBox1 = new TextBox();
            lsttamamlananlarlistesi = new ListBox();
            panel2 = new Panel();
            Tamamlanılanlarlistesititle = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            GrpYenigorevekle.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Menudosya, MenuTodo, Menuhakkimdahakkimizda });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(926, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Menudosya
            // 
            Menudosya.BackColor = Color.Transparent;
            Menudosya.DropDownItems.AddRange(new ToolStripItem[] { Menucikis, Menukaydet });
            Menudosya.Name = "Menudosya";
            Menudosya.Size = new Size(64, 24);
            Menudosya.Text = "Dosya";
            // 
            // Menucikis
            // 
            Menucikis.Image = Properties.Resources.closed;
            Menucikis.Name = "Menucikis";
            Menucikis.Size = new Size(138, 26);
            Menucikis.Text = "Çıkış";
            // 
            // Menukaydet
            // 
            Menukaydet.Name = "Menukaydet";
            Menukaydet.Size = new Size(138, 26);
            Menukaydet.Text = "Kaydet";
            // 
            // MenuTodo
            // 
            MenuTodo.DropDownItems.AddRange(new ToolStripItem[] { Menutodoyenigorev, Menutododuzelt, Menutodosyasil });
            MenuTodo.Name = "MenuTodo";
            MenuTodo.Size = new Size(57, 24);
            MenuTodo.Text = "Todo";
            MenuTodo.Click += todoToolStripMenuItem_Click;
            // 
            // Menutodoyenigorev
            // 
            Menutodoyenigorev.Image = Properties.Resources.add;
            Menutodoyenigorev.Name = "Menutodoyenigorev";
            Menutodoyenigorev.ShortcutKeys = Keys.Control | Keys.B;
            Menutodoyenigorev.Size = new Size(188, 26);
            Menutodoyenigorev.Text = "Yeni";
            // 
            // Menutododuzelt
            // 
            Menutododuzelt.Image = Properties.Resources.writing;
            Menutododuzelt.Name = "Menutododuzelt";
            Menutododuzelt.ShortcutKeys = Keys.Control | Keys.N;
            Menutododuzelt.Size = new Size(188, 26);
            Menutododuzelt.Text = "Düzelt";
            // 
            // Menutodosyasil
            // 
            Menutodosyasil.Image = Properties.Resources.close;
            Menutodosyasil.Name = "Menutodosyasil";
            Menutodosyasil.ShortcutKeys = Keys.Control | Keys.M;
            Menutodosyasil.Size = new Size(188, 26);
            Menutodosyasil.Text = "Sil";
            // 
            // Menuhakkimdahakkimizda
            // 
            Menuhakkimdahakkimizda.DropDownItems.AddRange(new ToolStripItem[] { hakkımızdaToolStripMenuItem, Menuhakkımdayardım });
            Menuhakkimdahakkimizda.Name = "Menuhakkimdahakkimizda";
            Menuhakkimdahakkimizda.Size = new Size(90, 24);
            Menuhakkimdahakkimizda.Text = "Hakkımda";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Size = new Size(170, 26);
            hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // Menuhakkımdayardım
            // 
            Menuhakkımdayardım.Image = Properties.Resources.chat;
            Menuhakkımdayardım.Name = "Menuhakkımdayardım";
            Menuhakkımdayardım.Size = new Size(170, 26);
            Menuhakkımdayardım.Text = "Yardım";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnyenigorev, btnduzelt, btnsil, toolStripSeparator2, toolStripSeparator, btnkes, btnkopyala, btnyapistir, toolStripSeparator1, btnyardim });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(926, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnyenigorev
            // 
            btnyenigorev.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnyenigorev.Image = Properties.Resources.add;
            btnyenigorev.ImageTransparentColor = Color.Magenta;
            btnyenigorev.Name = "btnyenigorev";
            btnyenigorev.Size = new Size(29, 24);
            btnyenigorev.Text = "Yeni";
            btnyenigorev.Click += btnyenigorev_Click;
            // 
            // btnduzelt
            // 
            btnduzelt.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnduzelt.Image = Properties.Resources.writing;
            btnduzelt.ImageTransparentColor = Color.Magenta;
            btnduzelt.Name = "btnduzelt";
            btnduzelt.Size = new Size(29, 24);
            btnduzelt.Text = "Duzelt";
            // 
            // btnsil
            // 
            btnsil.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnsil.Image = Properties.Resources.close;
            btnsil.ImageTransparentColor = Color.Magenta;
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(29, 24);
            btnsil.Text = "Sil";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 27);
            // 
            // btnkes
            // 
            btnkes.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnkes.Image = (Image)resources.GetObject("btnkes.Image");
            btnkes.ImageTransparentColor = Color.Magenta;
            btnkes.Name = "btnkes";
            btnkes.Size = new Size(29, 24);
            btnkes.Text = "Kes";
            // 
            // btnkopyala
            // 
            btnkopyala.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnkopyala.Image = (Image)resources.GetObject("btnkopyala.Image");
            btnkopyala.ImageTransparentColor = Color.Magenta;
            btnkopyala.Name = "btnkopyala";
            btnkopyala.Size = new Size(29, 24);
            btnkopyala.Text = "Kopyala";
            // 
            // btnyapistir
            // 
            btnyapistir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnyapistir.Image = (Image)resources.GetObject("btnyapistir.Image");
            btnyapistir.ImageTransparentColor = Color.Magenta;
            btnyapistir.Name = "btnyapistir";
            btnyapistir.Size = new Size(29, 24);
            btnyapistir.Text = "Yapıştır";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnyardim
            // 
            btnyardim.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnyardim.Image = (Image)resources.GetObject("btnyardim.Image");
            btnyardim.ImageTransparentColor = Color.Magenta;
            btnyardim.Name = "btnyardim";
            btnyardim.Size = new Size(29, 24);
            btnyardim.Text = "Yardım";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 55);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Clbyapilacaklarlistesi);
            splitContainer1.Panel1.Controls.Add(Yapilacaklarlistesititle);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(GrpYenigorevekle);
            splitContainer1.Panel1.Padding = new Padding(7, 5, 7, 5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lsttamamlananlarlistesi);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(Tamamlanılanlarlistesititle);
            splitContainer1.Panel2.Padding = new Padding(7, 5, 7, 5);
            splitContainer1.Size = new Size(926, 414);
            splitContainer1.SplitterDistance = 433;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 2;
            // 
            // Clbyapilacaklarlistesi
            // 
            Clbyapilacaklarlistesi.Dock = DockStyle.Fill;
            Clbyapilacaklarlistesi.FormattingEnabled = true;
            Clbyapilacaklarlistesi.Location = new Point(7, 155);
            Clbyapilacaklarlistesi.Margin = new Padding(4, 3, 4, 3);
            Clbyapilacaklarlistesi.Name = "Clbyapilacaklarlistesi";
            Clbyapilacaklarlistesi.Size = new Size(419, 254);
            Clbyapilacaklarlistesi.TabIndex = 4;
            // 
            // Yapilacaklarlistesititle
            // 
            Yapilacaklarlistesititle.AutoSize = true;
            Yapilacaklarlistesititle.Dock = DockStyle.Top;
            Yapilacaklarlistesititle.ForeColor = SystemColors.ButtonHighlight;
            Yapilacaklarlistesititle.Location = new Point(7, 125);
            Yapilacaklarlistesititle.Margin = new Padding(4, 0, 4, 0);
            Yapilacaklarlistesititle.Name = "Yapilacaklarlistesititle";
            Yapilacaklarlistesititle.Padding = new Padding(7, 5, 7, 5);
            Yapilacaklarlistesititle.Size = new Size(236, 30);
            Yapilacaklarlistesititle.TabIndex = 3;
            Yapilacaklarlistesititle.Text = "Yapılacaklar listesi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(532, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(7, 112);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 13);
            panel1.TabIndex = 1;
            // 
            // GrpYenigorevekle
            // 
            GrpYenigorevekle.Controls.Add(textBox1);
            GrpYenigorevekle.Dock = DockStyle.Top;
            GrpYenigorevekle.ForeColor = SystemColors.ButtonHighlight;
            GrpYenigorevekle.Location = new Point(7, 5);
            GrpYenigorevekle.Margin = new Padding(4, 3, 4, 3);
            GrpYenigorevekle.Name = "GrpYenigorevekle";
            GrpYenigorevekle.Padding = new Padding(15);
            GrpYenigorevekle.Size = new Size(419, 107);
            GrpYenigorevekle.TabIndex = 0;
            GrpYenigorevekle.TabStop = false;
            GrpYenigorevekle.Text = "Listeye yeni görev ekle";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(15, 38);
            textBox1.MaxLength = 120;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(389, 54);
            textBox1.TabIndex = 0;
            // 
            // lsttamamlananlarlistesi
            // 
            lsttamamlananlarlistesi.Dock = DockStyle.Fill;
            lsttamamlananlarlistesi.FormattingEnabled = true;
            lsttamamlananlarlistesi.Location = new Point(7, 48);
            lsttamamlananlarlistesi.Margin = new Padding(4, 3, 4, 3);
            lsttamamlananlarlistesi.Name = "lsttamamlananlarlistesi";
            lsttamamlananlarlistesi.Size = new Size(473, 361);
            lsttamamlananlarlistesi.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(7, 35);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(473, 13);
            panel2.TabIndex = 5;
            // 
            // Tamamlanılanlarlistesititle
            // 
            Tamamlanılanlarlistesititle.AutoSize = true;
            Tamamlanılanlarlistesititle.Dock = DockStyle.Top;
            Tamamlanılanlarlistesititle.ForeColor = SystemColors.ButtonHighlight;
            Tamamlanılanlarlistesititle.Location = new Point(7, 5);
            Tamamlanılanlarlistesititle.Margin = new Padding(4, 0, 4, 0);
            Tamamlanılanlarlistesititle.Name = "Tamamlanılanlarlistesititle";
            Tamamlanılanlarlistesititle.Padding = new Padding(7, 5, 7, 5);
            Tamamlanılanlarlistesititle.Size = new Size(269, 30);
            Tamamlanılanlarlistesititle.TabIndex = 4;
            Tamamlanılanlarlistesititle.Text = "Tamamlanılanlar listesi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(926, 469);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaption;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "To Do List";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            GrpYenigorevekle.ResumeLayout(false);
            GrpYenigorevekle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menudosya;
        private ToolStripMenuItem Menucikis;
        private ToolStripMenuItem Menukaydet;
        private ToolStripMenuItem MenuTodo;
        private ToolStrip toolStrip1;
        private ToolStripButton btnyenigorev;
        private ToolStripButton btnduzelt;
        private ToolStripButton kaydetToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton btnkes;
        private ToolStripButton btnkopyala;
        private ToolStripButton btnyapistir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnyardim;
        private ToolStripMenuItem Menutodoyenigorev;
        private ToolStripMenuItem Menutododuzelt;
        private ToolStripMenuItem Menutodosyasil;
        private ToolStripMenuItem Menuhakkimdahakkimizda;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem Menuhakkımdayardım;
        private ToolStripButton btnsil;
        private ToolStripSeparator toolStripSeparator2;
        private SplitContainer splitContainer1;
        private GroupBox GrpYenigorevekle;
        private Panel panel1;
        private CheckedListBox Clbyapilacaklarlistesi;
        private Label Yapilacaklarlistesititle;
        private Label label1;
        private ListBox lsttamamlananlarlistesi;
        private Panel panel2;
        private Label Tamamlanılanlarlistesititle;
        private TextBox textBox1;
    }
}
