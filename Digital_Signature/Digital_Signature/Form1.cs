using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;

namespace Digital_Signature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool IsSigned(string filepath)
        {
            var runspaceConfiguration = RunspaceConfiguration.Create();
            using (var runspace = RunspaceFactory.CreateRunspace(runspaceConfiguration))
            {
                runspace.Open();
                using (var pipeline = runspace.CreatePipeline())
                {
                    pipeline.Commands.AddScript("Get-AuthenticodeSignature \"" + filepath + "\"");
                    var results = pipeline.Invoke();
                    runspace.Close();

                    var signature = results[0].BaseObject as Signature;
                    return signature == null || signature.SignerCertificate == null ?
                           false : (signature.Status != SignatureStatus.NotSigned);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
