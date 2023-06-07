namespace MVC
{
    public partial class MainView : Form
    {
        private PyramidController controller;

        public MainView()
        {
            InitializeComponent();
            controller = new PyramidController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out var side) || side < 0)
            {
                MessageBox.Show("Помилка при обробці даних!");
                return;
            }

            if (!double.TryParse(textBox2.Text, out var height) || height < 0)
            {
                MessageBox.Show("Помилка при обробці даних!");
                return;
            }

            var area = controller.Area(side, height);
            var volume = controller.Volume(side, height);

            textBox3.Text = area.ToString();
            textBox4.Text = volume.ToString();
        }
    }
}