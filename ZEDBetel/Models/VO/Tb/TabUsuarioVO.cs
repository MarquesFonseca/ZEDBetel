using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Classe VO: Value Objects
/// Criador: Marques Silva Fonseca
/// Criada em 11/05/2019
/// Contato: marques-fonseca@hotmail.com
/// </summary>
public class TabUsuarioVO
{
    // Atributos
    private int _Codigo;
    private int _CodigoEmpresa;
    private int _CodigoUsuarioCadastro;
    private string _Nome;
    private string _Login;
    private string _Senha;
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
    public string Login
    {
        get { return _Login; }
        set { _Login = value; }
    }
    public string Senha
    {
        get { return _Senha; }
        set { _Senha = value; }
    }
    public DateTime DataCadastro
    {
        get { return _DataCadastro; }
        set { _DataCadastro = value; }
    }
}
