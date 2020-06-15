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
public class TabEmpresaBO
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE ( " + _filtro + " ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  NumeroInscricaoCNPJ =  '" + _NumeroInscricaoCNPJ + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  NumeroInscricaoCNPJ =  '" + _NumeroInscricaoCNPJ + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por TipoInscricao.
    /// </summary>
    /// <param name="_TipoInscricao">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_TipoInscricao(string _TipoInscricao)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  TipoInscricao =  '" + _TipoInscricao + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por TipoInscricao.
    /// </summary>
    /// <param name="_TipoInscricao">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_TipoInscricao(string _TipoInscricao, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  TipoInscricao =  '" + _TipoInscricao + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por DataAbertura.
    /// </summary>
    /// <param name="_DataAbertura">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_DataAbertura(DateTime _DataAbertura)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  DataAbertura = CONVERT(DATETIME, '" + _DataAbertura + "', 103)  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por DataAbertura.
    /// </summary>
    /// <param name="_DataAbertura">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_DataAbertura(DateTime _DataAbertura, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  DataAbertura = CONVERT(DATETIME, '" + _DataAbertura + "', 103)  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  NomeEmpresarial =  '" + _NomeEmpresarial + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  NomeEmpresarial =  '" + _NomeEmpresarial + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  NomeFantasia =  '" + _NomeFantasia + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  NomeFantasia =  '" + _NomeFantasia + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por Porte.
    /// </summary>
    /// <param name="_Porte">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Porte(string _Porte)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  Porte =  '" + _Porte + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por Porte.
    /// </summary>
    /// <param name="_Porte">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_Porte(string _Porte, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  Porte =  '" + _Porte + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por CodigoEDescricaoDaAtividadeEconomicaPrincial.
    /// </summary>
    /// <param name="_CodigoEDescricaoDaAtividadeEconomicaPrincial">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoEDescricaoDaAtividadeEconomicaPrincial(string _CodigoEDescricaoDaAtividadeEconomicaPrincial)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  CodigoEDescricaoDaAtividadeEconomicaPrincial =  '" + _CodigoEDescricaoDaAtividadeEconomicaPrincial + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por CodigoEDescricaoDaAtividadeEconomicaPrincial.
    /// </summary>
    /// <param name="_CodigoEDescricaoDaAtividadeEconomicaPrincial">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoEDescricaoDaAtividadeEconomicaPrincial(string _CodigoEDescricaoDaAtividadeEconomicaPrincial, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  CodigoEDescricaoDaAtividadeEconomicaPrincial =  '" + _CodigoEDescricaoDaAtividadeEconomicaPrincial + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por CodigoEDescricaoDaAtividadeSecundaria.
    /// </summary>
    /// <param name="_CodigoEDescricaoDaAtividadeSecundaria">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoEDescricaoDaAtividadeSecundaria(string _CodigoEDescricaoDaAtividadeSecundaria)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  CodigoEDescricaoDaAtividadeSecundaria =  '" + _CodigoEDescricaoDaAtividadeSecundaria + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por CodigoEDescricaoDaAtividadeSecundaria.
    /// </summary>
    /// <param name="_CodigoEDescricaoDaAtividadeSecundaria">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoEDescricaoDaAtividadeSecundaria(string _CodigoEDescricaoDaAtividadeSecundaria, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  CodigoEDescricaoDaAtividadeSecundaria =  '" + _CodigoEDescricaoDaAtividadeSecundaria + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por CodigoEDescricaoNaturezaJuridica.
    /// </summary>
    /// <param name="_CodigoEDescricaoNaturezaJuridica">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoEDescricaoNaturezaJuridica(string _CodigoEDescricaoNaturezaJuridica)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  CodigoEDescricaoNaturezaJuridica =  '" + _CodigoEDescricaoNaturezaJuridica + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por CodigoEDescricaoNaturezaJuridica.
    /// </summary>
    /// <param name="_CodigoEDescricaoNaturezaJuridica">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CodigoEDescricaoNaturezaJuridica(string _CodigoEDescricaoNaturezaJuridica, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  CodigoEDescricaoNaturezaJuridica =  '" + _CodigoEDescricaoNaturezaJuridica + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoLogradouro =  '" + _EnderecoLogradouro + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoLogradouro =  '" + _EnderecoLogradouro + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoNumero =  '" + _EnderecoNumero + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoNumero =  '" + _EnderecoNumero + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoComplemento =  '" + _EnderecoComplemento + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoComplemento =  '" + _EnderecoComplemento + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoCEP =  '" + _EnderecoCEP + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoCEP =  '" + _EnderecoCEP + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoBairro =  '" + _EnderecoBairro + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoBairro =  '" + _EnderecoBairro + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoMunicipio =  '" + _EnderecoMunicipio + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoMunicipio =  '" + _EnderecoMunicipio + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoUF =  '" + _EnderecoUF + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoUF =  '" + _EnderecoUF + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoEletronico =  '" + _EnderecoEletronico + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoEletronico =  '" + _EnderecoEletronico + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por ContatoEmpresa.
    /// </summary>
    /// <param name="_ContatoEmpresa">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_ContatoEmpresa(string _ContatoEmpresa)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  ContatoEmpresa =  '" + _ContatoEmpresa + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por ContatoEmpresa.
    /// </summary>
    /// <param name="_ContatoEmpresa">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_ContatoEmpresa(string _ContatoEmpresa, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  ContatoEmpresa =  '" + _ContatoEmpresa + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por SituacaoCadastral.
    /// </summary>
    /// <param name="_SituacaoCadastral">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_SituacaoCadastral(string _SituacaoCadastral)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  SituacaoCadastral =  '" + _SituacaoCadastral + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por SituacaoCadastral.
    /// </summary>
    /// <param name="_SituacaoCadastral">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_SituacaoCadastral(string _SituacaoCadastral, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  SituacaoCadastral =  '" + _SituacaoCadastral + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por DataSituacaoCadastral.
    /// </summary>
    /// <param name="_DataSituacaoCadastral">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_DataSituacaoCadastral(string _DataSituacaoCadastral)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  DataSituacaoCadastral =  '" + _DataSituacaoCadastral + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por DataSituacaoCadastral.
    /// </summary>
    /// <param name="_DataSituacaoCadastral">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_DataSituacaoCadastral(string _DataSituacaoCadastral, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  DataSituacaoCadastral =  '" + _DataSituacaoCadastral + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  NomeResponsavel =  '" + _NomeResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  NomeResponsavel =  '" + _NomeResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por CPFResponsavel.
    /// </summary>
    /// <param name="_CPFResponsavel">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CPFResponsavel(string _CPFResponsavel)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  CPFResponsavel =  '" + _CPFResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por CPFResponsavel.
    /// </summary>
    /// <param name="_CPFResponsavel">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_CPFResponsavel(string _CPFResponsavel, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  CPFResponsavel =  '" + _CPFResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por RGResponsavel.
    /// </summary>
    /// <param name="_RGResponsavel">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_RGResponsavel(string _RGResponsavel)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  RGResponsavel =  '" + _RGResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por RGResponsavel.
    /// </summary>
    /// <param name="_RGResponsavel">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_RGResponsavel(string _RGResponsavel, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  RGResponsavel =  '" + _RGResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoLogradouroResponsavel.
    /// </summary>
    /// <param name="_EnderecoLogradouroResponsavel">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoLogradouroResponsavel(string _EnderecoLogradouroResponsavel)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoLogradouroResponsavel =  '" + _EnderecoLogradouroResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoLogradouroResponsavel.
    /// </summary>
    /// <param name="_EnderecoLogradouroResponsavel">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoLogradouroResponsavel(string _EnderecoLogradouroResponsavel, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoLogradouroResponsavel =  '" + _EnderecoLogradouroResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoNumeroResponsavel.
    /// </summary>
    /// <param name="_EnderecoNumeroResponsavel">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoNumeroResponsavel(string _EnderecoNumeroResponsavel)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoNumeroResponsavel =  '" + _EnderecoNumeroResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoNumeroResponsavel.
    /// </summary>
    /// <param name="_EnderecoNumeroResponsavel">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoNumeroResponsavel(string _EnderecoNumeroResponsavel, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoNumeroResponsavel =  '" + _EnderecoNumeroResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoComplementoResponsavel.
    /// </summary>
    /// <param name="_EnderecoComplementoResponsavel">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoComplementoResponsavel(string _EnderecoComplementoResponsavel)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoComplementoResponsavel =  '" + _EnderecoComplementoResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoComplementoResponsavel.
    /// </summary>
    /// <param name="_EnderecoComplementoResponsavel">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoComplementoResponsavel(string _EnderecoComplementoResponsavel, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoComplementoResponsavel =  '" + _EnderecoComplementoResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoCEPResponsavel.
    /// </summary>
    /// <param name="_EnderecoCEPResponsavel">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoCEPResponsavel(string _EnderecoCEPResponsavel)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoCEPResponsavel =  '" + _EnderecoCEPResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoCEPResponsavel.
    /// </summary>
    /// <param name="_EnderecoCEPResponsavel">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoCEPResponsavel(string _EnderecoCEPResponsavel, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoCEPResponsavel =  '" + _EnderecoCEPResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoBairroResponsavel.
    /// </summary>
    /// <param name="_EnderecoBairroResponsavel">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoBairroResponsavel(string _EnderecoBairroResponsavel)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoBairroResponsavel =  '" + _EnderecoBairroResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoBairroResponsavel.
    /// </summary>
    /// <param name="_EnderecoBairroResponsavel">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoBairroResponsavel(string _EnderecoBairroResponsavel, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoBairroResponsavel =  '" + _EnderecoBairroResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoMunicipioResponsavel.
    /// </summary>
    /// <param name="_EnderecoMunicipioResponsavel">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoMunicipioResponsavel(string _EnderecoMunicipioResponsavel)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoMunicipioResponsavel =  '" + _EnderecoMunicipioResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoMunicipioResponsavel.
    /// </summary>
    /// <param name="_EnderecoMunicipioResponsavel">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoMunicipioResponsavel(string _EnderecoMunicipioResponsavel, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoMunicipioResponsavel =  '" + _EnderecoMunicipioResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoUFResponsavel.
    /// </summary>
    /// <param name="_EnderecoUFResponsavel">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoUFResponsavel(string _EnderecoUFResponsavel)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoUFResponsavel =  '" + _EnderecoUFResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoUFResponsavel.
    /// </summary>
    /// <param name="_EnderecoUFResponsavel">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoUFResponsavel(string _EnderecoUFResponsavel, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoUFResponsavel =  '" + _EnderecoUFResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoEletronicoResponsavel.
    /// </summary>
    /// <param name="_EnderecoEletronicoResponsavel">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoEletronicoResponsavel(string _EnderecoEletronicoResponsavel)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoEletronicoResponsavel =  '" + _EnderecoEletronicoResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por EnderecoEletronicoResponsavel.
    /// </summary>
    /// <param name="_EnderecoEletronicoResponsavel">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_EnderecoEletronicoResponsavel(string _EnderecoEletronicoResponsavel, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  EnderecoEletronicoResponsavel =  '" + _EnderecoEletronicoResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por ContatoEmpresaResponsavel.
    /// </summary>
    /// <param name="_ContatoEmpresaResponsavel">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_ContatoEmpresaResponsavel(string _ContatoEmpresaResponsavel)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  ContatoEmpresaResponsavel =  '" + _ContatoEmpresaResponsavel + "'  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por ContatoEmpresaResponsavel.
    /// </summary>
    /// <param name="_ContatoEmpresaResponsavel">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_ContatoEmpresaResponsavel(string _ContatoEmpresaResponsavel, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  ContatoEmpresaResponsavel =  '" + _ContatoEmpresaResponsavel + "'  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por SituacaoLicenca.
    /// </summary>
    /// <param name="_SituacaoLicenca">filtro da consulta</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_SituacaoLicenca(byte _SituacaoLicenca)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  SituacaoLicenca =   " + _SituacaoLicenca + "  ) ");

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    /// Seleciona todos os registros por SituacaoLicenca.
    /// </summary>
    /// <param name="_SituacaoLicenca">filtro da consulta</param>
    /// <param name="_orderby">campo de ordenação</param>
    /// <returns>DataSet</returns>
    public DataSet FindBy_SituacaoLicenca(byte _SituacaoLicenca, string _orderby)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            // colunas
            strSql.Append(" Codigo, NumeroInscricaoCNPJ, TipoInscricao, DataAbertura, NomeEmpresarial, NomeFantasia, Porte, CodigoEDescricaoDaAtividadeEconomicaPrincial, CodigoEDescricaoDaAtividadeSecundaria, CodigoEDescricaoNaturezaJuridica, EnderecoLogradouro, EnderecoNumero, EnderecoComplemento, EnderecoCEP, EnderecoBairro, EnderecoMunicipio, EnderecoUF, EnderecoEletronico, ContatoEmpresa, SituacaoCadastral, DataSituacaoCadastral, NomeResponsavel, CPFResponsavel, RGResponsavel, EnderecoLogradouroResponsavel, EnderecoNumeroResponsavel, EnderecoComplementoResponsavel, EnderecoCEPResponsavel, EnderecoBairroResponsavel, EnderecoMunicipioResponsavel, EnderecoUFResponsavel, EnderecoEletronicoResponsavel, ContatoEmpresaResponsavel, SituacaoLicenca  ");
            strSql.Append(" FROM  TabEmpresa  ");
            strSql.Append(" WHERE (  SituacaoLicenca =   " + _SituacaoLicenca + "  ) ");
            strSql.Append(" ORDER BY " + _orderby);

            objDO = new DO();

            // executa consulta e retorna um DataSet
            return objDO.GetDataSet(strSql.ToString(), "TabEmpresa");
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
    public int Insert(TabEmpresaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" INSERT INTO  TabEmpresa  ");
            strSql.Append(" (");

            strSql.Append(" NumeroInscricaoCNPJ, ");
            strSql.Append(" TipoInscricao, ");
            strSql.Append(" DataAbertura, ");
            strSql.Append(" NomeEmpresarial, ");
            strSql.Append(" NomeFantasia, ");
            strSql.Append(" Porte, ");
            strSql.Append(" CodigoEDescricaoDaAtividadeEconomicaPrincial, ");
            strSql.Append(" CodigoEDescricaoDaAtividadeSecundaria, ");
            strSql.Append(" CodigoEDescricaoNaturezaJuridica, ");
            strSql.Append(" EnderecoLogradouro, ");
            strSql.Append(" EnderecoNumero, ");
            strSql.Append(" EnderecoComplemento, ");
            strSql.Append(" EnderecoCEP, ");
            strSql.Append(" EnderecoBairro, ");
            strSql.Append(" EnderecoMunicipio, ");
            strSql.Append(" EnderecoUF, ");
            strSql.Append(" EnderecoEletronico, ");
            strSql.Append(" ContatoEmpresa, ");
            strSql.Append(" SituacaoCadastral, ");
            strSql.Append(" DataSituacaoCadastral, ");
            strSql.Append(" NomeResponsavel, ");
            strSql.Append(" CPFResponsavel, ");
            strSql.Append(" RGResponsavel, ");
            strSql.Append(" EnderecoLogradouroResponsavel, ");
            strSql.Append(" EnderecoNumeroResponsavel, ");
            strSql.Append(" EnderecoComplementoResponsavel, ");
            strSql.Append(" EnderecoCEPResponsavel, ");
            strSql.Append(" EnderecoBairroResponsavel, ");
            strSql.Append(" EnderecoMunicipioResponsavel, ");
            strSql.Append(" EnderecoUFResponsavel, ");
            strSql.Append(" EnderecoEletronicoResponsavel, ");
            strSql.Append(" ContatoEmpresaResponsavel, ");
            strSql.Append(" SituacaoLicenca ");
            strSql.Append(" ) ");
            strSql.Append(" VALUES (");
            strSql.Append("  '" + _vo.NumeroInscricaoCNPJ + "' , ");
            strSql.Append("  '" + _vo.TipoInscricao + "' , ");
            strSql.Append("  CONVERT(DATETIME, '" + _vo.DataAbertura + "', 103) , ");
            strSql.Append("  '" + _vo.NomeEmpresarial + "' , ");
            strSql.Append("  '" + _vo.NomeFantasia + "' , ");
            strSql.Append("  '" + _vo.Porte + "' , ");
            strSql.Append("  '" + _vo.CodigoEDescricaoDaAtividadeEconomicaPrincial + "' , ");
            strSql.Append("  '" + _vo.CodigoEDescricaoDaAtividadeSecundaria + "' , ");
            strSql.Append("  '" + _vo.CodigoEDescricaoNaturezaJuridica + "' , ");
            strSql.Append("  '" + _vo.EnderecoLogradouro + "' , ");
            strSql.Append("  '" + _vo.EnderecoNumero + "' , ");
            strSql.Append("  '" + _vo.EnderecoComplemento + "' , ");
            strSql.Append("  '" + _vo.EnderecoCEP + "' , ");
            strSql.Append("  '" + _vo.EnderecoBairro + "' , ");
            strSql.Append("  '" + _vo.EnderecoMunicipio + "' , ");
            strSql.Append("  '" + _vo.EnderecoUF + "' , ");
            strSql.Append("  '" + _vo.EnderecoEletronico + "' , ");
            strSql.Append("  '" + _vo.ContatoEmpresa + "' , ");
            strSql.Append("  '" + _vo.SituacaoCadastral + "' , ");
            strSql.Append("  '" + _vo.DataSituacaoCadastral + "' , ");
            strSql.Append("  '" + _vo.NomeResponsavel + "' , ");
            strSql.Append("  '" + _vo.CPFResponsavel + "' , ");
            strSql.Append("  '" + _vo.RGResponsavel + "' , ");
            strSql.Append("  '" + _vo.EnderecoLogradouroResponsavel + "' , ");
            strSql.Append("  '" + _vo.EnderecoNumeroResponsavel + "' , ");
            strSql.Append("  '" + _vo.EnderecoComplementoResponsavel + "' , ");
            strSql.Append("  '" + _vo.EnderecoCEPResponsavel + "' , ");
            strSql.Append("  '" + _vo.EnderecoBairroResponsavel + "' , ");
            strSql.Append("  '" + _vo.EnderecoMunicipioResponsavel + "' , ");
            strSql.Append("  '" + _vo.EnderecoUFResponsavel + "' , ");
            strSql.Append("  '" + _vo.EnderecoEletronicoResponsavel + "' , ");
            strSql.Append("  '" + _vo.ContatoEmpresaResponsavel + "' , ");
            strSql.Append(" " + _vo.SituacaoLicenca + "  )");


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
    public int Update(TabEmpresaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" UPDATE  TabEmpresa  ");
            strSql.Append(" SET ");

            strSql.Append("   NumeroInscricaoCNPJ =  '" + _vo.NumeroInscricaoCNPJ + "' ,  ");
            strSql.Append("   TipoInscricao =  '" + _vo.TipoInscricao + "' ,  ");
            strSql.Append("   DataAbertura = CONVERT(DATETIME, '" + _vo.DataAbertura + "' , 103) ,  ");
            strSql.Append("   NomeEmpresarial =  '" + _vo.NomeEmpresarial + "' ,  ");
            strSql.Append("   NomeFantasia =  '" + _vo.NomeFantasia + "' ,  ");
            strSql.Append("   Porte =  '" + _vo.Porte + "' ,  ");
            strSql.Append("   CodigoEDescricaoDaAtividadeEconomicaPrincial =  '" + _vo.CodigoEDescricaoDaAtividadeEconomicaPrincial + "' ,  ");
            strSql.Append("   CodigoEDescricaoDaAtividadeSecundaria =  '" + _vo.CodigoEDescricaoDaAtividadeSecundaria + "' ,  ");
            strSql.Append("   CodigoEDescricaoNaturezaJuridica =  '" + _vo.CodigoEDescricaoNaturezaJuridica + "' ,  ");
            strSql.Append("   EnderecoLogradouro =  '" + _vo.EnderecoLogradouro + "' ,  ");
            strSql.Append("   EnderecoNumero =  '" + _vo.EnderecoNumero + "' ,  ");
            strSql.Append("   EnderecoComplemento =  '" + _vo.EnderecoComplemento + "' ,  ");
            strSql.Append("   EnderecoCEP =  '" + _vo.EnderecoCEP + "' ,  ");
            strSql.Append("   EnderecoBairro =  '" + _vo.EnderecoBairro + "' ,  ");
            strSql.Append("   EnderecoMunicipio =  '" + _vo.EnderecoMunicipio + "' ,  ");
            strSql.Append("   EnderecoUF =  '" + _vo.EnderecoUF + "' ,  ");
            strSql.Append("   EnderecoEletronico =  '" + _vo.EnderecoEletronico + "' ,  ");
            strSql.Append("   ContatoEmpresa =  '" + _vo.ContatoEmpresa + "' ,  ");
            strSql.Append("   SituacaoCadastral =  '" + _vo.SituacaoCadastral + "' ,  ");
            strSql.Append("   DataSituacaoCadastral =  '" + _vo.DataSituacaoCadastral + "' ,  ");
            strSql.Append("   NomeResponsavel =  '" + _vo.NomeResponsavel + "' ,  ");
            strSql.Append("   CPFResponsavel =  '" + _vo.CPFResponsavel + "' ,  ");
            strSql.Append("   RGResponsavel =  '" + _vo.RGResponsavel + "' ,  ");
            strSql.Append("   EnderecoLogradouroResponsavel =  '" + _vo.EnderecoLogradouroResponsavel + "' ,  ");
            strSql.Append("   EnderecoNumeroResponsavel =  '" + _vo.EnderecoNumeroResponsavel + "' ,  ");
            strSql.Append("   EnderecoComplementoResponsavel =  '" + _vo.EnderecoComplementoResponsavel + "' ,  ");
            strSql.Append("   EnderecoCEPResponsavel =  '" + _vo.EnderecoCEPResponsavel + "' ,  ");
            strSql.Append("   EnderecoBairroResponsavel =  '" + _vo.EnderecoBairroResponsavel + "' ,  ");
            strSql.Append("   EnderecoMunicipioResponsavel =  '" + _vo.EnderecoMunicipioResponsavel + "' ,  ");
            strSql.Append("   EnderecoUFResponsavel =  '" + _vo.EnderecoUFResponsavel + "' ,  ");
            strSql.Append("   EnderecoEletronicoResponsavel =  '" + _vo.EnderecoEletronicoResponsavel + "' ,  ");
            strSql.Append("   ContatoEmpresaResponsavel =  '" + _vo.ContatoEmpresaResponsavel + "' ,  ");
            strSql.Append("   SituacaoLicenca =   '" + Convert.ToBoolean(_vo.SituacaoLicenca) + "'   ");

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
    public int Delete(TabEmpresaVO _vo)
    {
        try
        {
            strSql = new StringBuilder();
            strSql.Append(" DELETE FROM TabEmpresa  ");
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