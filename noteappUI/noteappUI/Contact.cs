using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noteappUI
{
    /// <summary>
    /// класс контакты
    /// </summary>
    public class contact
    {
        private string _surname, _name, _email, _vkid;
        private DateTime _happyB = new DateTime();
        private string _Number;
        public contact(string nSurname, string nName, string nEmail, string nvkid, DateTime nhappyB, string nNumber)
        {
            _Number = nNumber;
            _surname = nSurname;
            _name = nName;
            _email = nEmail;
            _vkid = nvkid;
            _happyB = nhappyB;
        }
        /// <summary>
        /// задание и проверка номера
        /// </summary>
        public string Number
        {
            set
            {
                if ((value.Length != 11) && (value[0] == '7'))
                {
                    throw new ArgumentException("Телефон введен не верно");
                }
                else
                {
                    _Number = value;
                }
            }

            get { return _Number; }
        }
        /// <summary>
        /// задание и проверка фамилии
        /// </summary>
        public string Surname
        {
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("фамилия должна содержать менее 50 символов");
                }
                else
                {
                    _surname = value;
                }
            }
            get { return _surname; }
        }

        /// <summary>
        /// задание и проверка имени
        /// </summary>
        public string name
        {
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("имя должно содержать менее 50 символов");
                }
                else
                {
                    _name = value;
                }
            }
            get { return _name; }
        }

        /// <summary>
        /// задание и проверка email
        /// </summary>
        public string email
        {
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("email должен содержать менее 50 символов");
                }
                else
                {
                    _email = value;
                }
            }
            get { return _email; }
        }

        /// <summary>
        /// задание и проверка вк
        /// </summary>
        public string vkid
        {
            set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException("vk id должне содержать менее 15 символов");
                }
                else
                {
                    _vkid = value;
                }
            }
            get { return _vkid; }
        }

        /// <summary>
        /// задание и проверка даты рождения
        /// </summary>
        public DateTime happyB
        {
            set
            {
                DateTime date1 = new DateTime(1900);
                DateTime date2 = new DateTime(1900);
                date2 = DateTime.Today;

                if ((value > date1) && (value > date2))
                {
                    throw new ArgumentException("введите верную дату рождения");
                }
                else
                {
                    _happyB = value;
                }
            }
            get { return _happyB; }
        }

    }
}
