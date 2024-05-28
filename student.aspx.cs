using CRUDUsingADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDUsingADO.NET
{
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadStudent();
        }
        private void loadStudent()
        {
            studentHelper db = new studentHelper();
            List<Student> students = db.Getstudent();

            gvstudent.DataSource = students;
            gvstudent.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //this is create button 
            // this method will get called when we cleick on create button
            Student student = new Student()
            {
                Name = TextBox1.Text,
                Age = int.Parse(TextBox2.Text),
               Email = TextBox3.Text,
                DOB = DateTime.Parse(TextBox4.Text)
            };
            studentHelper db= new studentHelper();
            bool status=db.InsertStudent(student);

            if (status)
            {
                loadStudent(); // isase ye load hoga or naya vala student bhi dikhayega.
                clearField(); // isase jab hum data create karate he tab hum usko create hone ke bad clear karane ke liye.
                lblmessage.Text = "student created succefully";
            }
            else
            {
                lblmessage.Text = "student created failed";

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // this is clear button
            // this method will get called when we click on clear button
            // so here we want that data which we pass in text box that data will store in our datatbase 
            // so for that hume yek method create karana hoga ki jisme vo data store hojaye.
            // so hum page behind code me yek method create karate he or usko insert ke detail dete he.
            clearField();

        }
        private void clearField()
        {
            TextBox1.Text=string.Empty;
            TextBox2.Text=string.Empty;
            TextBox3.Text=string.Empty;
            TextBox4.Text=string.Empty;
            lblmessage.Text=string.Empty;
        }
    }
}