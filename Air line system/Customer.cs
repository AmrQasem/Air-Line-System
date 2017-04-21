using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Air_line_system
{
    class Customer
    {
        public string name;
        public int id;
        public string country;
        public string date;
        public int phone;
        public int numberOfticket;
        public string TripType;
        public string classtype;
        public double NETfare;
        public Customer()
        {
            name = "";
            id = 0;
            country = "";
            date = "";
            phone = 0;
            numberOfticket = 0;
            TripType = "";
            NETfare = 0;
        }
        public Customer(string Name, int ID, int Phone, string Country, string Date, int NumberOfticket, string tripType,string Classtype)
        {
            name = Name;
            id = ID;
            phone = Phone;
            country = Country;
            date = Date;
            numberOfticket = NumberOfticket;
            TripType = tripType;
            classtype = Classtype;
            NETfare = 0;
        }
        public void add()
        {
            FileStream fs = new FileStream("Customer.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string delemter = "|";
            string data = this.name + delemter + this.id + delemter + this.country + delemter + this.date + delemter + this.phone + delemter + this.numberOfticket + delemter + this.TripType + delemter + this.classtype + delemter + this.NETfare;
            sw.WriteLine(data);
            sw.Close();
        }
        public bool Search(string country, string date)
        {
            FileStream fs = new FileStream("flight.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split('|');
                if (arr[0] == country)
                {
                    if (arr[1] == date)
                    {
                        sr.Close();
                        return true;
                    }
                }
            }
            sr.Close();
            return false;
        }
        public bool delete(string id)
        {
            int count = 0;
            List<string> lineList = new List<string>();
            FileStream fs = new FileStream("Customer.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split('|');
                if (arr[1] == id)
                {
                    sr.Close();
                    lineList = File.ReadAllLines("Customer.txt").ToList();
                    lineList.RemoveAt(count);
                    File.WriteAllLines(("Customer.txt"), lineList.ToArray());
                    return true;
                }
                count++;
            }
            sr.Close();
            return false;
           
        }
        public double NetFare()
        {
            double netfare = 0;
            //netfare = 0;   
            if (this.country == "USA")
            {
                if (this.TripType == "Round" && this.classtype == "Business")//we besnes
                {
                    netfare = 1000 * 2 * this.numberOfticket;
                }
                else if (this.TripType == "Round" && this.classtype == "Commerical")//comm
                {
                    netfare = (1000 + (1000 * 0.8)) * this.numberOfticket;
                }
                else if (this.TripType == "Oneway" && this.classtype == "Business")//bs
                {
                    netfare = (1000 + (1000 * .2)) * this.numberOfticket;
                }
                else if (this.TripType == "Oneway" && this.classtype == "Commerical")//comm
                {
                    netfare = 1000 * this.numberOfticket;
                }
            }
            if (this.country == "ITALY")
            {
                if (this.TripType == "Round" && this.classtype == "Business")//we besnes
                {
                    netfare = 1000 * 2 * this.numberOfticket;
                }
                else if (this.TripType == "Round" && this.classtype == "Commerial")//comm
                {
                    netfare = (1000 + (1000 * 0.8)) * this.numberOfticket;
                   
                }
                else if (this.TripType == "Oneway" && this.classtype == "Business")//bs
                {
                    netfare = (1000 + (1000 * .2)) * this.numberOfticket;
                    
                }
                else if (this.TripType == "Oneway" && this.classtype == "Commerical")//comm
                {
                    netfare = 1000 * this.numberOfticket;
                }
            }
            if (this.country == "KSA")
            {
                if (this.TripType == "Round" && this.classtype == "Business")//we besnes
                {
                    netfare = 500 * 2 * this.numberOfticket;
                }
                else if (this.TripType == "Round" && this.classtype == "Commerical")//comm
                {
                    netfare = (500 + (500 * 0.8)) * this.numberOfticket;
                   
                }
                else if (this.TripType == "Oneway" && this.classtype == "Business")//bs
                {
                    netfare = (500 + (500 * .2)) * this.numberOfticket;
   
                }
                else if (this.TripType == "Oneway" && this.classtype == "Commerical")//comm
                {
                    netfare = 500 * this.numberOfticket;
                }
            }
            if (this.country == "UAE")
            {
                if (this.TripType == "Round" && this.classtype == "Business")//we besnes
                {
                    netfare = 300 * 2 * this.numberOfticket;
                }
                else if (this.TripType == "Round" && this.classtype == "Commerical")//comm
                {
                    netfare = (300 + (300 * 0.8)) * this.numberOfticket;
                    
                }
                else if (this.TripType == "Oneway" && this.classtype == "Business")//bs
                {
                    netfare = (300 + (300 * .2)) * this.numberOfticket;
                    
                }
                else if (this.TripType == "Oneway" && this.classtype == "Commerical")//comm
                {
                    netfare = 300 * this.numberOfticket;
                }
            }
            return netfare;
        }
    }
}
