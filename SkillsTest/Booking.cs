using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Booking
    {
        //int _id;
        //DateTime _startDato;
        //DateTime _slutDato;
        //int _antalDeltagere;
        public int ID { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }
        public int AntalDeltagere { get; private set; }

        public Booking(int id, DateTime start, DateTime slut, int antalDeltagere)
        {
            ID = id;
            Start = start;
            End = slut;
            AntalDeltagere = antalDeltagere;
        }

        public override string ToString()
        {
            return $"Id: {ID}, Start: {Start}, Slut: {End}, Antal deltagere: {AntalDeltagere} ";
        }



    }



    
}
