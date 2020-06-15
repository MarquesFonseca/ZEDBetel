using System;
using System.Collections.Generic;
using System.Text;

//namespace VO
//{

/// <summary>
/// Classe VO: Value Objects
/// Criador: Marques Silva Fonseca
/// Criada em 15/05/2019 0:48
/// Contato: marques-fonseca@hotmail.com
/// </summary>

public class VwTabMembroVO
{
    // Atributos
    private int _Codigo;
    private string _Nome;
    private string _CPF;
    private string _RG;
    private string _EnderecoMunicipio;
    private string _EnderecoUF;
    private int _CodigoEmpresa;
    private string _NomeEmpresarial;

    // Propriedades
    public int Codigo
    {
        get { return _Codigo; }
        set { _Codigo = value; }
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
    public int CodigoEmpresa
    {
        get { return _CodigoEmpresa; }
        set { _CodigoEmpresa = value; }
    }
    public string NomeEmpresarial
    {
        get { return _NomeEmpresarial; }
        set { _NomeEmpresarial = value; }
    }
}
//}
