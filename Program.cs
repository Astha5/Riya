using System;
using System.Collections.Generic;


namespace Lab3
{
    public class Participant
    {
        private int _empId;
        private string _name;
        private string _companyName;
        private int _foundationMarks;
        private int _webBasicsMarks;
        private int _dotnetMarks;

        public int EmpId { get => _empId; set => _empId = value; }
        public string Name { get => _name; set => _name = value; }
        public string CompanyName { get => _companyName; set => _companyName = value; }
        public int FoundationMarks { get => _foundationMarks; set => _foundationMarks = value; }
        public int WebBasicsMarks { get => _webBasicsMarks; set => _webBasicsMarks = value; }
        public int DotnetMarks { get => _dotnetMarks; set => _dotnetMarks = value; }

        public Participant()
        {
            int TotalMarks = 300;
        }
        static Participant()
        {
            string CompanyName = "Corporate University";
        }

        public int ObtMarks()
        {
            int obtMarks = FoundationMarks + WebBasicsMarks + DotnetMarks;
            return obtMarks;

        }
        public int Percentage()
        {
            int per = (( ObtMarks()/ 3));
            return per;
        }
        public Participant(string EmpName, int FoundationMarks, int WebBasicsMarks, int DotnetMarks)
        {
            EmpName = null;
            FoundationMarks = 0;
            WebBasicsMarks = 0;
            DotnetMarks = 0;

        }
        
    }
}

