using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_zwei
{
    class Program
    {
        static void Main(string[] args)
        {
            SpieleKonsole playstation = new SpieleKonsole();
            Reciever dolby = new Reciever();
            Screen bildschirm = new Screen(dolby, playstation);
            playstation.active = false;
            bildschirm.active = true;
            dolby.active = false;
            //Console.WriteLine("Screen Kanal: " + Screen.kanal);
            //Screen.kanal = 2;
            // Console.WriteLine("Screen Kanal: " +  Screen.kanal);
            Console.WriteLine(bildschirm.SwitchChannel(dolby, playstation));        
            Console.ReadLine();


        }
    }
    class Screen
    {
        public bool active;
       
        public Reciever kenntReciever;
        public SpieleKonsole kenntKonsole;
        public static int kanal = 1;
        
        public Screen(Reciever kenntReciever, SpieleKonsole kenntKonsole)
        {
            this.kenntReciever = kenntReciever;
            this.kenntKonsole = kenntKonsole;
        }
        public string SwitchChannel(Reciever r, SpieleKonsole s)
        {
            if (active && r.active && kanal == 1)
            {
                return this.ToString() + " " + r.ToString() + "Kanal" + kanal;
            } else if (active && r.active == false && s.active)
            {
                kanal = 2;
                if (kanal == 2)
                {
                    return this.ToString() + " " + s.ToString() + " Kanal: " + kanal;
                }
            } else if (active && r.active == false && s.active == false)
            {
                return this.ToString() + " Kein aktives Signal im HDMI ";
            } 
           return " ";
        }
        public override string ToString()
        {
            return "Der Screen ist AN!";
        }
       
    }
    class Reciever
    {
        public bool active;
       
        
        public override string ToString()
        {
            return "Receiver belegt gerade den HDMI ausgang.";
        }
    }
    class SpieleKonsole
    {
        public bool active;
      
        
        public override string ToString()
        {
            return "Konsole belegt gerade den HDMI ausgang.";
        }
    }
}
