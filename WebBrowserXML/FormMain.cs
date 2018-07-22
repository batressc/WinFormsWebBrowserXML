using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WebBrowserXML {
    public partial class FormMain : Form {
        private Result _data;
        private string _xmlSample;

        public FormMain() {
            InitializeComponent();
            _data = new Result();
            saveCacheXML("<?xml version=\"1.0\"?><test><node1><node1_1 attribute=\"01\" type=\"demo\">Hello world!</node1_1></node1></test>");
        }

        private void saveCacheXML(string xmlString) {
            _xmlSample = xmlString;
            _data.StringValue = _xmlSample;
            this.propertyGridResult.SelectedObject = _data;
        }

        // If the value of the property that stores the text string changes, we assign the value in the PropertyGrid again so that the character arrays and their entire representation are displayed correctly
        private void propertyGridResult_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
            if (e.ChangedItem.PropertyDescriptor.Name == "StringValue") {
                saveCacheXML(e.ChangedItem.Value.ToString());
            }
        }

        // For the input string, it simulates a XML string with or without Byte Order Mark (BOM)
        private void UTF8String(bool useBOM) {
            UTF8Encoding encoder = new UTF8Encoding(useBOM);
            byte[] bytesBOM = null;
            byte[] bytesData = null;
            byte[] bytesString = null;
            // Generating BOM if the flag is true
            if (useBOM) {
                bytesBOM = encoder.GetPreamble();
            }
            // Generating data
            bytesData = encoder.GetBytes(_xmlSample);
            // Adding BOM if the flag is true
            if (useBOM) {
                bytesString = bytesBOM.Concat(bytesData).ToArray();
            } else {
                bytesString = bytesData;
            }
            // Encoding to string 
            _data.StringValue = Encoding.UTF8.GetString(bytesString);
            this.propertyGridResult.SelectedObject = _data;
        }

        // Generating and loading XML string without BOM
        private void buttonUTF8_Click(object sender, EventArgs e) {
            UTF8String(false);
            this.webBrowserXml.DocumentText = _data.StringValue;

        }

        // Generating and loading XML string with BOM
        private void buttonUTF8BOM_Click(object sender, EventArgs e) {
            UTF8String(true);
            this.webBrowserXml.DocumentText = _data.StringValue;
        }

        // Loading a XML file
        private void buttonLoadXml_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog() {
                CheckFileExists = true,
                DefaultExt = "*.xml|*.xml",
                Filter = "*.xml|*.xml",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                RestoreDirectory = true,
                Title = "Load XML File..."
            };
            if (ofd.ShowDialog() == DialogResult.OK) {
                XmlDocument doc = new XmlDocument();
                doc.Load(ofd.FileName);
                saveCacheXML(doc.OuterXml);
            }
        }
    }
}
