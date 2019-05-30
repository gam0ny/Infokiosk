using System.Collections.Generic;

namespace InfokioskAdministrationDesktopApplication.UiModels
{
    public class Tag
    {
        public string TagName { get; set; }
        public bool TagEnd { get; set; }

        public List<string> Parameters { get; set; }

        public Tag()
        {
            Parameters = new List<string>();
        }

        public void AddTag(string name, bool tagEnd)
        {
            TagName = name;
            TagEnd = tagEnd;
        }

        public void AddParam(string param)
        {
            Parameters.Add(param);
        }

    }
}
