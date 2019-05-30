using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLEditorCSharp
{
    public class Tag
    {
        private String tagName;
        public String TagName
        {
            get
            {
                return tagName;
            }
            set
            {
                tagName = value;
            }
        }
        private bool tagEnd;
        public bool TagEnd
        {
            get
            {
                return tagEnd;
            }
            set
            {
                tagEnd = value;
            }
        }

        private List<String> parameters;

        public Tag()
        {
            parameters = new List<string>();
        }

        public List<String> Parameters
        {
            get
            {
                return parameters;
            }
            set
            {
                parameters = value;
            }
        }


        /// <summary>
        /// Add TagName and returns True if Tag has CloseTag
        /// </summary>
        /// <param name="tName"></param>
        /// <param name="tEnd"></param>
        public void addTag(string tName, bool tEnd)
        {
            TagName = tName;
            TagEnd = tEnd;
        }

        /// <summary>
        /// Add Parameter in Tag
        /// </summary>
        /// <param name="param"></param>
        public void addParam(string param)
        {
            Parameters.Add(param);
        }

    }

}
