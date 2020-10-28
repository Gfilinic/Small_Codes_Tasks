using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaVirusTreatment_APP
{

    class Symptoms
    {
        public string SymptomName { get; set; }
        
        public Symptoms()
        {
            Console.Write("Please enter the symptom: ");
            this.SymptomName = Console.ReadLine();
        }
    }
}
