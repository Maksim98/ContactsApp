using NoteApp;

using System;
using System.Windows.Forms;

namespace NoteAppUI
{
    /// <summary>
    /// Form for editing and adding notes.
    /// </summary>
    public partial class SecondaryForm : Form
    {
        #region Properties

        /// <summary>
        /// Gets or sets contact's data.
        /// </summary>
        public Contact Contact
        {
            get => ContactControl.CurrentContact;
            set => ContactControl.CurrentContact = value;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public SecondaryForm()
        {
            InitializeComponent();
            ContactControl.ReadOnly = false;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Action when pressing the 'OK' button.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!ContactControl.IsCorrectContact)
            {
                MessageBox.Show("Not all fields are entered correctly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ((Form)TopLevelControl).DialogResult = DialogResult.OK;
            ((Form)TopLevelControl)?.Close();
        }

        /// <summary>
        /// Action when pressing the ' Cancel ' button.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).DialogResult = DialogResult.Cancel;
            ((Form)TopLevelControl)?.Close();
        }

        #endregion
    }
}
