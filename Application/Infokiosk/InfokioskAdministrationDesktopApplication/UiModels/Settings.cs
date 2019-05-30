using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication.UiModels
{
    [Serializable]
    public class Settings
    {
        public Color TagColor { get; set; }

        public Color ParameterColor { get; set; }

        public Color TextColor { get; set; }

        public Color CommentColor { get; set; }

        public Color ChangeColor { get; set; }

        public bool HeadTagPanelVisible { get; set; }

        public bool CommonTagPanelVisible { get; set; }

        public bool SpecialSymbolsTagPanelVisible { get; set; }

        public bool TableAndListTagPanelVisible { get; set; }


        private static Settings instance = null;

        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Settings();
                    instance.Load();
                }
                return instance;
            }
        }

        protected Settings()
        {

        }

        public void Save()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fileStream = new FileStream(Environment.CurrentDirectory + @"\Settings.dat", FileMode.Create);
                bf.Serialize(fileStream, instance);
                fileStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't save Settings");
            }
        }

        protected void Load()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fileStream = new FileStream("Settings.dat", FileMode.Open);
                instance = (Settings)bf.Deserialize(fileStream);
                fileStream.Close();
            }
            catch (Exception)
            {

                TextColor = Color.Blue;
                ParameterColor = Color.Red;
                TextColor = Color.Green;
                CommentColor = Color.Gray;
                ChangeColor = Color.Yellow;
            }
        }
    }
}
