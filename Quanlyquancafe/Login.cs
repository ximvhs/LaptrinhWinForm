namespace Quanlyquancafe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            TableManager f = new TableManager();
            this.Hide();        //xuất hiện tablleManager xong ẩn tableLogin đi 
            f.ShowDialog();     //xuất hiện tableManager
            this.Show();        //Nếu tắt tableManager thì hiện lại tableLogin
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Khi nhấn thoát hoặc nhấn dấu x thì nó sẽ hiện ra cửa xổ thông báo mình có chắc chắn muốn thoát hay ko
            if(MessageBox.Show("Bạn có muốn thoát không!", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}