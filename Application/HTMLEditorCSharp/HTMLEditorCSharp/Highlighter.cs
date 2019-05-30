using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;

namespace HTMLEditorCSharp
{
    public class Highlighter
    {
        private bool inTag;
        public Tags tags;
        public bool InTag
        {
            get
            {
                return inTag;
            }
            set
            {
                inTag = value;
            }
        }

        public Highlighter()
        {
            tags = new Tags();
            XmlSerializer serializer = new XmlSerializer(typeof(Tags));
            FileStream fs = new FileStream("Tags.xml", FileMode.Open);
            tags = (Tags)serializer.Deserialize(fs);
            fs.Close();
        }
        /// <summary>
        /// Highlight the full current text
        /// </summary>
        /// <param name="mainText"></param>
        public void FindAndHighlight(RichTextBox textBox, int selectionStart, int selectionLength)
        {

            int Selected = textBox.SelectionStart;
            //ifnd the full text of Tag
            Regex rx = new Regex(@"<.*?>", RegexOptions.IgnoreCase);
            textBox.Select(selectionStart,selectionLength);
            MatchCollection matches = rx.Matches(textBox.SelectedText); 
            foreach (Match match in matches)
            {
                textBox.Select(match.Index+selectionStart, match.Length);
                string tmp = textBox.SelectedText;


                Tag tmpTag = new Tag();
                Regex tmpRx=null;
                Match tmpMatch=null;
                //looking for TagName in TagString
                foreach (Tag t in tags.TagList)
                {

                    tmpRx = new Regex(@"[<,/]"+t.TagName+@"[\s,>]",RegexOptions.IgnoreCase);
                    Match tm = tmpRx.Match(tmp);
                    if (tm.Success) 
                    {
                        tmpMatch=tm;
                        tmpTag=t;
                        break;
                    }
                }

                //highlight of TagString
                if (tmpMatch != null)
                {
                    if (tmpMatch.Success)
                    {
                        //highlight of TagName
                        if (tmp[1] == '/') textBox.Select(match.Index+selectionStart, tmpMatch.Length+2);
                        else textBox.Select(match.Index+selectionStart, tmpMatch.Length );
                        textBox.SelectionColor = Settings.Instance.TagColor;

                        //highlight of TagEnd
                        textBox.Select(match.Index+selectionStart + match.Length - 1, 1);
                        textBox.SelectionColor = Settings.Instance.TagColor;

                        //highlight of Parameters
                        if (tmp[1] != '/') //if Tag is not CloseTag
                        {
                            foreach (String param in tmpTag.Parameters)
                            {
                                //find next parameter
                                tmpRx = new Regex(@"\s" + param + @"=*\S*[\s,>]", RegexOptions.IgnoreCase);
                                tmpMatch = null;
                                tmpMatch = tmpRx.Match(tmp);
                                //if parameter found Highlight it
                                if (tmpMatch.Success)
                                {
                                    textBox.Select(match.Index +selectionStart+ tmpMatch.Index + 1, tmpMatch.Length - 2);
                                    textBox.SelectionColor = Settings.Instance.ParameterColor;
                                }
                                //find text in " " 
                                tmpRx = new Regex(@""".*?""");
                                MatchCollection mcol = tmpRx.Matches(tmp);
                                foreach (Match tmpMat in mcol)
                                {
                                    textBox.Select(match.Index+selectionStart+tmpMat.Index,tmpMat.Length);
                                    textBox.SelectionColor = Settings.Instance.TextColor;
                                }
                            }     
                        }
                    }
                }
            }
            //highlight of comments
            rx = new Regex(@"<!--*?-->", RegexOptions.IgnoreCase);
            textBox.Select(selectionStart, selectionLength);
            matches = rx.Matches(textBox.SelectedText);  
            foreach (Match match in matches)
            {
                textBox.Select(match.Index+selectionStart, match.Length);
                textBox.SelectionBackColor = Settings.Instance.CommentColor;
            }

            //highlight of special symbols
            foreach (String symbol in tags.SpecSymbolList)
            {
                rx = new Regex(symbol);
                textBox.Select(selectionStart, selectionLength);
                matches = rx.Matches(textBox.SelectedText); 
                foreach (Match match in matches)
                {
                    textBox.Select(match.Index+selectionStart, match.Length);
                    textBox.SelectionColor = Settings.Instance.ChangeColor;
                }
            }
        }

    }
}

        
        
        
       
    


