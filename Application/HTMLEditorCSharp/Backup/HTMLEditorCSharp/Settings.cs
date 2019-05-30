using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Configuration;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace HTMLEditorCSharp
{
    [Serializable]
    class Settings
    {

        private Color tagColor;
        public Color TagColor
        {
            get { return tagColor; }
            set { tagColor = value; }
        }
        private Color parameterColor;
        public Color ParameterColor
        {
            get { return parameterColor; }
            set { parameterColor = value; }
        }
        private Color textColor;
        public Color TextColor
        {
            get { return textColor; }
            set { textColor = value; }
        }
        private Color commentColor;
        public Color CommentColor
        {
            get { return commentColor; }
            set { commentColor = value; }
        }
        private Color changeColor;
        public Color ChangeColor
        {
            get { return changeColor; }
            set { changeColor = value; }
        }

        private bool headTagPanelVisible = true;
        public bool HeadTagPanelVisible
        {
            get { return headTagPanelVisible; }
            set { headTagPanelVisible = value; }
        }

        private bool commonTagPanelVisible = true;
        public bool CommonTagPanelVisible
        {
            get { return commonTagPanelVisible; }
            set { commonTagPanelVisible = value; }
        }

        private bool specialSymbolsPanelVisible = true;
        public bool SpecialSymbolsTagPanelVisible
        {
            get { return specialSymbolsPanelVisible; }
            set { specialSymbolsPanelVisible = value; }
        }

        private bool tableAndListPanelVisible = true;
        public bool TableAndListTagPanelVisible
        {
            get { return tableAndListPanelVisible; }
            set { tableAndListPanelVisible = value; }
        }

        protected Settings()
        {        
        }
        private static Settings instance = null;
        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Settings();
                    instance.Load ();
                }
                return instance;
            }
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
