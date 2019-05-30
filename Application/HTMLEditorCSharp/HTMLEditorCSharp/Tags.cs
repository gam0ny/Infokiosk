using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLEditorCSharp
{
    public class Tags
    {
        public int number;
        private List<String> specSymbolList;
        public List<String> SpecSymbolList
        {
            get { return specSymbolList; }
            set { specSymbolList = value; }
        }
        private List<Tag> tagList;
        public List<Tag> TagList
        {
            get
            {
                return tagList;
            }
            set
            {
                tagList = value;
            }
        }

        public Tags()
        {
            tagList = new List<Tag>();
            specSymbolList = new List<string>();
        }

        /// <summary>
        /// Add Tag in TagList
        /// </summary>
        /// <param name="tag"></param>
        public void addTag(Tag tag)
        {
            TagList.Add(tag);
        }
        /// <summary>
        /// Add Special Symbol in SpecSymbolList
        /// </summary>
        /// <param name="symbol"></param>
        public void addSpecSymbol(String symbol)
        {
            SpecSymbolList.Add(symbol);
        }

    }

}
