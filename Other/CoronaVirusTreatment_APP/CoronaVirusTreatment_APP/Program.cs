using System;
using System.Collections.Generic;

namespace CoronaVirusTreatment_APP
{
    class Program
    {
        static List<Symptoms> _symptomList = new List<Symptoms>();
        static List<Patient> _patientList = new List<Patient>();
        static void Main(string[] args)
        {
            int menu;

            do
            {
                Console.WriteLine("Corona Symptoms APP");
                Console.WriteLine("---------------------------");
                Console.WriteLine("[1]Add Symptom");
                Console.WriteLine("[2]Add Patient");
                Console.WriteLine("[3]Recommend for screening");
                Console.WriteLine("[4]Exit");
                Console.Write("Input: ");
                menu = int.Parse(Console.ReadLine());


                switch (menu)
                {
                    case 1: AddSymptom(); break;
                    default:
                        break;
                    case 2: AddPatient();
                        ; break;
                    case 3: RecommendForScreening();
                        ;
                        break;
                    case 4:; break;
                }

            } while (menu != 4);


        
        }

        private static void RecommendForScreening()
        {
            Console.WriteLine("---------------------------");

            Console.WriteLine("Patients recommended for screening:");
            foreach (Patient patient in _patientList)
            {
                int count = 0;
                foreach (Symptoms symptom in patient._patientSymptomList)
                {
                    count++;
                }
                
                if (count > 2)
                {
                    Console.WriteLine(patient.Name);
                }
            }
            Console.WriteLine("---------------------------");

        }

        private static void AddPatient()
        {
            Console.WriteLine("---------------------------");

            string input;
            Patient newPatient = new Patient();
            Console.WriteLine("Please enter true/false or 1/0 if the patient has each of the following:");
            foreach (Symptoms symptom in _symptomList)
            {
                Console.Write($"{symptom.SymptomName}-> ");
                input = Console.ReadLine();
                if (input.Contains("true")||input.Contains("1"))
                {
                    newPatient._patientSymptomList.Add(symptom);
                }
            }
            _patientList.Add(newPatient);
            Console.WriteLine("---------------------------");

        }

        private static void AddSymptom()
        {
            Console.WriteLine("---------------------------");

            Symptoms newSymptom = new Symptoms();
            _symptomList.Add(newSymptom);
            Console.WriteLine("---------------------------");

        }
    }
}
