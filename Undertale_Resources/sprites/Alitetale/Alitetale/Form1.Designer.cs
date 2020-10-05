namespace Alitetale
{
    partial class Alitetale
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alitetale));
            this.lb_alitetale = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_addtab = new System.Windows.Forms.Button();
            this.btn_deltab = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pn_template = new System.Windows.Forms.Panel();
            this.pn_Error = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fine = new System.Windows.Forms.Button();
            this.txt_Error = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DirView = new System.Windows.Forms.TreeView();
            this.lb_spritepath = new System.Windows.Forms.Label();
            this.lb_sprite = new System.Windows.Forms.Label();
            this.txt_spritepath = new System.Windows.Forms.TextBox();
            this.txt_sprite = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btn_treesel = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lb_tree = new System.Windows.Forms.Label();
            this.lb_effect = new System.Windows.Forms.Label();
            this.lb_txt = new System.Windows.Forms.Label();
            this.cb_effect = new System.Windows.Forms.ComboBox();
            this.tab = new System.Windows.Forms.TabControl();
            this.lb_credit = new System.Windows.Forms.Label();
            this.lb_bigcredit = new System.Windows.Forms.Label();
            this.pb_flowey = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage1.SuspendLayout();
            this.pn_template.SuspendLayout();
            this.pn_Error.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_flowey)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_alitetale
            // 
            this.lb_alitetale.AutoSize = true;
            this.lb_alitetale.Font = new System.Drawing.Font("Monster Friend Back", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alitetale.ForeColor = System.Drawing.Color.White;
            this.lb_alitetale.Location = new System.Drawing.Point(496, 34);
            this.lb_alitetale.Name = "lb_alitetale";
            this.lb_alitetale.Size = new System.Drawing.Size(818, 96);
            this.lb_alitetale.TabIndex = 0;
            this.lb_alitetale.Text = "ALITETALE";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Black;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Determination Mono Web", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(726, 918);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(337, 91);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseEnter += new System.EventHandler(this.btn_start_MouseEnter);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            // 
            // btn_addtab
            // 
            this.btn_addtab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addtab.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_addtab.ForeColor = System.Drawing.Color.White;
            this.btn_addtab.Location = new System.Drawing.Point(1572, 156);
            this.btn_addtab.Name = "btn_addtab";
            this.btn_addtab.Size = new System.Drawing.Size(66, 67);
            this.btn_addtab.TabIndex = 4;
            this.btn_addtab.Text = "+";
            this.btn_addtab.UseVisualStyleBackColor = true;
            this.btn_addtab.Click += new System.EventHandler(this.btn_addtab_Click);
            // 
            // btn_deltab
            // 
            this.btn_deltab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deltab.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_deltab.ForeColor = System.Drawing.Color.White;
            this.btn_deltab.Location = new System.Drawing.Point(1644, 156);
            this.btn_deltab.Name = "btn_deltab";
            this.btn_deltab.Size = new System.Drawing.Size(66, 67);
            this.btn_deltab.TabIndex = 4;
            this.btn_deltab.Text = "-";
            this.btn_deltab.UseVisualStyleBackColor = true;
            this.btn_deltab.Click += new System.EventHandler(this.btn_deltab_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.pn_template);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1643, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scene1";
            // 
            // pn_template
            // 
            this.pn_template.Controls.Add(this.pn_Error);
            this.pn_template.Controls.Add(this.DirView);
            this.pn_template.Controls.Add(this.lb_spritepath);
            this.pn_template.Controls.Add(this.lb_sprite);
            this.pn_template.Controls.Add(this.txt_spritepath);
            this.pn_template.Controls.Add(this.txt_sprite);
            this.pn_template.Controls.Add(this.txt4);
            this.pn_template.Controls.Add(this.txt3);
            this.pn_template.Controls.Add(this.btn_treesel);
            this.pn_template.Controls.Add(this.txt2);
            this.pn_template.Controls.Add(this.txt1);
            this.pn_template.Controls.Add(this.lb_tree);
            this.pn_template.Controls.Add(this.lb_effect);
            this.pn_template.Controls.Add(this.lb_txt);
            this.pn_template.Controls.Add(this.cb_effect);
            this.pn_template.Location = new System.Drawing.Point(26, 19);
            this.pn_template.Name = "pn_template";
            this.pn_template.Size = new System.Drawing.Size(1590, 632);
            this.pn_template.TabIndex = 5;
            // 
            // pn_Error
            // 
            this.pn_Error.Controls.Add(this.label1);
            this.pn_Error.Controls.Add(this.btn_fine);
            this.pn_Error.Controls.Add(this.txt_Error);
            this.pn_Error.Controls.Add(this.pictureBox1);
            this.pn_Error.Location = new System.Drawing.Point(578, 148);
            this.pn_Error.Name = "pn_Error";
            this.pn_Error.Size = new System.Drawing.Size(538, 471);
            this.pn_Error.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Determination Mono Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "You IDIOT";
            // 
            // btn_fine
            // 
            this.btn_fine.BackColor = System.Drawing.Color.Black;
            this.btn_fine.FlatAppearance.BorderSize = 0;
            this.btn_fine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fine.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fine.ForeColor = System.Drawing.Color.White;
            this.btn_fine.Location = new System.Drawing.Point(123, 407);
            this.btn_fine.Name = "btn_fine";
            this.btn_fine.Size = new System.Drawing.Size(246, 53);
            this.btn_fine.TabIndex = 8;
            this.btn_fine.Text = "Fine..";
            this.btn_fine.UseVisualStyleBackColor = false;
            this.btn_fine.Click += new System.EventHandler(this.btn_fine_Click);
            // 
            // txt_Error
            // 
            this.txt_Error.BackColor = System.Drawing.Color.Black;
            this.txt_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Error.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Error.ForeColor = System.Drawing.Color.Red;
            this.txt_Error.Location = new System.Drawing.Point(78, 365);
            this.txt_Error.Name = "txt_Error";
            this.txt_Error.Size = new System.Drawing.Size(423, 36);
            this.txt_Error.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // DirView
            // 
            this.DirView.BackColor = System.Drawing.Color.Black;
            this.DirView.Font = new System.Drawing.Font("Determination Mono Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirView.ForeColor = System.Drawing.Color.White;
            this.DirView.Location = new System.Drawing.Point(1122, 78);
            this.DirView.Name = "DirView";
            this.DirView.Size = new System.Drawing.Size(448, 484);
            this.DirView.TabIndex = 5;
            this.DirView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DirView_AfterSelect);
            // 
            // lb_spritepath
            // 
            this.lb_spritepath.AutoSize = true;
            this.lb_spritepath.Font = new System.Drawing.Font("Determination Mono Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_spritepath.ForeColor = System.Drawing.Color.White;
            this.lb_spritepath.Location = new System.Drawing.Point(18, 576);
            this.lb_spritepath.Name = "lb_spritepath";
            this.lb_spritepath.Size = new System.Drawing.Size(68, 28);
            this.lb_spritepath.TabIndex = 3;
            this.lb_spritepath.Text = "Path";
            // 
            // lb_sprite
            // 
            this.lb_sprite.AutoSize = true;
            this.lb_sprite.Font = new System.Drawing.Font("Determination Mono Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sprite.ForeColor = System.Drawing.Color.White;
            this.lb_sprite.Location = new System.Drawing.Point(18, 491);
            this.lb_sprite.Name = "lb_sprite";
            this.lb_sprite.Size = new System.Drawing.Size(96, 28);
            this.lb_sprite.TabIndex = 3;
            this.lb_sprite.Text = "Sprite";
            // 
            // txt_spritepath
            // 
            this.txt_spritepath.BackColor = System.Drawing.Color.Black;
            this.txt_spritepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_spritepath.Font = new System.Drawing.Font("Determination Mono Web", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_spritepath.ForeColor = System.Drawing.Color.White;
            this.txt_spritepath.Location = new System.Drawing.Point(132, 568);
            this.txt_spritepath.Name = "txt_spritepath";
            this.txt_spritepath.Size = new System.Drawing.Size(947, 51);
            this.txt_spritepath.TabIndex = 4;
            // 
            // txt_sprite
            // 
            this.txt_sprite.BackColor = System.Drawing.Color.Black;
            this.txt_sprite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sprite.Font = new System.Drawing.Font("Determination Mono Web", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sprite.ForeColor = System.Drawing.Color.White;
            this.txt_sprite.Location = new System.Drawing.Point(132, 480);
            this.txt_sprite.Name = "txt_sprite";
            this.txt_sprite.Size = new System.Drawing.Size(947, 59);
            this.txt_sprite.TabIndex = 4;
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.Color.Black;
            this.txt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt4.Font = new System.Drawing.Font("Determination Mono Web", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt4.ForeColor = System.Drawing.Color.White;
            this.txt4.Location = new System.Drawing.Point(41, 321);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(1038, 47);
            this.txt4.TabIndex = 4;
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.Color.Black;
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3.Font = new System.Drawing.Font("Determination Mono Web", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.ForeColor = System.Drawing.Color.White;
            this.txt3.Location = new System.Drawing.Point(41, 241);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(1038, 47);
            this.txt3.TabIndex = 4;
            // 
            // btn_treesel
            // 
            this.btn_treesel.BackColor = System.Drawing.Color.Black;
            this.btn_treesel.FlatAppearance.BorderSize = 0;
            this.btn_treesel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_treesel.Font = new System.Drawing.Font("Determination Mono Web", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_treesel.ForeColor = System.Drawing.Color.White;
            this.btn_treesel.Location = new System.Drawing.Point(1153, 557);
            this.btn_treesel.Name = "btn_treesel";
            this.btn_treesel.Size = new System.Drawing.Size(337, 91);
            this.btn_treesel.TabIndex = 1;
            this.btn_treesel.Text = "Select";
            this.btn_treesel.UseVisualStyleBackColor = false;
            this.btn_treesel.Click += new System.EventHandler(this.btn_treesel_click);
            this.btn_treesel.MouseEnter += new System.EventHandler(this.btn_treesel_MouseEnter);
            this.btn_treesel.MouseLeave += new System.EventHandler(this.btn_treesel_MouseLeave);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.Black;
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2.Font = new System.Drawing.Font("Determination Mono Web", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.ForeColor = System.Drawing.Color.White;
            this.txt2.Location = new System.Drawing.Point(41, 163);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(1038, 47);
            this.txt2.TabIndex = 4;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.Black;
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1.Font = new System.Drawing.Font("Determination Mono Web", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.Color.White;
            this.txt1.Location = new System.Drawing.Point(41, 91);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(1038, 47);
            this.txt1.TabIndex = 4;
            // 
            // lb_tree
            // 
            this.lb_tree.AutoSize = true;
            this.lb_tree.Font = new System.Drawing.Font("Determination Mono Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tree.ForeColor = System.Drawing.Color.White;
            this.lb_tree.Location = new System.Drawing.Point(1117, 30);
            this.lb_tree.Name = "lb_tree";
            this.lb_tree.Size = new System.Drawing.Size(138, 28);
            this.lb_tree.TabIndex = 3;
            this.lb_tree.Text = "Directory";
            // 
            // lb_effect
            // 
            this.lb_effect.AutoSize = true;
            this.lb_effect.Font = new System.Drawing.Font("Determination Mono Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_effect.ForeColor = System.Drawing.Color.White;
            this.lb_effect.Location = new System.Drawing.Point(18, 416);
            this.lb_effect.Name = "lb_effect";
            this.lb_effect.Size = new System.Drawing.Size(166, 28);
            this.lb_effect.TabIndex = 3;
            this.lb_effect.Text = "Text Effect";
            // 
            // lb_txt
            // 
            this.lb_txt.AutoSize = true;
            this.lb_txt.Font = new System.Drawing.Font("Determination Mono Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt.ForeColor = System.Drawing.Color.White;
            this.lb_txt.Location = new System.Drawing.Point(36, 30);
            this.lb_txt.Name = "lb_txt";
            this.lb_txt.Size = new System.Drawing.Size(68, 28);
            this.lb_txt.TabIndex = 3;
            this.lb_txt.Text = "Text";
            // 
            // cb_effect
            // 
            this.cb_effect.BackColor = System.Drawing.Color.Black;
            this.cb_effect.Font = new System.Drawing.Font("Determination Mono Web", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_effect.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_effect.FormattingEnabled = true;
            this.cb_effect.Items.AddRange(new object[] {
            "Normal",
            "Demonic"});
            this.cb_effect.Location = new System.Drawing.Point(207, 404);
            this.cb_effect.Name = "cb_effect";
            this.cb_effect.Size = new System.Drawing.Size(222, 60);
            this.cb_effect.TabIndex = 2;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Font = new System.Drawing.Font("Determination Mono Web", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(86, 202);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1651, 699);
            this.tab.TabIndex = 3;
            // 
            // lb_credit
            // 
            this.lb_credit.AutoSize = true;
            this.lb_credit.Font = new System.Drawing.Font("Determination Mono Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_credit.ForeColor = System.Drawing.Color.White;
            this.lb_credit.Location = new System.Drawing.Point(28, 1011);
            this.lb_credit.Name = "lb_credit";
            this.lb_credit.Size = new System.Drawing.Size(558, 112);
            this.lb_credit.TabIndex = 5;
            this.lb_credit.Text = "Motivated from Undertale by Toby Fox\r\nDeveloped by Tyler Kim(김태욱)\r\nEmail : Alitec" +
    "raft@gmail.com\r\n© 2011 Tae Wook Kim ALL RIGHTS RESERVED\r\n";
            // 
            // lb_bigcredit
            // 
            this.lb_bigcredit.AutoSize = true;
            this.lb_bigcredit.Font = new System.Drawing.Font("Monster Friend Back", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bigcredit.ForeColor = System.Drawing.Color.White;
            this.lb_bigcredit.Location = new System.Drawing.Point(25, 950);
            this.lb_bigcredit.Name = "lb_bigcredit";
            this.lb_bigcredit.Size = new System.Drawing.Size(337, 48);
            this.lb_bigcredit.TabIndex = 3;
            this.lb_bigcredit.Text = "Credits";
            // 
            // pb_flowey
            // 
            this.pb_flowey.Image = ((System.Drawing.Image)(resources.GetObject("pb_flowey.Image")));
            this.pb_flowey.Location = new System.Drawing.Point(1644, 950);
            this.pb_flowey.Name = "pb_flowey";
            this.pb_flowey.Size = new System.Drawing.Size(151, 159);
            this.pb_flowey.TabIndex = 6;
            this.pb_flowey.TabStop = false;
            this.pb_flowey.Click += new System.EventHandler(this.pb_flowey_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Alitetale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1825, 1148);
            this.Controls.Add(this.pb_flowey);
            this.Controls.Add(this.lb_credit);
            this.Controls.Add(this.btn_deltab);
            this.Controls.Add(this.btn_addtab);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lb_alitetale);
            this.Controls.Add(this.lb_bigcredit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Alitetale";
            this.Text = "ALITETALE";
            this.Load += new System.EventHandler(this.Alitetale_Load);
            this.tabPage1.ResumeLayout(false);
            this.pn_template.ResumeLayout(false);
            this.pn_template.PerformLayout();
            this.pn_Error.ResumeLayout(false);
            this.pn_Error.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_flowey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_alitetale;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_addtab;
        private System.Windows.Forms.Button btn_deltab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lb_effect;
        private System.Windows.Forms.Label lb_txt;
        private System.Windows.Forms.ComboBox cb_effect;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.Panel pn_template;
        private System.Windows.Forms.Label lb_sprite;
        private System.Windows.Forms.Label lb_credit;
        private System.Windows.Forms.Label lb_tree;
        private System.Windows.Forms.Button btn_treesel;
        private System.Windows.Forms.Label lb_bigcredit;
        private System.Windows.Forms.PictureBox pb_flowey;
        private System.Windows.Forms.Label lb_spritepath;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pn_Error;
        private System.Windows.Forms.TextBox txt_Error;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_fine;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_sprite;
        public System.Windows.Forms.TextBox txt3;
        public System.Windows.Forms.TextBox txt2;
        public System.Windows.Forms.TextBox txt1;
        public System.Windows.Forms.TreeView DirView;
        public System.Windows.Forms.TextBox txt4;
        public System.Windows.Forms.TextBox txt_spritepath;
    }
}

