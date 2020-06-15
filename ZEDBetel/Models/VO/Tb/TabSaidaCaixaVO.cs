using System;
using System.Collections.Generic;
using System.Text;

//namespace VO
//{

/// <summary>
/// Classe VO: Value Objects
/// Criador: Marques Silva Fonseca
/// Criada em 15/05/2019 1:56
/// Contato: marques-fonseca@hotmail.com
/// </summary>

public class TabSaidaCaixaVO
{
    // Atributos
    private int _Codigo;
    private int _CodigoEmpresa;
    private int _CodigoUsuarioCadastro;
    private int _CodigoTipoSaidaCaixa;
    private int _CodigoEventoReferencia;
    private Decimal _ValorSaida;
    private string _Descricao;
    private DateTime _DataSaida;
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
    public int CodigoTipoSaidaCaixa
    {
        get { return _CodigoTipoSaidaCaixa; }
        set { _CodigoTipoSaidaCaixa = value; }
    }
    public int CodigoEventoReferencia
    {
        get { return _CodigoEventoReferencia; }
        set { _CodigoEventoReferencia = value; }
    }
    public Decimal ValorSaida
    {
        get { return _ValorSaida; }
        set { _ValorSaida = value; }
    }
    public string Descricao
    {
        get { return _Descricao; }
        set { _Descricao = value; }
    }
    public DateTime DataSaida
    {
        get { return _DataSaida; }
        set { _DataSaida = value; }
    }
    public DateTime DataCadastro
    {
        get { return _DataCadastro; }
        set { _DataCadastro = value; }
    }
}
//}
