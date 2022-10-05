using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BusinessLogicLayerLibrary;

namespace DataAccessLibrary
{
    public class DAL_IMS
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public DAL_IMS()
        {
            ds = new DataSet();//in memory cache called DataSet
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSCString"].ConnectionString);
        }

        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from course", cn);

            //da takes the data from the database using a select query and will disconnect
            //from the database server once it fills/pushes the data to the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "course");//disconnect from our database server
                                  //Single dataset object can hold multiple tables inside it
                                  //To identify each table uniquely we can use a index or name.
                                  //index starts with 0, but better to work with name.
            DataTable dt_coursedata = ds.Tables["course"];
            return dt_coursedata;
        }

        public int RowCount()
        {
            DataTable dt_coursedata = Connect();
            int coursecnt = dt_coursedata.Rows.Count;
            return coursecnt;



        }


        public bool Update(int Courseid, BLL_IMS course)
        {
            DataTable dt_coursedata = Connect();
            DataRow drow = ds.Tables["course"].Rows.Find(Courseid);


            drow["COURSEID"] = course.CourseID;
            drow["COURSENAME"] = course.COURSENAME;
            drow["DEPTID"] = course.DEPTID;
            drow["DURATION"] = course.DURATION;

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["course"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;



        }
        public BLL_IMS Find(int courseid)
        {
            DataTable dt_coursedata = Connect();
            DataRow drow = ds.Tables["course"].Rows.Find(courseid);
            BLL_IMS course = new BLL_IMS();
            course.CourseID = Convert.ToInt32(drow["COURSEID"]);
            course.COURSENAME = drow["COURSENAME"].ToString();
            course.DEPTID = Convert.ToInt32(drow["DEPTID"]);
            course.DURATION = Convert.ToInt32(drow["DURATION"]);
            return course;

        }


        public List<BLL_IMS> ShowAll()
        {
            DataTable dt_coursedata = Connect();
            List<BLL_IMS> courselist = new List<BLL_IMS>();
            for (int i = 0; i < dt_coursedata.Rows.Count; i++)
            {
                DataRow drow = dt_coursedata.Rows[i];
                BLL_IMS course = new BLL_IMS();
                course.CourseID = Convert.ToInt32(drow["COURSEID"]);
                course.COURSENAME = drow["COURSENAME"].ToString();
                course.DEPTID = Convert.ToInt32(drow["DEPTID"]);
                course.DURATION = Convert.ToInt32(drow["DURATION"]);
                courselist.Add(course);
            }
            return courselist;


        }


        public bool Delete(int courseid)
        {

            DataTable dt_coursedata = Connect();
            DataRow drow = ds.Tables["course"].Rows.Find(courseid);
            drow.Delete();

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["course"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;


        }


        public bool Insert(BLL_IMS course)
        {
            DataTable dt_coursedata = Connect();

            DataRow drow = ds.Tables["course"].NewRow();//creates new row in the datatable
            drow["COURSEID"] = course.CourseID;
            drow["COURSENAME"] = course.COURSENAME;
            drow["DEPTID"] = course.DEPTID;
            drow["DURATION"] = course.DURATION;

            ds.Tables["course"].Rows.Add(drow);// disconnected mode- in the dataset

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["course"]);//record added to the (original) database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;

        }
    }
}
