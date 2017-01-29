using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApplication1
{
    class obslugaXml
    {
        public void tworz() {
            XmlTextWriter writer = new XmlTextWriter(string nazwa, System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1", "Product 1", "1000", writer);
            createNode("2", "Product 2", "2000", writer);
            createNode("3", "Product 3", "3000", writer);
            createNode("4", "Product 4", "4000", writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MessageBox.Show("XML File created ! ");
            }
        private void createNode(string pID, string pName, string pPrice, XmlTextWriter writer)
        {
            writer.WriteStartElement("Product");
            writer.WriteStartElement("Product_id");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("Product_name");
            writer.WriteString(pName);
            writer.WriteEndElement();
            writer.WriteStartElement("Product_price");
            writer.WriteString(pPrice);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
