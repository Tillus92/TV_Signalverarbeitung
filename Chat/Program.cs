using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class Program //Kaffee
    {
        static void Main(string[] args)
        {
            Mann mann = new Mann();
            Frau frau = new Frau();
            mann.name = "Horst";
            frau.name = "Susann";
            frau.istInteressiert = true;

            //Das Bild des Mannes von der Frau entspricht dem Object frau. 
  
            Console.WriteLine(mann.AnsprechenDerFrau(frau));
            Console.WriteLine(frau.antwortFrau(mann));
            Console.ReadLine();
        


        }
    }
    class Mann
    {
        public string name; 
        //
        public Frau kennt;
        
        public string AnsprechenDerFrau(Frau frau)
        {
            return frau.istInteressiert ? "Mann: Hi was geht, ich bin " + name + " darf ich Sie auf einen Kaffe einladen?"  : "Mann sagt nichts und verlässt das Kaffee";
        }
    }
    class Frau
    {
        //Frau erhält Referenz des Typen Mann
        public Mann kennt;
        public string name;
        public bool istInteressiert;

        public string antwortFrau(Mann mann)
        {
            return istInteressiert ? "Frau: Hallo " + mann.name + " mein Name ist "  + name + " gerne können wenn wir einen Kaffe trinken, wenn du zahlst!" : "Kauft sich einen eigenen Kaffe";
        }
    }

}
