using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using Spire.Xls;

namespace DataConvertion

{
    public class Data
    {

        public static void exceltoxml()
        {
            Workbook wb = new Workbook();
            wb.LoadFromFile("Nombres.xlsx");
            wb.SaveAsXml("Nombres.xml");

            wb.LoadFromFile("Saldos.xlsx");
            wb.SaveAsXml("Saldos.xml");

            wb.LoadFromFile("Cuentas.xlsx");
            wb.SaveAsXml("Cuentas.xml");
        }


        public static string[] GetNombre()
        {
            XmlDocument reader = new XmlDocument();
            reader.Load("Nombres.xml");
            List<string> dato = new List<string>();
            XmlNodeList elemList = reader.GetElementsByTagName("Data");
            for (int i = 0; i < elemList.Count; i++)
            {
                dato.Add(elemList[i].InnerXml);
            }

            return dato.ToArray();

        }

        public static string[] GetCuenta()
        {
            XmlDocument reader = new XmlDocument();
            reader.Load("Saldos.xml.xml");
            List<string> dato = new List<string>();
            XmlNodeList elemList = reader.GetElementsByTagName("Data");
            for (int i = 0; i < elemList.Count; i++)
            {
                dato.Add(elemList[i].InnerXml);
            }

            return dato.ToArray();

        }


        public static string[] GetSaldo()
        {
            XmlDocument reader = new XmlDocument();
            reader.Load("Saldos.xml");
            List<string> dato = new List<string>();
            XmlNodeList elemList = reader.GetElementsByTagName("Data");
            for (int i = 0; i < elemList.Count; i++)
            {
                dato.Add(elemList[i].InnerXml);
            }

            return dato.ToArray();

        }
    }
}
