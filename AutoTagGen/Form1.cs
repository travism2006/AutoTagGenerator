using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTagGen
{
    public partial class autoTagGenForm : Form
    {
        public autoTagGenForm()
        {
            InitializeComponent();
        }

        private void exitClicked(object sender, EventArgs e)
        {
            autoTagGenForm.ActiveForm.Close();
        }

        private void resetParagraphTags(object sender, EventArgs e)
        {
            idParagraphTextField.Text = "";
            classParagraphTextField.Text = "";
            styleParagraphTextField.Text = "";
            paragraphTagContentTextField.ResetText();
            outputParagraphTextField.ResetText();
        }

        private void resetHTML_Bttn_Clicked(object sender, EventArgs e)
        {
            outputHTML_TextField.ResetText();
        }

        private void getHTML_Tag_Bttn_Clicked(object sender, EventArgs e)
        {
            if(!outputHTML_TextField.Text.Contains("<html xmlns=\"http://www.w3.org/1999/xhtml\">\n"+"\n\t"+"\n" + "\n</html>") )
            {
                outputHTML_TextField.AppendText("<html xmlns=\"http://www.w3.org/1999/xhtml\">\n");
                outputHTML_TextField.AppendText("\n\t");
                outputHTML_TextField.AppendText("\n");
                outputHTML_TextField.AppendText("\n</html>\n");
            }
        }

        private void checkPressEnter(object sender, KeyPressEventArgs e)
        {
            string keyEntered = "\n", tabSpace = "    ";
            string htmlTagInterpretted = autoCompleteTextField.Text.ToUpper();
            string[] htmlTagList =
                {"html", "div", "body", "font", 
                 "a", "table", "tr", "td", "th",
                 "p", "meta", "title", "head",
                 "h1", "h2", "h3", "h4","h5",
                 "h6", "caption", "br", "hr",
                 "b", "big", "i", "img", "li",
                "ul", "ol", "span", "style",
                "sup", "sub"};
        }

        private void getBodyTagsBttnClicked(object sender, EventArgs e)
        {
            outputBodyTagsTextField.ResetText();
            outputBodyTagsTextField.AppendText("<body >\n");
            outputBodyTagsTextField.AppendText("\n\t");
            outputBodyTagsTextField.AppendText(bodyContentBetweenTagsTextField.Text + "\n");
            outputBodyTagsTextField.AppendText("\n</body>\n");
        }

        private void getParagraphTagsBttnClicked(object sender, EventArgs e)
        {
            #region
            if (idParagraphTextField.Text.Length > 0)
            {
                outputParagraphTextField.ResetText();
                outputParagraphTextField.AppendText("<p id=\"" + idParagraphTextField.Text + "\">\n");
                outputParagraphTextField.AppendText("\n\t");
                outputParagraphTextField.AppendText(paragraphTagContentTextField.Text + "\n");
                outputParagraphTextField.AppendText("\n</p>");
            }
            else if (styleParagraphTextField.Text.Length > 0)
            {
                outputParagraphTextField.ResetText();
                outputParagraphTextField.AppendText("<p style=\"" + styleParagraphTextField.Text + "\">\n");
                outputParagraphTextField.AppendText("\n\t");
                outputParagraphTextField.AppendText(paragraphTagContentTextField.Text + "\n");
                outputParagraphTextField.AppendText("\n</p>");

            }
            else if (classParagraphTextField.Text.Length > 0)
            {
                outputParagraphTextField.ResetText();
                outputParagraphTextField.AppendText("<p class=\"" + classParagraphTextField.Text + "\">\n");
                outputParagraphTextField.AppendText("\n\t");
                outputParagraphTextField.AppendText(paragraphTagContentTextField.Text + "\n");
                outputParagraphTextField.AppendText("\n</p>");
            }
            else if (idParagraphTextField.Text.Length == 0 && styleParagraphTextField.Text.Length == 0 && classParagraphTextField.Text.Length == 0)
            {
                outputParagraphTextField.ResetText();
                outputParagraphTextField.AppendText("<p >\n");
                outputParagraphTextField.AppendText("\n\t");
                outputParagraphTextField.AppendText(paragraphTagContentTextField.Text + "\n");
                outputParagraphTextField.AppendText("\n</p>");
            }
            #endregion

            //sub section 1
            #region
            if (idParagraphTextField.Text.Length > 0 && styleParagraphTextField.Text.Length > 0
                        && classParagraphTextField.Text.Length > 0)
            {
                outputParagraphTextField.ResetText();
                outputParagraphTextField.AppendText("<p id=\"" + idParagraphTextField.Text + "\" " + "class=\"" + classParagraphTextField.Text + "\" style=\"" + styleParagraphTextField.Text + "\">\n");
                outputParagraphTextField.AppendText("\n\t");
                outputParagraphTextField.AppendText(paragraphTagContentTextField.Text + "\n");
                outputParagraphTextField.AppendText("\n</p>");
            }
            else if (idParagraphTextField.Text.Length > 0 && styleParagraphTextField.Text.Length > 0)
            {
                outputParagraphTextField.ResetText();
                outputParagraphTextField.AppendText("<p id=\"" + idParagraphTextField.Text + "\" style=\"" + styleParagraphTextField.Text + "\">\n");
                outputParagraphTextField.AppendText("\n\t");
                outputParagraphTextField.AppendText(paragraphTagContentTextField.Text + "\n");
                outputParagraphTextField.AppendText("\n</p>");
            }
            else if (idParagraphTextField.Text.Length > 0 && classParagraphTextField.Text.Length > 0)
            {
                outputParagraphTextField.ResetText();
                outputParagraphTextField.AppendText("<p id=\"" + idParagraphTextField.Text + "\" class=\"" + classParagraphTextField.Text + "\">\n");
                outputParagraphTextField.AppendText("\n\t");
                outputParagraphTextField.AppendText(paragraphTagContentTextField.Text + "\n");
                outputParagraphTextField.AppendText("\n</p>");
            }
            else if (styleParagraphTextField.Text.Length > 0 && classParagraphTextField.Text.Length > 0)
            {
                outputParagraphTextField.ResetText();
                outputParagraphTextField.AppendText("<p class=\"" + classParagraphTextField.Text + "\" style=\"" + styleParagraphTextField.Text + "\">\n");
                outputParagraphTextField.AppendText("\n\t");
                outputParagraphTextField.AppendText(paragraphTagContentTextField.Text + "\n");
                outputParagraphTextField.AppendText("\n</p>");
            }
            #endregion
        }
    }
}
