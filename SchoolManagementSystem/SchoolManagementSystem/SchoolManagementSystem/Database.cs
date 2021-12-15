using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SchoolManagementSystem
{
    class Database
    {
        public int[] GetCountPersonal()
        {
            int teacher = 0;
            int student = 0;
            int worker = 0;
            try
            {

                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from teachers";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    teacher++;
                }
                reader.Close();
                cmd.CommandText = "select * from students";
                MySqlDataReader reader2 = cmd.ExecuteReader();
                while (reader2.Read())
                {
                    student++;
                }
                reader2.Close();

                cmd.CommandText = "select * from workers";
                MySqlDataReader reader3 = cmd.ExecuteReader();
                while (reader3.Read())
                {
                    worker++;
                }
                reader3.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Personal Count Error");
            }

            return new int[] { teacher, student, worker };
        }
        public int GetCountPersonal(string classname)
        {
            int student = 0;
            try
            {

                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = String.Format("select * from subjects where classname='{0}'", classname);
                MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        student++;
                    }
                    reader.Close();              

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Personal Count Error");
            }

            return student;
        }
        public bool usedId(string id, string querytype)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;port=3306;uid=root;password=123456789;database=schooldb;");
                con.Open();
                string insertDataQuery = "";
                if (querytype == "student")
                {
                    insertDataQuery = "select * from students";
                }
                else if (querytype == "teacher")
                {
                    insertDataQuery = "select * from teachers";
                }
                string sql = insertDataQuery;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (id == reader.GetString("id"))
                    {
                        return true;
                    }
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("UsedID Error");
            }
            return false;

        }
        public bool hasUser(string id_user, string password, string logintype)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=schooldb;Uid=root;Pwd=123456789;");
                con.Open();
                string insertDataQuery = "";
                if (logintype == "student")
                {
                    insertDataQuery = "select * from students";
                }
                else if (logintype == "teacher")
                {
                    insertDataQuery = "select * from teachers";
                }
                else if (logintype == "admin")
                {
                    insertDataQuery = "select * from admin";
                }
                string sql = insertDataQuery;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (id_user == reader.GetString("id") && password == reader.GetString("password"))
                    {
                        return true;
                    }
                }
                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
        public void createTables()
        {
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = "create database if not exists schooldb";
                cmd1.ExecuteNonQuery();

                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandText = "create table if not exists schooldb.teachers(name varchar(20),surname varchar(30),profession varchar(30),phone varchar(15),id varchar(9),email varchar(50),password varchar(20),birthday varchar(15),gender varchar(7))";
                cmd2.ExecuteNonQuery();

                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandText = "create table if not exists schooldb.students(name varchar(20),surname varchar(30),fathername varchar(20),classname varchar(25),id varchar(9),email varchar(50),password varchar(20),birthday varchar(15),gender varchar(7))";
                cmd3.ExecuteNonQuery();

                MySqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandText = "create table if not exists schooldb.workers(name varchar(20),surname varchar(30),profession varchar(30),phone varchar(15),email varchar(50),birthday varchar(15),gender varchar(7))";
                cmd4.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e) {
                Console.WriteLine("Connection error");
            }

        }
        public void addTeacher(string name, string surname, string profession, string phone, string id, string email, string password, string birthday, string gender)
        {
            try
            {

                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO teachers(name,surname,profession,phone,id,email,password,birthday,gender) VALUES(@name,@surname,@profession,@phone,@id,@email,@password,@birthday,@gender)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@profession", profession);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Add Teacher Error");
            }
        }
        public void addStudent(string name, string surname, string fathername, string classname, string id, string email, string password, string birthday, string gender)
        {
            try
            {

                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO students(name,surname,fathername,classname,id,email,password,birthday,gender) VALUES(@name,@surname,@fathername,@classname,@id,@email,@password,@birthday,@gender)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@fathername", fathername);
                cmd.Parameters.AddWithValue("@classname", classname);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Add Student Error");
            }
        }
        public void addWorker(string name, string surname, string profession, string phone, string email, string birthday, string gender)
        {
            try
            {

                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO workers(name,surname,profession,phone,email,birthday,gender) VALUES(@name,@surname,@profession,@phone,@email,@birthday,@gender)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@profession", profession);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Add Student Error");
            }
        }
        public void createAdmin()
        {
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "create table if not exists admin(id varchar(9),password varchar(20))";
                cmd.ExecuteNonQuery();

                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandText = "select * from admin";
                MySqlDataReader reader = cmd2.ExecuteReader();
                bool ishave = true;
                if (!reader.Read())
                {
                    ishave = false;
                }
                con.Close();

                if (!ishave) {
                    string conString2 = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                    MySqlConnection con2 = new MySqlConnection(conString2);
                    con2.Open();
                    MySqlCommand cmd3 = con2.CreateCommand();
                    cmd3.CommandText = "insert into admin(id,password) values(@id,@password)";
                    cmd3.Parameters.AddWithValue("@id", "ADM123456");
                    cmd3.Parameters.AddWithValue("@password", "123456789");
                    cmd3.ExecuteNonQuery();
                    con2.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Admin");
                Console.WriteLine(e.Message);
            }
        }
        public void createsubjectTable()
        {
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "create table if not exists subjects(class varchar(20),subjects text(100))";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Student Subjects Error");
            }
        }
        public string[] getidData(string id, string searchtype)
        {
            string[] dataarr = new string[5];
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                if (searchtype == "student")
                {
                    cmd.CommandText = String.Format("select * from students where id='{0}'", id);
                }
                if (searchtype == "teacher")
                {
                    cmd.CommandText = String.Format("select * from teachers where id='{0}'", id);
                }
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                { if (searchtype == "teacher")
                    {
                        string name = reader.GetString("name");
                        string surname = reader.GetString("surname");
                        string email = reader.GetString("email");
                        string password = reader.GetString("password");
                        string profession = reader.GetString("profession");
                        dataarr[0] = name;
                        dataarr[1] = surname;
                        dataarr[2] = email;
                        dataarr[3] = password;
                        dataarr[4] = profession;
                    }
                    else if (searchtype == "student")
                    {
                        string name = reader.GetString("name");
                        string surname = reader.GetString("surname");
                        string email = reader.GetString("email");
                        string password = reader.GetString("password");
                        string classname = reader.GetString("classname");
                        dataarr[0] = name;
                        dataarr[1] = surname;
                        dataarr[2] = email;
                        dataarr[3] = password;
                        dataarr[4] = classname;
                    }
                }
                con.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("getidData Error");
            }
            return dataarr;
        }
        public string[] getphoneData(string phone)
        {
            string[] dataarr = new string[5];
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("select * from workers where phone='{0}'", phone);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString("name");
                    string surname = reader.GetString("surname");
                    string email = reader.GetString("email");
                    string phonenumber = reader.GetString("phone");
                    string profession = reader.GetString("profession");
                    dataarr[0] = name;
                    dataarr[1] = surname;
                    dataarr[2] = email;
                    dataarr[3] = phonenumber;
                    dataarr[4] = profession;
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("getphonedata Error");
            }
            return dataarr;
        }
        public void setData(string email, string phoneorpassword, string professionorpasswordorclass, string settype, string idorphone)
        {
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                if (settype == "teacher")
                    cmd.CommandText = String.Format("update teachers set email='{0}',password='{1}',profession='{2}' where id='{3}'", email, phoneorpassword, professionorpasswordorclass, idorphone);
                else if (settype == "student")
                    cmd.CommandText = String.Format("update students set email='{0}',password='{1}',classname='{2}' where id='{3}'", email, phoneorpassword, professionorpasswordorclass, idorphone);
                else if (settype == "worker")
                    cmd.CommandText = String.Format("update workers set email='{0}',phone='{1}',profession='{2}' where phone='{3}'", email, phoneorpassword, professionorpasswordorclass, idorphone);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("SetData Error");
            }
        }
        public string deletePersonal(string deletetype, string id)
        {
            string namesurname = null;
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                if (deletetype == "teacher") {
                    cmd.CommandText = String.Format("select * from teachers where id='{0}'", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        namesurname = reader.GetString("name") + " " + reader.GetString("surname");
                    }
                    con.Close();
                    /*if (candelete)
                    {
                        MySqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandText = String.Format("delete from teachers where id='{0}'", id);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                    }*/
                }
                else if (deletetype == "student")
                {
                    cmd.CommandText = String.Format("select * from students where id='{0}'", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        namesurname = reader.GetString("name") + " " + reader.GetString("surname");
                    }
                    /* if (candelete)
                     {
                         MySqlCommand cmd2 = con.CreateCommand();
                         cmd2.CommandText = String.Format("delete from students where id='{0}'", id);
                         cmd2.ExecuteNonQuery();
                         con.Close();
                     }
                    */
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Delete Data Error");
            }
            return namesurname;
        }
        public void deletePersonal(bool candelete, string id, string deletetype)
        {
            string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            if (deletetype == "teacher")
            {
                if (candelete)
                {
                    MySqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandText = String.Format("delete from teachers where id='{0}'", id);
                    cmd2.ExecuteNonQuery();
                }
                con.Close();

            }
            else if (deletetype == "student")
            {
                if (candelete)
                {
                    MySqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandText = String.Format("delete from students where id='{0}'", id);
                    cmd2.ExecuteNonQuery();
                }
                con.Close();

            }
        }
        public bool changePass(string oldpass, string newpass)
        {
            bool truepass = false;
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("select * from admin where id='{0}'", "ADM123456");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (oldpass == reader.GetString("password"))
                    {
                        truepass = true;
                    }
                }
                con.Close();
                if (truepass)
                {
                    MySqlConnection con2 = new MySqlConnection(conString);
                    con2.Open();
                    MySqlCommand cmd2 = con2.CreateCommand();
                    cmd2.CommandText = String.Format("Update admin set password='{0}'", newpass);
                    cmd2.ExecuteNonQuery();
                    con2.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Change password Error");
            }
            return truepass;
        }
        public void addSubject(string classname, string subjects)
        {
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "create table if not exists subjects(classname varchar(20),subjects varchar(100))";
                cmd.ExecuteNonQuery();
                cmd.CommandText = String.Format("insert into subjects(classname,subjects) values('{0}','{1}')", classname, subjects);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Add Subject Error");
            }
        }
        public bool checkeismptyclass(string classname)
        {
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("select * from subjects where classname='{0}'", classname);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString("subjects").Length > 1)
                    {
                        return false;
                    }
                }

                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Add Subject Error");
            }
            return true;
        }
        public void createResult(string classname,string[] subjectarray)
        {

            string[] students = getClassStudents(classname);
            string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
            string newclassname = null;
            try
            {

                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                newclassname = classname;
                if(subjectarray.Length == 4)
                {
                    cmd.CommandText = String.Format("create table if not exists {0}({1} varchar(40),{2} varchar(20),{3} varchar(20),{4} varchar(20),{5} varchar(20),{6} varchar(20))", newclassname,"NameSurname","ID", subjectarray[0], subjectarray[1], subjectarray[2], subjectarray[3]);
                }
                else if (subjectarray.Length == 5)
                {
                    cmd.CommandText = String.Format("create table if not exists {0}({1} varchar(40),{2} varchar(20),{3} varchar(20),{4} varchar(20),{5} varchar(20),{6} varchar(20),{7} varchar(20))", newclassname, "NameSurname", "ID", subjectarray[0], subjectarray[1], subjectarray[2], subjectarray[3], subjectarray[4]);
                }
                else if (subjectarray.Length == 6)
                {
                    cmd.CommandText = String.Format("create table if not exists {0}({1} varchar(40),{2} varchar(20),{3} varchar(20),{4} varchar(20),{5} varchar(20),{6} varchar(20),{7} varchar(20),{8} varchar(20))", newclassname, "NameSurname", "ID", subjectarray[0], subjectarray[1], subjectarray[2], subjectarray[3], subjectarray[4], subjectarray[5]);
                }
                else if (subjectarray.Length == 7)
                {
                    cmd.CommandText = String.Format("create table if not exists {0}({1} varchar(40),{2} varchar(20),{3} varchar(20),{4} varchar(20),{5} varchar(20),{6} varchar(20),{7} varchar(20),{8} varchar(20),{9} varchar(20))", newclassname, "NameSurname", "ID", subjectarray[0], subjectarray[1], subjectarray[2], subjectarray[3], subjectarray[4], subjectarray[5], subjectarray[6]);
                }
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Creating result table Error");
            }
            //Student points
            try
            {
                if (students != null)
                {
                    MySqlConnection connection = new MySqlConnection(conString);
                    connection.Open();
                    

                    for (int i = 0; i < students.Length; i++)
                    {
                        MySqlCommand command = connection.CreateCommand();
                        if (subjectarray.Length == 4)
                        {
                            command.CommandText = String.Format("insert into {0}({1},{2},{3},{4},{5},{6}) VALUES('{7}','{8}','{9}','{10}','{11}','{12}')", newclassname, "NameSurname", "ID", subjectarray[0], subjectarray[1], subjectarray[2], subjectarray[3], students[i].Split(' ')[0] + " " + students[i].Split(' ')[1], students[i].Split(' ')[2], "0", "0", "0", "0");
                        }
                        else if (subjectarray.Length == 5)
                        {
                            command.CommandText = String.Format("insert into {0}({1},{2},{3},{4},{5},{6},{7}) VALUES('{8}','{9}','{10}','{11}','{12}','{13}','{14}')", newclassname, "NameSurname", "ID", subjectarray[0], subjectarray[1], subjectarray[2], subjectarray[3], subjectarray[4], students[i].Split(' ')[0] + " " + students[i].Split(' ')[1], students[i].Split(' ')[2], "0", "0", "0", "0", "0");
                        }
                        else if (subjectarray.Length == 6)
                        {
                            command.CommandText = String.Format("insert into {0}({1},{2},{3},{4},{5},{6},{7},{8})  VALUES('{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}')", newclassname, "NameSurname", "ID", subjectarray[0], subjectarray[1], subjectarray[2], subjectarray[3], subjectarray[4], subjectarray[5], students[i].Split(' ')[0] + " " + students[i].Split(' ')[1], students[i].Split(' ')[2], "0", "0", "0", "0", "0", "0");

                        }
                        else if (subjectarray.Length == 7)
                        {
                            command.CommandText = String.Format("insert into {0}({1},{2},{3},{4},{5},{6},{7},{8},{9})  VALUES('{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}')", newclassname, "NameSurname", "ID", subjectarray[0], subjectarray[1], subjectarray[2], subjectarray[3], subjectarray[4], subjectarray[5], subjectarray[6], students[i].Split(' ')[0] + " " + students[i].Split(' ')[1], students[i].Split(' ')[2], "0", "0", "0", "0", "0", "0", "0");
                        }

                        command.ExecuteNonQuery();
                    }
                    
                    connection.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Insert point resulttable Error");
            }
                /*
                MySqlDataReader reader1 = command.ExecuteReader();
                    string[] subjarr = subjects.Split(' ');
                    for (int i = 0; i <= subjarr.Length - 1; i++)
                    {
                        if (!reader1.Read())
                        {
                            MySqlConnection con3 = new MySqlConnection(conString);
                            MySqlCommand cmd3 = con3.CreateCommand();
                            con3.Open();
                            cmd3.CommandText = String.Format("INSERT INTO {0}(subjects,point,missinglimit) VALUES(@subjects,@point,@missinglimit)", newclassname + "_notes");
                            cmd3.Parameters.AddWithValue("@subjects", subjarr[i]);
                            cmd3.Parameters.AddWithValue("@point", "0");
                            cmd3.Parameters.AddWithValue("@missinglimit", (3*i+1));
                            cmd3.ExecuteNonQuery();
                            con3.Close();
                        }

                    }
                connection.Close();

                */
           

        }
        public string getClass(string classname)
        {
            string subjects = null;
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("select * from subjects where classname='{0}'", classname);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    subjects = reader.GetString("subjects");
                }                            
                con.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("getClass Error");
            }
            return subjects;
        }
        public bool setavargepoint(string point,string subject,string classname,string studentid)
        {
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("update {0} set {1}='{2}' where ID ='{3}'",classname,subject,point,studentid);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
                Console.WriteLine("Set avarage point Error");
            }
            return false;
        }    
        public string[] getClassStudents(string classname)
        {
            int countstudents = GetCountPersonal(classname);
            string[] students = new string[countstudents];
            try
            {
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("select * from students where classname='{0}'", classname);
                MySqlDataReader reader = cmd.ExecuteReader();
                for(int i = 0; reader.Read();i++)
                {
                    students[i] = reader.GetString("name") + " " + reader.GetString("surname") +" " + reader.GetString("id");
                }
                con.Close();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("getclassstudents Error");
            }
            return students;

        }
      
    }
}
