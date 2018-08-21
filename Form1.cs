using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Integrantes del grupo
            //Victor Andres perez Drllard 15-EISN-1-251
            //Edwin Alberto 15-MISN-1-250
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Instroducir Solo Numero", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

    
            }

        private void button1_Click(object sender, EventArgs e)
        {
            long nt;
            nt = long.Parse(Ticket.Text);

            if (nt < 100000)

                MessageBox.Show("FELICIDADEZ!!!  El ticket es ganador");

            else

                MessageBox.Show(" El Ticket no es el ganador");
            Ticket.Clear();
            Ticket.Focus();
        }

        private void Ticket_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Instroducir Solo Numero", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            
        }
        }
    }

// Integrantes del grupo
//Victor Andres perez Drllard 15-EISN-1-251
//Edwin Alberto 15-MISN-1-250