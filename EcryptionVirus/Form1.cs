using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace EcryptionVirus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    FileStream file = new FileStream(fileDialog.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    byte[] Old = new byte[file.Length];
                    file.Read(Old, 0, Old.Length);
                     byte[] vs =  Old.Reverse().ToList().ToArray();
                    file.Position = 0;
                    file.Write(vs, 0, Old.Length);
                  
                    file.Close();

                    
                   

                }
            }
            

           
        }
    }
}
