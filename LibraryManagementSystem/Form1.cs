using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            List<char> genders = new List<char> { 'M', 'F' };

            List<string> genres = new List<string> { "Science fiction", "Satire", "Drama", "Action and Adventure",
                                                     "Romance", "Mystery", "Horror", "Health", "Guide", "Diaries",
                                                     "Comics", "Diaries", "Journals", "Biographies", "Fantasy",
                                                     "History", "Science", "Art" };
            InitializeComponent();

            PopulateStudentsTable();

            PopulateBooksTable();

            cmbStudentGender.DataSource = genders;

            cmbBooksGenres.DataSource = genres;

        }

        private void rdbStudents_CheckedChanged(object sender, EventArgs e)
        {
            boxStudents.Visible = true;
            boxBooks.Visible = false;
        }

        private void rdbBooks_CheckedChanged(object sender, EventArgs e)
        {
            boxBooks.Visible = true;
            boxStudents.Visible = false;
        }

        private void btnSearchS_Click(object sender, EventArgs e)
        {
            string str = txtSearchS.Text;

            string sqlQuery = string.Format("SELECT * FROM dbo.students " +
                                            "WHERE studentId LIKE '{0}'" +
                                            "OR name LIKE '{0}'" +
                                            "OR lastname LIKE '{0}'" +
                                            "OR birthdate LIKE '{0}'" +
                                            "OR gender LIKE '{0}'", str);

            using (SqlConnection connection = ConnectToDB.ConnectDB())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataAdapter adapt = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapt.Fill(dataSet);

                        dgvStudents.DataSource = dataSet.Tables[0];
                    }
                }
            }
        }

        private void btnSearchB_Click(object sender, EventArgs e)
        {
            string str = txtSearchB.Text;

            string sqlQuery = string.Format("SELECT A.bookId, A.name, B.lastname AS author, C.name AS genre " +
                                            "FROM dbo.books AS A, dbo.authors AS B, dbo.types AS C " +
                                            "WHERE A.authorId = B.authorId " +
                                            "AND A.typeId = C.typeId " +
                                            "AND (A.bookId LIKE '{0}' " +
                                            "OR A.name LIKE '{0}' " +
                                            "OR B.name LIKE '{0}' " +
                                            "OR C.name LIKE '{0}') ", str);

            using (SqlConnection connection = ConnectToDB.ConnectDB())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataAdapter adapt = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapt.Fill(dataSet);

                        dgvBooks.DataSource = dataSet.Tables[0];
                    }
                }
            }
        }

        public void PopulateStudentsTable()
        {
            string sqlQuery = "SELECT * FROM dbo.students ORDER BY studentid ASC";

            using (SqlConnection connection = ConnectToDB.ConnectDB())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataAdapter adapt = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapt.Fill(dataSet);

                        dgvStudents.DataSource = dataSet.Tables[0];
                    }
                }
            }
        }

        public void PopulateBooksTable()
        {
            string sqlQuery = "SELECT A.bookId, A.name, B.lastname AS author, C.name AS genre " +
                               "FROM dbo.books AS A, dbo.authors AS B, dbo.types AS C " +
                               "WHERE A.authorId = B.authorId " +
                               "AND A.typeId = C.typeId " +
                               "ORDER BY A.bookid ASC";

            using (SqlConnection connection = ConnectToDB.ConnectDB())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataAdapter adapt = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapt.Fill(dataSet);

                        dgvBooks.DataSource = dataSet.Tables[0];
                    }
                }
            }
        }

        private void btnClearS_Click(object sender, EventArgs e)
        {
            PopulateStudentsTable();
        }

        private void btnClearB_Click(object sender, EventArgs e)
        {
            PopulateBooksTable();
        }

        private void btnRemoveS_Click(object sender, EventArgs e)
        {
            string id = dgvStudents.CurrentRow.Cells[0].Value.ToString();

            string sqlQuery = string.Format("DELETE FROM dbo.students WHERE studentId = {0}", id);

            using (SqlConnection connection = ConnectToDB.ConnectDB())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            PopulateStudentsTable();

            MessageBox.Show("Successfully removed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveB_Click(object sender, EventArgs e)
        {
            string id = dgvBooks.CurrentRow.Cells[0].Value.ToString();

            string sqlQuery = string.Format("DELETE FROM dbo.books WHERE bookId = {0}", id);

            using (SqlConnection connection = ConnectToDB.ConnectDB())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            PopulateBooksTable();

            MessageBox.Show("Successfully removed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddS_Click(object sender, EventArgs e)
        {
            string sqlQuery = string.Format("INSERT INTO dbo.students (name, lastname, birthdate, gender) " +
                                            "VALUES ('{0}', '{1}', '{2}', '{3}')", txtStudentName.Text,
                                            txtStudentLastname.Text, txtStudentBirthdate.Text, cmbStudentGender.Text);

            string dateFormat = "yyyy-mm-dd";

            DateTime dateTime;

            if (DateTime.TryParseExact(txtStudentBirthdate.Text, dateFormat, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out dateTime)
                && txtStudentName.Text != String.Empty
                && txtStudentLastname.Text != String.Empty)
            {
                using (SqlConnection connection = ConnectToDB.ConnectDB())
                {
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Successfully added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PopulateStudentsTable();
            }
            else if (txtStudentName.Text == String.Empty)
            {
                MessageBox.Show("Enter the name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtStudentLastname.Text == String.Empty)
            {
                MessageBox.Show("Enter the last name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter date in the following fromat: YYYY-MM-DD.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddB_Click(object sender, EventArgs e)
        {
            int typeId = 0;
            int authorId = 0;

            if (txtBookName.Text != String.Empty
                && txtAuthorName.Text != String.Empty
                && txtAuthorLastname.Text != String.Empty)
            {
                string sqlQueryA = string.Format("SELECT typeId " +
                                                 "FROM dbo.types " +
                                                 "WHERE name " +
                                                 "LIKE '{0}'", cmbBooksGenres.Text);

                using (SqlConnection connection = ConnectToDB.ConnectDB())
                {
                    using (SqlCommand command = new SqlCommand(sqlQueryA, connection))
                    {
                        using (SqlDataAdapter adapt = new SqlDataAdapter(command))
                        {
                            DataSet dataSet = new DataSet();
                            adapt.Fill(dataSet);
                            typeId = Int32.Parse(dataSet.Tables[0].Rows[0]["typeId"].ToString());
                        }
                    }
                }

                string sqlQueryB = string.Format("SELECT authorId " +
                                                 "FROM dbo.authors " +
                                                 "WHERE name " +
                                                 "LIKE '{0}' " +
                                                 "AND lastname " +
                                                 "LIKE '{1}'", txtAuthorName.Text, txtAuthorLastname.Text);

                using (SqlConnection connection = ConnectToDB.ConnectDB())
                {
                    using (SqlCommand command = new SqlCommand(sqlQueryB, connection))
                    {
                        using (SqlDataAdapter adapt = new SqlDataAdapter(command))
                        {
                            DataSet dataSet = new DataSet();
                            adapt.Fill(dataSet);
                            try
                            {
                                authorId = Int32.Parse(dataSet.Tables[0].Rows[0]["authorId"].ToString());
                            }
                            catch (IndexOutOfRangeException ex)
                            {
                                authorId = 0;
                            }
                        }
                    }
                }

                if (authorId != 0)
                {
                    string sqlQueryC = string.Format("INSERT INTO dbo.books (name, authorId, typeId) " +
                                                     "VALUES ('{0}', " +
                                                     "(SELECT authorId FROM dbo.authors WHERE authorId = {1}), " +
                                                     "(SELECT typeId FROM dbo.types WHERE typeId = {2}))", txtBookName.Text, authorId, typeId);

                    using (SqlConnection connection = ConnectToDB.ConnectDB())
                    {
                        using (SqlCommand command = new SqlCommand(sqlQueryC, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else if (authorId == 0)
                {
                    string sqlQueryD = string.Format("INSERT INTO dbo.authors (name, lastname) " +
                                                     "VALUES ('{0}', '{1}')", txtAuthorName.Text, txtAuthorLastname.Text);

                    using (SqlConnection connection = ConnectToDB.ConnectDB())
                    {
                        using (SqlCommand command = new SqlCommand(sqlQueryD, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    using (SqlConnection connection = ConnectToDB.ConnectDB())
                    {
                        using (SqlCommand command = new SqlCommand(sqlQueryB, connection))
                        {
                            using (SqlDataAdapter adapt = new SqlDataAdapter(command))
                            {
                                DataSet dataSet = new DataSet();
                                adapt.Fill(dataSet);
                                authorId = Int32.Parse(dataSet.Tables[0].Rows[0]["authorId"].ToString());
                            }
                        }
                    }

                    string sqlQueryC = string.Format("INSERT INTO dbo.books (name, authorId, typeId) " +
                                                     "VALUES ('{0}', " +
                                                     "(SELECT authorId FROM dbo.authors WHERE authorId = {1}), " +
                                                     "(SELECT typeId FROM dbo.types WHERE typeId = {2}))", txtBookName.Text, authorId, typeId);

                    using (SqlConnection connection = ConnectToDB.ConnectDB())
                    {
                        using (SqlCommand command = new SqlCommand(sqlQueryC, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Successfully added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PopulateBooksTable();
            }
            else if (txtBookName.Text == String.Empty)
            {
                MessageBox.Show("Enter the book name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAuthorName.Text == String.Empty)
            {
                MessageBox.Show("Enter the author's name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAuthorLastname.Text == String.Empty)
            {
                MessageBox.Show("Enter the author's last name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
