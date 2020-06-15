using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//namespace BO
//{

/// <summary>
/// Classe BO: Business Objects
/// Criador: Marques Silva Fonseca
/// Criada em 15/05/2019 2:10
/// Contato: marques-fonseca@hotmail.com
/// </summary>

public class VwTabEntradaCaixaBO
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  Descricao =  '" + _Descricao + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  Descricao =  '" + _Descricao + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  ValorEntrada =   " + _ValorEntrada + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  ValorEntrada =   " + _ValorEntrada + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  DataEntrada = CONVERT(DATETIME, '" + _DataEntrada + "', 103)  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  DataEntrada = CONVERT(DATETIME, '" + _DataEntrada + "', 103)  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  DataCadastro = CONVERT(DATETIME, '" + _DataCadastro + "', 103)  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  DataCadastro = CONVERT(DATETIME, '" + _DataCadastro + "', 103)  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoEventoReferencia =   " + _CodigoEventoReferencia + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoEventoReferencia =   " + _CodigoEventoReferencia + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por EventoReferencia.
    /// </summary>
    /// <param name="_EventoReferencia">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EventoReferencia(string _EventoReferencia)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  EventoReferencia =  '" + _EventoReferencia + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por EventoReferencia.
    /// </summary>
    /// <param name="_EventoReferencia">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EventoReferencia(string _EventoReferencia, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  EventoReferencia =  '" + _EventoReferencia + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoMembro =   " + _CodigoMembro + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoMembro =   " + _CodigoMembro + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por NomeMembro.
    /// </summary>
    /// <param name="_NomeMembro">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_NomeMembro(string _NomeMembro)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  NomeMembro =  '" + _NomeMembro + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por NomeMembro.
    /// </summary>
    /// <param name="_NomeMembro">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_NomeMembro(string _NomeMembro, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  NomeMembro =  '" + _NomeMembro + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por EnderecoMunicipioMembro.
    /// </summary>
    /// <param name="_EnderecoMunicipioMembro">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoMunicipioMembro(string _EnderecoMunicipioMembro)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  EnderecoMunicipioMembro =  '" + _EnderecoMunicipioMembro + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por EnderecoMunicipioMembro.
    /// </summary>
    /// <param name="_EnderecoMunicipioMembro">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoMunicipioMembro(string _EnderecoMunicipioMembro, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  EnderecoMunicipioMembro =  '" + _EnderecoMunicipioMembro + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por EnderecoUFMembro.
    /// </summary>
    /// <param name="_EnderecoUFMembro">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoUFMembro(string _EnderecoUFMembro)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  EnderecoUFMembro =  '" + _EnderecoUFMembro + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por EnderecoUFMembro.
    /// </summary>
    /// <param name="_EnderecoUFMembro">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoUFMembro(string _EnderecoUFMembro, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  EnderecoUFMembro =  '" + _EnderecoUFMembro + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoTipoEntradaCaixa =   " + _CodigoTipoEntradaCaixa + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoTipoEntradaCaixa =   " + _CodigoTipoEntradaCaixa + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por TipoEntradaCaixa.
    /// </summary>
    /// <param name="_TipoEntradaCaixa">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_TipoEntradaCaixa(string _TipoEntradaCaixa)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  TipoEntradaCaixa =  '" + _TipoEntradaCaixa + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por TipoEntradaCaixa.
    /// </summary>
    /// <param name="_TipoEntradaCaixa">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_TipoEntradaCaixa(string _TipoEntradaCaixa, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  TipoEntradaCaixa =  '" + _TipoEntradaCaixa + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoUsuarioCadastro =   " + _CodigoUsuarioCadastro + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoUsuarioCadastro =   " + _CodigoUsuarioCadastro + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por NomeUsuarioCadastro.
    /// </summary>
    /// <param name="_NomeUsuarioCadastro">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_NomeUsuarioCadastro(string _NomeUsuarioCadastro)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  NomeUsuarioCadastro =  '" + _NomeUsuarioCadastro + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por NomeUsuarioCadastro.
    /// </summary>
    /// <param name="_NomeUsuarioCadastro">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_NomeUsuarioCadastro(string _NomeUsuarioCadastro, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  NomeUsuarioCadastro =  '" + _NomeUsuarioCadastro + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoEmpresa =   " + _CodigoEmpresa + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  CodigoEmpresa =   " + _CodigoEmpresa + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por NomeEmpresarial.
    /// </summary>
    /// <param name="_NomeEmpresarial">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_NomeEmpresarial(string _NomeEmpresarial)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  NomeEmpresarial =  '" + _NomeEmpresarial + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por NomeEmpresarial.
    /// </summary>
    /// <param name="_NomeEmpresarial">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_NomeEmpresarial(string _NomeEmpresarial, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  NomeEmpresarial =  '" + _NomeEmpresarial + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por EnderecoMunicipioEmpresa.
    /// </summary>
    /// <param name="_EnderecoMunicipioEmpresa">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoMunicipioEmpresa(string _EnderecoMunicipioEmpresa)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  EnderecoMunicipioEmpresa =  '" + _EnderecoMunicipioEmpresa + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por EnderecoMunicipioEmpresa.
    /// </summary>
    /// <param name="_EnderecoMunicipioEmpresa">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoMunicipioEmpresa(string _EnderecoMunicipioEmpresa, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  EnderecoMunicipioEmpresa =  '" + _EnderecoMunicipioEmpresa + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por EnderecoUFEmpresa.
    /// </summary>
    /// <param name="_EnderecoUFEmpresa">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoUFEmpresa(string _EnderecoUFEmpresa)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  EnderecoUFEmpresa =  '" + _EnderecoUFEmpresa + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    /// Seleciona todos os registros por EnderecoUFEmpresa.
    /// </summary>
    /// <param name="_EnderecoUFEmpresa">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoUFEmpresa(string _EnderecoUFEmpresa, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Descricao, ValorEntrada, DataEntrada, DataCadastro, CodigoEventoReferencia, EventoReferencia, CodigoMembro, NomeMembro, EnderecoMunicipioMembro, EnderecoUFMembro, CodigoTipoEntradaCaixa, TipoEntradaCaixa, CodigoUsuarioCadastro, NomeUsuarioCadastro, CodigoEmpresa, NomeEmpresarial, EnderecoMunicipioEmpresa, EnderecoUFEmpresa  ");
            strSql.Append(" FROM  VwTabEntradaCaixa  ");
            strSql.Append(" WHERE (  EnderecoUFEmpresa =  '" + _EnderecoUFEmpresa + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEntradaCaixa");
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
    public int Insert(VwTabEntradaCaixaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" INSERT INTO  VwTabEntradaCaixa  ");
            strSql.Append(" (");

            strSql.Append(" Descricao, ");
            strSql.Append(" ValorEntrada, ");
            strSql.Append(" DataEntrada, ");
            strSql.Append(" DataCadastro, ");
            strSql.Append(" CodigoEventoReferencia, ");
            strSql.Append(" EventoReferencia, ");
            strSql.Append(" CodigoMembro, ");
            strSql.Append(" NomeMembro, ");
            strSql.Append(" EnderecoMunicipioMembro, ");
            strSql.Append(" EnderecoUFMembro, ");
            strSql.Append(" CodigoTipoEntradaCaixa, ");
            strSql.Append(" TipoEntradaCaixa, ");
            strSql.Append(" CodigoUsuarioCadastro, ");
            strSql.Append(" NomeUsuarioCadastro, ");
            strSql.Append(" CodigoEmpresa, ");
            strSql.Append(" NomeEmpresarial, ");
            strSql.Append(" EnderecoMunicipioEmpresa, ");
            strSql.Append(" EnderecoUFEmpresa ");
            strSql.Append(" ) ");
            strSql.Append(" VALUES (");
            strSql.Append("  '" + _vo.Descricao + "' , ");
            strSql.Append(" " + _vo.ValorEntrada + " , ");
            strSql.Append("  CONVERT(DATETIME, '" + _vo.DataEntrada + "', 103) , ");
            strSql.Append("  CONVERT(DATETIME, '" + _vo.DataCadastro + "', 103) , ");
            strSql.Append(" " + _vo.CodigoEventoReferencia + " , ");
            strSql.Append("  '" + _vo.EventoReferencia + "' , ");
            strSql.Append(" " + _vo.CodigoMembro + " , ");
            strSql.Append("  '" + _vo.NomeMembro + "' , ");
            strSql.Append("  '" + _vo.EnderecoMunicipioMembro + "' , ");
            strSql.Append("  '" + _vo.EnderecoUFMembro + "' , ");
            strSql.Append(" " + _vo.CodigoTipoEntradaCaixa + " , ");
            strSql.Append("  '" + _vo.TipoEntradaCaixa + "' , ");
            strSql.Append(" " + _vo.CodigoUsuarioCadastro + " , ");
            strSql.Append("  '" + _vo.NomeUsuarioCadastro + "' , ");
            strSql.Append(" " + _vo.CodigoEmpresa + " , ");
            strSql.Append("  '" + _vo.NomeEmpresarial + "' , ");
            strSql.Append("  '" + _vo.EnderecoMunicipioEmpresa + "' , ");
            strSql.Append("  '" + _vo.EnderecoUFEmpresa + "'  )");


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
    public int Update(VwTabEntradaCaixaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" UPDATE  VwTabEntradaCaixa  ");
            strSql.Append(" SET ");

            strSql.Append("   Descricao =  '" + _vo.Descricao + "' ,  ");
            strSql.Append("   ValorEntrada =   " + _vo.ValorEntrada + " ,  ");
            strSql.Append("   DataEntrada = CONVERT(DATETIME, '" + _vo.DataEntrada + "' , 103) ,  ");
            strSql.Append("   DataCadastro = CONVERT(DATETIME, '" + _vo.DataCadastro + "' , 103) ,  ");
            strSql.Append("   CodigoEventoReferencia =   " + _vo.CodigoEventoReferencia + " ,  ");
            strSql.Append("   EventoReferencia =  '" + _vo.EventoReferencia + "' ,  ");
            strSql.Append("   CodigoMembro =   " + _vo.CodigoMembro + " ,  ");
            strSql.Append("   NomeMembro =  '" + _vo.NomeMembro + "' ,  ");
            strSql.Append("   EnderecoMunicipioMembro =  '" + _vo.EnderecoMunicipioMembro + "' ,  ");
            strSql.Append("   EnderecoUFMembro =  '" + _vo.EnderecoUFMembro + "' ,  ");
            strSql.Append("   CodigoTipoEntradaCaixa =   " + _vo.CodigoTipoEntradaCaixa + " ,  ");
            strSql.Append("   TipoEntradaCaixa =  '" + _vo.TipoEntradaCaixa + "' ,  ");
            strSql.Append("   CodigoUsuarioCadastro =   " + _vo.CodigoUsuarioCadastro + " ,  ");
            strSql.Append("   NomeUsuarioCadastro =  '" + _vo.NomeUsuarioCadastro + "' ,  ");
            strSql.Append("   CodigoEmpresa =   " + _vo.CodigoEmpresa + " ,  ");
            strSql.Append("   NomeEmpresarial =  '" + _vo.NomeEmpresarial + "' ,  ");
            strSql.Append("   EnderecoMunicipioEmpresa =  '" + _vo.EnderecoMunicipioEmpresa + "' ,  ");
            strSql.Append("   EnderecoUFEmpresa =  '" + _vo.EnderecoUFEmpresa + "'   ");

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
    public int Delete(VwTabEntradaCaixaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" DELETE FROM VwTabEntradaCaixa  ");
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

//}
