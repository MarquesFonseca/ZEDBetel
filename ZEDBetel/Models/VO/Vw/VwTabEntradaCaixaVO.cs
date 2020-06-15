using System;
using System.Collections.Generic;
using System.Text;

//namespace VO
//{

/// <summary>
/// Classe VO: Value Objects
/// Criador: Marques Silva Fonseca
/// Criada em 15/05/2019 2:09
/// Contato: marques-fonseca@hotmail.com
/// </summary>

public class VwTabEntradaCaixaVO
{
    // Atributos
    private int _Codigo;
    private string _Descricao;
    private Decimal _ValorEntrada;
    private DateTime _DataEntrada;
    private DateTime _DataCadastro;
    private int _CodigoEventoReferencia;
    private string _EventoReferencia;
    private int _CodigoMembro;
    private string _NomeMembro;
    private string _EnderecoMunicipioMembro;
    private string _EnderecoUFMembro;
    private int _CodigoTipoEntradaCaixa;
    private string _TipoEntradaCaixa;
    private int _CodigoUsuarioCadastro;
    private string _NomeUsuarioCadastro;
    private int _CodigoEmpresa;
    private string _NomeEmpresarial;
    private string _EnderecoMunicipioEmpresa;
    private string _EnderecoUFEmpresa;

    // Propriedades
    public int Codigo
    {
        get { return _Codigo; }
        set { _Codigo = value; }
    }
    public string Descricao
    {
        get { return _Descricao; }
        set { _Descricao = value; }
    }
    public Decimal ValorEntrada
    {
        get { return _ValorEntrada; }
        set { _ValorEntrada = value; }
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
    public int CodigoEventoReferencia
    {
        get { return _CodigoEventoReferencia; }
        set { _CodigoEventoReferencia = value; }
    }
    public string EventoReferencia
    {
        get { return _EventoReferencia; }
        set { _EventoReferencia = value; }
    }
    public int CodigoMembro
    {
        get { return _CodigoMembro; }
        set { _CodigoMembro = value; }
    }
    public string NomeMembro
    {
        get { return _NomeMembro; }
        set { _NomeMembro = value; }
    }
    public string EnderecoMunicipioMembro
    {
        get { return _EnderecoMunicipioMembro; }
        set { _EnderecoMunicipioMembro = value; }
    }
    public string EnderecoUFMembro
    {
        get { return _EnderecoUFMembro; }
        set { _EnderecoUFMembro = value; }
    }
    public int CodigoTipoEntradaCaixa
    {
        get { return _CodigoTipoEntradaCaixa; }
        set { _CodigoTipoEntradaCaixa = value; }
    }
    public string TipoEntradaCaixa
    {
        get { return _TipoEntradaCaixa; }
        set { _TipoEntradaCaixa = value; }
    }
    public int CodigoUsuarioCadastro
    {
        get { return _CodigoUsuarioCadastro; }
        set { _CodigoUsuarioCadastro = value; }
    }
    public string NomeUsuarioCadastro
    {
        get { return _NomeUsuarioCadastro; }
        set { _NomeUsuarioCadastro = value; }
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
    public string EnderecoMunicipioEmpresa
    {
        get { return _EnderecoMunicipioEmpresa; }
        set { _EnderecoMunicipioEmpresa = value; }
    }
    public string EnderecoUFEmpresa
    {
        get { return _EnderecoUFEmpresa; }
        set { _EnderecoUFEmpresa = value; }
    }
}
//}
