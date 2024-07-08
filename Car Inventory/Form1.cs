using System.Data.SqlClient;

namespace Car_Inventory
{
    public partial class Form1 : Form
    {
        string _sqlConnectionString = "Data Source=GAMER;Database=Carinventory;User Id=sa;Password=Develops";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlConnection = new SqlConnection(_sqlConnectionString))
            {
                string SqlQuery = $"insert into cars (brand,model,colour) values ('{txtbrand.Text}', '{txtmodel.Text}', '{txtcolour.Text}')";
                try
                {
                    SqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(SqlQuery, SqlConnection))
                    {
                        int row = sqlCommand.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Car Saved Succesfully", "Saved!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                    populatetextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Occured: {ex.Message}", "Error in Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtbrand.Text = string.Empty;
                    txtcolour.Text = string.Empty;
                    txtmodel.Text = string.Empty;

                }
            }
        }

        private void populatetextbox()
        {
            txtresult.Text = string.Empty;
            using (SqlConnection sqlConnection = new SqlConnection(_sqlConnectionString))
            {
                string SqlQuery = "select brand, colour, model from cars";
                try
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(SqlQuery, sqlConnection))
                    {
                        using (var reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txtresult.Text += "-----------------------" + Environment.NewLine;
                                txtresult.Text += $"Brand: {reader["brand"].ToString()}" + Environment.NewLine;
                                txtresult.Text += $"Colour: {reader["colour"].ToString()}" + Environment.NewLine;
                                txtresult.Text += $"Model: {reader["model"].ToString()}" + Environment.NewLine;
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Occured: {ex.Message}", "Error in Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populatetextbox();
        }
    }
}
