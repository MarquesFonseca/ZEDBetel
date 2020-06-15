using System;
using System.Collections.Generic;
using System.Text;

//namespace VO
//{

/// <summary>
/// Classe VO: Value Objects
/// Criador: Marques Silva Fonseca
/// Criada em 15/05/2019 2:06
/// Contato: marques-fonseca@hotmail.com
/// </summary>

public class VwTabSaidaCaixaVO
{
    // Atributos
    private int _Codigo;
    private string _Descricao;
    private Decimal _ValorSaida;
    private DateTime _DataSaida;
    private DateTime _DataCadastro;
    private int _CodigoEventoReferencia;
    private string _EventoReferencia;
    private int _CodigoTipoSaidaCaixa;
    private string _TipoSaidaCaixa;
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
    public Decimal ValorSaida
    {
        get { return _ValorSaida; }
        set { _ValorSaida = value; }
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
    public int CodigoTipoSaidaCaixa
    {
        get { return _CodigoTipoSaidaCaixa; }
        set { _CodigoTipoSaidaCaixa = value; }
    }
    public string TipoSaidaCaixa
    {
        get { return _TipoSaidaCaixa; }
        set { _TipoSaidaCaixa = value; }
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
