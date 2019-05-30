using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;

namespace HTMLEditorCSharp
{
    public partial class mainForm : Form
    {
        private string fileName;
        private Highlighter highlighter;

        private bool isModified = false;
        //Tags tags;
        public mainForm()
        {
            InitializeComponent();
            mainTextBox.Visible = false;
            fileName = "";

            headTagPanelToolStripMenuItem.Checked = headToolStrip.Visible = Settings.Instance.HeadTagPanelVisible;
            commonTagPanelToolStripMenuItem.Checked = textStrip.Visible = Settings.Instance.CommonTagPanelVisible;
            specialSymbolsPanelToolStripMenuItem.Checked = specSymbolsToolStrip.Visible = Settings.Instance.SpecialSymbolsTagPanelVisible;
            tableAndListPanelToolStripMenuItem.Checked = tablesAndListsToolStrip.Visible = Settings.Instance.TableAndListTagPanelVisible;
        }
        //open file 
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Visible == true)
                closeToolStripMenuItem_Click(sender,e);
            
            OpenFileDialog oFDialog = new OpenFileDialog();
            oFDialog.Title = "OK... Lets try to open file...";
            oFDialog.Multiselect = false;
            oFDialog.Filter="HTML files (*.html,*.htm)|*.html;*.htm";
            oFDialog.FilterIndex = 1 ;
            oFDialog.RestoreDirectory = true ;
            

