using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace InfokioskAdministrationDesktopApplication.UiModels
{
    public class Highlighter
    {
        public Tags tags { get; set; }
        public bool InTag { get; set; }

        public Highlighter()
        {
            this.tags = new Tags();
            var serializer = new XmlSerializer(typeof(Tags));
            var fs = new FileStream("Tags.xml", FileMode.Open);
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
            textBox.Select(selectionStart, selectionLength);
            MatchCollection matches = rx.Matches(textBox.SelectedText);
            foreach (Match match in matches)
            {
                textBox.Select(match.Index + selectionStart, match.Length);
                string tmp = textBox.SelectedText;


                Tag tmpTag = new Tag();
                Regex tmpRx = null;
                Match tmpMatch = null;
                //looking for TagName in TagString
                foreach (Tag t in tags.TagList)
                {

                    tmpRx = new Regex(@"[<,/]" + t.TagName + @"[\s,>]", RegexOptions.IgnoreCase);
                    Match tm = tmpRx.Match(tmp);
                    if (tm.Success)
                    {
                        tmpMatch = tm;
                        tmpTag = t;
                        break;
                    }
                }

                //highlight of TagString
                if (tmpMatch != null)
                {
                    if (tmpMatch.Success)
                    {
                        //highlight of TagName
                        if (tmp[1] == '/') textBox.Select(match.Index + selectionStart, tmpMatch.Length + 2);
                        else textBox.Select(match.Index + selectionStart, tmpMatch.Length);
                        textBox.SelectionColor = Constants.TagColor;

                        //highlight of TagEnd
                        textBox.Select(match.Index + selectionStart + match.Length - 1, 1);
                        textBox.SelectionColor = Constants.TagColor;

                        //highlight of Parameters
                        if (tmp[1] != '/') //if Tag is not CloseTag
                        {
                            foreach (var param in tmpTag.Parameters)
                            {
                                //find next parameter
                                tmpRx = new Regex(@"\s" + param + @"=*\S*[\s,>]", RegexOptions.IgnoreCase);
                                tmpMatch = null;
                                tmpMatch = tmpRx.Match(tmp);
                                //if parameter found Highlight it
                                if (tmpMatch.Success)
                                {
                                    textBox.Select(match.Index + selectionStart + tmpMatch.Index + 1, tmpMatch.Length - 2);
                                    textBox.SelectionColor = Constants.ParameterColor;
                                }
                                //find text in " " 
                                tmpRx = new Regex(@""".*?""");
                                MatchCollection mcol = tmpRx.Matches(tmp);
                                foreach (Match tmpMat in mcol)
                                {
                                    textBox.Select(match.Index + selectionStart + tmpMat.Index, tmpMat.Length);
                                    textBox.SelectionColor = Constants.TextColor;
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
                textBox.Select(match.Index + selectionStart, match.Length);
                textBox.SelectionBackColor = Constants.CommentColor;
            }

            //highlight of special symbols
            foreach (var symbol in tags.SpecSymbolList)
            {
                rx = new Regex(symbol);
                textBox.Select(selectionStart, selectionLength);
                matches = rx.Matches(textBox.SelectedText);
                foreach (Match match in matches)
                {
                    textBox.Select(match.Index + selectionStart, match.Length);
                    textBox.SelectionColor = Constants.ChangeColor;
                }
            }
        }

    }
}
