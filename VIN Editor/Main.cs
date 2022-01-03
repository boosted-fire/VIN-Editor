namespace VIN_Editor
{
    public partial class Main : Form
    {
        string serial_output;
        string vin_output;
        //string filePath = @"C:\Users\ebjer\OneDrive\Documents\S10.bin";
        string filePath = string.Empty;

        //serial number location
        const int SERIAL_START_LOC = 16392;
        const int SERIAL_NUM_LEN = 12;

        //vin number location
        const int VIN_START_LOC = 16417;
        const int VIN_NUM_LEN = 17;

        public Main()
        {
            InitializeComponent();
        }

        private void read_Click(object sender, EventArgs e)
        {            
            serial_output = String.Empty;
            vin_output = String.Empty;
            
            using (BinaryReader bin = new BinaryReader(File.Open(filePath,
                                                          FileMode.Open)))
            {  
                //read serial number
                bin.BaseStream.Seek(SERIAL_START_LOC, SeekOrigin.Begin);
                for (int i = 0; i < SERIAL_NUM_LEN; i++)
                {
                    serial_output += bin.ReadByte().ToString("X");
                }

                //read vin number
                bin.BaseStream.Seek(VIN_START_LOC, SeekOrigin.Begin);                
                for(int i = 0; i < VIN_NUM_LEN; i++)
                {
                    vin_output += bin.ReadByte().ToString("X");                    
                }
                
                //write results to text boxes
                serialNumTextBox.Text = HexConverter.hexToASCII(serial_output);
                vinNumTextBox.Text = HexConverter.hexToASCII(vin_output);
            }
            Log("Read completed.");
        }

        private void openBinBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    fileLabel.Text = filePath;                    
                }
                if (File.Exists(filePath))
                {
                    readBtn.Enabled = true;
                    writeBtn.Enabled = true;
                    calcChecksum.Enabled = true;
                }
            }
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            VinValidator vin = new VinValidator(vinNumTextBox.Text);
            if (vin.isValid)
            {
                WriteVINNumber();
            }                
            else
            {
                Log("VIN number entered is invalid.");
                Log("VIN number was not written.");
            }            
            
            if(serialNumTextBox.Text.Length == SERIAL_NUM_LEN)
            {
                WriteSerialNumber();
            }
            else
            {
                Log("Serial number is not 12 characters in length.");
                Log("Serial number was not written.");
            }                
        }

        private void WriteSerialNumber()
        {
            char[] c = serialNumTextBox.Text.ToCharArray();
            byte[] bin = new byte[SERIAL_NUM_LEN];

            //convert each serial number character to a byte
            for (int i = 0; i < SERIAL_NUM_LEN; i++)
            {
                bin[i] = Convert.ToByte(c[i]);
            }

            BinaryWriter bw = new BinaryWriter(File.OpenWrite(filePath));
            bw.Seek(SERIAL_START_LOC, SeekOrigin.Begin);
            bw.Write(bin);
            bw.Dispose();

            Log("Serial number written.");
        }

        private void WriteVINNumber()
        {
            char[] c = vinNumTextBox.Text.ToCharArray();
            byte[] bin = new byte[VIN_NUM_LEN];

            for (int i = 0; i < VIN_NUM_LEN; i++)
            {
                bin[i] = Convert.ToByte(c[i]);
            }

            BinaryWriter bw = new BinaryWriter(File.OpenWrite(filePath));
            bw.Seek(VIN_START_LOC, SeekOrigin.Begin);
            bw.Write(bin);
            bw.Dispose();

            Log("VIN number written.");
        }

        public void Log(String text)
        {
            DateTime time = DateTime.Now;
            logTextBox.AppendText(time.ToString("T") + ": " + text);
            logTextBox.AppendText(Environment.NewLine);
        }

        private void calcChecksum_Click(object sender, EventArgs e)
        {
            byte[] readBytes = File.ReadAllBytes(filePath);
            var binFile = new PcmHacking.FileValidator(readBytes);
            if (binFile.IsValid())
            {
                Log("File checksums are valid.");
            }
            else
            {
                Log("WARNING!! CHECKSUMS ARE INVALID!!");
            }
        }
    }
}