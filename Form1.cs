using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace szoveg_szerk
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
		{
			/*Ez a törlés gomb*/
			DialogResult result = MessageBox.Show("Az ablak tartalmát törölni fogja!\n\nBiztosan törli?", "Kérdés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				szoveg_doboz.Clear();
			}
		}

		private void megnyit_Click(object sender, EventArgs e)
		{
			if (szoveg_doboz.Text != "")
			{
				DialogResult result = MessageBox.Show("Ha vannak adatai amelyeket nem mentett azok elvesznek!\nBiztosan megnyit egy új fájlt?", "Üzenet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					szoveg_doboz.Clear();
					OpenFileDialog op1 = new OpenFileDialog();
					if (op1.ShowDialog() == DialogResult.OK)
					{
						StreamReader sr = new StreamReader(op1.FileName);
						szoveg_doboz.Text = sr.ReadToEnd();
						sr.Close();
					}
					this.Text = op1.FileName;
				}

			}
			else 
			{
				szoveg_doboz.Clear();
				OpenFileDialog op1 = new OpenFileDialog();
				if (op1.ShowDialog() == DialogResult.OK)
				{
					StreamReader sr = new StreamReader(op1.FileName);
					szoveg_doboz.Text = sr.ReadToEnd();
					sr.Close();
				}
				this.Text = op1.FileName;
			}
			
			
		}

		private void mentmas_Click(object sender, EventArgs e)
		{
			SaveFileDialog sa1 = new SaveFileDialog();
			sa1.DefaultExt = "rtl";
			sa1.Filter = "Szöveges Állomány (*.txt) | *.txt | Minden File (*.*) | *.* | Formázott állomány (*.rtf) | *.rtf";
			if (sa1.ShowDialog() == DialogResult.OK)
			{
				szoveg_doboz.SaveFile(sa1.FileName);
			}
			this.Text = sa1.FileName;
		}

		private void kilepes_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Ha vannak adatai amelyeket nem mentett azok elvesznek!\nBiztosan bezárja az alkalmazást?", "Üzenet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				Environment.Exit(0);
			}
			
		}

		private void keszito_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Készítette:\n\nKocsis Tamás", "Készítő", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
		}

		private void kivagastext_Click(object sender, EventArgs e)
		{
			szoveg_doboz.Cut();
		}

		private void beillesztestext_Click(object sender, EventArgs e)
		{
			szoveg_doboz.Paste();
		}

		private void torlestext_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectedText = "";
		}

		private void masolastext_Click(object sender, EventArgs e)
		{
			szoveg_doboz.Copy();
		}

		private void visszavontext_Click(object sender, EventArgs e)
		{
			szoveg_doboz.Undo();
		}

		private void ujratext_Click(object sender, EventArgs e)
		{
			szoveg_doboz.Redo();
		}

		private void újToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult d = MessageBox.Show("Ha új lapot nyit az törli a szöveg dobozt!\n\nBiztosan akarja?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (d == DialogResult.Yes)
			{
				szoveg_doboz.Clear();
				this.Text = "TextBox";
			}
		}

		private void sima_mentes_Click(object sender, EventArgs e)
		{
			SaveFileDialog sa1 = new SaveFileDialog();
			sa1.DefaultExt = "rtl";
			sa1.Filter = "Szöveges Állomány (*.txt) | *.txt | Minden File (*.*) | *.* | Formázott állomány (*.rtf) | *.rtf";
			if (sa1.ShowDialog() == DialogResult.OK)
			{
				szoveg_doboz.SaveFile(sa1.FileName);
			}
			this.Text = sa1.FileName;

		}

		private void betu_Click(object sender, EventArgs e)
		{
			if (fontvalt.ShowDialog() == DialogResult.OK)
			{
				szoveg_doboz.SelectionFont = fontvalt.Font;
				szoveg_doboz.SelectionColor = fontvalt.Color;
			}
		}

		private void datum_Click(object sender, EventArgs e)
		{
			
		}

		private void évToolStripMenuItem_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectionLength = 0;
			szoveg_doboz.SelectedText = DateTime.Now.ToString("yyyy");
		}

		private void hónapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectionLength = 0;
			szoveg_doboz.SelectedText = DateTime.Now.ToString("MM");
		}

		private void aHétNapjaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectionLength = 0;
			szoveg_doboz.SelectedText = DateTime.Now.ToString("dddd");
		}

		private void napToolStripMenuItem_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectionLength = 0;
			szoveg_doboz.SelectedText = DateTime.Now.ToString("dd");
		}

		private void óraToolStripMenuItem_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectionLength = 0;
			szoveg_doboz.SelectedText = DateTime.Now.ToString("HH");
		}

		private void percToolStripMenuItem_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectionLength = 0;
			szoveg_doboz.SelectedText = DateTime.Now.ToString("mm");
		}

		private void másodpercToolStripMenuItem_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectionLength = 0;
			szoveg_doboz.SelectedText = DateTime.Now.ToString("ss");
		}

		private void teljes_ido_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectionLength = 0;
			szoveg_doboz.SelectedText = DateTime.Now.ToString("T");
		}

		private void teljesdatum_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectionLength = 0;
			szoveg_doboz.SelectedText = DateTime.Now.ToString("D");
		}

		private void teljesFormatum_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectionLength = 0;
			szoveg_doboz.SelectedText = DateTime.Now.ToString("F");
		}

		private void kivagas_Click(object sender, EventArgs e)
		{
			szoveg_doboz.Cut();
		}

		private void masolas_Click(object sender, EventArgs e)
		{
			szoveg_doboz.Copy();
		}

		private void beillesztes_Click(object sender, EventArgs e)
		{
			szoveg_doboz.Paste();
		}

		private void datumbesz_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectionLength = 0;
			szoveg_doboz.SelectedText = DateTime.Now.ToString("f");
		}

		private void btsz_Click(object sender, EventArgs e)
		{
			if (fontvalt.ShowDialog() == DialogResult.OK)
			{
				szoveg_doboz.SelectionFont = fontvalt.Font;
				szoveg_doboz.SelectionColor = fontvalt.Color;
				
			}
		}

		private void hatterszin_CheckedChanged(object sender, EventArgs e)
		{
			if (hatterszin.Checked)
			{
				this.BackColor = Color.DarkBlue; this.ForeColor = Color.White;
				szoveg_doboz.BackColor = Color.DarkBlue;
				szoveg_doboz.ForeColor = Color.White;
			}
			else
			{
				this.BackColor = Color.White; this.ForeColor = Color.DarkBlue;
				szoveg_doboz.BackColor = Color.White;
				szoveg_doboz.ForeColor = Color.DarkBlue;
			}
		}

		private void sortores_CheckedChanged(object sender, EventArgs e)
		{
			if  (sortores.Checked)
			{
				szoveg_doboz.WordWrap = true;
			}
			else
			{
				szoveg_doboz.WordWrap = false;
			}
		}

		private void radiobal_CheckedChanged(object sender, EventArgs e)
		{
			
			szoveg_doboz.SelectionAlignment = HorizontalAlignment.Left;
		}

		private void radiocenter_CheckedChanged(object sender, EventArgs e)
		{
			
			szoveg_doboz.SelectionAlignment = HorizontalAlignment.Center;
		}

		private void radiojobb_CheckedChanged(object sender, EventArgs e)
		{
			
			szoveg_doboz.SelectionAlignment = HorizontalAlignment.Right;
		}

		private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
		{
			szoveg_doboz.SelectedText = "";
		}
	}
}
