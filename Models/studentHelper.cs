using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;



namespace CRUDUsingADO.NET.Models
{
    public class studentHelper
    {
        public List<Student> Getstudent()
        {
            List<Student> Students = new List<Student>();
            string connecting = "server=DESKTOP-KVGH71D;database=B22ADO_NET; integrated security=true";
            SqlConnection sc = new SqlConnection(connecting);
            sc.Open();
            SqlCommand cmd = new SqlCommand("select * from student", sc);
           
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {  
                Student sw = new Student();

                sw.Rollnumber = (int)dr["Rollnumber"];
                sw.Name = dr["Name"].ToString();
                sw.Age = (int)dr["Age"];
                sw.Email = dr["Email"].ToString();
                sw.DOB = (DateTime)dr["BOD"];


                Students.Add(sw);
            }
            
          sc.Close();
            return Students;
        }


        public bool InsertStudent(Student student)
        {
            try
            {
                List<Student> Students = new List<Student>();
                string connecting = "server=DESKTOP-KVGH71D;database=B22ADO_NET; integrated security=true";
                SqlConnection sc = new SqlConnection(connecting);
                sc.Open();
                SqlCommand cmd = new SqlCommand("sp_insertstudentData", sc);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@BOD", student.DOB);
                cmd.ExecuteNonQuery();
                sc.Close();
                return true;
            }
            catch(Exception e   )
            {
                return false;   
            }
        }
    }
}
     // hume abhi ye method call karana he to vo hume create button se call karani he to uske liye hum usame student ka object create karake usko 
     // id se join karenge.