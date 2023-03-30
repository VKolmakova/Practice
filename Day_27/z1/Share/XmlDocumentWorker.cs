using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using z1.Interfaces;
using z1.Models;

namespace z1.Share
{
    internal class XmlDocumentWorker:IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;

        public XmlDocumentWorker (ILogger logger)
        {
            _logger = logger;
            _document = new XmlDocument();
        }

        public void Add(Record records)
        {
            var xRoot = _document.DocumentElement;

            XmlElement recordElem = _document.CreateElement("Record");
            XmlAttribute surnameAttribute = _document.CreateAttribute("Surname");
            XmlText surnameText = _document.CreateTextNode(records.Surname);
            surnameAttribute.AppendChild(surnameText);


            XmlElement dateOfBirthElem = _document.CreateElement("Date of birth");
            XmlText DateOfBirthInnerText = _document.CreateTextNode(records.DateOfBirth.ToString());
            dateOfBirthElem.AppendChild(DateOfBirthInnerText);
            recordElem.AppendChild(dateOfBirthElem);

            XmlElement phoneNumberElem = _document.CreateElement("Phone number");
            XmlText phoneNumberInnerText = _document.CreateTextNode(records.PhoneNumber.ToString());
            phoneNumberElem.AppendChild(phoneNumberInnerText);
            recordElem.AppendChild(phoneNumberElem);

            xRoot.AppendChild(recordElem);
            _document.Save(_xmlFilePath);
        }
        public List<Record> GetAll()
        {
            List<Record> records = new List<Record>();
            var xRoot = _document.DocumentElement;
            foreach (XmlNode node in xRoot)
            {
                var record = GetRecord(node);
                    records.Add(record);
            }
            return records;
        }
    
    public void Delete(string surname)
        {
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    var attributeSurName = xNode.Attributes.GetNamedItem("Surname");
                    
                    
                        var attributeSurNameText = attributeSurName?.InnerText;
                        if (attributeSurNameText.Equals(surname))
                        {
                            xRoot.RemoveChild(xNode);
                        }
                    
                   
                }
            }
        }

        public Record FindBy(string surname)
        {
            Record record = null;
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                record = GetRecord(xNode);
                if  (record.Surname.Equals(surname))
                {
                    return record;
                }
            }
            return record;
        }

      
         
        public void Load (string xmlFieleRath)
        {
            _xmlFilePath = xmlFieleRath;
            _document.Load(xmlFieleRath);
        }

        private Record GetRecord(XmlNode node)
        {
            var record = new Record();
            if (node.Attributes.Count > 0)
            {
                var attributeSurName = node.Attributes.GetNamedItem("Surname");
                record.Surname = attributeSurName?.Value;
            }
            foreach (XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("\"Date of birth"))
                    {
                        record.DateOfBirth = int.Parse(childNode.InnerText);
                    }
                    if (childNode.Name.Equals("Phone number"))
                        record.PhoneNumber = int.Parse(childNode.InnerText);
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    
                }
            }
            return record;
        }
        
    }
}
