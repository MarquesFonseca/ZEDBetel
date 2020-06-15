using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Classe VO: Value Objects
/// Criador: Marques Silva Fonseca
/// Criada em 11/05/2019
/// Contato: marques-fonseca@hotmail.com
/// </summary>
public class TabEntradaCaixaVO
{
    // Atributos
    private int _Codigo;
    private int _CodigoEmpresa;
    private int _CodigoUsuarioCadastro;
    private int _CodigoTipoEntradaCaixa;
    private int _CodigoMembro;
    private int _CodigoEventoReferencia;
    private Decimal _ValorEntrada;
    private string _Descricao;
    private DateTime _DataEntrada;
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
    public int CodigoTipoEntradaCaixa
    {
        get { return _CodigoTipoEntradaCaixa; }
        set { _CodigoTipoEntradaCaixa = value; }
    }
    public int CodigoMembro
    {
        get { return _CodigoMembro; }
        set { _CodigoMembro = value; }
    }
    public int CodigoEventoReferencia
    {
        get { return _CodigoEventoReferencia; }
        set { _CodigoEventoReferencia = value; }
    }
    public Decimal ValorEntrada
    {
        get { return _ValorEntrada; }
        set { _ValorEntrada = value; }
    }
    public string Descricao
    {
        get { return _Descricao; }
        set { _Descricao = value; }
    }
    public DateTime DataEntrada
    {
        get { return _DataEntrada; }
        set { _DataEntrada = value; }
    }
    public DateTime DataCadastro
    {
        get { return _DataCadastro; }
        set { _DataCadastro = value; }
    }
}
