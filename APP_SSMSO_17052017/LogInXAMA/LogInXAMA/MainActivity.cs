using Android.App;
using Android.Widget;
using Android.OS;
using OxyPlot.Xamarin.Android;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;

namespace LogInXAMA
{
    [Activity(Label = "LogInXAMA", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        PlotView view;
        Button btn_punto;
        Button btn_torta;
        Button btn_barra;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

         
           
            SetContentView (Resource.Layout.Main);
            // view = FindViewById<PlotView>(Resource.Id.plot_view1);
            ////btn_punto = FindViewById<Button>(Resource.Id.grafico_punto);
            ////btn_torta = FindViewById<Button>(Resource.Id.gráfico_torta);
            //btn_punto.Click += Btn_punto_Click1;

            //view = FindViewById<PlotView>(Resource.Id.plot_view2);
            //btn_barra = FindViewById<Button>(Resource.Id.btn_graficoBarra);
            //btn_barra.Click += Btn_barra_Click;

            Button btn = FindViewById<Button>(Resource.Id.btnIngresar);
            btn.Click += Btn_Click;

            // ProgressBar pb = FindViewById<ProgressBar>(Resource.Id.progressBar1);                   
            //btn_torta = FindViewById<Button>(Resource.Id.gráfico_torta);
            //btn_torta.Click += Btn_torta_Click;
          

        }

        private void Btn_barra_Click(object sender, EventArgs e)
        {
            view.Model = GraficoBarra();
        }

        private PlotModel GraficoBarra()
        {

            var model = new PlotModel
            {

                Title = "Gráfico Abastecimiento",
                TextColor = OxyColors.Yellow,
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.BottomCenter,
                LegendOrientation = LegendOrientation.Horizontal,
                LegendBorderThickness = 0
            }
           ;

            var s1 = new BarSeries { Title = "2015", StrokeColor = OxyColors.Black, FillColor = OxyColors.BlueViolet, StrokeThickness = 1 };
            s1.Items.Add(new BarItem { Value = 25 });
            s1.Items.Add(new BarItem { Value = 137 });
            s1.Items.Add(new BarItem { Value = 18 });
            s1.Items.Add(new BarItem { Value = 40 });

            var s2 = new BarSeries { Title = "2016", Background = OxyColors.Aqua, StrokeColor = OxyColors.Red, StrokeThickness = 1 };
            s2.Items.Add(new BarItem { Value = 12 });
            s2.Items.Add(new BarItem { Value = 14 });
            s2.Items.Add(new BarItem { Value = 120 });
            s2.Items.Add(new BarItem { Value = 26 });

            var categorias = new CategoryAxis { Position = AxisPosition.Left };
            categorias.Labels.Add("Stock Anual");
            categorias.Labels.Add("Stock Actual");
            categorias.Labels.Add("Stock Consumido");
            categorias.Labels.Add("Merma");

            var valorAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                MinimumPadding = 0,
                MaximumPadding = 0.06,
                AbsoluteMinimum = 0

            };

            model.Series.Add(s1);
            model.Series.Add(s2);

            model.Axes.Add(categorias);
            model.Axes.Add(valorAxis);

            return model;
        }

        private void Btn_punto_Click1(object sender, EventArgs e)
        {
            view.Model = GraficoPunto();
        }

       // private void Btn_punto_Click(object sender, System.EventArgs e)
       // {
       //    view.Model = GraficoPunto();
       //}

