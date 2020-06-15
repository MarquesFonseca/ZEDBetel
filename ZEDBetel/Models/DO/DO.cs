using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Reflection;

/// <summary>
/// Classe DO: Data Objects
/// Criador: Marques Silva Fonseca
/// Criada em 13/05/2019 18:37
/// Contato: marques-fonseca@hotmail.com
/// </summary>

public class DO
{
    // Atributos
    private SqlConnection oConnection = null;
    private string connectionString = null;
    private SqlDataAdapter oDataAdapter = null;
    private SqlCommand oCommand = null;
    private DataSet oDataSet = null;
    //private string strServidor = null;
    //Construtor
    public DO()
    {
        connectionString = @"Data Source=MARQUES-PC\SQLEXPRESS;Initial Catalog=ZED;Integrated Security=True;";
        oConnection = new SqlConnection(connectionString);
    }
    //Métodos
    /// <summary>
    /// Executa comandos sql e retorna o número de linhas afetadas.
    /// </summary>
    /// <param name="sSQL">Comando sql</param>
    /// <returns>int regAffect</returns>
    /// <returns>int regAffect</returns>
    public int ExecutaQuery(string sSQL)
    {
        int numeroLinhasAfetadas = 0;
        try
        {
            oConnection.Open();
            oCommand = new SqlCommand(sSQL, oConnection);
            numeroLinhasAfetadas = oCommand.ExecuteNonQuery();

            if (numeroLinhasAfetadas == 0)
            {
                throw new Exception("Ocorreu um erro, entre em contato com o administrador do sistema.");
            }
            else
            {
                return numeroLinhasAfetadas;
            }
        }
        catch (Exception err)
        {
            throw err;
        }
        finally
        {
            oConnection.Dispose();
            oCommand.Dispose();
        }
    }

    /// <summary>
    /// Retorna um data set apartir de um comando sql
    /// </summary>
    /// <param name="command">Comando sql</param>
    /// <param name="table">Nome da tabela</param>
    /// <returns>DataSet oDataSet</returns>
    public DataSet GetDataSet(string command, string table)
    {
        try
        {
            oConnection.Open();
            oCommand = new SqlCommand(command, oConnection);
            oDataAdapter = new SqlDataAdapter(oCommand);
            oDataSet = new DataSet();
            oDataAdapter.Fill(oDataSet, table);
            return oDataSet;
        }
        catch (SqlException err)
        {
            throw err;
        }
        finally
        {
            oConnection.Dispose();
            oCommand.Dispose();
            oDataAdapter.Dispose();
        }
    }

    /// <summary>
    /// Executa select no _banco
    /// </summary>
    /// <param name="command"></param>
    /// <returns>DataReader oCommand.ExecuteReader()</returns>
    public SqlDataReader QueryConsulta(string command)
    {
        try
        {
            oConnection.Open();
            oCommand = new SqlCommand(command, oConnection);
            return oCommand.ExecuteReader();
        }
        catch (Exception err)
        {
            throw err;
        }
        finally
        {
            oConnection.Dispose();
            oCommand.Dispose();
        }
    }

    public void CloseConn()
    {
        oConnection.Dispose();
    }

    //public static List<T> ConvertDataTable<T>(DataTable dt)
    //{
    //List<T> data = new List<T>();
    //foreach (DataRow row in dt.Rows)
    //{
    //T item = GetItem<T>(row);
    //data.Add(item);
    //}
    //return data;
    //}

    //private static T GetItem<T>(DataRow dr)
    //{
    //Type temp = typeof(T);
    //T obj = Activator.CreateInstance<T>();

    //foreach (DataColumn column in dr.Table.Columns)
    //{
    //foreach (System.Reflection.PropertyInfo pro in temp.GetProperties())
    //{
    //if (pro.Name == column.ColumnName)
    //pro.SetValue(obj, dr[column.ColumnName], null);
    //else
    //continue;
    //}
    //}
    //return obj;
    //}

}
