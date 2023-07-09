using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp_TuDienNoiAnh_Viet
{
    public class DictionaryManager
    {
        #region properties
        private string filePath = "data.xml";

        private DictionaryItem items;

        public DictionaryItem Items
        {
            get { return items; }
            set { items = value; }
        }
        #endregion

        #region methods
        public DictionaryManager()
        {
            items = (DictionaryItem)DeserializeFromXML(filePath);
        }

        public void LoadDataToCombobox(ComboBox combo)
        {
            combo.DataSource = items.Items;
        }


        public void Serialize()
        {
            SerializeToXML(Items, filePath);
        }

        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

            sr.Serialize(fs, data);

            fs.Close();
        }

        public object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

            object obj = sr.Deserialize(fs);

            fs.Close();

            return obj;
        }

        #endregion
    }
}
