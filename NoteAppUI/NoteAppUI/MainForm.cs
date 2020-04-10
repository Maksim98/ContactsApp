using NoteApp;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NoteAppUI
{
    /// <summary>
    /// Main application form.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Private fields

        /// <summary>
        /// Contact data.
        /// </summary>
        private Project _project;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InfoContact.ReadOnly = true;
            _project = new Project();
            ContactsListBox.Items.Clear();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Opening the window "About".
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Adding a new contact.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void AddContact(object sender, EventArgs e)
        {
            var secondaryForm = new SecondaryForm();
            secondaryForm.Contact = new Contact();

            var dialogResult = secondaryForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var newContact = secondaryForm.Contact;

                _project.Contacts.Add(newContact);
                ContactsListBox.Items.Add(newContact.Surame);
                var index = _project.Contacts.Count - 1;
                ContactsListBox.SetSelected(index, true);
            }
        }

        /// <summary>
        /// Loading data from a file every time you start the application.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            _project = new Project();
            UpdateContactsListBox(_project);
            if (_project.Contacts.Count >= 1)
            {
                ContactsListBox.SetSelected(0, true);
            }
        }

        /// <summary>
        /// Contact list update.
        /// </summary>
        /// <param name="project">Contact list.</param>
        private void UpdateContactsListBox(Project project)
        {
            ContactsListBox.Items.Clear();
            foreach (var contact in project.Contacts)
            {
                ContactsListBox.Items.Add(contact.Surame);
            }

            ManagerProject.SaveToFile(_project);
        }

        /// <summary>
        /// The action that occurs before each closure of this form.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerProject.SaveToFile(_project);
        }


        /// <summary>
        /// Display the selected contact.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            if (index >= 0)
            {
                InfoContact.CurrentContact = _project.Contacts[index];
            }
        }

        /// <summary>
        /// Validation the entered string for a match in the ContactsListBox.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void FindTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (FindTextBox.Text != "")
            {
                var founded = new Project();

                foreach (var contact in _project.Contacts)
                {
                    if (contact.Surame.Contains(FindTextBox.Text))
                    {
                        founded.Contacts.Add(contact);
                    }
                }

                UpdateContactsListBox(founded);
            }
            else
            {
                UpdateContactsListBox(_project);
            }
        }

        /// <summary>
        /// Validation the entered symbol.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void FindTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' || e.KeyChar == (char)Keys.Back ||
                char.ToLower(e.KeyChar) >= 'а' && char.ToLower(e.KeyChar) <= 'я')
            {
                if (FindTextBox.Text.Length == 0 || FindTextBox.Text.EndsWith("-"))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
                else
                {
                    e.KeyChar = char.ToLower(e.KeyChar);
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Edit the selected contact.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void EditContact(object sender, EventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            var secondaryForm = new SecondaryForm();
            var current = _project.Contacts[index];
            secondaryForm.Contact = current;
            var dialogResult = secondaryForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var newContact = secondaryForm.Contact;
                _project.Contacts.RemoveAt(index);
                _project.Contacts.Insert(index, newContact);
                UpdateContactsListBox(_project);
                ContactsListBox.SetSelected(index, true);
            }
        }

        /// <summary>
        /// Edit the selected contact.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void ContactsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            var secondaryForm = new SecondaryForm();
            var current = _project.Contacts[index];
            secondaryForm.Contact = current;
            var dialogResult = secondaryForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var newContact = secondaryForm.Contact;
                _project.Contacts.RemoveAt(index);
                _project.Contacts.Insert(index, newContact);
                UpdateContactsListBox(_project);
                ContactsListBox.SetSelected(index, true);
            }
        }

        /// <summary>
        /// Removing the selected contact.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void RemoveContact(object sender, EventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            var result = MessageBox.Show(
                @"Do you really want to remove this contact : " +
                _project.Contacts[index].Surame + " ?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ContactsListBox.Items.RemoveAt(index);
                _project.Contacts.RemoveAt(index);
                ManagerProject.SaveToFile(_project);
                if (_project.Contacts.Count >= 1)
                {
                    ContactsListBox.SetSelected(0, true);
                }
                else
                {
                    InfoContact.CurrentContact = null;
                }
            }
        }

        /// <summary>
        /// Closing the application.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
