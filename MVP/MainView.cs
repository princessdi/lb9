namespace MVP
{
    public partial class MainView : Form, IPyramidView
    {
        private PyramidPresenter presenter;

        public MainView()
        {
            InitializeComponent();
            presenter = new PyramidPresenter(this, new Pyramid(1, 1));
        }

        public void SetArea(double area)
        {
            textBox3.Text = area.ToString();
        }

        public void SetVolume(double volume)
        {
            textBox4.Text = volume.ToString();
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

            presenter.SetPyramidData(side, height);
        }
    }
}