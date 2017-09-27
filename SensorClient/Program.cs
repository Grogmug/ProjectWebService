using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorClient
{
    class Program
    {
        string line;
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.CollectSensorData();
        }

        public void Run()
        {

        }

        public void CollectSensorData()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("logfil.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] dataSeperated = SeperateString(line);

                Console.WriteLine($"Tid: {dataSeperated[0]} Id: {dataSeperated[1]} Alarm: {dataSeperated[2]} Navn: {dataSeperated[3]} Afdeling: {dataSeperated[4]} Bolig: {dataSeperated[5]} Afmeldt: {dataSeperated[7]}");
            }
            file.Close();
            Console.ReadLine();
        }
        public string[] SeperateString(string input)
        {
            return input.Split('\t');
        }
    }
}
