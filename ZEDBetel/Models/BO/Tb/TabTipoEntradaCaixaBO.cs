using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

/// <summary>
/// Classe BO: Business Objects
/// Criador: Marques Silva Fonseca
/// Criada em 11/05/2019
/// Contato: marques-fonseca@hotmail.com
/// </summary>
public class TabTipoEntradaCaixaBO
{

    // Atributos
    private DO objDO = null;
    private StringBuilder strSql = null;

    //Métodos
    /// <summary>
    /// Seleciona todos os registros e retorna um DataSet.
    /// </summary>
    /// <returns>DataSet</returns>
    public DataSet FindAll()
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    //Métodos
    /// <summary>
    /// Seleciona todos os registros e retorna um DataSet.
    /// </summary>
    /// <returns>DataSet</returns>
    public List<TabTipoEntradaCaixaVO> FindAllEmLista()
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            DataSet ds = objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");

            //List<TabTipoEntradaCaixaVO> list = ds.Tables[0].AsEnumerable().ToList<TabTipoEntradaCaixaVO>();

            return new List<TabTipoEntradaCaixaVO>();
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros com ordenação e retorna um DataSet.
    /// </summary>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindAll(string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros com filtro.
    /// </summary>
    /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindByWhere(string _filtro)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros com filtro e ordenação.
    /// </summary>
    /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindByWhere(string _filtro, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros por Codigo.
    /// </summary>
    /// <param name="_Codigo">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Codigo(int _Codigo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros por Codigo.
    /// </summary>
    /// <param name="_Codigo">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Codigo(int _Codigo, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros por CodigoEmpresa.
    /// </summary>
    /// <param name="_CodigoEmpresa">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoEmpresa(int _CodigoEmpresa)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoEmpresa =   " + _CodigoEmpresa + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros por CodigoEmpresa.
    /// </summary>
    /// <param name="_CodigoEmpresa">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoEmpresa(int _CodigoEmpresa, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoEmpresa =   " + _CodigoEmpresa + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros por CodigoUsuarioCadastro.
    /// </summary>
    /// <param name="_CodigoUsuarioCadastro">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoUsuarioCadastro(int _CodigoUsuarioCadastro)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoUsuarioCadastro =   " + _CodigoUsuarioCadastro + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros por CodigoUsuarioCadastro.
    /// </summary>
    /// <param name="_CodigoUsuarioCadastro">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoUsuarioCadastro(int _CodigoUsuarioCadastro, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoUsuarioCadastro =   " + _CodigoUsuarioCadastro + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros por Descricao.
    /// </summary>
    /// <param name="_Descricao">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Descricao(string _Descricao)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE (  Descricao =  '" + _Descricao + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros por Descricao.
    /// </summary>
    /// <param name="_Descricao">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Descricao(string _Descricao, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE (  Descricao =  '" + _Descricao + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros por DataCadastro.
    /// </summary>
    /// <param name="_DataCadastro">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_DataCadastro(DateTime _DataCadastro)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE (  DataCadastro = CONVERT(DATETIME, '" + _DataCadastro + "', 103)  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Seleciona todos os registros por DataCadastro.
    /// </summary>
    /// <param name="_DataCadastro">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_DataCadastro(DateTime _DataCadastro, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Descricao, DataCadastro  ");
            strSql.Append(" FROM  TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE (  DataCadastro = CONVERT(DATETIME, '" + _DataCadastro + "', 103)  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabTipoEntradaCaixa");
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Insere os registros do banco e retorna o número de linhas afetadas.
    /// </summary>
    /// <param name="_vo">objetos vo do banco</param>
    /// <returns>int</returns>
    public int Insert(TabTipoEntradaCaixaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" INSERT INTO  TabTipoEntradaCaixa  ");
            strSql.Append(" (");

            strSql.Append(" CodigoEmpresa, ");
            strSql.Append(" CodigoUsuarioCadastro, ");
            strSql.Append(" Descricao, ");
            strSql.Append(" DataCadastro ");
            strSql.Append(" ) ");
            strSql.Append(" VALUES (");
            strSql.Append(" " + _vo.CodigoEmpresa + " , ");
            strSql.Append(" " + _vo.CodigoUsuarioCadastro + " , ");
            strSql.Append("  '" + _vo.Descricao + "' , ");
            //strSql.Append("  CONVERT(DATETIME, '" + _vo.DataCadastro + "', 103)  )");
            strSql.Append("  CONVERT(DATETIME, GETDATE(), 103)  )");


            objDO = new DO();

            // executa comando e retorna o número de linhas afetadas.
            return objDO.ExecutaQuery(strSql.ToString());
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Atualiza os registros do banco e retorna o número de linhas afetadas.
    /// </summary>
    /// <param name="_vo">objetos vo do banco</param>
    /// <returns>int</returns>
    public int Update(TabTipoEntradaCaixaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" UPDATE  TabTipoEntradaCaixa  ");
            strSql.Append(" SET ");

            //strSql.Append("   CodigoEmpresa =   " + _vo.CodigoEmpresa + " ,  ");
            //strSql.Append("   CodigoUsuarioCadastro =   " + _vo.CodigoUsuarioCadastro + " ,  ");
            strSql.Append("   Descricao =  '" + _vo.Descricao + "'   ");
            //strSql.Append("   DataCadastro = CONVERT(DATETIME, '" + _vo.DataCadastro + "' , 103)   ");

            strSql.Append(" WHERE ( Codigo =   " + _vo.Codigo + "  ) ");

            objDO = new DO();

            // executa comando e retorna o número de linhas afetadas.
            return objDO.ExecutaQuery(strSql.ToString());
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }

    /// <summary>
    /// Deleta os registros do banco e retorna o número de linhas afetadas.
    /// </summary>
    /// <param name="_vo">objetos vo do banco</param>
    /// <returns>int</returns>
    public int Delete(TabTipoEntradaCaixaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" DELETE FROM TabTipoEntradaCaixa  ");
            strSql.Append(" WHERE ( Codigo = " + _vo.Codigo + " ) ");

            objDO = new DO();

            // executa comando e retorna o número de linhas afetadas.
            return objDO.ExecutaQuery(strSql.ToString());
        }
        catch (Exception er)
        {
            throw new Exception("Aconteceu um erro:" + er.Message.ToString());
        }
        finally
        {
            strSql = null;
        }
    }
}

