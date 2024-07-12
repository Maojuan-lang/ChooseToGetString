namespace ChooseToGetString
{
    public partial class Form1 : Form
    {
        // your button
        String[] strings = {"dog1","dog2","dog3","dog4", "dog5", "dog6" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Panel panel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            this.Controls.Add(panel);

            int numberOfRadioButtons = strings.Length;
            // button height
            int radioButtonHeight = 50;
            // button margin
            int margin = 10;

            for (int i = 0; i < numberOfRadioButtons; i++)
            {
                RadioButton radioButton = new RadioButton
                {
                    Text = strings[i],
                    Location = new System.Drawing.Point(10, i * (radioButtonHeight + margin)),
                    AutoSize = true
                };
                radioButton.Font = new Font(radioButton.Font.FontFamily, 15, radioButton.Font.Style);
                radioButton.CheckedChanged += textBox1_TextChanged;
                panel1.Controls.Add(radioButton);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                label1.Text = "";
                // additive button string
                textBox1.Text = "My name is " + radioButton.Text;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                Clipboard.SetText(textBox1.Text);
                // copy successfully
                label1.Text = "复制成功";
            }
            else
            {
                // please to choose the button firstly
                label1.Text = "请先选择按钮";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
