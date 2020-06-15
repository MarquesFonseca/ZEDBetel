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
public class TabMembroBO
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  CodigoEmpresa =   " + _CodigoEmpresa + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  CodigoEmpresa =   " + _CodigoEmpresa + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  CodigoUsuarioCadastro =   " + _CodigoUsuarioCadastro + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  CodigoUsuarioCadastro =   " + _CodigoUsuarioCadastro + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  Nome =  '" + _Nome + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  Nome =  '" + _Nome + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por CPF.
    /// </summary>
    /// <param name="_CPF">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CPF(string _CPF)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  CPF =  '" + _CPF + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por CPF.
    /// </summary>
    /// <param name="_CPF">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CPF(string _CPF, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  CPF =  '" + _CPF + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por RG.
    /// </summary>
    /// <param name="_RG">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_RG(string _RG)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  RG =  '" + _RG + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por RG.
    /// </summary>
    /// <param name="_RG">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_RG(string _RG, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  RG =  '" + _RG + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoLogradouro.
    /// </summary>
    /// <param name="_EnderecoLogradouro">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoLogradouro(string _EnderecoLogradouro)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoLogradouro =  '" + _EnderecoLogradouro + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoLogradouro.
    /// </summary>
    /// <param name="_EnderecoLogradouro">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoLogradouro(string _EnderecoLogradouro, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoLogradouro =  '" + _EnderecoLogradouro + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoNumero.
    /// </summary>
    /// <param name="_EnderecoNumero">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoNumero(string _EnderecoNumero)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoNumero =  '" + _EnderecoNumero + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoNumero.
    /// </summary>
    /// <param name="_EnderecoNumero">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoNumero(string _EnderecoNumero, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoNumero =  '" + _EnderecoNumero + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoComplemento.
    /// </summary>
    /// <param name="_EnderecoComplemento">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoComplemento(string _EnderecoComplemento)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoComplemento =  '" + _EnderecoComplemento + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoComplemento.
    /// </summary>
    /// <param name="_EnderecoComplemento">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoComplemento(string _EnderecoComplemento, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoComplemento =  '" + _EnderecoComplemento + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoCEP.
    /// </summary>
    /// <param name="_EnderecoCEP">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoCEP(string _EnderecoCEP)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoCEP =  '" + _EnderecoCEP + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoCEP.
    /// </summary>
    /// <param name="_EnderecoCEP">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoCEP(string _EnderecoCEP, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoCEP =  '" + _EnderecoCEP + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoBairro.
    /// </summary>
    /// <param name="_EnderecoBairro">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoBairro(string _EnderecoBairro)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoBairro =  '" + _EnderecoBairro + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoBairro.
    /// </summary>
    /// <param name="_EnderecoBairro">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoBairro(string _EnderecoBairro, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoBairro =  '" + _EnderecoBairro + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoMunicipio.
    /// </summary>
    /// <param name="_EnderecoMunicipio">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoMunicipio(string _EnderecoMunicipio)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoMunicipio =  '" + _EnderecoMunicipio + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoMunicipio.
    /// </summary>
    /// <param name="_EnderecoMunicipio">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoMunicipio(string _EnderecoMunicipio, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoMunicipio =  '" + _EnderecoMunicipio + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoUF.
    /// </summary>
    /// <param name="_EnderecoUF">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoUF(string _EnderecoUF)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoUF =  '" + _EnderecoUF + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoUF.
    /// </summary>
    /// <param name="_EnderecoUF">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoUF(string _EnderecoUF, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoUF =  '" + _EnderecoUF + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoEletronico.
    /// </summary>
    /// <param name="_EnderecoEletronico">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoEletronico(string _EnderecoEletronico)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoEletronico =  '" + _EnderecoEletronico + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por EnderecoEletronico.
    /// </summary>
    /// <param name="_EnderecoEletronico">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoEletronico(string _EnderecoEletronico, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  EnderecoEletronico =  '" + _EnderecoEletronico + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por Contato.
    /// </summary>
    /// <param name="_Contato">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Contato(string _Contato)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  Contato =  '" + _Contato + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por Contato.
    /// </summary>
    /// <param name="_Contato">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Contato(string _Contato, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  Contato =  '" + _Contato + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por Contato2.
    /// </summary>
    /// <param name="_Contato2">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Contato2(string _Contato2)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  Contato2 =  '" + _Contato2 + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    /// Seleciona todos os registros por Contato2.
    /// </summary>
    /// <param name="_Contato2">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Contato2(string _Contato2, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  Contato2 =  '" + _Contato2 + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  DataCadastro = CONVERT(DATETIME, '" + _DataCadastro + "', 103)  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
            strSql.Append(" Codigo, CodigoEmpresa, CodigoUsuarioCadastro, Nome, CPF, RG, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, Contato, Contato2, DataCadastro  ");
            strSql.Append(" FROM  TabMembro  ");
            strSql.Append(" WHERE (  DataCadastro = CONVERT(DATETIME, '" + _DataCadastro + "', 103)  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabMembro");
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
    public int Insert(TabMembroVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" INSERT INTO  TabMembro  ");
            strSql.Append(" (");

            strSql.Append(" CodigoEmpresa, ");
            strSql.Append(" CodigoUsuarioCadastro, ");
            strSql.Append(" Nome, ");
            strSql.Append(" CPF, ");
            strSql.Append(" RG, ");
            strSql.Append(" EnderecoLogradouro, ");
            strSql.Append(" EnderecoNumero, ");
            strSql.Append(" EnderecoComplemento, ");
            strSql.Append(" EnderecoCEP, ");
            strSql.Append(" EnderecoBairro, ");
            strSql.Append(" EnderecoMunicipio, ");
            strSql.Append(" EnderecoUF, ");
            strSql.Append(" EnderecoEletronico, ");
            strSql.Append(" Contato, ");
            strSql.Append(" Contato2, ");
            strSql.Append(" DataCadastro ");
            strSql.Append(" ) ");
            strSql.Append(" VALUES (");
            strSql.Append(" " + _vo.CodigoEmpresa + " , ");
            strSql.Append(" " + _vo.CodigoUsuarioCadastro + " , ");
            strSql.Append("  '" + _vo.Nome + "' , ");
            strSql.Append("  '" + _vo.CPF + "' , ");
            strSql.Append("  '" + _vo.RG + "' , ");
            strSql.Append("  '" + _vo.EnderecoLogradouro + "' , ");
            strSql.Append("  '" + _vo.EnderecoNumero + "' , ");
            strSql.Append("  '" + _vo.EnderecoComplemento + "' , ");
            strSql.Append("  '" + _vo.EnderecoCEP + "' , ");
            strSql.Append("  '" + _vo.EnderecoBairro + "' , ");
            strSql.Append("  '" + _vo.EnderecoMunicipio + "' , ");
            strSql.Append("  '" + _vo.EnderecoUF + "' , ");
            strSql.Append("  '" + _vo.EnderecoEletronico + "' , ");
            strSql.Append("  '" + _vo.Contato + "' , ");
            strSql.Append("  '" + _vo.Contato2 + "' , ");
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
    public int Update(TabMembroVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" UPDATE  TabMembro  ");
            strSql.Append(" SET ");

            //strSql.Append("   CodigoEmpresa =   " + _vo.CodigoEmpresa + " ,  ");
            //strSql.Append("   CodigoUsuarioCadastro =   " + _vo.CodigoUsuarioCadastro + " ,  ");
            strSql.Append("   Nome =  '" + _vo.Nome + "' ,  ");
            strSql.Append("   CPF =  '" + _vo.CPF + "' ,  ");
            strSql.Append("   RG =  '" + _vo.RG + "' ,  ");
            strSql.Append("   EnderecoLogradouro =  '" + _vo.EnderecoLogradouro + "' ,  ");
            strSql.Append("   EnderecoNumero =  '" + _vo.EnderecoNumero + "' ,  ");
            strSql.Append("   EnderecoComplemento =  '" + _vo.EnderecoComplemento + "' ,  ");
            strSql.Append("   EnderecoCEP =  '" + _vo.EnderecoCEP + "' ,  ");
            strSql.Append("   EnderecoBairro =  '" + _vo.EnderecoBairro + "' ,  ");
            strSql.Append("   EnderecoMunicipio =  '" + _vo.EnderecoMunicipio + "' ,  ");
            strSql.Append("   EnderecoUF =  '" + _vo.EnderecoUF + "' ,  ");
            strSql.Append("   EnderecoEletronico =  '" + _vo.EnderecoEletronico + "' ,  ");
            strSql.Append("   Contato =  '" + _vo.Contato + "' ,  ");
            strSql.Append("   Contato2 =  '" + _vo.Contato2 + "'   ");
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
    public int Delete(TabMembroVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" DELETE FROM TabMembro  ");
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
