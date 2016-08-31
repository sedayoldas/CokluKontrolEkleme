using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokluKontrolEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 10;
            for (int i = 1; i <= 5; i++)
            {
                Button btn = new Button();
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                btn.Location = new System.Drawing.Point(x, 10);
                x += 110;
                btn.Name = "btn" + i.ToString();
                btn.Size = new System.Drawing.Size(92, 30);
                btn.Text = "Click!..";
                btn.Click += new EventHandler(HangiButon);
                this.Controls.Add(btn);
            }
        }

        void HangiButon(object s, EventArgs e)
        {
            Button b = (Button)s;//S argümanı tıklanan butonu temsil etmiş olur.
            this.Text = b.Name.Trim('b', 't', 'n') + " tıklandı";
            b.BackColor = Color.Green;

            if (b.Name=="btn3")
            {
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //basılan tuşun Enter olduğunu görürsen diğer textbox a geç
            if (e.KeyCode == Keys.Enter)
                textBox2.Focus();
        }
             
    }
}
