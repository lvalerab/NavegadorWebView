
namespace LfvbNavegador
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TBoxUrl = new System.Windows.Forms.TextBox();
            this.WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.BtnIr = new System.Windows.Forms.Button();
            this.TCCaracteristicas = new System.Windows.Forms.TabControl();
            this.TPDatosGeneralesWeb = new System.Windows.Forms.TabPage();
            this.LblRelativeUrl = new System.Windows.Forms.Label();
            this.LblBaseUrl = new System.Windows.Forms.Label();
            this.LblUrl = new System.Windows.Forms.Label();
            this.TPCookies = new System.Windows.Forms.TabPage();
            this.TPTiempos = new System.Windows.Forms.TabPage();
            this.SlcTipoGraficaTiempo = new System.Windows.Forms.ComboBox();
            this.LblTipoGraficaTiempos = new System.Windows.Forms.Label();
            this.SlcTipoDatoTiempo = new System.Windows.Forms.ComboBox();
            this.LblTipoDatoTiempos = new System.Windows.Forms.Label();
            this.CHTiempos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TPPeticiones = new System.Windows.Forms.TabPage();
            this.GRVPeticiones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.WebView)).BeginInit();
            this.TCCaracteristicas.SuspendLayout();
            this.TPDatosGeneralesWeb.SuspendLayout();
            this.TPTiempos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CHTiempos)).BeginInit();
            this.TPPeticiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRVPeticiones)).BeginInit();
            this.SuspendLayout();
            // 
            // TBoxUrl
            // 
            this.TBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxUrl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TBoxUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxUrl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TBoxUrl.Location = new System.Drawing.Point(12, 3);
            this.TBoxUrl.Name = "TBoxUrl";
            this.TBoxUrl.Size = new System.Drawing.Size(804, 20);
            this.TBoxUrl.TabIndex = 1;
            this.TBoxUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBoxUrl_KeyPress);
            // 
            // WebView
            // 
            this.WebView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebView.CreationProperties = null;
            this.WebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.WebView.Location = new System.Drawing.Point(12, 29);
            this.WebView.Name = "WebView";
            this.WebView.Size = new System.Drawing.Size(843, 167);
            this.WebView.Source = new System.Uri("http://www.google.es", System.UriKind.Absolute);
            this.WebView.TabIndex = 2;
            this.WebView.ZoomFactor = 1D;
            // 
            // BtnIr
            // 
            this.BtnIr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnIr.BackColor = System.Drawing.Color.Transparent;
            this.BtnIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIr.Location = new System.Drawing.Point(822, -2);
            this.BtnIr.Name = "BtnIr";
            this.BtnIr.Size = new System.Drawing.Size(33, 30);
            this.BtnIr.TabIndex = 3;
            this.BtnIr.Text = "Ir";
            this.BtnIr.UseVisualStyleBackColor = false;
            this.BtnIr.Click += new System.EventHandler(this.BtnIr_Click);
            // 
            // TCCaracteristicas
            // 
            this.TCCaracteristicas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCCaracteristicas.Controls.Add(this.TPDatosGeneralesWeb);
            this.TCCaracteristicas.Controls.Add(this.TPCookies);
            this.TCCaracteristicas.Controls.Add(this.TPTiempos);
            this.TCCaracteristicas.Controls.Add(this.TPPeticiones);
            this.TCCaracteristicas.Location = new System.Drawing.Point(12, 201);
            this.TCCaracteristicas.Name = "TCCaracteristicas";
            this.TCCaracteristicas.SelectedIndex = 0;
            this.TCCaracteristicas.Size = new System.Drawing.Size(850, 249);
            this.TCCaracteristicas.TabIndex = 4;
            // 
            // TPDatosGeneralesWeb
            // 
            this.TPDatosGeneralesWeb.Controls.Add(this.LblRelativeUrl);
            this.TPDatosGeneralesWeb.Controls.Add(this.LblBaseUrl);
            this.TPDatosGeneralesWeb.Controls.Add(this.LblUrl);
            this.TPDatosGeneralesWeb.Location = new System.Drawing.Point(4, 22);
            this.TPDatosGeneralesWeb.Name = "TPDatosGeneralesWeb";
            this.TPDatosGeneralesWeb.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosGeneralesWeb.Size = new System.Drawing.Size(842, 223);
            this.TPDatosGeneralesWeb.TabIndex = 0;
            this.TPDatosGeneralesWeb.Text = "Datos generales del site";
            this.TPDatosGeneralesWeb.UseVisualStyleBackColor = true;
            // 
            // LblRelativeUrl
            // 
            this.LblRelativeUrl.AutoSize = true;
            this.LblRelativeUrl.Location = new System.Drawing.Point(12, 66);
            this.LblRelativeUrl.Name = "LblRelativeUrl";
            this.LblRelativeUrl.Size = new System.Drawing.Size(69, 13);
            this.LblRelativeUrl.TabIndex = 2;
            this.LblRelativeUrl.Text = "URL relativa:";
            // 
            // LblBaseUrl
            // 
            this.LblBaseUrl.AutoSize = true;
            this.LblBaseUrl.Location = new System.Drawing.Point(12, 39);
            this.LblBaseUrl.Name = "LblBaseUrl";
            this.LblBaseUrl.Size = new System.Drawing.Size(59, 13);
            this.LblBaseUrl.TabIndex = 1;
            this.LblBaseUrl.Text = "Base URL:";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(12, 12);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(32, 13);
            this.LblUrl.TabIndex = 0;
            this.LblUrl.Text = "URL:";
            // 
            // TPCookies
            // 
            this.TPCookies.Location = new System.Drawing.Point(4, 22);
            this.TPCookies.Name = "TPCookies";
            this.TPCookies.Padding = new System.Windows.Forms.Padding(3);
            this.TPCookies.Size = new System.Drawing.Size(842, 223);
            this.TPCookies.TabIndex = 1;
            this.TPCookies.Text = "Cookies";
            this.TPCookies.UseVisualStyleBackColor = true;
            // 
            // TPTiempos
            // 
            this.TPTiempos.Controls.Add(this.SlcTipoGraficaTiempo);
            this.TPTiempos.Controls.Add(this.LblTipoGraficaTiempos);
            this.TPTiempos.Controls.Add(this.SlcTipoDatoTiempo);
            this.TPTiempos.Controls.Add(this.LblTipoDatoTiempos);
            this.TPTiempos.Controls.Add(this.CHTiempos);
            this.TPTiempos.Location = new System.Drawing.Point(4, 22);
            this.TPTiempos.Name = "TPTiempos";
            this.TPTiempos.Padding = new System.Windows.Forms.Padding(3);
            this.TPTiempos.Size = new System.Drawing.Size(842, 223);
            this.TPTiempos.TabIndex = 2;
            this.TPTiempos.Text = "Tiempos";
            this.TPTiempos.UseVisualStyleBackColor = true;
            // 
            // SlcTipoGraficaTiempo
            // 
            this.SlcTipoGraficaTiempo.FormattingEnabled = true;
            this.SlcTipoGraficaTiempo.Items.AddRange(new object[] {
            "LINEAS",
            "BARRAS",
            "QUESO"});
            this.SlcTipoGraficaTiempo.Location = new System.Drawing.Point(291, 19);
            this.SlcTipoGraficaTiempo.Name = "SlcTipoGraficaTiempo";
            this.SlcTipoGraficaTiempo.Size = new System.Drawing.Size(304, 21);
            this.SlcTipoGraficaTiempo.TabIndex = 4;
            this.SlcTipoGraficaTiempo.SelectedValueChanged += new System.EventHandler(this.SlcTipoDatoTiempo_SelectedValueChanged);
            // 
            // LblTipoGraficaTiempos
            // 
            this.LblTipoGraficaTiempos.AutoSize = true;
            this.LblTipoGraficaTiempos.Location = new System.Drawing.Point(296, 3);
            this.LblTipoGraficaTiempos.Name = "LblTipoGraficaTiempos";
            this.LblTipoGraficaTiempos.Size = new System.Drawing.Size(41, 13);
            this.LblTipoGraficaTiempos.TabIndex = 3;
            this.LblTipoGraficaTiempos.Text = "Gráfica";
            // 
            // SlcTipoDatoTiempo
            // 
            this.SlcTipoDatoTiempo.FormattingEnabled = true;
            this.SlcTipoDatoTiempo.Items.AddRange(new object[] {
            "ACUMULADO",
            "DIFERENCIAS"});
            this.SlcTipoDatoTiempo.Location = new System.Drawing.Point(9, 19);
            this.SlcTipoDatoTiempo.Name = "SlcTipoDatoTiempo";
            this.SlcTipoDatoTiempo.Size = new System.Drawing.Size(276, 21);
            this.SlcTipoDatoTiempo.TabIndex = 2;
            this.SlcTipoDatoTiempo.SelectedValueChanged += new System.EventHandler(this.SlcTipoDatoTiempo_SelectedValueChanged);
            // 
            // LblTipoDatoTiempos
            // 
            this.LblTipoDatoTiempos.AutoSize = true;
            this.LblTipoDatoTiempos.Location = new System.Drawing.Point(6, 3);
            this.LblTipoDatoTiempos.Name = "LblTipoDatoTiempos";
            this.LblTipoDatoTiempos.Size = new System.Drawing.Size(30, 13);
            this.LblTipoDatoTiempos.TabIndex = 1;
            this.LblTipoDatoTiempos.Text = "Dato";
            // 
            // CHTiempos
            // 
            chartArea1.Name = "ChartArea1";
            this.CHTiempos.ChartAreas.Add(chartArea1);
            this.CHTiempos.IsSoftShadows = false;
            legend1.Name = "Legend1";
            this.CHTiempos.Legends.Add(legend1);
            this.CHTiempos.Location = new System.Drawing.Point(6, 46);
            this.CHTiempos.Name = "CHTiempos";
            this.CHTiempos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CHTiempos.Series.Add(series1);
            this.CHTiempos.Size = new System.Drawing.Size(828, 169);
            this.CHTiempos.TabIndex = 0;
            this.CHTiempos.Text = "Tiempos";
            this.CHTiempos.Click += new System.EventHandler(this.CHTiempos_Click);
            // 
            // TPPeticiones
            // 
            this.TPPeticiones.Controls.Add(this.GRVPeticiones);
            this.TPPeticiones.Location = new System.Drawing.Point(4, 22);
            this.TPPeticiones.Name = "TPPeticiones";
            this.TPPeticiones.Padding = new System.Windows.Forms.Padding(3);
            this.TPPeticiones.Size = new System.Drawing.Size(842, 223);
            this.TPPeticiones.TabIndex = 3;
            this.TPPeticiones.Text = "Peticiones";
            this.TPPeticiones.UseVisualStyleBackColor = true;
            // 
            // GRVPeticiones
            // 
            this.GRVPeticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRVPeticiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRVPeticiones.Location = new System.Drawing.Point(3, 3);
            this.GRVPeticiones.Name = "GRVPeticiones";
            this.GRVPeticiones.Size = new System.Drawing.Size(836, 217);
            this.GRVPeticiones.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.TCCaracteristicas);
            this.Controls.Add(this.BtnIr);
            this.Controls.Add(this.WebView);
            this.Controls.Add(this.TBoxUrl);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navegador";
            ((System.ComponentModel.ISupportInitialize)(this.WebView)).EndInit();
            this.TCCaracteristicas.ResumeLayout(false);
            this.TPDatosGeneralesWeb.ResumeLayout(false);
            this.TPDatosGeneralesWeb.PerformLayout();
            this.TPTiempos.ResumeLayout(false);
            this.TPTiempos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CHTiempos)).EndInit();
            this.TPPeticiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRVPeticiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBoxUrl;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebView;
        private System.Windows.Forms.Button BtnIr;
        private System.Windows.Forms.TabControl TCCaracteristicas;
        private System.Windows.Forms.TabPage TPDatosGeneralesWeb;
        private System.Windows.Forms.TabPage TPCookies;
        private System.Windows.Forms.Label LblRelativeUrl;
        private System.Windows.Forms.Label LblBaseUrl;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.TabPage TPTiempos;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHTiempos;
        private System.Windows.Forms.ComboBox SlcTipoDatoTiempo;
        private System.Windows.Forms.Label LblTipoDatoTiempos;
        private System.Windows.Forms.ComboBox SlcTipoGraficaTiempo;
        private System.Windows.Forms.Label LblTipoGraficaTiempos;
        private System.Windows.Forms.TabPage TPPeticiones;
        private System.Windows.Forms.DataGridView GRVPeticiones;
    }
}

