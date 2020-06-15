using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Classe VO: Value Objects
/// Criador: Marques Silva Fonseca
/// Criada em 11/05/2019
/// Contato: marques-fonseca@hotmail.com
/// </summary>
public class TabEmpresaVO
{
    // Atributos
    private int _Codigo;
    private string _NumeroInscricaoCNPJ;
    private string _TipoInscricao;
    private DateTime _DataAbertura;
    private string _NomeEmpresarial;
    private string _NomeFantasia;
    private string _Porte;
    private string _CodigoEDescricaoDaAtividadeEconomicaPrincial;
    private string _CodigoEDescricaoDaAtividadeSecundaria;
    private string _CodigoEDescricaoNaturezaJuridica;
    private string _EnderecoLogradouro;
    private string _EnderecoNumero;
    private string _EnderecoComplemento;
    private string _EnderecoCEP;
    private string _EnderecoBairro;
    private string _EnderecoMunicipio;
    private string _EnderecoUF;
    private string _EnderecoEletronico;
    private string _ContatoEmpresa;
    private string _SituacaoCadastral;
    private string _DataSituacaoCadastral;
    private string _NomeResponsavel;
    private string _CPFResponsavel;
    private string _RGResponsavel;
    private string _EnderecoLogradouroResponsavel;
    private string _EnderecoNumeroResponsavel;
    private string _EnderecoComplementoResponsavel;
    private string _EnderecoCEPResponsavel;
    private string _EnderecoBairroResponsavel;
    private string _EnderecoMunicipioResponsavel;
    private string _EnderecoUFResponsavel;
    private string _EnderecoEletronicoResponsavel;
    private string _ContatoEmpresaResponsavel;
    private bool _SituacaoLicenca;

    // Propriedades
    public int Codigo
    {
        get { return _Codigo; }
        set { _Codigo = value; }
    }
    public string NumeroInscricaoCNPJ
    {
        get { return _NumeroInscricaoCNPJ; }
        set { _NumeroInscricaoCNPJ = value; }
    }
    public string TipoInscricao
    {
        get { return _TipoInscricao; }
        set { _TipoInscricao = value; }
    }
    public DateTime DataAbertura
    {
        get { return _DataAbertura; }
        set { _DataAbertura = value; }
    }
    public string NomeEmpresarial
    {
        get { return _NomeEmpresarial; }
        set { _NomeEmpresarial = value; }
    }
    public string NomeFantasia
    {
        get { return _NomeFantasia; }
        set { _NomeFantasia = value; }
    }
    public string Porte
    {
        get { return _Porte; }
        set { _Porte = value; }
    }
    public string CodigoEDescricaoDaAtividadeEconomicaPrincial
    {
        get { return _CodigoEDescricaoDaAtividadeEconomicaPrincial; }
        set { _CodigoEDescricaoDaAtividadeEconomicaPrincial = value; }
    }
    public string CodigoEDescricaoDaAtividadeSecundaria
    {
        get { return _CodigoEDescricaoDaAtividadeSecundaria; }
        set { _CodigoEDescricaoDaAtividadeSecundaria = value; }
    }
    public string CodigoEDescricaoNaturezaJuridica
    {
        get { return _CodigoEDescricaoNaturezaJuridica; }
        set { _CodigoEDescricaoNaturezaJuridica = value; }
    }
    public string EnderecoLogradouro
    {
        get { return _EnderecoLogradouro; }
        set { _EnderecoLogradouro = value; }
    }
    public string EnderecoNumero
    {
        get { return _EnderecoNumero; }
        set { _EnderecoNumero = value; }
    }
    public string EnderecoComplemento
    {
        get { return _EnderecoComplemento; }
        set { _EnderecoComplemento = value; }
    }
    public string EnderecoCEP
    {
        get { return _EnderecoCEP; }
        set { _EnderecoCEP = value; }
    }
    public string EnderecoBairro
    {
        get { return _EnderecoBairro; }
        set { _EnderecoBairro = value; }
    }
    public string EnderecoMunicipio
    {
        get { return _EnderecoMunicipio; }
        set { _EnderecoMunicipio = value; }
    }
    public string EnderecoUF
    {
        get { return _EnderecoUF; }
        set { _EnderecoUF = value; }
    }
    public string EnderecoEletronico
    {
        get { return _EnderecoEletronico; }
        set { _EnderecoEletronico = value; }
    }
    public string ContatoEmpresa
    {
        get { return _ContatoEmpresa; }
        set { _ContatoEmpresa = value; }
    }
    public string SituacaoCadastral
    {
        get { return _SituacaoCadastral; }
        set { _SituacaoCadastral = value; }
    }
    public string DataSituacaoCadastral
    {
        get { return _DataSituacaoCadastral; }
        set { _DataSituacaoCadastral = value; }
    }
    public string NomeResponsavel
    {
        get { return _NomeResponsavel; }
        set { _NomeResponsavel = value; }
    }
    public string CPFResponsavel
    {
        get { return _CPFResponsavel; }
        set { _CPFResponsavel = value; }
    }
    public string RGResponsavel
    {
        get { return _RGResponsavel; }
        set { _RGResponsavel = value; }
    }
    public string EnderecoLogradouroResponsavel
    {
        get { return _EnderecoLogradouroResponsavel; }
        set { _EnderecoLogradouroResponsavel = value; }
    }
    public string EnderecoNumeroResponsavel
    {
        get { return _EnderecoNumeroResponsavel; }
        set { _EnderecoNumeroResponsavel = value; }
    }
    public string EnderecoComplementoResponsavel
    {
        get { return _EnderecoComplementoResponsavel; }
        set { _EnderecoComplementoResponsavel = value; }
    }
    public string EnderecoCEPResponsavel
    {
        get { return _EnderecoCEPResponsavel; }
        set { _EnderecoCEPResponsavel = value; }
    }
    public string EnderecoBairroResponsavel
    {
        get { return _EnderecoBairroResponsavel; }
        set { _EnderecoBairroResponsavel = value; }
    }
    public string EnderecoMunicipioResponsavel
    {
        get { return _EnderecoMunicipioResponsavel; }
        set { _EnderecoMunicipioResponsavel = value; }
    }
    public string EnderecoUFResponsavel
    {
        get { return _EnderecoUFResponsavel; }
        set { _EnderecoUFResponsavel = value; }
    }
    public string EnderecoEletronicoResponsavel
    {
        get { return _EnderecoEletronicoResponsavel; }
        set { _EnderecoEletronicoResponsavel = value; }
    }
    public string ContatoEmpresaResponsavel
    {
        get { return _ContatoEmpresaResponsavel; }
        set { _ContatoEmpresaResponsavel = value; }
    }
    public bool SituacaoLicenca
    {
        get { return _SituacaoLicenca; }
        set { _SituacaoLicenca = value; }
    }
}
