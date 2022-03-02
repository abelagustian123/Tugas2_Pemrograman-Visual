/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 02/03/2022
 * Time: 14.51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			comboBox1.Items.Add("Komunikasi Data dan Jaringan Komputer");
			comboBox1.Items.Add("Komputer Grafik dan Visualisasi");
			comboBox1.Items.Add("Organisasi dan Arsitektur Komputer");
			comboBox1.Items.Add("Pemrograman Visual");
			comboBox1.Items.Add("Sistem Informasi");
			comboBox1.Items.Add("Kecakapan Antar Personal");
			comboBox1.Items.Add("Teori Bahasa Otomata (TBO)");
			comboBox1.Items.Add("Pengajaran Berbantuan Komputer");
		}
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Selamat Datang " + this.textBox1.Text+" di Matakuliah "+this.comboBox1.Text);
		}
	}
}
