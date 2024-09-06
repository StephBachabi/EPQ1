namespace EPQ1
{
    using System.Diagnostics;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Char> AllowedKeys = new List<Char>()
        {  
           '1',
           '2',
           '3',
           '4',
           '5',
           '6',
           '7',
           '8',
           '9',
           '0',
           '(',
           ')',
           '-',
           '=',
           '+',
           '*',
           '^',
           '!',
           'x'
        };
        bool EquationOpen = false;
        bool SampleOpen = false;
        string EquationText = "3x^(2)";
        string SampleNum = "50";
        public TextBox FunctionEquation { get; private set; }
        public TextBox SampleNumber { get; private set; }
        private void FunctionOpener_Click(object sender, EventArgs e)
        {
            if (!EquationOpen)
            {
                TextBox frame = new TextBox();
                frame.Name = "FunctionEquation";
                frame.Location = new System.Drawing.Point(100, 0);
                frame.Size = new System.Drawing.Size(500, 100);
                frame.TextChanged += Equation_TextChanged;
                frame.Text = EquationText;
                this.Controls.Add(frame);
                this.FunctionEquation = frame;
                frame.BringToFront();
                EquationOpen = true;
            }
            else
            {
                EquationText = this.FunctionEquation.Text;
                EquationOpen = false;
                this.FunctionEquation.TextChanged -= Equation_TextChanged;
                this.Controls.Remove(this.FunctionEquation);
                
            }
        }
       
        private void Equation_TextChanged(object sender, EventArgs e)
        {
            if (!EquationOpen) { return; }
            char[] textArray = this.FunctionEquation.Text.ToCharArray();
            int length = this.FunctionEquation.TextLength;
            int i = 0;
            foreach (char v in textArray)
            {
                i += 1;
                if (AllowedKeys.IndexOf(v) == -1)
                {
                    this.FunctionEquation.Text = this.FunctionEquation.Text.Substring(0, i - 1) + this.FunctionEquation.Text.Substring(i);
                }
            }
        }
        private void SampleViewer_Click(object sender, EventArgs e)
        {
            if (!SampleOpen)
            {
                TextBox frame = new TextBox();
                frame.Name = "SampleNumber";
                frame.Location = new System.Drawing.Point(100, 100);
                frame.Size = new System.Drawing.Size(100, 100);
                frame.Text = SampleNum;
                this.Controls.Add(frame);
                frame.TextChanged += Sample_TextChanged;
                this.Controls.Add(frame);
                this.SampleNumber = frame;
                frame.BringToFront();
                SampleOpen = true;
            }
            else
            {
                SampleNum = this.SampleNumber.Text;
                SampleOpen = false;
                this.SampleNumber.TextChanged -= Sample_TextChanged;
                this.Controls.Remove(this.SampleNumber);

            }
        }
        private void Sample_TextChanged(object sender, EventArgs e)
        {
            if (!SampleOpen) { return; }
            char[] textArray = this.SampleNumber.Text.ToCharArray();
            int length = this.SampleNumber.TextLength;
            int i = 0;
            foreach (char v in textArray)
            {
                i += 1;
                if (!Char.IsNumber(v))
                {
                    this.SampleNumber.Text = this.SampleNumber.Text.Substring(0, i - 1) + this.SampleNumber.Text.Substring(i);
                }
            }
        }
    }
}
