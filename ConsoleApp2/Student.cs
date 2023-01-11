using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Student
    {
        string code;
        string name;
        double english;
        double math;
        double chinese;
        double physics;
        double chemistry;
        double biology;
        double sum;
        double avg;

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public double English { get => english; set => english = value; }
        public double Math { get => math; set => math = value; }
        public double Chinese { get => chinese; set => chinese = value; }
        public double Physics { get => physics; set => physics = value; }
        public double Chemistry { get => chemistry; set => chemistry = value; }
        public double Biology { get => biology; set => biology = value; }
        public double Sum
        {
            get
            {
                return sum = english + math + chinese + physics + chemistry + biology;
            }
            set
            {
                sum = value;
            }
        }
        public double Avg
        {
            get
            {
                return avg = sum / 6;
            }
            set
            {
                avg = value;
            }
        }

        public Student() { }
        public Student(string code, string name, double sum, double avg, double english, double math, double chinese, double physics, double chemistry, double biology)
        {
            this.Code = code;
            this.Name = name;
            this.Sum = sum;
            this.Avg = avg;
            this.English = english;
            this.Math = math;
            this.Chinese = chinese;
            this.Physics = physics;
            this.Chemistry = chemistry;
            this.Biology = biology;

        }

    }
}
