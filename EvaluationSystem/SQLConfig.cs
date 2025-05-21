using EvaluationSystem;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System;

public class SQLConfig
{
    private MySqlConnection con = new MySqlConnection("server=localhost;user id=;password=;database=tuts_dbcurriculumn;sslMode=none");
    private MySqlCommand cmd;
    private MySqlDataAdapter da;
    public DataTable dt;
    int result;
    usableFunction funct = new usableFunction();


    public void Execute_CUD(string sql, string msg_false, string msg_true, params MySqlParameter[] parameters)
    {
        try
        {
            con.Open();
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddRange(parameters);
            result = cmd.ExecuteNonQuery();
            MessageBox.Show(result > 0 ? msg_true : msg_false);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }

    public void Execute_Query(string sql, params MySqlParameter[] parameters)
    {
        try
        {
            con.Open();
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }
    public DataTable Load_Data(string sql, params MySqlParameter[] parameters)
    {
        DataTable dataTable = new DataTable();
        try
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddRange(parameters);
            da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataTable = null;
        }
        finally
        {
            da?.Dispose();
            con.Close();
        }
        return dataTable;
    }

    public void Load_DTG(string sql, DataGridView dtg, params MySqlParameter[] parameters)
    {
        try
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddRange(parameters);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dtg.DataSource = dt;
            funct.ResponsiveDtg(dtg);
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            da?.Dispose();
            con.Close();
        }
    }

    public int maxrow(string sql, params MySqlParameter[] parameters)
    {
        int maxrow = 0;
        try
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddRange(parameters);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            maxrow = dt.Rows.Count;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            da?.Dispose();
            con.Close();
        }
        return maxrow;
    }

   public void loadReports(string sql, params MySqlParameter[] parameters)
    {
        try
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddRange(parameters);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading report data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            con.Close();
            da?.Dispose();
        }
    }

    public void autocomplete(string sql, TextBox txt)
    {
        try
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd = new MySqlCommand(sql, con);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            txt.AutoCompleteCustomSource.Clear();
            txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (DataRow r in dt.Rows)
            {
                txt.AutoCompleteCustomSource.Add(r.Field<string>(0));
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            con.Close();
            da?.Dispose();
        }
    }

    public void fiil_CBO(string sql, ComboBox cbo)
    {
        try
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd = new MySqlCommand(sql, con);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.ValueMember = dt.Columns[0].ColumnName;
            cbo.DisplayMember = dt.Columns[1].ColumnName;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            con.Close();
            da?.Dispose();
        }
    }

    public void singleResult(string sql, params MySqlParameter[] parameters)
    {
        try
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddRange(parameters);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            con.Close();
            da?.Dispose();
        }
    }
}