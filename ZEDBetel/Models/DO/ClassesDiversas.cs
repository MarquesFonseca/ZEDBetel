using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Reflection;

public static class ClassesDiversas
{
    public static int CodigoUsuarioLogado = 5; // Usuario 1 pertence à empresa 1
    //public static int CodigoUsuarioLogado = 5; // Usuario 5 pertence à empresa 2
    //public static int CodigoUsuarioLogado = 8; // Usuario 8 pertence à empresa 3

    private static VwTabUsuarioVO _UsuarioLogado;

    // Propriedades
    public static VwTabUsuarioVO UsuarioLogado
    {
        get
        {
            return RetornaUsuarioLogado(CodigoUsuarioLogado);
        }
        set { _UsuarioLogado = value; }
    }

    private static VwTabUsuarioVO RetornaUsuarioLogado(int codigoUsuarioLogado)
    {
        VwTabUsuarioVO _Vo = new VwTabUsuarioVO();
        try
        {
            VwTabUsuarioBO BO = new VwTabUsuarioBO();
            DataTable Dt = BO.FindBy_Codigo(codigoUsuarioLogado).Tables[0];
            _Vo = ClassesDiversas.ConvertDataTable<VwTabUsuarioVO>(Dt).FirstOrDefault();
            return _Vo;
        }
        catch (Exception)
        {
            throw new NotImplementedException();
        }
    }
    
    public static List<T> ConvertDataTable<T>(DataTable dt)
    {
        List<T> data = new List<T>();
        foreach (DataRow row in dt.Rows)
        {
            T item = GetItem<T>(row);
            data.Add(item);
        }
        return data;
    }
    private static T GetItem<T>(DataRow dr)
    {
        Type temp = typeof(T);
        T obj = Activator.CreateInstance<T>();

        foreach (DataColumn column in dr.Table.Columns)
        {
            foreach (System.Reflection.PropertyInfo pro in temp.GetProperties())
            {
                //((System.RuntimeType)((System.Reflection.RuntimePropertyInfo)pro).PropertyType).FullName
                //if(pro.GetType() == pro.PropertyType.)
                if (pro.Name == column.ColumnName)
                    pro.SetValue(obj, dr[column.ColumnName], null);
                else
                    continue;
            }
        }
        return obj;
    }
}
