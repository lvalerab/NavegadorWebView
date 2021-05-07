using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using LfvbNavegador.Utils.Timing;
using Microsoft.Web.WebView2.Core;

namespace LfvbNavegador
{
    public partial class Form1 : Form
    {
        private TableOfTime _tiempos;
        public Form1()
        {
            InitializeComponent();
            this.WebView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
        }

        private void WebView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            this.WebView.CoreWebView2.ContentLoading += new EventHandler<CoreWebView2ContentLoadingEventArgs>(this.OnContentLoagind);
            this.WebView.CoreWebView2.DOMContentLoaded += CoreWebView2_DOMContentLoaded;
            this._tiempos = new TableOfTime(this.WebView.CoreWebView2,this.CHTiempos,this.GRVPeticiones);

        }

        private void BtnIr_Click(object sender, EventArgs e)
        {
            Navegar(this.TBoxUrl.Text);
        }

        private void CoreWebView2_DOMContentLoaded(object sender, CoreWebView2DOMContentLoadedEventArgs e)
        {
            Console.WriteLine("Se ha cargado");          
            this.Text = "" + this.WebView.CoreWebView2.DocumentTitle;
            if(this.TBoxUrl.Text.Trim()==String.Empty)
            {
                this.TBoxUrl.Text = this.WebView.Source.ToString();
            }        
         
        }

        private void OnContentLoagind(object sender, CoreWebView2ContentLoadingEventArgs e)
        {

            Console.WriteLine("Se ha cargado");
            if (e.IsErrorPage)
            {
                this.Text = "Error al cargar la página";
            }
            else
            {
                this.Text = "Abriendo: " + this.WebView.CoreWebView2.DocumentTitle;
                this.LblUrl.Text ="Url: "+ this.WebView.CoreWebView2.Source;
                if(new Uri(this.WebView.CoreWebView2.Source).Query!=String.Empty) { 
                    this.LblBaseUrl.Text = "Base URL: " + new Uri(this.WebView.CoreWebView2.Source).AbsoluteUri.Replace(new Uri(this.WebView.CoreWebView2.Source).Query, "");
                } else
                {
                    this.LblBaseUrl.Text = "Base URL: " + new Uri(this.WebView.CoreWebView2.Source).AbsoluteUri;
                };
                this.LblRelativeUrl.Text = "URL relativa: " + new Uri(this.WebView.CoreWebView2.Source).Query;
            }
        }

        private void TBoxUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                this.BtnIr_Click(sender, e);
            }
        }

      
        private void Navegar(string Url)
        {
            if (Url.Trim() != String.Empty && this.WebView != null && this.WebView.CoreWebView2 != null)
            {
                if (!Url.Trim().ToUpper().Contains("HTTP"))
                {
                    Url = "https://" + Url.Trim();
                }
                this.WebView.CoreWebView2.Navigate(Url);
                this.TBoxUrl.Text = Url;
            }
        }

        private void CHTiempos_Click(object sender, EventArgs e)
        {

        }

        private void SlcTipoDatoTiempo_SelectedValueChanged(object sender, EventArgs e)
        {
            this._tiempos.CuentaValores = this.SlcTipoDatoTiempo.Text;
            this._tiempos.TipoGrafica = this.SlcTipoGraficaTiempo.Text;
            this._tiempos.DibujaDiagrama();
        }
    }
}
