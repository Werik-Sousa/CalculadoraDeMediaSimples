using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaDaTurma {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            double nota1, nota2, nota3, media;

            nota1 = double.Parse(textBox1.Text);
            nota2 = double.Parse(textBox2.Text);
            nota3 = double.Parse(textBox3.Text);

            media = (nota1 + nota2 + nota3) / 3;

            label6.Text = Convert.ToString(media);

            if (media > 7) {
                label7.Text = "Aprovado";
                label7.ForeColor = Color.Blue;
            } else {
                label7.Text = "Reprovado";
                label7.ForeColor = Color.Red;
            }
        }
    }
}
