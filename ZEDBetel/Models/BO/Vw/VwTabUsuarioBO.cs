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
/// Criada em 14/05/2019 0:14
/// Contato: marques-fonseca@hotmail.com
/// </summary>

public class VwTabUsuarioBO
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
    /// Seleciona todos os registros por Nome.
    /// </summary>
    /// <param name="_Nome">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Nome(string _Nome)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  Nome =  '" + _Nome + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
    /// Seleciona todos os registros por Nome.
    /// </summary>
    /// <param name="_Nome">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Nome(string _Nome, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  Nome =  '" + _Nome + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
    /// Seleciona todos os registros por Login.
    /// </summary>
    /// <param name="_Login">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Login(string _Login)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  Login =  '" + _Login + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
    /// Seleciona todos os registros por Login.
    /// </summary>
    /// <param name="_Login">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Login(string _Login, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  Login =  '" + _Login + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
    /// Seleciona todos os registros por Senha.
    /// </summary>
    /// <param name="_Senha">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Senha(string _Senha)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  Senha =  '" + _Senha + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
    /// Seleciona todos os registros por Senha.
    /// </summary>
    /// <param name="_Senha">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Senha(string _Senha, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  Senha =  '" + _Senha + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  CodigoEmpresa =   " + _CodigoEmpresa + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  CodigoEmpresa =   " + _CodigoEmpresa + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
    /// Seleciona todos os registros por NomeFantasia.
    /// </summary>
    /// <param name="_NomeFantasia">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_NomeFantasia(string _NomeFantasia)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  NomeFantasia =  '" + _NomeFantasia + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
    /// Seleciona todos os registros por NomeFantasia.
    /// </summary>
    /// <param name="_NomeFantasia">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_NomeFantasia(string _NomeFantasia, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  NomeFantasia =  '" + _NomeFantasia + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  NomeEmpresarial =  '" + _NomeEmpresarial + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  NomeEmpresarial =  '" + _NomeEmpresarial + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  CodigoUsuarioCadastro =   " + _CodigoUsuarioCadastro + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  CodigoUsuarioCadastro =   " + _CodigoUsuarioCadastro + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  NomeUsuarioCadastro =  '" + _NomeUsuarioCadastro + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  NomeUsuarioCadastro =  '" + _NomeUsuarioCadastro + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  DataCadastro = CONVERT(DATETIME, '" + _DataCadastro + "', 103)  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
            strSql.Append(" Codigo, Nome, Login, Senha, CodigoEmpresa, NomeFantasia, NomeEmpresarial, CodigoUsuarioCadastro, NomeUsuarioCadastro, DataCadastro  ");
            strSql.Append(" FROM  VwTabUsuario  ");
            strSql.Append(" WHERE (  DataCadastro = CONVERT(DATETIME, '" + _DataCadastro + "', 103)  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabUsuario");
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
    public int Insert(VwTabUsuarioVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" INSERT INTO  VwTabUsuario  ");
            strSql.Append(" (");

            strSql.Append(" Nome, ");
            strSql.Append(" Login, ");
            strSql.Append(" Senha, ");
            strSql.Append(" CodigoEmpresa, ");
            strSql.Append(" NomeFantasia, ");
            strSql.Append(" NomeEmpresarial, ");
            strSql.Append(" CodigoUsuarioCadastro, ");
            strSql.Append(" NomeUsuarioCadastro, ");
            strSql.Append(" DataCadastro ");
            strSql.Append(" ) ");
            strSql.Append(" VALUES (");
            strSql.Append("  '" + _vo.Nome + "' , ");
            strSql.Append("  '" + _vo.Login + "' , ");
            strSql.Append("  '" + _vo.Senha + "' , ");
            strSql.Append(" " + _vo.CodigoEmpresa + " , ");
            strSql.Append("  '" + _vo.NomeFantasia + "' , ");
            strSql.Append("  '" + _vo.NomeEmpresarial + "' , ");
            strSql.Append(" " + _vo.CodigoUsuarioCadastro + " , ");
            strSql.Append("  '" + _vo.NomeUsuarioCadastro + "' , ");
            strSql.Append("  CONVERT(DATETIME, '" + _vo.DataCadastro + "', 103)  )");


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
    public int Update(VwTabUsuarioVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" UPDATE  VwTabUsuario  ");
            strSql.Append(" SET ");

            strSql.Append("   Nome =  '" + _vo.Nome + "' ,  ");
            strSql.Append("   Login =  '" + _vo.Login + "' ,  ");
            strSql.Append("   Senha =  '" + _vo.Senha + "' ,  ");
            strSql.Append("   CodigoEmpresa =   " + _vo.CodigoEmpresa + " ,  ");
            strSql.Append("   NomeFantasia =  '" + _vo.NomeFantasia + "' ,  ");
            strSql.Append("   NomeEmpresarial =  '" + _vo.NomeEmpresarial + "' ,  ");
            strSql.Append("   CodigoUsuarioCadastro =   " + _vo.CodigoUsuarioCadastro + " ,  ");
            strSql.Append("   NomeUsuarioCadastro =  '" + _vo.NomeUsuarioCadastro + "' ,  ");
            strSql.Append("   DataCadastro = CONVERT(DATETIME, '" + _vo.DataCadastro + "' , 103)   ");

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
    public int Delete(VwTabUsuarioVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" DELETE FROM VwTabUsuario  ");
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
