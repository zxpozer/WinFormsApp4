namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // ������� ������ ���������
            g.FillRectangle(Brushes.Gray, 50, 50, 80, 200);

            // ������� ������� �����
            g.FillEllipse(Brushes.Red, 70, 60, 40, 40);

            // ������� ����� �����
            g.FillEllipse(Brushes.Yellow, 70, 120, 40, 40);

            // ������� ������ �����
            g.FillEllipse(Brushes.Green, 70, 180, 40, 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  // ������� ��������
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������: ����\n��'�: ������\n�����: ��-21\n������: 3", "��� ��������");
        }
    }
}
