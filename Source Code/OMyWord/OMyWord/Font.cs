#region Namespaces Used
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

#region Documentation

/* Author           :       Charl Roesch
 * Date             :       29/08/2019
 * Description      :       The Fonts class is used to store all Font related functions that manipulates the string text 
 *                          of the RichTextBox on the main form. Because the Fonts class will not be instantiated to create
 *                          new objects the class will be created as a static class. Methods will also perform the same 
 *                          functions repeatedly.
 *                          
 *Class Composition :       Variables:
 *                                      - fontBold (FontStyle)
 *                                      - fontItalic (FontStyle)
 *                                      - fontUnLine (FontStyle)
 *                                      - sButtonColour (Color)
 *                                      - fontName (string)
 *                                      - fontSize (float)
 *                                  
 *                          Properties:       
 *                                      - ButtonColor (Color)
 *                                      
 *                          Functions:
 *                                      - SetTextColor()
 *                                      - SetBackColor()
 *                                      - SetFontName()
 *                                      - SetBIU()
 *                                      - SetUpLow()               
 */

#endregion

namespace OMyWord
{
    public static class Fonts
    {

#region Variable Declaration 
        //Variables Declared for Fonts Class

        private static FontStyle fontBold = FontStyle.Regular;
        private static FontStyle fontItalic = FontStyle.Regular;
        private static FontStyle fontUnLine = FontStyle.Regular;
        private static Color sButtonColour = Color.White;
        private static string fontName = "Microsoft Sans Serif";
        private static float fontSize = 8;
#endregion

#region Properties
        //Properties

        public static Color ButtonColor
        {
            get
            {
                return sButtonColour;
            }

        }
        #endregion

#region Methods

        #region SetBackColor()
        /*   Summary:
         *   SetTextColor Method is used to set the RichTextBox text colour 
         *   based on the colour selection on the colorDialog.
         *
         *   Returns:
         *   No return. 
         */

        public static void SetTextColor(this RichTextBox rtxtBox1)
        {
            if (rtxtBox1.Text.Length <= 0)
            {
                Messages.MsgBox(1);
            }

            ColorDialog clrTextDialog = new ColorDialog();
            clrTextDialog.ShowDialog();

            if (rtxtBox1.SelectionLength > 0)
            {
                rtxtBox1.SelectionColor = clrTextDialog.Color;
            }
            else
            {
                rtxtBox1.ForeColor = clrTextDialog.Color;
            }

            sButtonColour = clrTextDialog.Color;

        }
        #endregion

        #region SetBackColor()
        /*   Summary:
         *   SetBackColor Method is used to set the RichTextBox background colour 
         *   based on the colour selection on the colorDialog.
         *
         *   Returns:
         *   No return. 
         */

        public static void SetBackColor(this RichTextBox rtxtBox1)
        {
            ColorDialog clrTextDialog = new ColorDialog();
            clrTextDialog.ShowDialog();

            rtxtBox1.BackColor = clrTextDialog.Color;
            sButtonColour = clrTextDialog.Color;
        }
        #endregion

        #region SetFontName()
        /*   Summary:
         *   SetFontName Method is used to set the RichTextBox text Font Name and Size
         *   based on the selections made on the fontDialog.
         *
         *   Returns:
         *   No return. 
         */

        public static void SetFontName(this RichTextBox rtxtBox1)
        {
            if (rtxtBox1.Text.Length <= 0)
            {
                Messages.MsgBox(1);
            }

            FontDialog fntTextDialog = new FontDialog();
            fntTextDialog.ShowDialog();

            fontName = fntTextDialog.Font.Name;
            fontSize = fntTextDialog.Font.Size;

            if (rtxtBox1.SelectedText.Length > 0)
            {
                rtxtBox1.SelectionFont = new Font(fontName, fontSize, fontBold | fontItalic | fontUnLine);
            }
            else
            {
                rtxtBox1.Font = new Font(fontName, fontSize, fontBold | fontItalic | fontUnLine);
            }
            
        }
        #endregion

        #region SetBIU()
        /*   Summary:
         *   SetBIU Method is used to set the RichTextBox text Font style, Bond, Italic or Underlined 
         *   based on the corresponding three check boxes in the Font Toolstrip.
         *
         *   Returns:
         *   No return. 
         */

        public static void SetBIU(this RichTextBox rtxtBox1, bool tsbtnBold, bool tsbtnItalic, bool tsbtnULine)
        {
            if (rtxtBox1.Text.Length <= 0)
            {
                Messages.MsgBox(1);
            }

            fontBold = tsbtnBold == true ? FontStyle.Bold : FontStyle.Regular;
            fontItalic = tsbtnItalic == true ? FontStyle.Italic : FontStyle.Regular;
            fontUnLine = tsbtnULine == true ? FontStyle.Underline : FontStyle.Regular;

            rtxtBox1.SelectionFont = new Font(fontName, fontSize, fontBold | fontItalic | fontUnLine);

        }
        #endregion

        #region SetUpLow()
        /*   Summary:
         *   SetUpLow Method is used to set the RichTextBox text to Upper or Lowercase for
         *   either the selection or the entire RichTextBox. And is triggered by the Upper
         *   and Lower buttons on the Font ToolStrip. 
         *      
         *   Returns:
         *   No return. 
         */

        public static void SetUpLow(this RichTextBox rtxtBox1, int caseUpLow)
        {
            if (rtxtBox1.Text.Length <= 0)
            {
                Messages.MsgBox(1);
            }

            if (rtxtBox1.SelectedText.Length > 0)
            {
                if (caseUpLow == 0)
                {
                    rtxtBox1.SelectedText = rtxtBox1.SelectedText.ToUpper();
                }
                else
                {
                    rtxtBox1.SelectedText = rtxtBox1.SelectedText.ToLower();
                }
            }
            else
            {
                if (caseUpLow == 0)
                {
                    rtxtBox1.Text = rtxtBox1.Text.ToUpper();
                }
                else
                {
                    rtxtBox1.Text = rtxtBox1.Text.ToLower();
                }
            }
            
        }
        #endregion

#endregion

    }
}
