﻿using System;
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
    /// <summary>
    /// класс номер телефона
    /// </summary>
    public class NumberPh
    {
        private string _Number;
        public string Number
        {
            get { return _Number; }
            set
            {
                //спросить как лучше сделать условие
                if (//условие)
                        {
                    throw new Exception();
                    _Number = value;
                }
            }
        }
    }

    public NumberPh(string Number)
    {
        Number = Number;
    }

    /// <summary>
    /// класс конакты содержит фамилию, имя, номер, др, емайл, вкид
    /// </summary>
    public class contact
    {
        private string _surname; //как ограничить число символов
        private string _name;
        private string _Number;
        private int _happyB;
        private string _email;
        private string _vkid;

        public string surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
            }
        }
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public string Number
        {
            get { return _Number; }
            set
            {
                _Number = value;
            }
        }
        public int happyB
        {
            get { return _happyB; }
            set
            {
                _happyB = value;
            }
        }
        public string email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }
        public string vkid
        {
            get { return _vkid; }
            set
            {
                _vkid = value;
            }
        }
    }
    public contact(string surname, string name, string Number, int happyB, string email, string vkid)
    {
        surname = surname;
        name = name;
        Number = Number;
        happyB = happyB;
        email = email;
        vkid = vkid;
    }

    private class project
    {
        //хз что сюда
    }

    private class managerprj
    {
        //настроить сохранение
    }

    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }
    }
}
