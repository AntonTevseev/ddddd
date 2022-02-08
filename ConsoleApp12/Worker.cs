using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApp12
{
    struct Worker
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }
        private string High { get; set; }
        public string DataBirthsday { get; set; }
        public string Place { get; set; }
        string Data = DateTime.Now.ToShortTimeString();
        public Worker(string ID, string FullName, string Age, string High, string DataBirthsday, string Place)
        {
            this.ID = ID;
            this.FullName = FullName;
            this.Age = Age;
            this.High = High;
            this.DataBirthsday = DataBirthsday;
            this.Place = Place;
        }
        
        public string PrintID()
        {
            return $"{ID}";
        }
        public void Save()
        {
            string info1 = $"{ ID }, { FullName }, { Data }, { Age }, { High }, { DataBirthsday }, { Place }\t";
            //string info2 += $" { FullName }";
            //string info3 += $" { Data }";
            //string info4 += $" { Age }";
            //string info5 += $" { High }";
            //string info6 += $" { DataBirthsday }";
            //string info7 += $" { Place }";
            
           
            File.WriteAllText(@"d:\data3.txt", info1);
            //File.AppendAllText(@"d:\data3.txt", info2);
            //File.AppendAllText(@"d:\data3.txt", info3);
            //File.AppendAllText(@"d:\data3.txt", info4);
            //File.AppendAllText(@"d:\data3.txt", info5);
            //File.AppendAllText(@"d:\data3.txt", info6);
            //File.AppendAllText(@"d:\data3.txt", info7);

        }
        public void NewSave(string ID, string FullName, string Age, string High, string DataBirthsday, string Place)
        {
            string info2 = $"\n{ID}, {FullName}, {Age}, {High}, { Data }, {DataBirthsday}, {Place}";
            File.AppendAllText(@"d:\data3.txt", info2);
        }

        public void NewID(string ID)
        {
            this.ID = ID;
        }
        public void NewName(string FullName)
        {
            this.FullName = FullName ;
        }
        public void NewAge(string Age)
        {
            this.Age = Age;
        }
        public void NewHigh(string High)
        {
            this.High = High;
        }
        public void newDatabir(string DataBirthsday)
        { this.DataBirthsday = DataBirthsday;}

        public void NewPlace(string Place)
        {
            this.Place = Place;
        }

    }
}
