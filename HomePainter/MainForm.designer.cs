namespace HomePainter
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeHomePainterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figuraaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.tabPageArrange = new System.Windows.Forms.TabPage();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.tabPageEstilo = new System.Windows.Forms.TabPage();
            this.grpboxOpacidad = new System.Windows.Forms.GroupBox();
            this.metroTrackBarOpacidad = new MetroFramework.Controls.MetroTrackBar();
            this.numOpacidad = new System.Windows.Forms.NumericUpDown();
            this.grpboxBorde = new System.Windows.Forms.GroupBox();
            this.picboxBordeColor = new System.Windows.Forms.PictureBox();
            this.numBordeGrosor = new System.Windows.Forms.NumericUpDown();
            this.cboBorde = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelEstiloColor = new System.Windows.Forms.FlowLayoutPanel();
            this.picboxColorAzul = new System.Windows.Forms.PictureBox();
            this.picboxColorVerde = new System.Windows.Forms.PictureBox();
            this.picboxColorRojo = new System.Windows.Forms.PictureBox();
            this.picboxColorNaranja = new System.Windows.Forms.PictureBox();
            this.picboxColorRosa = new System.Windows.Forms.PictureBox();
            this.picboxColorNegro = new System.Windows.Forms.PictureBox();
            this.metroTabControlFormato = new MetroFramework.Controls.MetroTabControl();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.metroMainPanel = new MetroFramework.Controls.MetroPanel();
            this.menuStripMain.SuspendLayout();
            this.tabPageEstilo.SuspendLayout();
            this.grpboxOpacidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacidad)).BeginInit();
            this.grpboxBorde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBordeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBordeGrosor)).BeginInit();
            this.flowLayoutPanelEstiloColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColorAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColorVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColorRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColorNaranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColorRosa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColorNegro)).BeginInit();
            this.metroTabControlFormato.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.figuraaToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(928, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            this.menuStripMain.MouseEnter += new System.EventHandler(this.menuStripMain_MouseEnter);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeHomePainterToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // acercaDeHomePainterToolStripMenuItem
            // 
            this.acercaDeHomePainterToolStripMenuItem.Name = "acercaDeHomePainterToolStripMenuItem";
            this.acercaDeHomePainterToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.acercaDeHomePainterToolStripMenuItem.Text = "Acerca de HomePainter";
            this.acercaDeHomePainterToolStripMenuItem.Click += new System.EventHandler(this.acercaDeHomePainterToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // figuraaToolStripMenuItem
            // 
            this.figuraaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectanguloToolStripMenuItem,
            this.circuloToolStripMenuItem,
            this.elipseToolStripMenuItem,
            this.pentagonoToolStripMenuItem});
            this.figuraaToolStripMenuItem.Name = "figuraaToolStripMenuItem";
            this.figuraaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.figuraaToolStripMenuItem.Text = "Figura";
            // 
            // rectanguloToolStripMenuItem
            // 
            this.rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
            this.rectanguloToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.rectanguloToolStripMenuItem.Text = "Rectangulo";
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.circuloToolStripMenuItem.Text = "Circulo";
            // 
            // elipseToolStripMenuItem
            // 
            this.elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            this.elipseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.elipseToolStripMenuItem.Text = "Elipse";
            // 
            // pentagonoToolStripMenuItem
            // 
            this.pentagonoToolStripMenuItem.Name = "pentagonoToolStripMenuItem";
            this.pentagonoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.pentagonoToolStripMenuItem.Text = "Pentagono";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMachineName.Location = new System.Drawing.Point(0, 406);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(76, 13);
            this.lblMachineName.TabIndex = 2;
            this.lblMachineName.Text = "MachineName";
            // 
            // tabPageArrange
            // 
            this.tabPageArrange.Location = new System.Drawing.Point(4, 38);
            this.tabPageArrange.Name = "tabPageArrange";
            this.tabPageArrange.Size = new System.Drawing.Size(320, 340);
            this.tabPageArrange.TabIndex = 2;
            this.tabPageArrange.Text = "Organizar";
            // 
            // tabPageText
            // 
            this.tabPageText.Location = new System.Drawing.Point(4, 38);
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.Size = new System.Drawing.Size(320, 340);
            this.tabPageText.TabIndex = 1;
            this.tabPageText.Text = "Texto";
            // 
            // tabPageEstilo
            // 
            this.tabPageEstilo.Controls.Add(this.grpboxOpacidad);
            this.tabPageEstilo.Controls.Add(this.grpboxBorde);
            this.tabPageEstilo.Controls.Add(this.flowLayoutPanelEstiloColor);
            this.tabPageEstilo.Location = new System.Drawing.Point(4, 38);
            this.tabPageEstilo.Name = "tabPageEstilo";
            this.tabPageEstilo.Size = new System.Drawing.Size(320, 340);
            this.tabPageEstilo.TabIndex = 0;
            this.tabPageEstilo.Text = "Estilo";
            // 
            // grpboxOpacidad
            // 
            this.grpboxOpacidad.Controls.Add(this.metroTrackBarOpacidad);
            this.grpboxOpacidad.Controls.Add(this.numOpacidad);
            this.grpboxOpacidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpboxOpacidad.Location = new System.Drawing.Point(0, 218);
            this.grpboxOpacidad.Name = "grpboxOpacidad";
            this.grpboxOpacidad.Size = new System.Drawing.Size(320, 55);
            this.grpboxOpacidad.TabIndex = 9;
            this.grpboxOpacidad.TabStop = false;
            this.grpboxOpacidad.Text = "Opacidad";
            // 
            // metroTrackBarOpacidad
            // 
            this.metroTrackBarOpacidad.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarOpacidad.Location = new System.Drawing.Point(15, 19);
            this.metroTrackBarOpacidad.Name = "metroTrackBarOpacidad";
            this.metroTrackBarOpacidad.Size = new System.Drawing.Size(242, 20);
            this.metroTrackBarOpacidad.TabIndex = 7;
            this.metroTrackBarOpacidad.Text = "Opacidad";
            this.metroTrackBarOpacidad.Value = 100;
            this.metroTrackBarOpacidad.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBarOpacidad_Scroll);
            // 
            // numOpacidad
            // 
            this.numOpacidad.Location = new System.Drawing.Point(263, 19);
            this.numOpacidad.Name = "numOpacidad";
            this.numOpacidad.Size = new System.Drawing.Size(51, 20);
            this.numOpacidad.TabIndex = 6;
            this.numOpacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOpacidad.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numOpacidad.ValueChanged += new System.EventHandler(this.numOpacidad_ValueChanged);
            this.numOpacidad.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numOpacidad_Scroll);
            // 
            // grpboxBorde
            // 
            this.grpboxBorde.Controls.Add(this.picboxBordeColor);
            this.grpboxBorde.Controls.Add(this.numBordeGrosor);
            this.grpboxBorde.Controls.Add(this.cboBorde);
            this.grpboxBorde.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpboxBorde.Location = new System.Drawing.Point(0, 118);
            this.grpboxBorde.Name = "grpboxBorde";
            this.grpboxBorde.Size = new System.Drawing.Size(320, 100);
            this.grpboxBorde.TabIndex = 8;
            this.grpboxBorde.TabStop = false;
            this.grpboxBorde.Text = "Borde";
            // 
            // picboxBordeColor
            // 
            this.picboxBordeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxBordeColor.Location = new System.Drawing.Point(132, 55);
            this.picboxBordeColor.Name = "picboxBordeColor";
            this.picboxBordeColor.Size = new System.Drawing.Size(125, 20);
            this.picboxBordeColor.TabIndex = 4;
            this.picboxBordeColor.TabStop = false;
            this.picboxBordeColor.Click += new System.EventHandler(this.picboxBordeColor_Click);
            // 
            // numBordeGrosor
            // 
            this.numBordeGrosor.Location = new System.Drawing.Point(263, 55);
            this.numBordeGrosor.Name = "numBordeGrosor";
            this.numBordeGrosor.Size = new System.Drawing.Size(49, 20);
            this.numBordeGrosor.TabIndex = 1;
            this.numBordeGrosor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboBorde
            // 
            this.cboBorde.FormattingEnabled = true;
            this.cboBorde.Items.AddRange(new object[] {
            "Sin Bordes",
            "Linea"});
            this.cboBorde.Location = new System.Drawing.Point(15, 19);
            this.cboBorde.Name = "cboBorde";
            this.cboBorde.Size = new System.Drawing.Size(297, 21);
            this.cboBorde.TabIndex = 0;
            this.cboBorde.Text = "Sin Bordes";
            this.cboBorde.TextChanged += new System.EventHandler(this.cboBorde_TextChanged);
            // 
            // flowLayoutPanelEstiloColor
            // 
            this.flowLayoutPanelEstiloColor.Controls.Add(this.picboxColorAzul);
            this.flowLayoutPanelEstiloColor.Controls.Add(this.picboxColorVerde);
            this.flowLayoutPanelEstiloColor.Controls.Add(this.picboxColorRojo);
            this.flowLayoutPanelEstiloColor.Controls.Add(this.picboxColorNaranja);
            this.flowLayoutPanelEstiloColor.Controls.Add(this.picboxColorRosa);
            this.flowLayoutPanelEstiloColor.Controls.Add(this.picboxColorNegro);
            this.flowLayoutPanelEstiloColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelEstiloColor.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelEstiloColor.Name = "flowLayoutPanelEstiloColor";
            this.flowLayoutPanelEstiloColor.Size = new System.Drawing.Size(320, 118);
            this.flowLayoutPanelEstiloColor.TabIndex = 0;
            // 
            // picboxColorAzul
            // 
            this.picboxColorAzul.BackColor = System.Drawing.Color.DodgerBlue;
            this.picboxColorAzul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxColorAzul.Location = new System.Drawing.Point(3, 3);
            this.picboxColorAzul.Name = "picboxColorAzul";
            this.picboxColorAzul.Size = new System.Drawing.Size(100, 50);
            this.picboxColorAzul.TabIndex = 0;
            this.picboxColorAzul.TabStop = false;
            this.picboxColorAzul.MouseEnter += new System.EventHandler(this.picboxColorAzul_MouseEnter);
            this.picboxColorAzul.MouseLeave += new System.EventHandler(this.picboxColorAzul_MouseLeave);
            // 
            // picboxColorVerde
            // 
            this.picboxColorVerde.BackColor = System.Drawing.Color.LimeGreen;
            this.picboxColorVerde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxColorVerde.Location = new System.Drawing.Point(109, 3);
            this.picboxColorVerde.Name = "picboxColorVerde";
            this.picboxColorVerde.Size = new System.Drawing.Size(100, 50);
            this.picboxColorVerde.TabIndex = 1;
            this.picboxColorVerde.TabStop = false;
            this.picboxColorVerde.MouseEnter += new System.EventHandler(this.picboxColorVerde_MouseEnter);
            this.picboxColorVerde.MouseLeave += new System.EventHandler(this.picboxColorVerde_MouseLeave);
            // 
            // picboxColorRojo
            // 
            this.picboxColorRojo.BackColor = System.Drawing.Color.Red;
            this.picboxColorRojo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxColorRojo.Location = new System.Drawing.Point(215, 3);
            this.picboxColorRojo.Name = "picboxColorRojo";
            this.picboxColorRojo.Size = new System.Drawing.Size(100, 50);
            this.picboxColorRojo.TabIndex = 2;
            this.picboxColorRojo.TabStop = false;
            this.picboxColorRojo.MouseEnter += new System.EventHandler(this.picboxColorRojo_MouseEnter);
            this.picboxColorRojo.MouseLeave += new System.EventHandler(this.picboxColorRojo_MouseLeave);
            // 
            // picboxColorNaranja
            // 
            this.picboxColorNaranja.BackColor = System.Drawing.Color.Orange;
            this.picboxColorNaranja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxColorNaranja.Location = new System.Drawing.Point(3, 59);
            this.picboxColorNaranja.Name = "picboxColorNaranja";
            this.picboxColorNaranja.Size = new System.Drawing.Size(100, 50);
            this.picboxColorNaranja.TabIndex = 3;
            this.picboxColorNaranja.TabStop = false;
            this.picboxColorNaranja.MouseEnter += new System.EventHandler(this.picboxColorNaranja_MouseEnter);
            this.picboxColorNaranja.MouseLeave += new System.EventHandler(this.picboxColorNaranja_MouseLeave);
            // 
            // picboxColorRosa
            // 
            this.picboxColorRosa.BackColor = System.Drawing.Color.HotPink;
            this.picboxColorRosa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxColorRosa.Location = new System.Drawing.Point(109, 59);
            this.picboxColorRosa.Name = "picboxColorRosa";
            this.picboxColorRosa.Size = new System.Drawing.Size(100, 50);
            this.picboxColorRosa.TabIndex = 4;
            this.picboxColorRosa.TabStop = false;
            this.picboxColorRosa.MouseEnter += new System.EventHandler(this.picboxColorRosa_MouseEnter);
            this.picboxColorRosa.MouseLeave += new System.EventHandler(this.picboxColorRosa_MouseLeave);
            // 
            // picboxColorNegro
            // 
            this.picboxColorNegro.BackColor = System.Drawing.Color.Black;
            this.picboxColorNegro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxColorNegro.Location = new System.Drawing.Point(215, 59);
            this.picboxColorNegro.Name = "picboxColorNegro";
            this.picboxColorNegro.Size = new System.Drawing.Size(100, 50);
            this.picboxColorNegro.TabIndex = 5;
            this.picboxColorNegro.TabStop = false;
            this.picboxColorNegro.MouseEnter += new System.EventHandler(this.picboxColorNegro_MouseEnter);
            this.picboxColorNegro.MouseLeave += new System.EventHandler(this.picboxColorNegro_MouseLeave);
            // 
            // metroTabControlFormato
            // 
            this.metroTabControlFormato.Controls.Add(this.tabPageEstilo);
            this.metroTabControlFormato.Controls.Add(this.tabPageText);
            this.metroTabControlFormato.Controls.Add(this.tabPageArrange);
            this.metroTabControlFormato.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroTabControlFormato.Location = new System.Drawing.Point(600, 24);
            this.metroTabControlFormato.Name = "metroTabControlFormato";
            this.metroTabControlFormato.SelectedIndex = 0;
            this.metroTabControlFormato.Size = new System.Drawing.Size(328, 382);
            this.metroTabControlFormato.TabIndex = 3;
            this.metroTabControlFormato.UseSelectable = true;
            this.metroTabControlFormato.MouseEnter += new System.EventHandler(this.metroTabControlFormato_MouseEnter);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // metroMainPanel
            // 
            this.metroMainPanel.BackColor = System.Drawing.Color.Transparent;
            this.metroMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroMainPanel.HorizontalScrollbarBarColor = true;
            this.metroMainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroMainPanel.HorizontalScrollbarSize = 10;
            this.metroMainPanel.Location = new System.Drawing.Point(0, 24);
            this.metroMainPanel.Name = "metroMainPanel";
            this.metroMainPanel.Size = new System.Drawing.Size(600, 382);
            this.metroMainPanel.TabIndex = 4;
            this.metroMainPanel.VerticalScrollbarBarColor = true;
            this.metroMainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroMainPanel.VerticalScrollbarSize = 10;
            this.metroMainPanel.MouseEnter += new System.EventHandler(this.metroMainPanel_MouseEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 419);
            this.Controls.Add(this.metroMainPanel);
            this.Controls.Add(this.metroTabControlFormato);
            this.Controls.Add(this.lblMachineName);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "HomePainter";
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabPageEstilo.ResumeLayout(false);
            this.grpboxOpacidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOpacidad)).EndInit();
            this.grpboxBorde.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxBordeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBordeGrosor)).EndInit();
            this.flowLayoutPanelEstiloColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxColorAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColorVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColorRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColorNaranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColorRosa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColorNegro)).EndInit();
            this.metroTabControlFormato.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem figuraaToolStripMenuItem;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.ToolStripMenuItem rectanguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentagonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeHomePainterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageArrange;
        private System.Windows.Forms.TabPage tabPageText;
        private System.Windows.Forms.TabPage tabPageEstilo;
        private System.Windows.Forms.GroupBox grpboxOpacidad;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarOpacidad;
        private System.Windows.Forms.NumericUpDown numOpacidad;
        private System.Windows.Forms.GroupBox grpboxBorde;
        private System.Windows.Forms.NumericUpDown numBordeGrosor;
        private System.Windows.Forms.ComboBox cboBorde;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEstiloColor;
        private System.Windows.Forms.PictureBox picboxColorAzul;
        private System.Windows.Forms.PictureBox picboxColorVerde;
        private System.Windows.Forms.PictureBox picboxColorRojo;
        private System.Windows.Forms.PictureBox picboxColorNaranja;
        private System.Windows.Forms.PictureBox picboxColorRosa;
        private System.Windows.Forms.PictureBox picboxColorNegro;
        private MetroFramework.Controls.MetroTabControl metroTabControlFormato;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.PictureBox picboxBordeColor;
        private MetroFramework.Controls.MetroPanel metroMainPanel;
    }
}

