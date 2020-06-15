using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Classe VO: Value Objects
/// Criador: Marques Silva Fonseca
/// Criada em 11/05/2019
/// Contato: marques-fonseca@hotmail.com
/// </summary>
public class TabMembroVO
{
    // Atributos
    private int _Codigo;
    private int _CodigoEmpresa;
    private int _CodigoUsuarioCadastro;
    private string _Nome;
    private string _CPF;
    private string _RG;
    private string _EnderecoLogradouro;
    private string _EnderecoNumero;
    private string _EnderecoComplemento;
    private string _EnderecoCEP;
    private string _EnderecoBairro;
    private string _EnderecoMunicipio;
    private string _EnderecoUF;
    private string _EnderecoEletronico;
    private string _Contato;
    private string _Contato2;
    private DateTime _DataCadastro;

    // Propriedades
    public int Codigo
    {
        get { return _Codigo; }
        set { _Codigo = value; }
    }
    public int CodigoEmpresa
    {
        get { return _CodigoEmpresa; }
        set { _CodigoEmpresa = value; }
    }
    public int CodigoUsuarioCadastro
    {
        get { return _CodigoUsuarioCadastro; }
        set { _CodigoUsuarioCadastro = value; }
    }
    public string Nome
    {
        get { return _Nome; }
        set { _Nome = value; }
    }
    public string CPF
    {
        get { return _CPF; }
        set { _CPF = value; }
    }
    public string RG
    {
        get { return _RG; }
        set { _RG = value; }
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
    public string Contato
    {
        get { return _Contato; }
        set { _Contato = value; }
    }
    public string Contato2
    {
        get { return _Contato2; }
        set { _Contato2 = value; }
    }
    public DateTime DataCadastro
    {
        get { return _DataCadastro; }
        set { _DataCadastro = value; }
    }
}
