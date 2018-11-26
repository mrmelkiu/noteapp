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
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find";
            // 
            // SpislistBox1
            // 
            this.SpislistBox1.FormattingEnabled = true;
            this.SpislistBox1.ItemHeight = 16;
            this.SpislistBox1.Location = new System.Drawing.Point(27, 64);
            this.SpislistBox1.Name = "SpislistBox1";
            this.SpislistBox1.Size = new System.Drawing.Size(239, 468);
            this.SpislistBox1.TabIndex = 1;
            // 
            // FindtextBox1
            // 
            this.FindtextBox1.Location = new System.Drawing.Point(65, 34);
            this.FindtextBox1.Name = "FindtextBox1";
            this.FindtextBox1.Size = new System.Drawing.Size(201, 22);
            this.FindtextBox1.TabIndex = 2;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(308, 64);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(65, 17);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Surname";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(328, 98);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 17);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(313, 135);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(60, 17);
            this.birthday.TabIndex = 5;
            this.birthday.Text = "Birthday";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(324, 171);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(49, 17);
            this.phone.TabIndex = 6;
            this.phone.Text = "Phone";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(332, 209);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 17);
            this.email.TabIndex = 7;
            this.email.Text = "email";
            this.email.Click += new System.EventHandler(this.label6_Click);
            // 
            // vk
            // 
            this.vk.AutoSize = true;
            this.vk.Location = new System.Drawing.Point(321, 247);
            this.vk.Name = "vk";
            this.vk.Size = new System.Drawing.Size(52, 17);
            this.vk.TabIndex = 8;
            this.vk.Text = "vk.com";
            // 
            // SurnametextBox1
            // 
            this.SurnametextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SurnametextBox1.Location = new System.Drawing.Point(379, 64);
            this.SurnametextBox1.Name = "SurnametextBox1";
            this.SurnametextBox1.Size = new System.Drawing.Size(386, 22);
            this.SurnametextBox1.TabIndex = 9;
            // 
            // NametextBox2
            // 
            this.NametextBox2.Location = new System.Drawing.Point(380, 98);
            this.NametextBox2.Name = "NametextBox2";
            this.NametextBox2.Size = new System.Drawing.Size(386, 22);
            this.NametextBox2.TabIndex = 10;
            // 
            // BirthdaytextBox3
            // 
            this.BirthdaytextBox3.Location = new System.Drawing.Point(379, 135);
            this.BirthdaytextBox3.Name = "BirthdaytextBox3";
            this.BirthdaytextBox3.Size = new System.Drawing.Size(386, 22);
            this.BirthdaytextBox3.TabIndex = 11;
            // 
            // PhonetextBox4
            // 
            this.PhonetextBox4.Location = new System.Drawing.Point(379, 171);
            this.PhonetextBox4.Name = "PhonetextBox4";
            this.PhonetextBox4.Size = new System.Drawing.Size(386, 22);
            this.PhonetextBox4.TabIndex = 12;
            // 
            // EmailtextBox5
            // 
            this.EmailtextBox5.Location = new System.Drawing.Point(380, 209);
            this.EmailtextBox5.Name = "EmailtextBox5";
            this.EmailtextBox5.Size = new System.Drawing.Size(386, 22);
            this.EmailtextBox5.TabIndex = 13;
            // 
            // VktextBox6
            // 
            this.VktextBox6.Location = new System.Drawing.Point(380, 247);
            this.VktextBox6.Name = "VktextBox6";
            this.VktextBox6.Size = new System.Drawing.Size(386, 22);
            this.VktextBox6.TabIndex = 14;
            // 
            // FindTextBox
            // 
            this.ClientSize = new System.Drawing.Size(794, 569);
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
            this.Controls.Add(this.label1);
            this.Name = "FindTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
