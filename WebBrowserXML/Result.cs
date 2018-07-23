using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowserXML {
    public class Result {
        private string stringValue;

        public string StringValue {
            get { return stringValue; }
            set {
                stringValue = value;
                // string to byte array for to see BOM 
                DataByte = Encoding.UTF8.GetBytes(stringValue);

                DataChar = stringValue.ToArray();
            }
        }

        public char[] DataChar { get; private set; }
        public byte[] DataByte { get; private set; }
    }
}
