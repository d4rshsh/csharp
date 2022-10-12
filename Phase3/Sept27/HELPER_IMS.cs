using BusinessLogicLayerLibrary;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class HELPER_IMS
    {
        DAL_IMS dal = null;
        public HELPER_IMS()
        {
            dal = new DAL_IMS();
        }


        public int RowCount()
        {
            return dal.RowCount();

        }
        public bool AddNew(BLL_IMS COURSE)
        {
            return dal.Insert(COURSE);
        }
        public BLL_IMS Locate(BLL_IMS course)
        {

            return dal.Find(course.CourseID);
        }

        public List<BLL_IMS> EmployeeList()
        {
            return dal.ShowAll();
        }

        public bool Remove(BLL_IMS Course)
        {
            return dal.Delete(Course.CourseID);
        }



        public bool Edit(BLL_IMS Course)
        {
            return dal.Update(Course.CourseID, Course);
        }
    }
}
