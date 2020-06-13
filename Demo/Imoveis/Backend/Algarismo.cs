using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BackendSQL;

namespace Backend
{
    public class Algarismo<T>
    {
        public T valorAlgarismo { get; set; }
        public DB oDB { get; set; }

        public T somarAlgarismos(T valorAlgarismoPirmeiro, T valorAlgarismoSegundo)
        {
            dynamic operando1 = valorAlgarismoPirmeiro;
            dynamic operando2 = valorAlgarismoSegundo;
            return operando1 + operando2;
        }

        public void Gravar(Algarismo<T> oAlgarismo)
        {
            oDB = new DB();
            oDB.Gravar(string.Format("INSERT INTO NUMERO (VALOR, TIPO) VALUES ('{0}', '{1}')", oAlgarismo.valorAlgarismo, oAlgarismo.GetType().Name));
        }
    }
}
