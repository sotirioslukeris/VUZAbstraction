using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionVUZ
{
    public abstract class Student:IGetAverage
    {
        private string name;
        private string faculty;
        private int facultyNum;
        protected string speciality;
        private string group;
        protected double score;

        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name not entered");
                }
                name = value;   
            }

        }

        public Student(double score,string speciality)
        {
            this.score = score;
            this.speciality = speciality;
            
        }
        public string Faculty
        {
            get { return faculty; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faculty not entered");
                }
                faculty = value;
            }
        }

        public int FacultyNum
        {
            get { return facultyNum; }
            set
            {
                facultyNum = value; 
            }
        }

        

        public string Group
        {
            get { return group; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Group not entered");
                }
                group = value;
            }
        }

        public abstract double GetAverage(List<VUZAverage> students);

        public string Print()
        {
            return $"Student name : {Name}\nSpeciality : {speciality}" +
                $"\nGroup : {Group}\nFaculty : {Faculty} \nFaculty number : {FacultyNum}" +
                $"Score : {score}";
        }


        
    }
}
