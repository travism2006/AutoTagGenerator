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
        //for ease:
        //      autoCompleteTextField.AppendText("-reset  tab page\n");

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

            autoCompleteTextField.AppendText("-reset paragraph tab page\n");
        }

        private void resetHTML_Bttn_Clicked(object sender, EventArgs e)
        {
            outputHTML_TextField.ResetText();

            autoCompleteTextField.AppendText("-reset HTML tab page\n");
        }

        private void getHTML_Tag_Bttn_Clicked(object sender, EventArgs e)
        {
            if(!outputHTML_TextField.Text.Contains("<html xmlns=\"http://www.w3.org/1999/xhtml\">\n"+"\n\t"+"\n" + "\n</html>") )
            {
                outputHTML_TextField.AppendText("<html xmlns=\"http://www.w3.org/1999/xhtml\">\n");
                outputHTML_TextField.AppendText("\n\t");
                outputHTML_TextField.AppendText("\n");
                outputHTML_TextField.AppendText("\n</html>\n");

                autoCompleteTextField.AppendText("<html xmlns=\"http://www.w3.org/1999/xhtml\">\n\t\n</html>\n");
            }
        }

        private void getBodyTagsBttnClicked(object sender, EventArgs e)
        {
            outputBodyTagsTextField.ResetText();
            outputBodyTagsTextField.AppendText("<body >\n");
            outputBodyTagsTextField.AppendText("\n\t");
            outputBodyTagsTextField.AppendText(bodyContentBetweenTagsTextField.Text + "\n");
            outputBodyTagsTextField.AppendText("\n</body>\n");

            autoCompleteTextField.AppendText("<body >\n\t\n</body>\n");
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

        private void resetBodyTagsBttnClicked(object sender, EventArgs e)
        {
            bodyStyleTextField.Text = "";

            autoCompleteTextField.AppendText("-reset body tab page\n");
        }

        private void get_a_TagsBttnClicked(object sender, EventArgs e)
        {
            string href_a_Value = href_a_TextField.Text,
                   title_a_Value = title_a_TextField.Text,
                   target_a_Value = target_a_TextField.Text,
                   dir_a_Value = dir_a_TextField.Text,
                   style_a_Value = style_a_TextField.Text,
                   id_a_Value = id_a_TextField.Text,
                   type_a_Value = type_a_TextField.Text,
                   class_a_Value = class_a_TextField.Text;

            #region
            //href
            if(href_a_Value.Length > 0)
            {
                output_a_TextField.ResetText();
                output_a_TextField.AppendText("<a href=\"" + href_a_Value + "\">\n\n\t\n</a>");
            }
            else if(title_a_Value.Length > 0)   //title
            {
                output_a_TextField.ResetText();
                output_a_TextField.AppendText("<a title=\"" + title_a_Value + "\">\n\n\t\n</a>");
            }
            else if (target_a_Value.Length > 0)     //target
            {
                output_a_TextField.ResetText();
                output_a_TextField.AppendText("<a target=\"" + target_a_Value + "\">\n\n\t\n</a>");
            }
            else if (dir_a_Value.Equals("ltr"))     //dir=='ltr'
            {
                output_a_TextField.ResetText();
                output_a_TextField.AppendText("<a dir=\"ltr\">\n\n\t\n</a>");
            }
            else if (dir_a_Value.Equals("rtl"))     //dir2=='rtl'
            {
                output_a_TextField.ResetText();
                output_a_TextField.AppendText("<a dir=\"rtl\">\n\n\t\n</a>");
            }
            else if (style_a_Value.Length > 0)     //style
            {
                output_a_TextField.ResetText();
                output_a_TextField.AppendText("<a style=\"" + style_a_Value + "\">\n\n\t\n</a>");
            }
            else if (id_a_Value.Length > 0)     //id
            {
                output_a_TextField.ResetText();
                output_a_TextField.AppendText("<a id=\"" + id_a_Value + "\">\n\n\t\n</a>");
            }
            else if (type_a_Value.Length > 0)     //type
            {
                output_a_TextField.ResetText();
                output_a_TextField.AppendText("<a type=\"" + type_a_Value + "\">\n\n\t\n</a>");
            }
            else if (class_a_Value.Length > 0)     //class
            {
                output_a_TextField.ResetText();
                output_a_TextField.AppendText("<a class=\"" + class_a_Value + "\">\n\n\t\n</a>");
            }
            else if(href_a_Value.Length > 0 && title_a_Value.Length > 0)    //all empty!
            {
                output_a_TextField.ResetText();
                output_a_TextField.AppendText("<a>\n\n\t\n</a>");
            #endregion
            }
        }
    }
}
