using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;


namespace Dohqa.Arduino
{
    public class Arduino
    {
        SerialPort dohqa = new SerialPort("COM4", 9600);

        public bool buttonclick1()
        {
            dohqa.Open();
            dohqa.Write("S1");
            string resposta = dohqa.ReadLine();
            if (resposta == "")
            {
                return true;
            }
            else return false;
        }


    }
}
