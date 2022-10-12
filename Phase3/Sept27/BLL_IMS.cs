using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayerLibrary
{
    public class BLL_IMS
    {
        private int _Courseid;

        public int CourseID
        {
            get { return _Courseid; }
            set
            {
                if (value != 0)
                {
                    _Courseid = value;
                }
                else
                {
                    Console.WriteLine("Invalid Course Id");
                }
            }
        }

        public string COURSENAME { get; set; }

        public int DEPTID { get; set; }

        public int DURATION { get; set; }

    }

    public class BLL_Exam
    {
        private int _examid;

        public int Exam_Id
        {
            get { return _examid; }
            set
            {
                if (value != 0 && value > 4000)
                {
                    _examid = value;
                }
                else
                {
                    Console.WriteLine("Invalid exam id");
                }
            }
        }


        public int crsid { get; set; }

        public int Studid { get; set; }

        public int Marks { get; set; }

    }

    public class BLL_student
    {
        private int _studid;

        public int StudId
        {
            get { return _studid; }
            set
            {
                if (value != 0 && value > 1000)
                {
                    _studid = value;
                }
                else
                {
                    Console.WriteLine("Invalid exam id");
                }
            }
        }


        public string Name { get; set; }
        public int crsid { get; set; }
    }
}
