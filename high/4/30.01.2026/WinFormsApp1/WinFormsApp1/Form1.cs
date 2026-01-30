namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RegisterSlider(sliderR);
            RegisterSlider(sliderG);
            RegisterSlider(sliderB);
        }

        void RegisterSlider(TrackBar slider)
        {
            slider.ValueChanged += new EventHandler((object? sender, EventArgs e) => UpdateColor());
        }

        void UpdateColor()
        {
            int r = sliderR.Value;
            int g = sliderG.Value;
            int b = sliderB.Value;

            valueR.Text = r.ToString();
            valueG.Text = g.ToString();
            valueB.Text = b.ToString();

            colorPanel.BackColor = Color.FromArgb(r, g, b);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            int r = sliderR.Value;
            int g = sliderG.Value;
            int b = sliderB.Value;

            colorText.Text = $"{r}, {g}, {b}";
            colorText.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
