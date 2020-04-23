namespace ZH20200423
{
    public partial class Form1 : Form
    {
        private int height = 100;
        private int width = 100;
        public Form1()
        {
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            InitializeComponent();
        }

        protected override void MouseMove(object sender, MouseEventArgs e){
            if(e.X <= x + width && e.X >= x - width &&  e.Y <= y + height && e.Y >= x - height){
                timer.Stop();
            }
                else{
                    Invalidate();
                }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.R)
            {
               height = 10;
               width = 10;
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            height += new Random().Next(10);
            width += new Random().Next(10);    
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), height, width, 10, 10);
            if (width < 300){
                e.Graphics.DrawString("Bal", this.Font, new SolidBrush(Color.Black), 50, 100);
            } else {
                e.Graphics.DrawString("Jobb", this.Font, new SolidBrush(Color.Black), 50, 100);
            }
            base.OnPaint(e);
        }
    }
}
