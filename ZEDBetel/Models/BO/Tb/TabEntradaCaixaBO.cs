using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Classe BO: Business Objects
/// Criador: Marques Silva Fonseca
/// Criada em 11/05/2019
/// Contato: marques-fonseca@hotmail.com
/// </summary>
public class TabEntradaCaixaBO
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoEmpresa =   " + _CodigoEmpresa + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoEmpresa =   " + _CodigoEmpresa + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoUsuarioCadastro =   " + _CodigoUsuarioCadastro + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoUsuarioCadastro =   " + _CodigoUsuarioCadastro + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
    /// Seleciona todos os registros por CodigoTipoEntradaCaixa.
    /// </summary>
    /// <param name="_CodigoTipoEntradaCaixa">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoTipoEntradaCaixa(int _CodigoTipoEntradaCaixa)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoTipoEntradaCaixa =   " + _CodigoTipoEntradaCaixa + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
    /// Seleciona todos os registros por CodigoTipoEntradaCaixa.
    /// </summary>
    /// <param name="_CodigoTipoEntradaCaixa">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoTipoEntradaCaixa(int _CodigoTipoEntradaCaixa, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoTipoEntradaCaixa =   " + _CodigoTipoEntradaCaixa + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
    /// Seleciona todos os registros por CodigoMembro.
    /// </summary>
    /// <param name="_CodigoMembro">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoMembro(int _CodigoMembro)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoMembro =   " + _CodigoMembro + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
    /// Seleciona todos os registros por CodigoMembro.
    /// </summary>
    /// <param name="_CodigoMembro">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoMembro(int _CodigoMembro, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoMembro =   " + _CodigoMembro + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
    /// Seleciona todos os registros por CodigoEventoReferencia.
    /// </summary>
    /// <param name="_CodigoEventoReferencia">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoEventoReferencia(int _CodigoEventoReferencia)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoEventoReferencia =   " + _CodigoEventoReferencia + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
    /// Seleciona todos os registros por CodigoEventoReferencia.
    /// </summary>
    /// <param name="_CodigoEventoReferencia">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoEventoReferencia(int _CodigoEventoReferencia, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoEventoReferencia =   " + _CodigoEventoReferencia + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
    /// Seleciona todos os registros por ValorEntrada.
    /// </summary>
    /// <param name="_ValorEntrada">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_ValorEntrada(Decimal _ValorEntrada)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  ValorEntrada =   " + _ValorEntrada + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
    /// Seleciona todos os registros por ValorEntrada.
    /// </summary>
    /// <param name="_ValorEntrada">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_ValorEntrada(Decimal _ValorEntrada, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  ValorEntrada =   " + _ValorEntrada + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  Descricao =  '" + _Descricao + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  Descricao =  '" + _Descricao + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
    /// Seleciona todos os registros por DataEntrada.
    /// </summary>
    /// <param name="_DataEntrada">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_DataEntrada(DateTime _DataEntrada)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  DataEntrada = CONVERT(DATETIME, '" + _DataEntrada + "', 103)  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
    /// Seleciona todos os registros por DataEntrada.
    /// </summary>
    /// <param name="_DataEntrada">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_DataEntrada(DateTime _DataEntrada, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  DataEntrada = CONVERT(DATETIME, '" + _DataEntrada + "', 103)  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  DataCadastro = CONVERT(DATETIME, '" + _DataCadastro + "', 103)  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, CodigoTipoEntradaCaixa, CodigoMembro, CodigoEventoReferencia, ValorEntrada, Descricao, DataEntrada, DataCadastro  ");
            strSql.Append(" FROM  TabEntradaCaixa  ");
            strSql.Append(" WHERE (  DataCadastro = CONVERT(DATETIME, '" + _DataCadastro + "', 103)  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEntradaCaixa");
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
    public int Insert(TabEntradaCaixaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" INSERT INTO  TabEntradaCaixa  ");
            strSql.Append(" (");

            strSql.Append(" CodigoEmpresa, ");
            strSql.Append(" CodigoUsuarioCadastro, ");
            strSql.Append(" CodigoTipoEntradaCaixa, ");
            strSql.Append(" CodigoMembro, ");
            strSql.Append(" CodigoEventoReferencia, ");
            strSql.Append(" ValorEntrada, ");
            strSql.Append(" Descricao, ");
            strSql.Append(" DataEntrada, ");
            strSql.Append(" DataCadastro ");
            strSql.Append(" ) ");
            strSql.Append(" VALUES (");
            strSql.Append(" " + _vo.CodigoEmpresa + " , ");
            strSql.Append(" " + _vo.CodigoUsuarioCadastro + " , ");
            strSql.Append(" " + _vo.CodigoTipoEntradaCaixa + " , ");
            strSql.Append(" " + _vo.CodigoMembro + " , ");
            strSql.Append(" " + _vo.CodigoEventoReferencia + " , ");
            strSql.Append(" " + _vo.ValorEntrada + " , ");
            strSql.Append("  '" + _vo.Descricao + "' , ");
            strSql.Append("  CONVERT(DATETIME, '" + _vo.DataEntrada + "', 103) , ");
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
    public int Update(TabEntradaCaixaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" UPDATE  TabEntradaCaixa  ");
            strSql.Append(" SET ");

            //strSql.Append("   CodigoEmpresa =   " + _vo.CodigoEmpresa + " ,  ");
            //strSql.Append("   CodigoUsuarioCadastro =   " + _vo.CodigoUsuarioCadastro + " ,  ");
            strSql.Append("   CodigoTipoEntradaCaixa =   " + _vo.CodigoTipoEntradaCaixa + " ,  ");
            strSql.Append("   CodigoMembro =   " + _vo.CodigoMembro + " ,  ");
            strSql.Append("   CodigoEventoReferencia =   " + _vo.CodigoEventoReferencia + " ,  ");
            strSql.Append("   ValorEntrada =   " + _vo.ValorEntrada + " ,  ");
            strSql.Append("   Descricao =  '" + _vo.Descricao + "' ,  ");
            strSql.Append("   DataEntrada = CONVERT(DATETIME, '" + _vo.DataEntrada + "' , 103)   ");
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
    public int Delete(TabEntradaCaixaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" DELETE FROM TabEntradaCaixa  ");
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