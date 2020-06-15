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
/// Criada em 14/05/2019 22:22
/// Contato: marques-fonseca@hotmail.com
/// </summary>

public class VwTabEmpresaBO
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
    /// Seleciona todos os registros por NumeroInscricaoCNPJ.
    /// </summary>
    /// <param name="_NumeroInscricaoCNPJ">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_NumeroInscricaoCNPJ(string _NumeroInscricaoCNPJ)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE (  NumeroInscricaoCNPJ =  '" + _NumeroInscricaoCNPJ + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
    /// Seleciona todos os registros por NumeroInscricaoCNPJ.
    /// </summary>
    /// <param name="_NumeroInscricaoCNPJ">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_NumeroInscricaoCNPJ(string _NumeroInscricaoCNPJ, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE (  NumeroInscricaoCNPJ =  '" + _NumeroInscricaoCNPJ + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE (  NomeEmpresarial =  '" + _NomeEmpresarial + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE (  NomeEmpresarial =  '" + _NomeEmpresarial + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoMunicipio =  '" + _EnderecoMunicipio + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoMunicipio =  '" + _EnderecoMunicipio + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoUF =  '" + _EnderecoUF + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoUF =  '" + _EnderecoUF + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
    /// Seleciona todos os registros por NomeResponsavel.
    /// </summary>
    /// <param name="_NomeResponsavel">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_NomeResponsavel(string _NomeResponsavel)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE (  NomeResponsavel =  '" + _NomeResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
    /// Seleciona todos os registros por NomeResponsavel.
    /// </summary>
    /// <param name="_NomeResponsavel">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_NomeResponsavel(string _NomeResponsavel, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, NomeEmpresarial, EnderecoMunicipio, EnderecoUF, NomeResponsavel  ");
            strSql.Append(" FROM  VwTabEmpresa  ");
            strSql.Append(" WHERE (  NomeResponsavel =  '" + _NomeResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "VwTabEmpresa");
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
    public int Insert(VwTabEmpresaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" INSERT INTO  VwTabEmpresa  ");
            strSql.Append(" (");

            strSql.Append(" NumeroInscricaoCNPJ, ");
            strSql.Append(" NomeEmpresarial, ");
            strSql.Append(" EnderecoMunicipio, ");
            strSql.Append(" EnderecoUF, ");
            strSql.Append(" NomeResponsavel ");
            strSql.Append(" ) ");
            strSql.Append(" VALUES (");
            strSql.Append("  '" + _vo.NumeroInscricaoCNPJ + "' , ");
            strSql.Append("  '" + _vo.NomeEmpresarial + "' , ");
            strSql.Append("  '" + _vo.EnderecoMunicipio + "' , ");
            strSql.Append("  '" + _vo.EnderecoUF + "' , ");
            strSql.Append("  '" + _vo.NomeResponsavel + "'  )");


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
    public int Update(VwTabEmpresaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" UPDATE  VwTabEmpresa  ");
            strSql.Append(" SET ");

            strSql.Append("   NumeroInscricaoCNPJ =  '" + _vo.NumeroInscricaoCNPJ + "' ,  ");
            strSql.Append("   NomeEmpresarial =  '" + _vo.NomeEmpresarial + "' ,  ");
            strSql.Append("   EnderecoMunicipio =  '" + _vo.EnderecoMunicipio + "' ,  ");
            strSql.Append("   EnderecoUF =  '" + _vo.EnderecoUF + "' ,  ");
            strSql.Append("   NomeResponsavel =  '" + _vo.NomeResponsavel + "'   ");

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
    public int Delete(VwTabEmpresaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" DELETE FROM VwTabEmpresa  ");
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
