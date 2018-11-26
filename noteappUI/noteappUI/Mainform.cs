using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteappUI
{
    
    public partial class FindTextBox : Form
    {
        public FindTextBox()
        {
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            this.findlabel1 = new System.Windows.Forms.Label();
            this.SpislistBox1 = new System.Windows.Forms.ListBox();
            this.FindtextBox1 = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.vk = new System.Windows.Forms.Label();
            this.SurnametextBox1 = new System.Windows.Forms.TextBox();
            this.NametextBox2 = new System.Windows.Forms.TextBox();
            this.BirthdaytextBox3 = new System.Windows.Forms.TextBox();
            this.PhonetextBox4 = new System.Windows.Forms.TextBox();
            this.EmailtextBox5 = new System.Windows.Forms.TextBox();
            this.VktextBox6 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.helpbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findlabel1
            // 
            this.findlabel1.AutoSize = true;
            this.findlabel1.Location = new System.Drawing.Point(24, 37);
            this.findlabel1.Name = "findlabel1";
            this.findlabel1.Size = new System.Drawing.Size(35, 17);
            this.findlabel1.TabIndex = 0;
            this.findlabel1.Text = "Find";
            this.findlabel1.Click += new System.EventHandler(this.findlabel1_Click);
            // 
            // SpislistBox1
            // 
            this.SpislistBox1.AutoSize = true;
            this.SpislistBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SpislistBox1.FormattingEnabled = true;
            this.SpislistBox1.ItemHeight = 16;
            this.SpislistBox1.Location = new System.Drawing.Point(27, 64);
            this.SpislistBox1.MinimumSize = new System.Drawing.Size(239, 468);
            this.SpislistBox1.Name = "SpislistBox1";
            this.SpislistBox1.Size = new System.Drawing.Size(239, 468);
            this.SpislistBox1.TabIndex = 1;
            this.SpislistBox1.SelectedIndexChanged += new System.EventHandler(this.SpislistBox1_SelectedIndexChanged);
            // 
            // FindtextBox1
            // 
            this.FindtextBox1.Location = new System.Drawing.Point(65, 34);
            this.FindtextBox1.MaximumSize = new System.Drawing.Size(402, 44);
            this.FindtextBox1.Name = "FindtextBox1";
            this.FindtextBox1.Size = new System.Drawing.Size(201, 22);
            this.FindtextBox1.TabIndex = 2;
            this.FindtextBox1.TextChanged += new System.EventHandler(this.FindtextBox1_TextChanged);
            // 
            // Surname
            // 
            this.Surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(308, 64);
            this.Surname.MinimumSize = new System.Drawing.Size(65, 17);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(65, 17);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Surname";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(328, 98);
            this.name.MinimumSize = new System.Drawing.Size(45, 17);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 17);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            // 
            // birthday
            // 
            this.birthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(313, 135);
            this.birthday.MinimumSize = new System.Drawing.Size(60, 17);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(60, 17);
            this.birthday.TabIndex = 5;
            this.birthday.Text = "Birthday";
            // 
            // phone
            // 
            this.phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(324, 171);
            this.phone.MinimumSize = new System.Drawing.Size(49, 17);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(49, 17);
            this.phone.TabIndex = 6;
            this.phone.Text = "Phone";
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(332, 209);
            this.email.MinimumSize = new System.Drawing.Size(41, 17);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 17);
            this.email.TabIndex = 7;
            this.email.Text = "email";
            this.email.Click += new System.EventHandler(this.label6_Click);
            // 
            // vk
            // 
            this.vk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vk.AutoSize = true;
            this.vk.Location = new System.Drawing.Point(321, 247);
            this.vk.MinimumSize = new System.Drawing.Size(52, 17);
            this.vk.Name = "vk";
            this.vk.Size = new System.Drawing.Size(52, 17);
            this.vk.TabIndex = 8;
            this.vk.Text = "vk.com";
            // 
            // SurnametextBox1
            // 
            this.SurnametextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SurnametextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SurnametextBox1.Location = new System.Drawing.Point(379, 64);
            this.SurnametextBox1.MaximumSize = new System.Drawing.Size(772, 44);
            this.SurnametextBox1.Name = "SurnametextBox1";
            this.SurnametextBox1.Size = new System.Drawing.Size(386, 22);
            this.SurnametextBox1.TabIndex = 9;
            this.SurnametextBox1.TextChanged += new System.EventHandler(this.SurnametextBox1_TextChanged);
            // 
            // NametextBox2
            // 
            this.NametextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NametextBox2.Location = new System.Drawing.Point(380, 98);
            this.NametextBox2.MaximumSize = new System.Drawing.Size(772, 44);
            this.NametextBox2.Name = "NametextBox2";
            this.NametextBox2.Size = new System.Drawing.Size(386, 22);
            this.NametextBox2.TabIndex = 10;
            this.NametextBox2.TextChanged += new System.EventHandler(this.NametextBox2_TextChanged);
            // 
            // BirthdaytextBox3
            // 
            this.BirthdaytextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BirthdaytextBox3.Location = new System.Drawing.Point(379, 135);
            this.BirthdaytextBox3.MaximumSize = new System.Drawing.Size(772, 44);
            this.BirthdaytextBox3.Name = "BirthdaytextBox3";
            this.BirthdaytextBox3.Size = new System.Drawing.Size(386, 22);
            this.BirthdaytextBox3.TabIndex = 11;
            this.BirthdaytextBox3.TextChanged += new System.EventHandler(this.BirthdaytextBox3_TextChanged);
            // 
            // PhonetextBox4
            // 
            this.PhonetextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhonetextBox4.Location = new System.Drawing.Point(379, 171);
            this.PhonetextBox4.MaximumSize = new System.Drawing.Size(772, 44);
            this.PhonetextBox4.Name = "PhonetextBox4";
            this.PhonetextBox4.Size = new System.Drawing.Size(386, 22);
            this.PhonetextBox4.TabIndex = 12;
            this.PhonetextBox4.TextChanged += new System.EventHandler(this.PhonetextBox4_TextChanged);
            // 
            // EmailtextBox5
            // 
            this.EmailtextBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmailtextBox5.Location = new System.Drawing.Point(380, 209);
            this.EmailtextBox5.MaximumSize = new System.Drawing.Size(772, 44);
            this.EmailtextBox5.Name = "EmailtextBox5";
            this.EmailtextBox5.Size = new System.Drawing.Size(386, 22);
            this.EmailtextBox5.TabIndex = 13;
            this.EmailtextBox5.TextChanged += new System.EventHandler(this.EmailtextBox5_TextChanged);
            // 
            // VktextBox6
            // 
            this.VktextBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VktextBox6.Location = new System.Drawing.Point(380, 247);
            this.VktextBox6.MaximumSize = new System.Drawing.Size(772, 44);
            this.VktextBox6.Name = "VktextBox6";
            this.VktextBox6.Size = new System.Drawing.Size(386, 22);
            this.VktextBox6.TabIndex = 14;
            this.VktextBox6.TextChanged += new System.EventHandler(this.VktextBox6_TextChanged);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Add.Location = new System.Drawing.Point(27, 538);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(77, 23);
            this.Add.TabIndex = 15;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edit.Location = new System.Drawing.Point(108, 539);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(77, 23);
            this.edit.TabIndex = 16;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // remove
            // 
            this.remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.remove.Location = new System.Drawing.Point(189, 538);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(77, 23);
            this.remove.TabIndex = 17;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // helpbutton1
            // 
            this.helpbutton1.Location = new System.Drawing.Point(165, 5);
            this.helpbutton1.Name = "helpbutton1";
            this.helpbutton1.Size = new System.Drawing.Size(75, 23);
            this.helpbutton1.TabIndex = 18;
            this.helpbutton1.Text = "help";
            this.helpbutton1.UseVisualStyleBackColor = true;
            // 
            // FindTextBox
            // 
            this.ClientSize = new System.Drawing.Size(794, 569);
            this.Controls.Add(this.helpbutton1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.VktextBox6);
            this.Controls.Add(this.EmailtextBox5);
            this.Controls.Add(this.PhonetextBox4);
            this.Controls.Add(this.BirthdaytextBox3);
            this.Controls.Add(this.NametextBox2);
            this.Controls.Add(this.SurnametextBox1);
            this.Controls.Add(this.vk);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.FindtextBox1);
            this.Controls.Add(this.SpislistBox1);
            this.Controls.Add(this.findlabel1);
            this.Name = "FindTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {

        }

        private void findlabel1_Click(object sender, EventArgs e)
        {

        }

        private void FindtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SpislistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SurnametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NametextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BirthdaytextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhonetextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailtextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void VktextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
