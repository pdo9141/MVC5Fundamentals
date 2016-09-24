using System.Collections.Generic;

namespace PatientData.Models
{
    public class Patient
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Ailment> Ailments { get; set; }

        public IEnumerable<Medication> Medications { get; set; }
    }

    public class Medication
    {
        public string Name { get; set; }

        public int Doses { get; set; }
    }

    public class Ailment
    {
        public string Name { get; set; }
    }
}