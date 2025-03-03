using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract13_3_karamov
{
    class Computer
    {
        private int number; //номер компьютера
        private string name; //имя пользователя
        private string system; //система
        private string cpu; //процессор
        private string gpu; //видеокарта
        private int ozu; //оперативная память
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string System
        {
            get { return system; }
            set { system = value; }
        }
        public string CPU
        {
            get { return cpu; }
            set { cpu = value; }
        }
        public string GPU
        {
            get { return gpu; }
            set { gpu = value; }
        }
        public int OZU
        {
            get { return ozu; }
            set { ozu = value; }
        }
    }
}
