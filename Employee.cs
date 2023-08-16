using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Premier_Service_Solutions
{
    internal class Employee
    {
        // const string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=PremierServiceSolutions; Integrated Security=true;";
        string connectionString = Global.connectionString;

        SqlConnection cnn;
        SqlDataReader reader;
        SqlCommand cmd;

        private int employeeID;
        private string firstName;
        private string surname;
        private string email;
        private string cellNo;
        private string postion;
        private string department;
        private string field;
        private string username;
        private string password;



        public int EmployeeID { get { return employeeID; } set { employeeID = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string CellNo { get { return cellNo; } set { cellNo = value; } }
        public string Postion { get { return postion; } set { postion = value; } }
        public string Department { get { return department; } set { department = value; } }
        public string Field { get { return field; } set { field = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }

        public Employee(string firstName, string surname, string email, string cellNo, string postion, string department, string field, string username, string password)
        {
            FirstName = firstName;
            Surname = surname;
            Email = email;
            CellNo = cellNo;
            Postion = postion;
            Department = department;
            Field = field;
            Username = username;
            Password = password;
        }

        public Employee(int employeeID, string firstName, string surname, string email, string cellNo, string postion, string department, string field, string username, string password)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            Surname = surname;
            Email = email;
            CellNo = cellNo;
            Postion = postion;
            Department = department;
            Field = field;
            Username = username;
            Password = password;
        }

        public Employee(int employeeID, string firstName, string surname, string email, string cellNo, string postion, string department, string field)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            Surname = surname;
            Email = email;
            CellNo = cellNo;
            Postion = postion;
            Department = department;
            Field = field;
        }

        public Employee() { }


        public bool FindEmployee(int employeeID)
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open();

                cmd = new SqlCommand($@"SELECT * FROM Employee WHERE EmployeeID = {employeeID}", cnn);
                reader = cmd.ExecuteReader();

                reader.Read();

                EmployeeID = employeeID;
                FirstName = reader.GetString(1);
                Surname = reader.GetString(2);
                Email = reader.GetString(3);
                CellNo = reader.GetString(4);
                Postion = reader.GetString(5);
                Department = reader.GetString(6);
                Field = reader.GetString(7);
                Username = reader.GetString(8);
                Password = reader.GetString(9);

                cnn.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
               
            }
        }

        public void InsertEmployee()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            cmd = new SqlCommand($@"INSERT INTO Employee (Firstname, Surname, Email, CellNo, Postion, Department, Field, Username, Password) VALUES ('{FirstName}', '{Surname}', '{Email}', '{CellNo}', '{Postion}', '{Department}', '{Field}', '{Username}', '{Password}') ", cnn);
            cmd.ExecuteNonQuery();

            cnn.Close();
        }
        public void RemoveEmployee(int employeeID)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            cmd = new SqlCommand($"DELETE FROM Employee WHERE EmployeeID = {employeeID}", cnn);
            cmd.ExecuteNonQuery();

            cnn.Close();
        }
        public void UpdateEmployee()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            //cmd = new SqlCommand("UPDATE Employee SET Firstname=@Firstname, Surname=@Surname, Email=@Email, CellNo=@CellNo, Postion=@Postion, Department=@Department, Field=@Field, Username=@Username, Password=@Password WHERE EmployeeID=@EmployeeID", cnn);
            cmd = new SqlCommand("UPDATE Employee SET Firstname=@Firstname, Surname=@Surname, Email=@Email, CellNo=@CellNo, Postion=@Postion, Department=@Department, Field=@Field WHERE EmployeeID=@EmployeeID", cnn);

            cmd.Parameters.AddWithValue("@Firstname", FirstName);
            cmd.Parameters.AddWithValue("@Surname", Surname);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@CellNo", CellNo);
            cmd.Parameters.AddWithValue("@Postion", Postion);
            cmd.Parameters.AddWithValue("@Department", Department);
            cmd.Parameters.AddWithValue("@Field", Field);
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            // cmd.Parameters.AddWithValue("@Username", Username);
            // cmd.Parameters.AddWithValue("@Password", Password);

            cmd.ExecuteNonQuery();


            cnn.Close();
        }
        public void UpdateUserAndPassword()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            cmd = new SqlCommand("UPDATE Employee SET Username=@Username, Password=@Password WHERE EmployeeID=@EmployeeID", cnn);

            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);

            cmd.ExecuteNonQuery();


            cnn.Close();
        }
        public string CheckLogin(string user, string password)
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open();

                cmd = new SqlCommand($@"SELECT * FROM Employee WHERE Username = '{user}' AND Password = '{password}'", cnn);
                reader = cmd.ExecuteReader();

                reader.Read();

                EmployeeID = reader.GetInt32(0);
                FirstName = reader.GetString(1);
                Surname = reader.GetString(2);
                Email = reader.GetString(3);
                CellNo = reader.GetString(4);
                Postion = reader.GetString(5);
                Department = reader.GetString(6);
                Field = reader.GetString(7);
                Username = user;
                Password = password;

                reader.Close();
                cnn.Close();

                return department;
            }
            catch (Exception)
            {
                return "fail";
            }
        }
        public void AssignTicket(int ticketID)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            cmd = new SqlCommand($@"INSERT INTO EmployeeTickets (EmployeeID, TicketID, CurrentlyWorkingOn) VALUES ('{employeeID}', {ticketID}, 1) ", cnn);
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public DataTable GetEmployeeTickets()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlDataAdapter data = new SqlDataAdapter($@"SELECT Ticket.TicketID, Ticket.Description, EmployeeTickets.CurrentlyWorkingOn, Ticket.Status, Ticket.ClientID FROM Ticket INNER JOIN EmployeeTickets ON Ticket.TicketID=EmployeeTickets.TicketID WHERE  EmployeeTickets.EmployeeID = {EmployeeID}", cnn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            cnn.Close();
            return dt;      
        }

    }
}
