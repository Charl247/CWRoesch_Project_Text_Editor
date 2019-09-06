#region Namespaces Used
using System;
using System.Collections;
using System.Windows.Forms;
#endregion

#region Documentation

/* Author           :       Charl Roesch
 * Date             :       29/08/2019
 * Description      :       The WordLibrary class is used to build and update the ComboBox in the Word Library Toolstrip.
 *                          This class will also add words selected from the ComboBox to the RichTextBox text.
 *                          
 *Class Composition :       Variables:
 *                                  
 *                          Properties:       
 *                                      
 *                          Functions:
 *                                      - WordLib()
 *                                      - AddWord()             
 */

#endregion

namespace OMyWord
{
    static class WordLibrary
    {

#region Methods

        #region WordLib()
        /*   Summary:
         *   ArrayList Declaration - The ArrayList alEordLib stores the words entered by the user in an
         *   ArrayList for the duration of the programs life span.
         */

        static ArrayList alWordLib = new ArrayList();        
           
        /*   Summary:
         *   The WordLib() method is used to update the ArrayList as well as setting the Items in the ComboBox.
         *   
         *   Returns:
         *   No return. 
         */

        public static void WordLib(this ToolStripComboBox tscBoxLib)
        {
            if (alWordLib.Contains(tscBoxLib.Text))
            {
                Messages.MsgBox(4);
            }
            else
            {
                alWordLib.Add(tscBoxLib.Text);
            }

            tscBoxLib.Text = "";
            tscBoxLib.Items.Clear();

            foreach(string item in alWordLib)
            {
                tscBoxLib.Items.Add(item);
            }

        }
        #endregion

        #region AddWord()

        /*   Summary:
         *   The AddWord() method adds the item selected from the ComboBox items to the RichTextBox Text.
         *   
         *   Returns:
         *   No return. 
         */

        public static void AddWord(this ToolStripComboBox tscBoxLib, RichTextBox rtxtBox1)
        {

            Clipboard.SetText(tscBoxLib.Text);
            rtxtBox1.Paste();

            //rtxtBox1.Text = rtxtBox1.Text + tscBoxLib.Text; -- Paste used to prevent emoticons from being overidden by setting the RichTextBox text.
        }

        #endregion

#endregion

    }
}
