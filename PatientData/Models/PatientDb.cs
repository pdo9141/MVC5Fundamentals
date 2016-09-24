using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientData.Models
{
    public static class PatientDb
    {
        internal static IEnumerable<Patient> FindAll()
        {
            var results = new List<Patient>();
            results.Add(new Patient
            {
                Id = "1",
                Name = "Alshon Jeffery",
                Ailments = new List<Ailment>
                {
                    new Ailment { Name = "Tight Hamstring" }
                },
                Medications = new List<Medication>
                {
                    new Medication { Name = "Vicodin", Doses = 1 }
                }
            });

            results.Add(new Patient
            {
                Id = "2",
                Name = "Brandon Marshall",
                Ailments = new List<Ailment>
                {
                    new Ailment { Name = "MCL" }
                },
                Medications = new List<Medication>
                {
                    new Medication { Name = "Zohydro", Doses = 2 }
                }
            });

            results.Add(new Patient
            {
                Id = "3",
                Name = "Tyler Lockett",
                Ailments = new List<Ailment>
                {
                    new Ailment { Name = "ACL" }
                },
                Medications = new List<Medication>
                {
                    new Medication { Name = "Ameritox", Doses = 5 }
                }
            });

            return results;
        }
    }
}