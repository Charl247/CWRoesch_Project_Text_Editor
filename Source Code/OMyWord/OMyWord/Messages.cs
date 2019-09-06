#region Namespaces Used
using System.Windows.Forms;
#endregion

#region Documentation

/* Author           :       Charl Roesch
 * Date             :       29/08/2019
 * Description      :       The Message Class is used to store a set of predefined messageboxes with their 
 *                          unique controls which can be reused throughout the program.
 *                          
 *Class Composition :       Variables:
 *                                  
 *                          Properties:       
 *                                      
 *                          Functions:
 *                                      - MsgBox(int msgNum)             
 */

#endregion

namespace OMyWord
{
    public static class Messages
    {

#region Methods

    #region MsgBox()

    /*   Summary:
        *   The MsgBox() method is used to display specified message boxes as specified 
        *   when called through out the program.
        *
        *   Returns:
        *   The method return a DialogResult property which can then be used and applied to
        *   logic in the calling class and method. 
        */

    public static DialogResult MsgBox(int msgNum)
    {

        switch (msgNum)
        {
            case 1:
                MessageBox.Show("There is no text available to modify!", "No Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;
            case 2:
                MessageBox.Show("Document not saved!", "Document not saved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                break;
            case 3:
                DialogResult result = MessageBox.Show("Your document contains text. Would you like to save the current document?"
                                                    , "Save Document"
                                                    , MessageBoxButtons.YesNoCancel
                                                    , MessageBoxIcon.Warning);
                return result;
            case 4:
                MessageBox.Show("This word is already stored in the Word Library!", "Word Library", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;
            case 5:
                MessageBox.Show("About: O My Word" + "\n" + 
                                "Version: v1.0.0 (Official Release)" + "\n" +
                                "Release Date: 04/09/2019" + "\n" +
                                "Discription: Rich Text Editor able to open, edit and save documents.", "About O My Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;

            }
        return 0;
    }
    #endregion

#endregion

    }
}