        private PlotModel GraficoPunto()
        {
            var modelo = new PlotModel { Title = "Gráfico SSMSO - Abastecimiento", TextColor = OxyColors.Yellow };
            modelo.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            modelo.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Maximum = 10, Minimum = 0 });


            var series1 = new LineSeries
            {

                Color = OxyColors.Green,
                MarkerType = MarkerType.Star,
                MarkerSize = 5,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.Black,
                MarkerStrokeThickness = 4.0

            };

            series1.Points.Add(new DataPoint(0.0, 6.0));
            series1.Points.Add(new DataPoint(1.4, 2.1));
            series1.Points.Add(new DataPoint(2.0, 4.2));
            series1.Points.Add(new DataPoint(3.3, 2.3));
            series1.Points.Add(new DataPoint(4.7, 7.0));

            modelo.Series.Add(series1);


            return modelo;
        }

        private void Btn_torta_Click(object sender, EventArgs e)
        {


            view.Model = GraficoTorta();


        }

        private PlotModel GraficoTorta()
        {
            PlotModel modelTorta = new PlotModel { Title = "Insumos Abastecimiento SSMSO 2017", TextColor = OxyColors.Yellow };
            var seriesTorta = new PieSeries
            {
                StrokeThickness = 2.0,
                InsideLabelPosition = 0.8,
                AngleSpan = 360,
                StartAngle = 0,
            };
            seriesTorta.Slices.Add(new PieSlice("Stock Consumido", 1030) { IsExploded = false, Fill = OxyColors.PaleGreen });
            //seriesTorta.Slices.Add(new PieSlice("América", 929) { IsExploded = true });
            seriesTorta.Slices.Add(new PieSlice("Stock Actual", 4157) { IsExploded = true });
            seriesTorta.Slices.Add(new PieSlice("Merma", 739) { IsExploded = true });
            seriesTorta.Slices.Add(new PieSlice("Otros", 35) { IsExploded = true });

            modelTorta.Series.Add(seriesTorta);

            return modelTorta;
        }

        private void Btn_Click(object sender, System.EventArgs e)
        {


            WSZero.ServiciosWebSSMSO servicio = new WSZero.ServiciosWebSSMSO();
            WSZero.ingresoIdentidad id = new WSZero.ingresoIdentidad();
         
         
            string usuario = FindViewById<EditText>(Resource.Id.txtUsuario).Text;
            string password = FindViewById<EditText>(Resource.Id.txtPass).Text;

            id.nPassword = password;
            id.nUsuario = usuario;
            WSZero.sIdentidad respuesta = new WSZero.sIdentidad();
           
            respuesta = servicio.MetControlIdentidad(id);
            ProgressBar pb = FindViewById<ProgressBar>(Resource.Id.progressBar1);
            pb.Progress = 35;

            string lala = respuesta.nPerfil.ToString();
            FindViewById<TextView>(Resource.Id.txtHablador).Text = respuesta.nPerfil.ToString();

            if (lala.Equals("1") || lala.Equals("3")||lala.Equals("2"))
            {
                int variable = int.Parse(lala);

                switch (variable)
                {
                    case 1:
                        pb.Progress = 75;
                        //Genero el axml y su perfil definido
                        SetContentView(Resource.Layout.Perfil1);
                        //Inicializo los gráficos 
                        view = FindViewById<PlotView>(Resource.Id.plot_view1);
                        //Gráfico Barra
                        btn_punto = FindViewById<Button>(Resource.Id.grafico_punto);
                        btn_punto.Click += Btn_punto_Click1;
                        //Gráfico Torta
                        btn_torta = FindViewById<Button>(Resource.Id.gráfico_torta);
                        btn_torta.Click += Btn_torta_Click;
                        FindViewById<TextView>(Resource.Id.txtFecha).Text = respuesta.nfechaEmision.ToString();
                        FindViewById<TextView>(Resource.Id.txtnombreUsuario).Text = respuesta.nNombres.ToString();
                        FindViewById<TextView>(Resource.Id.txtCargo).Text = respuesta.nCargoEmpresa.ToString();
                        FindViewById<TextView>(Resource.Id.txtRut).Text = respuesta.nRun.ToString()+" - "+respuesta.nDigito.ToString();
                        
                        pb.Progress = 100;

                        break;
                    case 2:

                        pb.Progress = 75;

                        SetContentView(Resource.Layout.Ingreso);
                        FindViewById<TextView>(Resource.Id.txtFecha).Text = respuesta.nfechaEmision.ToString();
                        FindViewById<TextView>(Resource.Id.txtnombreUsuario).Text = respuesta.nNombres.ToString();
                        FindViewById<TextView>(Resource.Id.txtCargo).Text = respuesta.nCargoEmpresa.ToString();
                        FindViewById<TextView>(Resource.Id.txtRut).Text = respuesta.nRun.ToString() + " - " + respuesta.nDigito.ToString();
                        FindViewById<TextView>(Resource.Id.txtMensaje).Text = "\r   \n " + "Usted No cuenta con los privilegios para hacer consumo de esta App";

                        pb.Progress = 100;
                        break;
                    case 3:
                        pb.Progress = 75;

                        SetContentView(Resource.Layout.Perfil3);
                        //Gráfico de barra
                        view = FindViewById<PlotView>(Resource.Id.plot_view2);
                        btn_barra = FindViewById<Button>(Resource.Id.btn_graficoBarra);
                        btn_barra.Click += Btn_barra_Click;

                        FindViewById<TextView>(Resource.Id.txtFecha).Text = respuesta.nfechaEmision.ToString();
                        FindViewById<TextView>(Resource.Id.txtnombreUsuario).Text = respuesta.nNombres.ToString();
                        FindViewById<TextView>(Resource.Id.txtCargo).Text = respuesta.nCargoEmpresa.ToString();
                        FindViewById<TextView>(Resource.Id.txtRut).Text = respuesta.nRun.ToString() + " - " + respuesta.nDigito.ToString();
                        
                        pb.Progress = 100;
                        break;
                    default:

                        
                        break;


                }

                //pb.Progress = 75;

                //SetContentView(Resource.Layout.Ingreso);
                //FindViewById<TextView>(Resource.Id.txtFecha).Text = respuesta.nfechaEmision.ToString();
                //FindViewById<TextView>(Resource.Id.txtnombreUsuario).Text = respuesta.nNombres.ToString();
                //FindViewById<TextView>(Resource.Id.txtPerfil).Text = respuesta.nPerfil.ToString();
                //FindViewById<TextView>(Resource.Id.txtRut).Text = respuesta.nRun.ToString();


                //pb.Progress = 100;



            }
            else
            {
                pb.Progress = 99;
                FindViewById<TextView>(Resource.Id.txtError).Text = respuesta.ndescripcion.ToString();
             
            }

            //servicio.Dispose();
        }

        //public void Limpiar() {


        //    //FindViewById<EditText>(Resource.Id.txtUsuario).Text = string.Empty.ToString();
        //    //FindViewById<EditText>(Resource.Id.txtPass).Text = string.Empty.ToString();
        //    //FindViewById<TextView>(Resource.Id.txtFecha).Text = string.Empty.ToString();
        //    //FindViewById<TextView>(Resource.Id.txtnombreUsuario).Text = string.Empty.ToString();
        //    //FindViewById<TextView>(Resource.Id.txtPerfil).Text = string.Empty.ToString();
        //   //FindViewById<TextView>(Resource.Id.txtRut).Text = string.Empty.ToString();
        //}


       
    }
}

