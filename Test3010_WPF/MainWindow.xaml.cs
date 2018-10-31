using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test3010_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection con;
        private string SelectedTable = string.Empty;
        private List<string> QueryColumns = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            
            con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conStud"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select group_name, COUNT(stud_name) count_ from groups Join Studs on groups.group_id = Studs.group_id group by group_name order by count_";
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {          
                Label label = new Label();
                Label label1 = new Label();
                label.MouseDown += Label_MouseDown;
                label.Content = rd[0].ToString();
                label1.Content = rd[1].ToString();

                spGroups.Children.Add(label);
                spCount.Children.Add(label1);
            }
            rd.Close();
            con.Dispose();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            tableRow.Items.Clear();
               con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conStud"].ConnectionString;
            con.Open();

            Label label = (Label)sender;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (label.Content.ToString()== "group1")
            {
                cmd.CommandText = "Select stud_id,stud_name from Studs Join groups on groups.group_id = Studs.group_id where group_name = 'group1'";
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    ListBoxItem itm = new ListBoxItem();                    
                    itm.Content = rd[0].ToString() + " - " + rd[1].ToString(); 
                    tableRow.Items.Add(itm);
                }
                rd.Close();              
            }
            else if (label.Content.ToString() == "group2")
            {
                cmd.CommandText = "Select stud_id,stud_name from Studs Join groups on groups.group_id = Studs.group_id where group_name = 'group2'";
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = rd[0].ToString() + " - " + rd[1].ToString(); ;

                    tableRow.Items.Add(itm);
                }
                rd.Close();              
            }
            else if (label.Content.ToString() == "group3")
            {
                cmd.CommandText = "Select stud_id,stud_name from Studs Join groups on groups.group_id = Studs.group_id where group_name = 'group3'";
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = rd[0].ToString() + " - " + rd[1].ToString(); 

                    tableRow.Items.Add(itm);
                }
                rd.Close();              
            }
            else if (label.Content.ToString() == "group4")
            {
                cmd.CommandText = "Select stud_id,stud_name from Studs Join groups on groups.group_id = Studs.group_id where group_name = 'group4'";
                SqlDataReader rd = cmd.ExecuteReader();
               
                while (rd.Read())
                {
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = rd[0].ToString() + " - " + rd[1].ToString(); 

                    tableRow.Items.Add(itm);
                }
                rd.Close();              
            }           
            con.Dispose();           
        }
    }
} 

