using NoteApp;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NoteAppUI
{
    /// <summary>
    /// Control for viewing and editing notes.
    /// </summary>
    public partial class ContactControl : UserControl
    {
        #region Private fields

        /// <summary>
        /// Current contact's data.
        /// </summary>
        private Contact _currentContact;

        /// <summary>
        /// The correctness of the entered contact's data.
        /// </summary>
        private bool _isCorrectContact = true;

        /// <summary>
        /// Contact's phone number.
        /// </summary>
        private long _number;

        #endregion

        #region Properties

        /// <summary>
        /// Control mode.
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                SurameTextBox.ReadOnly = value;
                NameTextBox.ReadOnly = value;
                BirthdayDateTime.Enabled = !value;
                PhoneMaskedTextBox.ReadOnly = value;
                EmailTextBox.ReadOnly = value;
                IdTextBox.ReadOnly = value;
                ToolTip.Active = !value;
            }
        }

        /// <summary>
        /// Gets or sets the correctness of the entered contact's data.
        /// </summary>
        public bool IsCorrectContact
        {
            get
            {
                UpdateContact();
                return _isCorrectContact;
            }
            private set => _isCorrectContact = value;
        }

        /// <summary>
        /// Gets or sets current contact's data.
        /// </summary>
        public Contact CurrentContact
        {
            get
            {
                UpdateContact();
                return _currentContact;
            }
            set
            {
                if (value == null)
                {
                    SurameTextBox.Text = "";
                    NameTextBox.Text = "";
                    BirthdayDateTime.Value = DateTime.Today;
                    PhoneMaskedTextBox.ResetText();
                    EmailTextBox.Text = "";
                    IdTextBox.Text = "";
                    IsCorrectContact = false;
                }
                else if (value.Name == null)
                {
                    SurameTextBox.Text = "";
                    NameTextBox.Text = "";
                    BirthdayDateTime.Value = DateTime.Today;
                    PhoneMaskedTextBox.ResetText();
                    EmailTextBox.Text = "";
                    IdTextBox.Text = "";
                    IsCorrectContact = false;
                }
                else
                {
                    SurameTextBox.Text = value.Surame;
                    NameTextBox.Text = value.Name;
                    BirthdayDateTime.Value = value.Birthsday;
                    PhoneMaskedTextBox.Text = Convert.ToString(value.Phone.Number).Remove(0, 1);

                    EmailTextBox.Text = value.Email;
                    IdTextBox.Text = value.ID;
                    IsCorrectContact = true;
                    _currentContact = value;
                }
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public ContactControl()
        {
            InitializeComponent();
            BirthdayDateTime.MaxDate = DateTime.Now;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Updating data from a text field to the contact.
        /// </summary>
        private void UpdateContact()
        {
            if (!string.IsNullOrWhiteSpace(SurameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(NameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(EmailTextBox.Text) &&
                IsCorrectPhone(PhoneMaskedTextBox.Text) &&
                !string.IsNullOrWhiteSpace(IdTextBox.Text))
            {
                _currentContact.Surame = SurameTextBox.Text;
                _currentContact.Name = NameTextBox.Text;
                _currentContact.Birthsday = BirthdayDateTime.Value;
                _currentContact.Phone.Number = _number;
                _currentContact.Email = EmailTextBox.Text;
                _currentContact.ID = IdTextBox.Text;

                IsCorrectContact = true;
            }
            else
            {
                IsCorrectContact = false;
            }
        }

        /// <summary>
        /// Event that occurs when you press keys in the text field 'Surame'.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void SurameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' || e.KeyChar == (char)Keys.Back ||
                char.ToLower(e.KeyChar) >= 'а' && char.ToLower(e.KeyChar) <= 'я')
            {
                if (SurameTextBox.Text.Length == 0 || SurameTextBox.Text.EndsWith("-"))
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
        /// Event that occurs when you press keys in the text field 'Name'.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || char.ToLower(e.KeyChar) >= 'а' &&
                char.ToLower(e.KeyChar) <= 'я')
            {
                e.KeyChar = NameTextBox.Text.Length == 0
                    ? char.ToUpper(e.KeyChar)
                    : char.ToLower(e.KeyChar);
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Event that occurs when the 'Phone field is left.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void PhoneMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (!PhoneMaskedTextBox.ReadOnly)
            {
                if (IsCorrectPhone(PhoneMaskedTextBox.Text))
                {
                    PhoneMaskedTextBox.BackColor = Color.White;
                }
                else
                {
                    PhoneMaskedTextBox.BackColor = Color.Red;
                    IsCorrectContact = false;
                }
            }
        }

        /// <summary>
        /// Validation if the entered values are a phone number.
        /// </summary>
        /// <param name="str">Entered string.</param>
        /// <returns>Returns whether the string is a phone number.</returns>
        private bool IsCorrectPhone(string str)
        {
            var pattern = @"\D+";
            var patternPhone = @"79[0-9]{9}";
            var regex = new Regex(pattern);
            var result = regex.Replace(str, "");
            if (Regex.IsMatch(result, patternPhone))
            {
                _number = long.Parse(result);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Event that occurs when you press keys in the text field 'Email'.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == '_' || e.KeyChar == '-' ||
                e.KeyChar == '@' || e.KeyChar == '.' ||
                char.ToLower(e.KeyChar) >= 'a' && char.ToLower(e.KeyChar) <= 'z' ||
                e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.KeyChar = char.ToLower(e.KeyChar);
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Event that occurs when the 'Email' field is left.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (!EmailTextBox.ReadOnly)
            {
                var pattern =
                    "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

                if (!Regex.IsMatch(EmailTextBox.Text, pattern, RegexOptions.IgnoreCase))
                {
                    EmailTextBox.BackColor = Color.Red;
                    IsCorrectContact = false;
                }
                else
                {
                    EmailTextBox.BackColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Event that occurs when you press keys in the text field 'Id'.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '_' || e.KeyChar == (char)Keys.Back ||
                char.ToLower(e.KeyChar) >= 'a' && char.ToLower(e.KeyChar) <= 'z' ||
                e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.KeyChar = char.ToLower(e.KeyChar);
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Event that occurs when a anything field is left.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An argument that stores event information.</param>
        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (!((TextBox)sender).ReadOnly)
            {
                if (((TextBox)sender).Text == "")
                {
                    ((TextBox)sender).BackColor = Color.Red;
                    IsCorrectContact = false;
                }
                else
                {
                    ((TextBox)sender).BackColor = Color.White;
                }
            }
        }

        #endregion
    }
}
