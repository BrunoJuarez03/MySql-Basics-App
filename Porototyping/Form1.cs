using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Porototyping
{
    


    public partial class Form1 : Form
    {
        public string usuario;
        public string contraseña;
        public string server;
        public string database;

        public Form1()
        {
            InitializeComponent();
            QueryBox.Enabled = false;
            BtnEjecutar.Enabled = false;

            TitleLabel.Text = "";
            Plabel.Text = "";
            CommandLabel1.Text = "";
            CommandLabel2.Text = "";
            CommandLabel3.Text = "";
            SintaxisLabel.Text = "";
            
        }

        public Form1(bool Conexion, string user, string pass, string host, string db)
        {
            InitializeComponent();
            if (Conexion == true) 
            {
                QueryBox.Enabled = true;
                BtnEjecutar.Enabled=true;
                BtnDb.Enabled = false;

                TitleLabel.Text = "";
                Plabel.Text = "";
                CommandLabel1.Text = "";
                CommandLabel2.Text = "";
                CommandLabel3.Text = "";
                SintaxisLabel.Text = "";
                

                usuario = user;
                contraseña = pass;
                server = host;
                database = db;

            }
            else
            {
                QueryBox.Enabled = false;
                BtnEjecutar.Enabled = false;
            }
        }


        public void EjecutarQuery(string query) 
        {
            string connectionString = "server="+server+";database="+database+";user id="+usuario+";password="+contraseña+";";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(":D");
                conn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        public void CargarDgv(string query)
        {
            DataTable dt = new DataTable();
            string connectionString = "server=" + server + ";database=" + database + ";user id=" + usuario + ";password=" + contraseña + ";";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                DgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvTable.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnDb_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void DropDownbox_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            string query = QueryBox.Text;
            string SelectStr = QueryBox.Text;

            if (SelectStr.Length >= 6)
            {
                if (SelectStr.Substring(0, 6) == "SELECT" || SelectStr.Substring(0, 6) == "Select" || SelectStr.Substring(0, 6) == "select")
                {
                    CargarDgv(query);
                }
                else if (SelectStr.Substring(0, 6) != "SELECT" || SelectStr.Substring(0, 6) != "Select" || SelectStr.Substring(0, 6) != "select")
                {
                    EjecutarQuery(query);
                }
            }
            
        }

        private void DropDownbox_TextChanged(object sender, EventArgs e)
        {
            if (DropDownbox.Text == "MYSQL")
            {
                TitleLabel.Text = "MySql";
                Plabel.Text = " MySQL is a widely used relational database management system (RDBMS) and SQL is the standard language for dealing with Relational Databases.\r\n SQL is used to insert, search, update, and delete database records.";
                CommandLabel1.Text = "";
                CommandLabel2.Text = "";
                CommandLabel3.Text = "";
                SintaxisLabel.Text = "";
                
            }
            if (DropDownbox.Text == "CREATE DB")
            {
                TitleLabel.Text = "CREATE DB";
                Plabel.Text = " The CREATE DATABASE statement is used to create a new SQL database.";
                CommandLabel1.Text = "CREATE DATABASE db_name;";
                CommandLabel2.Text = "DROP DATABASE db_name; //ELIMINATES THE DATABASE";
                CommandLabel3.Text = "";

            }
            if (DropDownbox.Text == "CREATE TABLE")
            {
                TitleLabel.Text = "CREATE TABLE";
                Plabel.Text = "The CREATE TABLE statement is used to create a new Table in the database.";
                CommandLabel1.Text = "CREATE TABLE table_name (column1 datatype, column2 datatype ...);";
                CommandLabel2.Text = "PRIMARY KEY (id) / FOREIGN KEY (id_other_table) ";
                CommandLabel3.Text = "id int auto_increment  //AUTO INCREMENTAL ID";
            }
            if (DropDownbox.Text == "SELECT")
            {
                TitleLabel.Text = "SELECT";
                Plabel.Text = "The SELECT statement is used to select data from a database. The data returned is stored in a result table, called the result-set.";
                CommandLabel1.Text = "SELECT * FROM table_name;";
                CommandLabel2.Text = "SELECT column1, column2, ...FROM table_name;";
                CommandLabel3.Text = "";
            }

            if (DropDownbox.Text == "WHERE")
            {
                TitleLabel.Text = "WHERE";
                Plabel.Text = "The WHERE clause is used to filter records by adding a condition to an statement.";
                CommandLabel1.Text = "SELECT column1 FROM table_name WHERE idcolumn = 1;";
                CommandLabel2.Text = "DELETE FROM table_name WHERE name_column = 'Hugo';";
                CommandLabel3.Text = "";
            }

            if (DropDownbox.Text == "Nested SELECT")
            {
                TitleLabel.Text = "Nested SELECT";
                Plabel.Text = "A Nested SELECT consist of SELECT statement nested into another statement.";
                CommandLabel1.Text = "SELECT * FROM table1 WHERE id = (SELECT sum(column1) FROM table2);";
                CommandLabel2.Text = "";
                CommandLabel3.Text = "";
            }

            if (DropDownbox.Text == "AND/OR/ NOT")
            {
                TitleLabel.Text = "OPERATORS (some of them)";
                Plabel.Text = " The AND operator displays a record if all the conditions are TRUE.\r\n The OR operator displays a record if any of the conditions are TRUE.\r\n The NOT operator is used in combination with other operators to give the opposite result, also called the negative result.";
                CommandLabel1.Text = "SELECT * FROM table1 WHERE column1 = 'Spain' AND column2 LIKE 'G%';";
                CommandLabel2.Text = "SELECT * FROM table1 WHERE column1 = 'Germany' OR column1 = 'Spain';";
                CommandLabel3.Text = "SELECT * FROM table1 WHERE NOT column = 'Spain';";  
            }
            if (DropDownbox.Text == "ORDERBY")
            {
                TitleLabel.Text = "ORDER BY";
                Plabel.Text = "The ORDER BY keyword is used to sort the result-set in ascending or descending order.";
                CommandLabel1.Text = "SELECT * FROM table_name ORDER BY price_column;";
                CommandLabel2.Text = "";
                CommandLabel3.Text = "";
            }
            if (DropDownbox.Text == "INSERT INTO")
            {
                TitleLabel.Text = "INSERT INTO";
                Plabel.Text = "The INSERT INTO statement is used to insert new records in a table.";
                CommandLabel1.Text = "INSERT INTO table_name (column1, column2, column3, ...)\r\nVALUES (value1, value2, value3, ...);";
                CommandLabel2.Text = "";
                CommandLabel3.Text = "";
            }
            if (DropDownbox.Text == "UPDATE")
            {
                TitleLabel.Text = "UPDATE";
                Plabel.Text = "The UPDATE statement is used to modify the existing records in a table.";
                CommandLabel1.Text = "UPDATE table_name\r\nSET column1 = value1, column2 = value2, ...\r\nWHERE condition;";
                CommandLabel2.Text = "";
                CommandLabel3.Text = "INSERT INTO table_name VALUES (value1, value2, value3, ...);";
            }
            if (DropDownbox.Text == "MIN/MAX")
            {
                TitleLabel.Text = "MIN / MAX";
                Plabel.Text = "The MIN() function returns the smallest value of the selected column.\r\n\r\nThe MAX() function returns the largest value of the selected column.";
                CommandLabel1.Text = "SELECT MIN(Price) FROM Products;";
                CommandLabel2.Text = "SELECT MAX(Price) FROM Products;";
                CommandLabel3.Text = "";
            }
            if (DropDownbox.Text == "COUNT/AVG/SUM")
            {
                TitleLabel.Text = "COUNT/AVG/SUM";
                Plabel.Text = "The COUNT() function returns the number of rows that matches a specified criterion. \r\n The SUM() function returns the total sum of a numeric column. \r\n The AVG() function returns the average value of a numeric column.";
                CommandLabel1.Text = "SELECT COUNT(*) FROM table_name;";
                CommandLabel2.Text = "SELECT SUM(column1) FROM table_name;";
                CommandLabel3.Text = "SELECT AVG(column1) FROM table_name;";
            }
            if (DropDownbox.Text == "LIKE")
            {
                TitleLabel.Text = "LIKE";
                Plabel.Text = "The LIKE operator is used in a WHERE clause to search for a specified pattern in a column.\r\n\r\nThere are two wildcards often used in conjunction with the LIKE operator:\r\n\r\n The percent sign % represents zero, one, or multiple characters\r\n The underscore sign _ represents one, single character";
                CommandLabel1.Text = "SELECT * FROM table_name WHERE column1 LIKE pattern;";
                CommandLabel2.Text = "SELECT * FROM table_name WHERE column1 LIKE  'a%'; //example";
                CommandLabel3.Text = "";
            }
            if (DropDownbox.Text == "BETWEEN")
            {
                TitleLabel.Text = "BETWEEN";
                Plabel.Text = "The BETWEEN operator selects values within a given range. The values can be numbers, text, or dates.";
                CommandLabel1.Text = "SELECT column_name\r\nFROM table_name\r\nWHERE column_name BETWEEN value1 AND value2;";
                CommandLabel2.Text = "";
                CommandLabel3.Text = "";
            }
            if (DropDownbox.Text == "JOIN(S)")
            {
                TitleLabel.Text = "JOIN(S)";
                Plabel.Text = "(INNER) JOIN: Returns records that have matching values in both tables\r\nLEFT (OUTER) JOIN: Returns all records from the left table, and the matched records from the right table\r\nRIGHT (OUTER) JOIN: Returns all records from the right table, and the matched records from the left table\r\nFULL (OUTER) JOIN: Returns all records when there is a match in either left or right table.\r\n The most used JOIN is the INNER JOIN.";
                CommandLabel1.Text = "SELECT column_name(s)\r\nFROM table1\r\nINNER JOIN table2\r\nON table1.column_name = table2.column_name;";
                CommandLabel2.Text = "";
                CommandLabel3.Text = "";

            }

            if (DropDownbox.Text == "Data Types")
            {
                TitleLabel.Text = "Data Types";
                Plabel.Text = "MySQL -> C#\r\n char(x) = string\r\ndatetime = DateTime\r\nvarchar(x) = string\r\nsmallint = short\r\nsmallint unsigned = ushort\r\nint = int\r\nint unsigned = uint\r\nbigint = long\r\ntinyint = sbyte\r\ntinyint unsigned = byte\r\nbigint unsigned = ulong\r\ntext = string";
                CommandLabel1.Text = "";
                CommandLabel2.Text = "";
                CommandLabel3.Text = "";

            }

            if (DropDownbox.Text == "Relations")
            {
                TitleLabel.Text = "Relations";
                Plabel.Text = "There are five types of relations in the databases: one-to-one, one-to-many, many-to-one, many-to-many, and self-referencing relationships.\r\n https://blog.devart.com/types-of-relationships-in-sql-server-database.html";
                CommandLabel1.Text = "";
                CommandLabel2.Text = "";
                CommandLabel3.Text = "";

            }

            if (DropDownbox.Text == "")
            {
                TitleLabel.Text = "";
                Plabel.Text = "";
                CommandLabel1.Text = "";
                CommandLabel2.Text = "";
                CommandLabel3.Text = "";
                SintaxisLabel.Text = "";
                
            }
            if(DropDownbox.Text != "" && DropDownbox.Text != "MYSQL")
            {
                SintaxisLabel.Text = "Syntax: ";
                BoxLabel.Text = "Query Box: ";
            }

        }

        private void QueryBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
