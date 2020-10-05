using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Alitetale
{
    public partial class Alitetale : System.Windows.Forms.Form
    {
        public string line1;
        public string line2;
        public string line3;
        public string line4;

        public string path;

        // private Form2 otherForm;
        //private void GetOtherFormTextBox()
        //{
        //     txt_sprite.Text = otherForm.TextBox1.Text;
        //}
        private Form2 frm2 = new Form2();
        

        public Alitetale()
        {
            InitializeComponent();
            pn_Error.Visible = false;

            //Setup to display Directory in the treeview(DirView)
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Tyler\Documents\Visual Studio 2015\Projects\Alitetale\Alitetale\Undertale");
            if (directoryInfo.Exists)
            {
                DirView.AfterSelect += treeView1_AfterSelect;
                BuildTree(directoryInfo, DirView.Nodes);
            }
            //timer1.Interval = 2000;
            timer1.Enabled = true;
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_alitetale.ForeColor = lb_alitetale.ForeColor == Color.Orange ? Color.DeepSkyBlue : Color.Orange;
        }
        
        #region Methods

        public void AddTab()
        {
            string title = "Scene" + (tab.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tab.TabPages.Add(myTabPage);
        }

        public void DelTab()
        {
            if (tab.TabCount != 0) tab.TabPages.Remove(tab.SelectedTab);
        }

        #endregion

        #region Treeview
        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            TreeNode curNode = addInMe.Add(directoryInfo.Name);

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                curNode.Nodes.Add(file.FullName, file.Name);
            }
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                BuildTree(subdir, curNode.Nodes);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name.EndsWith("txt"))
            {
                StreamReader reader = new StreamReader(e.Node.Name);
                this.DirView.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void DirView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNodeText = e.Node.Text;
            txt_sprite.Text = selectedNodeText;


            string path = e.Node.FullPath;
            txt_spritepath.Text = path;

        }
        #endregion

        #region buttons
        private void btn_addtab_Click(object sender, EventArgs e) //how to copy the panel
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2015\Projects\Alitetale\Alitetale\Undertale\SFX\Ding.wav");
            player.Play();

            AddTab();
            
        }

        private void btn_deltab_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2015\Projects\Alitetale\Alitetale\Undertale\SFX\Ding.wav");
            player.Play();

            DelTab();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            
            if (txt1.Text != string.Empty && txt_sprite.Text != string.Empty)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2015\Projects\Alitetale\Alitetale\Undertale\SFX\SAVE_ok.wav");
                player.Play();


                //otherForm.Show();
                this.frm2.Show();

                txt1.Text = line1;
                txt2.Text = line2;
                txt3.Text = line3;
                txt4.Text = line4;
                txt_spritepath.Text = path;

            }
            else if(txt1.Text == string.Empty)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2015\Projects\Alitetale\Alitetale\Undertale\SFX\omegaflowey_battle_sound_18.wav");
                player.Play();
                pn_Error.Visible = true;
                txt_Error.Text = "YOU FORGOT THE TEXT";
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2015\Projects\Alitetale\Alitetale\Undertale\SFX\omegaflowey_battle_sound_18.wav");
                player.Play();
                pn_Error.Visible = true;
                txt_Error.Text = "CHOOSE THE SPRITE";
            }
                
        }

        private void btn_treesel_click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2015\Projects\Alitetale\Alitetale\Undertale\SFX\SAVE_ok.wav");
            player.Play();
            DirView.ForeColor = Color.White;
            DirView.SelectedNode.ForeColor = Color.Yellow;
        }

        private void pb_flowey_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2015\Projects\Alitetale\Alitetale\Undertale\SFX\thats_a_wonderful_idea.wav");
            player.Play();
        }
        private void btn_fine_Click(object sender, EventArgs e)
        {
            pn_Error.Visible = false;

        }

        private void Alitetale_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Yellow Button
        private void btn_start_MouseEnter(object sender, EventArgs e)
        {
            btn_start.ForeColor = Color.Yellow;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.ForeColor = Color.White;
        }

        private void btn_treesel_MouseEnter(object sender, EventArgs e)
        {
            btn_treesel.ForeColor = Color.Yellow;
        }

        private void btn_treesel_MouseLeave(object sender, EventArgs e)
        {
            btn_treesel.ForeColor = Color.White;
        }
        #endregion


    }
    }
