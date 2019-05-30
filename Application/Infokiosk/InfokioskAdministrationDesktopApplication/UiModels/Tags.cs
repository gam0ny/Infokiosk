using System.Collections.Generic;

namespace InfokioskAdministrationDesktopApplication.UiModels
{
    public class Tags
    {
        public int number;
        public List<string> SpecSymbolList { get; set; }
        public List<Tag> TagList { get; set; }

        public Tags()
        {
            TagList = new List<Tag>();
            SpecSymbolList = new List<string>();
        }

        public void AddTag(Tag tag)
        {
            TagList.Add(tag);
        }

        public void AddSpecSymbol(string symbol)
        {
            SpecSymbolList.Add(symbol);
        }

    }
}
