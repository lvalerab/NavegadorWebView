using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Web.WebView2.Core;

namespace LfvbNavegador.Utils.Timing
{
    public class EntryOfTime
    {
        public string Etiqueta { get; set; }
        public String Mensaje { get; set; }
        public DateTime Tiempo { get; set; }
    }

    public class TableOfTime
    {
        private IList<EntryOfTime> _tiempos;
        private CoreWebView2 _vistaHtml;
        private Chart _diagrama;
        private DataGridView _grid;

        public String CuentaValores { get; set; }
        public String TipoGrafica { get; set; }

        public TableOfTime(CoreWebView2 vistaHtml, Chart diagrama, DataGridView grid)
        {
            this._vistaHtml = vistaHtml;
            this._diagrama = diagrama;
            this._grid = grid;
            this._vistaHtml.NavigationStarting += _vistaHtml_NavigationStarting;
            this._vistaHtml.ContentLoading += _vistaHtml_ContentLoading;
            this._vistaHtml.NavigationCompleted += _vistaHtml_NavigationCompleted;
            this._vistaHtml.DOMContentLoaded += _vistaHtml_DOMContentLoaded;
            this._vistaHtml.FrameNavigationCompleted += _vistaHtml_FrameNavigationCompleted;
            this._vistaHtml.FrameNavigationStarting += _vistaHtml_FrameNavigationStarting;
            this._vistaHtml.WebMessageReceived += _vistaHtml_WebMessageReceived;
            this._vistaHtml.WebResourceRequested += _vistaHtml_WebResourceRequested;
            this._vistaHtml.WebResourceResponseReceived += _vistaHtml_WebResourceResponseReceived;
        }

        private void _vistaHtml_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            if (this._tiempos != null)
            {
                this._tiempos.Add(new EntryOfTime
                {
                    Etiqueta = "MENSAJE RECIVIDO",
                    Mensaje = "Mensaje recibido " + e.TryGetWebMessageAsString(),
                    Tiempo = DateTime.Now
                });
                this.DibujaDiagrama();
            }
        }

        private void _vistaHtml_WebResourceResponseReceived(object sender, CoreWebView2WebResourceResponseReceivedEventArgs e)
        {
            if (this._tiempos != null)
            {
                this._tiempos.Add(new EntryOfTime
                {
                    Etiqueta = "RECURSO SOLICITADO OBTENIDO",
                    Mensaje = "Se obtiene el recurso " + e.Request.Uri,
                    Tiempo = DateTime.Now
                });
                this.DibujaDiagrama();
            }
        }

        private void _vistaHtml_WebResourceRequested(object sender, CoreWebView2WebResourceRequestedEventArgs e)
        {
            if (this._tiempos != null)
            {
                this._tiempos.Add(new EntryOfTime
                {
                    Etiqueta = "SOLICITUD DE RECURSO",
                    Mensaje = "Se solicita el recurso "+e.Request.Uri,
                    Tiempo = DateTime.Now
                });
                this.DibujaDiagrama();
            }
        }

