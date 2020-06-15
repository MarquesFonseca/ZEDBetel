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
/// Criada em 15/05/2019 0:50
/// Contato: marques-fonseca@hotmail.com
/// </summary>

public class VwTabMembroBO
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  Nome =  '" + _Nome + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  Nome =  '" + _Nome + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  CPF =  '" + _CPF + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  CPF =  '" + _CPF + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  RG =  '" + _RG + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  RG =  '" + _RG + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  EnderecoMunicipio =  '" + _EnderecoMunicipio + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  EnderecoMunicipio =  '" + _EnderecoMunicipio + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  EnderecoUF =  '" + _EnderecoUF + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  EnderecoUF =  '" + _EnderecoUF + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  CodigoEmpresa =   " + _CodigoEmpresa + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  CodigoEmpresa =   " + _CodigoEmpresa + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  NomeEmpresarial =  '" + _NomeEmpresarial + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
            strSql.Append(" Codigo, Nome, CPF, RG, EnderecoMunicipio, EnderecoUF, CodigoEmpresa, NomeEmpresarial  ");
            strSql.Append(" FROM  VwTabMembro  ");
            strSql.Append(" WHERE (  NomeEmpresarial =  '" + _NomeEmpresarial + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabMembro");
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
    public int Insert(VwTabMembroVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" INSERT INTO  VwTabMembro  ");
            strSql.Append(" (");

            strSql.Append(" Nome, ");
            strSql.Append(" CPF, ");
            strSql.Append(" RG, ");
            strSql.Append(" EnderecoMunicipio, ");
            strSql.Append(" EnderecoUF, ");
            strSql.Append(" CodigoEmpresa, ");
            strSql.Append(" NomeEmpresarial ");
            strSql.Append(" ) ");
            strSql.Append(" VALUES (");
            strSql.Append("  '" + _vo.Nome + "' , ");
            strSql.Append("  '" + _vo.CPF + "' , ");
            strSql.Append("  '" + _vo.RG + "' , ");
            strSql.Append("  '" + _vo.EnderecoMunicipio + "' , ");
            strSql.Append("  '" + _vo.EnderecoUF + "' , ");
            strSql.Append(" " + _vo.CodigoEmpresa + " , ");
            strSql.Append("  '" + _vo.NomeEmpresarial + "'  )");


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
    public int Update(VwTabMembroVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" UPDATE  VwTabMembro  ");
            strSql.Append(" SET ");

            strSql.Append("   Nome =  '" + _vo.Nome + "' ,  ");
            strSql.Append("   CPF =  '" + _vo.CPF + "' ,  ");
            strSql.Append("   RG =  '" + _vo.RG + "' ,  ");
            strSql.Append("   EnderecoMunicipio =  '" + _vo.EnderecoMunicipio + "' ,  ");
            strSql.Append("   EnderecoUF =  '" + _vo.EnderecoUF + "' ,  ");
            strSql.Append("   CodigoEmpresa =   " + _vo.CodigoEmpresa + " ,  ");
            strSql.Append("   NomeEmpresarial =  '" + _vo.NomeEmpresarial + "'   ");

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
    public int Delete(VwTabMembroVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" DELETE FROM VwTabMembro  ");
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
