using System;
using System.Collections.Generic;
using System.Text;

//namespace VO
//{

/// <summary>
/// Classe VO: Value Objects
/// Criador: Marques Silva Fonseca
/// Criada em 14/05/2019 22:22
/// Contato: marques-fonseca@hotmail.com
/// </summary>

public class VwTabEmpresaVO
{
    // Atributos
    private int _Codigo;
    private string _NumeroInscricaoCNPJ;
    private string _NomeEmpresarial;
    private string _EnderecoMunicipio;
    private string _EnderecoUF;
    private string _NomeResponsavel;

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
    public string NomeEmpresarial
    {
        get { return _NomeEmpresarial; }
        set { _NomeEmpresarial = value; }
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
    public string NomeResponsavel
    {
        get { return _NomeResponsavel; }
        set { _NomeResponsavel = value; }
    }
}
//}