        private void _vistaHtml_FrameNavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            if (this._tiempos != null)
            {
                this._tiempos.Add(new EntryOfTime
                {
                    Etiqueta = "CARGA DE FRAME INICIADO",
                    Mensaje = "Se empieza la carga del frame",
                    Tiempo = DateTime.Now
                });
                this.DibujaDiagrama();
            }
        }

        private void _vistaHtml_FrameNavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (this._tiempos != null)
            {
                this._tiempos.Add(new EntryOfTime
                {
                    Etiqueta = "FRAME CARGADO",
                    Mensaje = "Se ha terminado la carga del frame",
                    Tiempo = DateTime.Now
                });
                this.DibujaDiagrama();
            }
        }

        private void _vistaHtml_DOMContentLoaded(object sender, CoreWebView2DOMContentLoadedEventArgs e)
        {
            if (this._tiempos != null)
            {
                this._tiempos.Add(new EntryOfTime
                {
                    Etiqueta = "DOM CARGADO",
                    Mensaje = "Se ha terminado el dom de la página",
                    Tiempo = DateTime.Now
                });
                this.DibujaDiagrama();
            }
        }

        private void _vistaHtml_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (this._tiempos != null)
            {
                this._tiempos.Add(new EntryOfTime
                {
                    Etiqueta = "NAVEGACION TERMINADA",
                    Mensaje = "Se ha terminado la navegación",
                    Tiempo = DateTime.Now
                });
                this.DibujaDiagrama();
            }
        }

        private void _vistaHtml_ContentLoading(object sender, CoreWebView2ContentLoadingEventArgs e)
        {
            if(this._tiempos!=null)
            {
                this._tiempos.Add(new EntryOfTime
                {
                    Etiqueta="CARGA CONTENIDO",
                    Mensaje="Se carga el contenido",
                    Tiempo=DateTime.Now
                });
            }
        }

        private void _vistaHtml_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            this._tiempos = new List<EntryOfTime>();
            this._tiempos.Add(new EntryOfTime
            {
                Etiqueta="INICIO",
                Mensaje="Se inicia la navegación a "+e.Uri,
                Tiempo=DateTime.Now
            });
        }
    
        public void DibujaDiagrama()
        {
            this._diagrama.Series.Clear();
            Series serie = new Series();
            if(this.TipoGrafica==String.Empty)
            {
                this.TipoGrafica = "BARRAS";
            }
            if(this.CuentaValores==String.Empty)
            {
                this.CuentaValores = "ACUMULADO";
            }
            switch(this.CuentaValores)
            {
                case "ACUMULADO":
                        serie = new Series("Tiempos absolutos");
                        EntryOfTime inicio = this._tiempos[0];
                        for (int i = 0; i < this._tiempos.Count; i++)
                        {
                            TimeSpan dif = this._tiempos[i].Tiempo.Subtract(inicio.Tiempo);
                            serie.Points.Add(new DataPoint
                            {
                                //AxisLabel=this._tiempos[i].Etiqueta,                                
                                XValue = i,
                                YValues = new double[] { dif.TotalSeconds },
                                ToolTip = this._tiempos[i].Etiqueta + " (" + this._tiempos[i].Mensaje + ")"
                            });
                        }
                    break;
                case "DIFERENCIAS":
                        serie = new Series("Tiempo relativo");
                        for (int i = 1; i < this._tiempos.Count; i++)
                        {
                            TimeSpan dif = this._tiempos[i].Tiempo.Subtract(this._tiempos[i - 1].Tiempo);
                            serie.Points.Add(new DataPoint
                            {
                                //AxisLabel = this._tiempos[i].Etiqueta,
                                XValue = i,
                                YValues = new double[] { dif.TotalSeconds },
                                ToolTip = this._tiempos[i].Etiqueta + " (" + this._tiempos[i].Mensaje + ")"
                            });
                        }
                    break;
            }
            switch(this.TipoGrafica)
            {
                case "LINEAS":
                    serie.ChartType = SeriesChartType.ThreeLineBreak;
                    break;
                case "BARRAS":
                    serie.ChartType = SeriesChartType.Bar;
                    break;
                case "QUESO":
                    serie.ChartType = SeriesChartType.Pie;
                    break;
            }
            this._diagrama.Series.Add(serie);
            this.RefrescaGridPeticiones();
        }
            
        public void RefrescaGridPeticiones()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("TIEMPO", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("TIEMPO_ANT", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("ACUMULADO", typeof(TimeSpan)));
            dt.Columns.Add(new DataColumn("DIFERENCIA", typeof(TimeSpan)));
            dt.Columns.Add(new DataColumn("ETIQUETA", typeof(String)));
            dt.Columns.Add(new DataColumn("MENSAJE", typeof(String)));

            EntryOfTime inicial = null;
            EntryOfTime anterior = null;
            for(var i=0;i<this._tiempos.Count;i++)
            {
                if(inicial==null)
                {
                    inicial = this._tiempos[i];
                }
                DataRow dr = dt.NewRow();
                dr["TIEMPO"] = this._tiempos[i].Tiempo;
                dr["ACUMULADO"] = this._tiempos[i].Tiempo.Subtract(inicial.Tiempo);
                if(anterior!=null)
                {
                    dr["TIEMPO_ANT"] = anterior.Tiempo;
                    dr["DIFERENCIA"] = this._tiempos[i].Tiempo.Subtract(anterior.Tiempo);
                } else
                {
                    dr["TIEMPO_ANT"] = this._tiempos[i].Tiempo;
                    dr["DIFERENCIA"] = TimeSpan.Zero;
                };
                dr["ETIQUETA"] = this._tiempos[i].Etiqueta;
                dr["MENSAJE"] = this._tiempos[i].Mensaje;
                anterior = this._tiempos[i];
                dt.Rows.Add(dr);
            }
            this._grid.DataSource = dt;
        }    
            
    }
}
