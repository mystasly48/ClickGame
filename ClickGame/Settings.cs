using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClickGame {
    public class Settings {
        public List<Record> Records { get; set; }

        private string Path;
        private Settings settings;

        public Settings(string path) {
            Path = path;
        }
        
        public void Save() {

        }

        public Settings Load() {
            var settings = new Settings(Path);
            if (File.Exists(Path)) {
                var serializer = new XmlSerializer(typeof(Settings));
                var reader = new StreamReader(Path);
                settings = (Settings)serializer.Deserialize(reader);
                reader.Close();
            } else {
                Save();
                Load();
            }
            return settings;
        }
    }
}