            if (oFDialog.ShowDialog() == DialogResult.OK)
            { 
                this.fileName = oFDialog.FileName;
                try
                {
                    mainTextBox.LoadFile(fileName,RichTextBoxStreamType.PlainText);
                }
                catch (Exception)
                {
                    MessageBox.Show("I can't open File!!!");
                }
                if (fileName != "")
                {
                    mainTextBox.SelectAll();
                    highlighter.FindAndHighlight(mainTextBox,0,mainTextBox.TextLength);
                    mainTextBox.Visible = true;
                }
            }
            isModified = false;
            
        }

       //save file
       private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //if file exist then onle save it
           //if it doesn't exist then call for SaveAsDialog
           if (fileName == "")
            {
               SaveFileDialog sFDialog = new SaveFileDialog();
               sFDialog.Title = "OK... Lets try to save it...";
               sFDialog.InitialDirectory="d:\\Проги\\HTMLEditor\\ex";
               sFDialog.Filter = "HTML files (*.html)|*.html|HTM files (*.htm)|*htm";
               if (sFDialog.ShowDialog() == DialogResult.OK)
                   if (sFDialog.FileName != "")
                   {
                       fileName = sFDialog.FileName;
                       mainTextBox.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                   }
            }
            else mainTextBox.SaveFile(fileName, RichTextBoxStreamType.PlainText);
            isModified = false;
        }
        
        //Save as file
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFDialog = new SaveFileDialog();
            sFDialog.Title = "OK... Lets try to save it...";
            sFDialog.InitialDirectory = "d:\\Проги\\HTMLEditor\\ex";
            sFDialog.Filter = "HTML files (*.html)|*.html|HTM files (*.htm)|*htm";
            if (sFDialog.ShowDialog() == DialogResult.OK)
                if (sFDialog.FileName != "")
                {
                    fileName = sFDialog.FileName;
                    mainTextBox.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                }
        }

        //creatinf of new file
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Visible == true)
            {
                    closeToolStripMenuItem_Click(sender,e);
            }
            mainTextBox.Visible = true;
            mainTextBox.Text = String.Empty;
        }

        //close file
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isModified)
            {
                return;
            }
            if (mainTextBox.Visible == true)
            {
                saveChangesInFileDialogForm f = new saveChangesInFileDialogForm();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    mainTextBox.Visible = false;
                }
                else
                {
                    mainTextBox.Text = "";
                    mainTextBox.Visible = false;
                }
            }
            
        }

        
        //Print About this product
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This product was created by Sparco!!!!");
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            highlighter = new Highlighter();
        }

        private void uBatton_Click(object sender, EventArgs e)
        {
            String strBegin = "<U>";
            String strEnd = "</U>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<B>";
            String strEnd = "</B>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;

            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void iButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<I>";
            String strEnd = "</I>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;

            InsertBegin(ref start,ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<S>";
            String strEnd = "</S>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start,ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void commButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<!-- ";
            String strEnd = "-->";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start,ref end, strBegin, Settings.Instance.CommentColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void pButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<P";
            String strEnd = "</P>";
            PForm pf = new PForm();
            pf.ShowDialog();
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start,ref  end, strBegin, Settings.Instance.TagColor);

            if (pf.DialogResult == DialogResult.OK && pf.Align != "none")
            {
                strBegin = "";
                strBegin += " align=";
                strBegin += pf.Align;
                InsertBegin(ref start,ref end, strBegin, Settings.Instance.ParameterColor);
            }
            strBegin = ">";
            InsertBegin(ref start,ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);

                
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            FontForm ff = new FontForm(Color.FromArgb(0,0,0));
            ff.ShowDialog();
            String strBegin = "<FONT";
            String strEnd = "</FONT>";

            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start,ref end, strBegin, Settings.Instance.TagColor);
            if (ff.FontFont!="Times New Roman" || ff.FontSize!=8 || ff.FontCheck!='=' || ff.FontColor!=Color.Black)
            {
                if (ff.FontFont != "Times New Roman")
                {
                    strBegin = "";
                    strBegin += " face=";
                    InsertBegin(ref start,ref end, strBegin, Settings.Instance.ParameterColor);

                    strBegin = "";
                    strBegin += '"';
                    strBegin +=ff.FontFont;
                    strBegin +='"';
                    InsertBegin(ref start,ref  end, strBegin, Settings.Instance.TextColor);
                }

                if (ff.FontCheck != '=' || ff.FontSize != 8)
                {
                    strBegin = "";
                    strBegin += "  size=";
                    if (ff.FontCheck!='=')
                        strBegin += ff.FontCheck;
                    strBegin += ff.FontSize.ToString();
                    InsertBegin(ref start,ref end, strBegin, Settings.Instance.ParameterColor);
                }

                if (ff.FontColor != Color.Black)
                {
                    strBegin = "";
                    strBegin += " color=";
                    String f ="#"+ff.FontColor.R + ff.FontColor.G + ff.FontColor.B;
                    strBegin += f;
                    
                    InsertBegin(ref start,ref end, strBegin, Settings.Instance.ParameterColor);
                }
            }

            strBegin = ">";
            InsertBegin(ref start,ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        /// <summary>
        /// insert Part of curent Tag in the Begin of Selection
        /// </summary>
        /// <param name="start"></param>
        /// <param name="strBegin"></param>
        /// <param name="color"></param>
        private void InsertBegin(ref int start,ref int end, String strBegin,Color color)
        {
            if (mainTextBox.Visible)
            {
                mainTextBox.Select(start, 0);
                mainTextBox.SelectedText = strBegin;
                start += strBegin.Length;
                end += strBegin.Length;
                mainTextBox.Select(start - strBegin.Length, strBegin.Length);
                mainTextBox.SelectionColor = color;
                mainTextBox.DeselectAll();
                mainTextBox.SelectionColor = Color.Black;
            }
        }
        
        /// <summary>
        /// insert End Part of current Tag in the End of Selecting
        /// </summary>
        /// <param name="end"></param>
        /// <param name="strEnd"></param>
        /// <param name="color"></param>
        private void InsertEnd(int end, String strEnd, Color color)
        {
            if (mainTextBox.Visible)
            {
                mainTextBox.Select(end, 0);
                mainTextBox.SelectedText = strEnd;
                mainTextBox.Select(end, strEnd.Length);
                mainTextBox.SelectionColor = color;
                mainTextBox.DeselectAll();
                mainTextBox.SelectionColor = Color.Black;
            }
        }

        private void imgButton_Click(object sender, EventArgs e)
        {
            ImgForm iForm = new ImgForm();
            iForm.ShowDialog();
            String strBegin = "<IMG";
           
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;

            InsertBegin(ref start, ref end, strBegin,Settings.Instance.TagColor);
            if (iForm.DialogResult == DialogResult.OK)
            {
                if (iForm.Src != "")
                {
                    strBegin = " scr=";
                    InsertBegin(ref start, ref end, strBegin, Settings.Instance.ParameterColor);
                    strBegin = '"' + iForm.Src + '"';
                    InsertBegin(ref start, ref end, strBegin, Settings.Instance.TextColor);
                }
                if (iForm.Alt != "")
                {
                    strBegin = " alt=";
                    InsertBegin(ref start, ref end, strBegin, Settings.Instance.ParameterColor);
                    strBegin = '"' + iForm.Alt + '"';
                    InsertBegin(ref start, ref end, strBegin, Settings.Instance.TextColor);
                }
                if (iForm.Lowsrc != "")
                {
                    strBegin = " lowscr=";
                    InsertBegin(ref start, ref end, strBegin, Settings.Instance.ParameterColor);
                    strBegin = '"' + iForm.Lowsrc + '"';
                    InsertBegin(ref start, ref end, strBegin, Settings.Instance.TextColor);
                }
                strBegin = " width=" + iForm.Width.ToString();
                if (iForm.Check == 1) strBegin += '%';
                InsertBegin(ref start, ref end, strBegin, Settings.Instance.ParameterColor);
                strBegin = " height=" + iForm.Height.ToString();
                if (iForm.Check == 1) strBegin += '%';
                InsertBegin(ref start, ref end, strBegin, Settings.Instance.ParameterColor);

                if (iForm.Align1 != "none")
                {
                    strBegin = " align=" + iForm.Align1;
                    InsertBegin(ref start, ref end, strBegin, Settings.Instance.ParameterColor);
                }
                if (iForm.Align2 != "none")
                {
                    strBegin = " align=" + iForm.Align2;
                    InsertBegin(ref start, ref end, strBegin, Settings.Instance.ParameterColor);
                }
            }
            strBegin = ">";
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            AForm af = new AForm();
            af.ShowDialog();
            String strBegin = "<A";
            String strEnd = "</A>";

            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            if (af.DialogResult == DialogResult.OK)
            {
                if (af.Path != "")
                {
                    strBegin = " href=";
                    InsertBegin(ref start, ref end, strBegin, Settings.Instance.ParameterColor);
                    strBegin = '"' + af.Path + '"';
                    InsertBegin(ref start, ref end, strBegin, Settings.Instance.TextColor);
                }
            }
            strBegin = ">";
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sForm = new SettingsForm();
            sForm.ShowDialog();
            highlighter.FindAndHighlight(mainTextBox,0,mainTextBox.TextLength);
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeToolStripMenuItem_Click(sender, e);
            Settings.Instance.Save();
        }

        private void ltButton_Click(object sender, EventArgs e)
        {
            String strBegin = "&lt";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.ChangeColor);
        }

        private void gtButton_Click(object sender, EventArgs e)
        {
            String strBegin = "&gt";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.ChangeColor);
        }

        private void nbspButton_Click(object sender, EventArgs e)
        {
            String strBegin = "&nbsp";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.ChangeColor);
        }

        private void ampButtom_Click(object sender, EventArgs e)
        {
            String strBegin = "&amp";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.ChangeColor);
        }

        private void laquoButton_Click(object sender, EventArgs e)
        {
            String strBegin = "&laquo";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.ChangeColor);
        }

        private void raquoButton_Click(object sender, EventArgs e)
        {
            String strBegin = "&raquot";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.ChangeColor);
        }

        private void ldquoButton_Click(object sender, EventArgs e)
        {
            String strBegin = "&ldquo";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.ChangeColor);
        }

        private void rdquoButton_Click(object sender, EventArgs e)
        {
            String strBegin = "&rdquo";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.ChangeColor);
        }

        private void tableButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<TABLE>";
            String strEnd = "</TABLE>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void tdButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<TD>";
            String strEnd = "</TD>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void trButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<TR>";
            String strEnd = "</TR>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void ulButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<UL>";
            String strEnd = "</UL>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void liButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<LI>";
            String strEnd = "</LI>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void h1Button_Click(object sender, EventArgs e)
        {
            String strBegin = "<H1>";
            String strEnd = "</H1>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void h2Button_Click(object sender, EventArgs e)
        {
            String strBegin = "<H2>";
            String strEnd = "</H2>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void h3Button_Click(object sender, EventArgs e)
        {
            String strBegin = "<H3>";
            String strEnd = "</H3>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void h4Button_Click(object sender, EventArgs e)
        {
            String strBegin = "<H4>";
            String strEnd = "</H4>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void h5Button_Click(object sender, EventArgs e)
        {
            String strBegin = "<H5>";
            String strEnd = "</H5>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void h6Button_Click(object sender, EventArgs e)
        {
            String strBegin = "<H6>";
            String strEnd = "</H6>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void htmlButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<HTML>";
            String strEnd = "</HTML>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void headButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<HEAD>";
            String strEnd = "</HEAD>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void bodyButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<BODY>";
            String strEnd = "</BODY>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            String strBegin = "<TITLE>";
            String strEnd = "</TITLE>";
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            InsertBegin(ref start, ref end, strBegin, Settings.Instance.TagColor);
            InsertEnd(end, strEnd, Settings.Instance.TagColor);
        }

        private void mainTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                int selectionStart = mainTextBox.SelectionStart;
                Regex rx = new Regex(@"<.*?", RegexOptions.RightToLeft); 
                Match match=rx.Match(mainTextBox.Text,selectionStart);
                if (match.Success)
                    highlighter.FindAndHighlight(mainTextBox, match.Index, match.Length);
                mainTextBox.Select(selectionStart, 0);
                mainTextBox.SelectionColor = Color.Black;

                rx = new Regex(@"&.*?", RegexOptions.RightToLeft);
                match = rx.Match(mainTextBox.Text, selectionStart);
                if (match.Success)
                {
                    mainTextBox.Select(match.Index, match.Length);
                    mainTextBox.SelectionColor = Color.Black;
                    highlighter.FindAndHighlight(mainTextBox, match.Index, match.Length);
                }
                mainTextBox.Select(selectionStart, 0);
                mainTextBox.SelectionColor = Color.Black;
            }
            if (e.KeyChar == '\b')
            {
                
                int selectionStart = mainTextBox.SelectionStart;
                Regex rx = new Regex(@"<.*?", RegexOptions.RightToLeft);
                Match match = rx.Match(mainTextBox.Text, selectionStart);
                if (match.Success)
                {
                    mainTextBox.Select(match.Index, match.Length);
                    mainTextBox.SelectionColor = Color.Black;
                    highlighter.FindAndHighlight(mainTextBox, match.Index, match.Length);
                }
                mainTextBox.Select(selectionStart, 0);
                mainTextBox.SelectionColor = Color.Black;
            }
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void headTagPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            headTagPanelToolStripMenuItem.Checked = !headTagPanelToolStripMenuItem.Checked;
            headToolStrip.Visible = headTagPanelToolStripMenuItem.Checked;
            Settings.Instance.HeadTagPanelVisible = headTagPanelToolStripMenuItem.Checked;
        }

        private void commonTagPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commonTagPanelToolStripMenuItem.Checked = !commonTagPanelToolStripMenuItem.Checked;
            textStrip.Visible = commonTagPanelToolStripMenuItem.Checked;
            Settings.Instance.CommonTagPanelVisible = commonTagPanelToolStripMenuItem.Checked;
        }

        private void tableAndListPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableAndListPanelToolStripMenuItem.Checked = !tableAndListPanelToolStripMenuItem.Checked;
            tablesAndListsToolStrip.Visible = tableAndListPanelToolStripMenuItem.Checked;
            Settings.Instance.TableAndListTagPanelVisible  = tableAndListPanelToolStripMenuItem.Checked;
        }

        private void specialSymbolsPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            specialSymbolsPanelToolStripMenuItem.Checked = !specialSymbolsPanelToolStripMenuItem.Checked;
            specSymbolsToolStrip.Visible = specialSymbolsPanelToolStripMenuItem.Checked;
            Settings.Instance.SpecialSymbolsTagPanelVisible = specialSymbolsPanelToolStripMenuItem.Checked;
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Visible)
            {
                try
                {
                    saveToolStripButton_Click(sender, e);
                    Process.Start(fileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "File cannot be previewed");
                }
            }
        }


    }
}





       