using KNZ.CPV;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace KNZ.CPV
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VisualizationViewModel _vm;


        private Point _pointOnClick; // Click Position for panning
        private ScaleTransform _scaleTransform;
        private TranslateTransform _translateTransform;
        private TransformGroup _transformGroup;


        public MainWindow()
        {
            InitializeComponent();
            DataController mdc = new DataController();
            //TODO It should be so that Calculator know the Canvas, it did not work
            //Calculator calculator = new Calculator(Canvas); 
            Calculator calculator = new Calculator();
            VisualizationController visualizationController = new VisualizationController(mdc, calculator);
            _vm = new VisualizationViewModel(Canvas, visualizationController );


            _translateTransform = new TranslateTransform();
            _scaleTransform = new ScaleTransform();
            _transformGroup = new TransformGroup();
            _transformGroup.Children.Add(_scaleTransform);
            _transformGroup.Children.Add(_translateTransform);
            

            Canvas.RenderTransform = _transformGroup;
            DataContext = _vm;
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Capture Mouse
            Canvas.CaptureMouse();
            //Store click position relation to Parent of the canvas
            _pointOnClick = e.GetPosition((FrameworkElement)Canvas.Parent);
        }

        private void Canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //Release Mouse Capture
            Canvas.ReleaseMouseCapture();
            //Set cursor by default
            Mouse.OverrideCursor = null;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
           
            //Return if mouse is not captured
            if (!Canvas.IsMouseCaptured) return;
            //Point on move from Parent
            Point pointOnMove = e.GetPosition((FrameworkElement)Canvas.Parent);
            //set TranslateTransform
            _translateTransform.X = Canvas.RenderTransform.Value.OffsetX - (_pointOnClick.X - pointOnMove.X);
            _translateTransform.Y = Canvas.RenderTransform.Value.OffsetY - (_pointOnClick.Y - pointOnMove.Y);
            //Update pointOnClic
            _pointOnClick = e.GetPosition((FrameworkElement)Canvas.Parent);
        }

        private void Canvas_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            //Point de la souris
            Point mousePosition = e.GetPosition(Canvas);
            //Actual Zoom
            double zoomNow = Math.Round(Canvas.RenderTransform.Value.M11, 1);
            //ZoomScale
            double zoomScale = 0.1;
            //Positive or negative zoom
            double valZoom = e.Delta > 0 ? zoomScale : -zoomScale;
            //Point de la souris pour le panning et zoom/dezoom
            Point pointOnMove = e.GetPosition((FrameworkElement)Canvas.Parent);
            //RenderTransformOrigin (doesn't fully working)
            Canvas.RenderTransformOrigin = new Point(mousePosition.X / Canvas.ActualWidth, mousePosition.Y / Canvas.ActualHeight);
            //Appel du zoom
            Zoom(new Point(mousePosition.X, mousePosition.Y), zoomNow + valZoom);
        }

        /// Zoom function
        private void Zoom(Point point, double scale)
        {
            //Calcul des centres selon la position de la souris
            double centerX = (point.X - _translateTransform.X) / _scaleTransform.ScaleX;
            double centerY = (point.Y - _translateTransform.Y) / _scaleTransform.ScaleY;
            //Mise à l'échelle
            _scaleTransform.ScaleX = scale;
            _scaleTransform.ScaleY = scale;
            //Retablissement du translate pour éviter un décalage
            _translateTransform.X = point.X - centerX * _scaleTransform.ScaleX;
            _translateTransform.Y = point.Y - centerY * _scaleTransform.ScaleY;
        }
    }
}
