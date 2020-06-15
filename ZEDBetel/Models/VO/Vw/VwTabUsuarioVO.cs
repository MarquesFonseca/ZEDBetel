using System;
using System.Collections.Generic;
using System.Text;

//namespace VO
//{

/// <summary>
/// Classe VO: Value Objects
/// Criador: Marques Silva Fonseca
/// Criada em 14/05/2019 0:14
/// Contato: marques-fonseca@hotmail.com
/// </summary>

public class VwTabUsuarioVO
{
    // Atributos
    private int _Codigo;
    private string _Nome;
    private string _Login;
    private string _Senha;
    private int _CodigoEmpresa;
    private string _NomeFantasia;
    private string _NomeEmpresarial;
    private int _CodigoUsuarioCadastro;
    private string _NomeUsuarioCadastro;
    private DateTime _DataCadastro;

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
    public int CodigoEmpresa
    {
        get { return _CodigoEmpresa; }
        set { _CodigoEmpresa = value; }
    }
    public string NomeFantasia
    {
        get { return _NomeFantasia; }
        set { _NomeFantasia = value; }
    }
    public string NomeEmpresarial
    {
        get { return _NomeEmpresarial; }
        set { _NomeEmpresarial = value; }
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
    public DateTime DataCadastro
    {
        get { return _DataCadastro; }
        set { _DataCadastro = value; }
    }
}
//}
