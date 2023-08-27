namespace szoveg_szerk
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.szoveg_doboz = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.kivagas = new System.Windows.Forms.ToolStripMenuItem();
			this.masolas = new System.Windows.Forms.ToolStripMenuItem();
			this.beillesztes = new System.Windows.Forms.ToolStripMenuItem();
			this.datumbesz = new System.Windows.Forms.ToolStripMenuItem();
			this.btsz = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.file = new System.Windows.Forms.ToolStripMenuItem();
			this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.megnyit = new System.Windows.Forms.ToolStripMenuItem();
			this.sima_mentes = new System.Windows.Forms.ToolStripMenuItem();
			this.mentmas = new System.Windows.Forms.ToolStripMenuItem();
			this.kilepes = new System.Windows.Forms.ToolStripMenuItem();
			this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kivagastext = new System.Windows.Forms.ToolStripMenuItem();
			this.masolastext = new System.Windows.Forms.ToolStripMenuItem();
			this.beillesztestext = new System.Windows.Forms.ToolStripMenuItem();
			this.torlestext = new System.Windows.Forms.ToolStripMenuItem();
			this.visszavontext = new System.Windows.Forms.ToolStripMenuItem();
			this.ujratext = new System.Windows.Forms.ToolStripMenuItem();
			this.betu = new System.Windows.Forms.ToolStripMenuItem();
			this.datum = new System.Windows.Forms.ToolStripMenuItem();
			this.évToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hónapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aHétNapjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.napToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.óraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.percToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.másodpercToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.teljes_ido = new System.Windows.Forms.ToolStripMenuItem();
			this.teljesdatum = new System.Windows.Forms.ToolStripMenuItem();
			this.teljesFormatum = new System.Windows.Forms.ToolStripMenuItem();
			this.nevjegy = new System.Windows.Forms.ToolStripMenuItem();
			this.keszito = new System.Windows.Forms.ToolStripMenuItem();
			this.fontvalt = new System.Windows.Forms.FontDialog();
			this.group = new System.Windows.Forms.GroupBox();
			this.radiojobb = new System.Windows.Forms.RadioButton();
			this.radiocenter = new System.Windows.Forms.RadioButton();
			this.radiobal = new System.Windows.Forms.RadioButton();
			this.sortores = new System.Windows.Forms.CheckBox();
			this.hatterszin = new System.Windows.Forms.CheckBox();
			this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.group.SuspendLayout();
			this.SuspendLayout();
			// 
			// szoveg_doboz
			// 
			this.szoveg_doboz.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.szoveg_doboz.ContextMenuStrip = this.contextMenuStrip1;
			this.szoveg_doboz.ForeColor = System.Drawing.Color.Black;
			this.szoveg_doboz.Location = new System.Drawing.Point(12, 73);
			this.szoveg_doboz.Name = "szoveg_doboz";
			this.szoveg_doboz.Size = new System.Drawing.Size(776, 365);
			this.szoveg_doboz.TabIndex = 0;
			this.szoveg_doboz.Text = "";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kivagas,
            this.masolas,
            this.beillesztes,
            this.törlésToolStripMenuItem,
            this.datumbesz,
            this.btsz});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(169, 136);
			// 
			// kivagas
			// 
			this.kivagas.Name = "kivagas";
			this.kivagas.Size = new System.Drawing.Size(180, 22);
			this.kivagas.Text = "Kivágás";
			this.kivagas.Click += new System.EventHandler(this.kivagas_Click);
			// 
			// masolas
			// 
			this.masolas.Name = "masolas";
			this.masolas.Size = new System.Drawing.Size(180, 22);
			this.masolas.Text = "Másolás";
			this.masolas.Click += new System.EventHandler(this.masolas_Click);
			// 
			// beillesztes
			// 
			this.beillesztes.Name = "beillesztes";
			this.beillesztes.Size = new System.Drawing.Size(180, 22);
			this.beillesztes.Text = "Beillesztés";
			this.beillesztes.Click += new System.EventHandler(this.beillesztes_Click);
			// 
			// datumbesz
			// 
			this.datumbesz.Name = "datumbesz";
			this.datumbesz.Size = new System.Drawing.Size(180, 22);
			this.datumbesz.Text = "Dátum beszúrása";
			this.datumbesz.Click += new System.EventHandler(this.datumbesz_Click);
			// 
			// btsz
			// 
			this.btsz.Name = "btsz";
			this.btsz.Size = new System.Drawing.Size(180, 22);
			this.btsz.Text = "Betűt típus és szín";
			this.btsz.Click += new System.EventHandler(this.btsz_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.szerkesztésToolStripMenuItem,
            this.nevjegy});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// file
			// 
			this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.megnyitásToolStripMenuItem,
            this.megnyit,
            this.sima_mentes,
            this.mentmas,
            this.kilepes});
			this.file.Name = "file";
			this.file.Size = new System.Drawing.Size(37, 20);
			this.file.Text = "File";
			// 
			// újToolStripMenuItem
			// 
			this.újToolStripMenuItem.Name = "újToolStripMenuItem";
			this.újToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.újToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
			this.újToolStripMenuItem.Text = "Új";
			this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
			// 
			// megnyitásToolStripMenuItem
			// 
			this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
			this.megnyitásToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
			this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
			this.megnyitásToolStripMenuItem.Text = "Törlés";
			this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
			// 
			// megnyit
			// 
			this.megnyit.Name = "megnyit";
			this.megnyit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.megnyit.Size = new System.Drawing.Size(230, 22);
			this.megnyit.Text = "Megnyitás";
			this.megnyit.Click += new System.EventHandler(this.megnyit_Click);
			// 
			// sima_mentes
			// 
			this.sima_mentes.Name = "sima_mentes";
			this.sima_mentes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.sima_mentes.Size = new System.Drawing.Size(230, 22);
			this.sima_mentes.Text = "Mentés";
			this.sima_mentes.Click += new System.EventHandler(this.sima_mentes_Click);
			// 
			// mentmas
			// 
			this.mentmas.Name = "mentmas";
			this.mentmas.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.mentmas.Size = new System.Drawing.Size(230, 22);
			this.mentmas.Text = "MentésMásként";
			this.mentmas.Click += new System.EventHandler(this.mentmas_Click);
			// 
			// kilepes
			// 
			this.kilepes.Name = "kilepes";
			this.kilepes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
			this.kilepes.Size = new System.Drawing.Size(230, 22);
			this.kilepes.Text = "Kilépés";
			this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
			// 
			// szerkesztésToolStripMenuItem
			// 
			this.szerkesztésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kivagastext,
            this.masolastext,
            this.beillesztestext,
            this.torlestext,
            this.visszavontext,
            this.ujratext,
            this.betu,
            this.datum});
			this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
			this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
			// 
			// kivagastext
			// 
			this.kivagastext.Name = "kivagastext";
			this.kivagastext.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.kivagastext.Size = new System.Drawing.Size(189, 22);
			this.kivagastext.Text = "Kivágás";
			this.kivagastext.Click += new System.EventHandler(this.kivagastext_Click);
			// 
			// masolastext
			// 
			this.masolastext.Name = "masolastext";
			this.masolastext.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.masolastext.Size = new System.Drawing.Size(189, 22);
			this.masolastext.Text = "Másolás";
			this.masolastext.Click += new System.EventHandler(this.masolastext_Click);
			// 
			// beillesztestext
			// 
			this.beillesztestext.Name = "beillesztestext";
			this.beillesztestext.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.beillesztestext.Size = new System.Drawing.Size(189, 22);
			this.beillesztestext.Text = "Beillesztés";
			this.beillesztestext.Click += new System.EventHandler(this.beillesztestext_Click);
			// 
			// torlestext
			// 
			this.torlestext.Name = "torlestext";
			this.torlestext.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.torlestext.Size = new System.Drawing.Size(189, 22);
			this.torlestext.Text = "Törlés";
			this.torlestext.Click += new System.EventHandler(this.torlestext_Click);
			// 
			// visszavontext
			// 
			this.visszavontext.Name = "visszavontext";
			this.visszavontext.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.visszavontext.Size = new System.Drawing.Size(189, 22);
			this.visszavontext.Text = "Visszavonás";
			this.visszavontext.Click += new System.EventHandler(this.visszavontext_Click);
			// 
			// ujratext
			// 
			this.ujratext.Name = "ujratext";
			this.ujratext.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.ujratext.Size = new System.Drawing.Size(189, 22);
			this.ujratext.Text = "Újra";
			this.ujratext.Click += new System.EventHandler(this.ujratext_Click);
			// 
			// betu
			// 
			this.betu.Name = "betu";
			this.betu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.betu.Size = new System.Drawing.Size(189, 22);
			this.betu.Text = "Betű formázás";
			this.betu.Click += new System.EventHandler(this.betu_Click);
			// 
			// datum
			// 
			this.datum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.évToolStripMenuItem,
            this.hónapToolStripMenuItem,
            this.aHétNapjaToolStripMenuItem,
            this.napToolStripMenuItem,
            this.óraToolStripMenuItem,
            this.percToolStripMenuItem,
            this.másodpercToolStripMenuItem,
            this.teljes_ido,
            this.teljesdatum,
            this.teljesFormatum});
			this.datum.Name = "datum";
			this.datum.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.datum.Size = new System.Drawing.Size(189, 22);
			this.datum.Text = "Dátum beszúrása";
			this.datum.Click += new System.EventHandler(this.datum_Click);
			// 
			// évToolStripMenuItem
			// 
			this.évToolStripMenuItem.Name = "évToolStripMenuItem";
			this.évToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.évToolStripMenuItem.Text = "év";
			this.évToolStripMenuItem.Click += new System.EventHandler(this.évToolStripMenuItem_Click);
			// 
			// hónapToolStripMenuItem
			// 
			this.hónapToolStripMenuItem.Name = "hónapToolStripMenuItem";
			this.hónapToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.hónapToolStripMenuItem.Text = "hónap";
			this.hónapToolStripMenuItem.Click += new System.EventHandler(this.hónapToolStripMenuItem_Click);
			// 
			// aHétNapjaToolStripMenuItem
			// 
			this.aHétNapjaToolStripMenuItem.Name = "aHétNapjaToolStripMenuItem";
			this.aHétNapjaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.aHétNapjaToolStripMenuItem.Text = "a hét napja";
			this.aHétNapjaToolStripMenuItem.Click += new System.EventHandler(this.aHétNapjaToolStripMenuItem_Click);
			// 
			// napToolStripMenuItem
			// 
			this.napToolStripMenuItem.Name = "napToolStripMenuItem";
			this.napToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.napToolStripMenuItem.Text = "nap";
			this.napToolStripMenuItem.Click += new System.EventHandler(this.napToolStripMenuItem_Click);
			// 
			// óraToolStripMenuItem
			// 
			this.óraToolStripMenuItem.Name = "óraToolStripMenuItem";
			this.óraToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.óraToolStripMenuItem.Text = "óra";
			this.óraToolStripMenuItem.Click += new System.EventHandler(this.óraToolStripMenuItem_Click);
			// 
			// percToolStripMenuItem
			// 
			this.percToolStripMenuItem.Name = "percToolStripMenuItem";
			this.percToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.percToolStripMenuItem.Text = "perc";
			this.percToolStripMenuItem.Click += new System.EventHandler(this.percToolStripMenuItem_Click);
			// 
			// másodpercToolStripMenuItem
			// 
			this.másodpercToolStripMenuItem.Name = "másodpercToolStripMenuItem";
			this.másodpercToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.másodpercToolStripMenuItem.Text = "másodperc";
			this.másodpercToolStripMenuItem.Click += new System.EventHandler(this.másodpercToolStripMenuItem_Click);
			// 
			// teljes_ido
			// 
			this.teljes_ido.Name = "teljes_ido";
			this.teljes_ido.Size = new System.Drawing.Size(196, 22);
			this.teljes_ido.Text = "teljes formátum idő";
			this.teljes_ido.Click += new System.EventHandler(this.teljes_ido_Click);
			// 
			// teljesdatum
			// 
			this.teljesdatum.Name = "teljesdatum";
			this.teljesdatum.Size = new System.Drawing.Size(196, 22);
			this.teljesdatum.Text = "teljes formátum dátum";
			this.teljesdatum.Click += new System.EventHandler(this.teljesdatum_Click);
			// 
			// teljesFormatum
			// 
			this.teljesFormatum.Name = "teljesFormatum";
			this.teljesFormatum.Size = new System.Drawing.Size(196, 22);
			this.teljesFormatum.Text = "teljes formátum";
			this.teljesFormatum.Click += new System.EventHandler(this.teljesFormatum_Click);
			// 
			// nevjegy
			// 
			this.nevjegy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keszito});
			this.nevjegy.Name = "nevjegy";
			this.nevjegy.Size = new System.Drawing.Size(62, 20);
			this.nevjegy.Text = "Névjegy";
			// 
			// keszito
			// 
			this.keszito.Name = "keszito";
			this.keszito.Size = new System.Drawing.Size(111, 22);
			this.keszito.Text = "Készítő";
			this.keszito.Click += new System.EventHandler(this.keszito_Click);
			// 
			// fontvalt
			// 
			this.fontvalt.ShowColor = true;
			// 
			// group
			// 
			this.group.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.group.Controls.Add(this.radiojobb);
			this.group.Controls.Add(this.radiocenter);
			this.group.Controls.Add(this.radiobal);
			this.group.Controls.Add(this.sortores);
			this.group.Controls.Add(this.hatterszin);
			this.group.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.group.Location = new System.Drawing.Point(12, 30);
			this.group.Name = "group";
			this.group.Size = new System.Drawing.Size(776, 37);
			this.group.TabIndex = 2;
			this.group.TabStop = false;
			this.group.Text = "Eszközök";
			// 
			// radiojobb
			// 
			this.radiojobb.AutoSize = true;
			this.radiojobb.Location = new System.Drawing.Point(420, 14);
			this.radiojobb.Name = "radiojobb";
			this.radiojobb.Size = new System.Drawing.Size(86, 17);
			this.radiojobb.TabIndex = 4;
			this.radiojobb.TabStop = true;
			this.radiojobb.Text = "Jobbra igazít";
			this.radiojobb.UseVisualStyleBackColor = true;
			this.radiojobb.CheckedChanged += new System.EventHandler(this.radiojobb_CheckedChanged);
			// 
			// radiocenter
			// 
			this.radiocenter.AutoSize = true;
			this.radiocenter.Location = new System.Drawing.Point(328, 14);
			this.radiocenter.Name = "radiocenter";
			this.radiocenter.Size = new System.Drawing.Size(93, 17);
			this.radiocenter.TabIndex = 3;
			this.radiocenter.TabStop = true;
			this.radiocenter.Text = "Középre igazít";
			this.radiocenter.UseVisualStyleBackColor = true;
			this.radiocenter.CheckedChanged += new System.EventHandler(this.radiocenter_CheckedChanged);
			// 
			// radiobal
			// 
			this.radiobal.AutoSize = true;
			this.radiobal.Location = new System.Drawing.Point(236, 14);
			this.radiobal.Name = "radiobal";
			this.radiobal.Size = new System.Drawing.Size(80, 17);
			this.radiobal.TabIndex = 2;
			this.radiobal.TabStop = true;
			this.radiobal.Text = "Ballra igazít";
			this.radiobal.UseVisualStyleBackColor = true;
			this.radiobal.CheckedChanged += new System.EventHandler(this.radiobal_CheckedChanged);
			// 
			// sortores
			// 
			this.sortores.AutoSize = true;
			this.sortores.Location = new System.Drawing.Point(113, 14);
			this.sortores.Name = "sortores";
			this.sortores.Size = new System.Drawing.Size(81, 17);
			this.sortores.TabIndex = 1;
			this.sortores.Text = "Sortörés Be";
			this.sortores.UseVisualStyleBackColor = true;
			this.sortores.CheckedChanged += new System.EventHandler(this.sortores_CheckedChanged);
			// 
			// hatterszin
			// 
			this.hatterszin.AutoSize = true;
			this.hatterszin.Location = new System.Drawing.Point(7, 14);
			this.hatterszin.Name = "hatterszin";
			this.hatterszin.Size = new System.Drawing.Size(99, 17);
			this.hatterszin.TabIndex = 0;
			this.hatterszin.Text = "Háttér sötétítés";
			this.hatterszin.UseVisualStyleBackColor = true;
			this.hatterszin.CheckedChanged += new System.EventHandler(this.hatterszin_CheckedChanged);
			// 
			// törlésToolStripMenuItem
			// 
			this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
			this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.törlésToolStripMenuItem.Text = "Törlés";
			this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.group);
			this.Controls.Add(this.szoveg_doboz);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.DarkBlue;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "TextBox";
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.group.ResumeLayout(false);
			this.group.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox szoveg_doboz;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem file;
		private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem megnyit;
		private System.Windows.Forms.ToolStripMenuItem mentmas;
		private System.Windows.Forms.ToolStripMenuItem kilepes;
		private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kivagastext;
		private System.Windows.Forms.ToolStripMenuItem masolastext;
		private System.Windows.Forms.ToolStripMenuItem beillesztestext;
		private System.Windows.Forms.ToolStripMenuItem torlestext;
		private System.Windows.Forms.ToolStripMenuItem visszavontext;
		private System.Windows.Forms.ToolStripMenuItem ujratext;
		private System.Windows.Forms.ToolStripMenuItem nevjegy;
		private System.Windows.Forms.ToolStripMenuItem keszito;
		private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sima_mentes;
		private System.Windows.Forms.ToolStripMenuItem betu;
		private System.Windows.Forms.ToolStripMenuItem datum;
		private System.Windows.Forms.FontDialog fontvalt;
		private System.Windows.Forms.ToolStripMenuItem évToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hónapToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aHétNapjaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem napToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem óraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem percToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem másodpercToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem teljes_ido;
		private System.Windows.Forms.ToolStripMenuItem teljesdatum;
		private System.Windows.Forms.ToolStripMenuItem teljesFormatum;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem kivagas;
		private System.Windows.Forms.ToolStripMenuItem masolas;
		private System.Windows.Forms.ToolStripMenuItem beillesztes;
		private System.Windows.Forms.ToolStripMenuItem datumbesz;
		private System.Windows.Forms.ToolStripMenuItem btsz;
		private System.Windows.Forms.GroupBox group;
		private System.Windows.Forms.CheckBox hatterszin;
		private System.Windows.Forms.CheckBox sortores;
		private System.Windows.Forms.RadioButton radiojobb;
		private System.Windows.Forms.RadioButton radiocenter;
		private System.Windows.Forms.RadioButton radiobal;
		private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
	}
}

