using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Student :  IComparable<Student>,IGetAverage
    {
        private string name;
        private string faculty;
        private int facNum;
        protected string speciality;
        private string group;
        protected double[] score;

        public Student(string name, string faculty, int facNum, string speciality, string group, double[] scores)
        {
            this.Name = name;
            this.Faculty = faculty;
            this.FacNum = facNum;
            this.speciality = speciality;
            this.Group = group;
            this.Score = scores;
        }

        public Student(string speciality, double[]score)
        {
            this.speciality= speciality;
            this.score = score;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name not specified");
                }
                name = value;
            }
        }

        public string Faculty
        {
            get { return faculty; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Faculty not specified");
                }
                faculty = value;
            }
        }

        public string Speciality
        {
            get { return speciality; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Speciality not specified");
                }
                speciality = value;
            }
        }

        public int FacNum
        {
            get { return facNum; }
            set
            {
                facNum = value;
            }
        }

        public double[] Score
        {
            get { return score; }
            set
            {
                if (value.Length != 5)
                {
                    throw new ArgumentOutOfRangeException("Score on disciplines not specified");
                }
                score = value;  
            }
        }

        public string Group
        {
            get { return group; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ArgumentNullException");
                }
                group = value;
            }
        }

        public abstract string Print();
        

        public abstract string GetAverage(List<Student> students, double enterScore);
        


        public virtual int CompareTo(Student other)
        {
            return speciality.CompareTo(other.speciality);
        }
    }
}
