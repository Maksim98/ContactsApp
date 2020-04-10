using System;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    /// <summary>
    /// Создание формы ContactForm
    /// </summary>
    public partial class ContactForm : Form
    {
        private Contact _contact;

        /// <summary>
        /// Поле с классом контакта
        /// </summary>
        public Contact Contact { get { return _contact; } set { _contact = value; } }
        public ContactForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Действия при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactForm_Load(object sender, EventArgs e)
        {
            if (Contact == null)
            {
                Contact = new Contact();
            }
            else
            {
                PhoneTextBox.Text = Contact.Phone.Number.ToString();
                SurnameTextBox.Text = Contact.Surname;
                NameTextBox.Text = Contact.Name;
                BirthdayDateTimePicker.Value = Contact.BirthDay;
                EmailTextBox.Text = Contact.Email;
                VkTextBox.Text = Contact.VkId;

            }
        }

        /// <summary>
        /// Закрытие формы при нажатии Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Обработчик исключений и присваивание при нажатии кнопки Ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                Contact.Surname = SurnameTextBox.Text;
                Contact.Name = NameTextBox.Text;
                Contact.BirthDay = BirthdayDateTimePicker.Value;
                Contact.Phone.Number = long.Parse(PhoneTextBox.Text);
                Contact.Email = EmailTextBox.Text;
                Contact.VkId = VkTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
