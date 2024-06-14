using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class GymHall
    {
        Booking bookings;
        Dictionary<int, Booking> _bookings;

        int _id;
        string _name;
        string _adress;
        string _phone;
        string _email;
        

        public GymHall(int id, string name, string adress, string phone, string email) 
        {

            _id = id;
            _name = name;
            _adress = adress;
            _phone = phone;
            _email = email;
            _bookings = new Dictionary<int, Booking>();
        }



        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
         

        //Det er udkoomenteret for at første del virker 

        //public void RegisterBooking(Booking booking) 
        //{
        //    _bookings.Add(Booking.ID Booking);
        //}

        //public void PrintBookings() 
        //{
        //    foreach (Booking booking in _bookings.Values)
        //    {
        //        Console.WriteLine(Booking);
        //    }
        //}

        //public void RemoveBooking() 
        //{
        //    _bookings.Remove(ID);
        //}


        public override string ToString()
        {
            return $"Id: {ID}\nNavn: {Name}\nAdresse {Adress}\nTelefonnummer: {Phone}\nEmail: {Email} ";
        }



    }


}
