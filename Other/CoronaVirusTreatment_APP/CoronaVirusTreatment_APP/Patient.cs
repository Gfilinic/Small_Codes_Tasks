using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaVirusTreatment_APP
{
    class Patient
    {
        public string Name { get; set; }

        public Symptoms Symptoms { get; set; }

        public Patient()
        {
            Console.Write("Enter the name of a new patient: ");
            this.Name = Console.ReadLine();
        }
        public List<Symptoms> _patientSymptomList = new List<Symptoms>();
    }
}
