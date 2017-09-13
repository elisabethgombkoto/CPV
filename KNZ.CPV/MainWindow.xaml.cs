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
        private VisualizationViewModel _visualizationVM;
        private Point _centerPoint;
        private Point _onClickPoint; // Click Position for panning
        private ScaleTransform _scaleTransform;
        private TranslateTransform _translateTransform;
        private TransformGroup _transformGroup;


        public MainWindow()
        {
            InitializeComponent();
            MockMonitorDataProvider dmc = new MockMonitorDataProvider();
            ConverterStrategy calculator = new ConverterStrategy(Canvas.Width, Canvas.Height);
            VisualizationController visualizationController = new VisualizationController(dmc, calculator);
            _visualizationVM = new VisualizationViewModel(Canvas, visualizationController );


            _translateTransform = new TranslateTransform();
            _scaleTransform = new ScaleTransform();
            _transformGroup = new TransformGroup();
            _transformGroup.Children.Add(_scaleTransform);
            _transformGroup.Children.Add(_translateTransform);           

            Canvas.RenderTransform = _transformGroup;
            DataContext = _visualizationVM;
        }

       
        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {           
            Canvas.CaptureMouse();
            //Store click position relation to Parent of the canvas
            _onClickPoint = e.GetPosition((FrameworkElement)Canvas.Parent);     
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
            Point onMovePoint = e.GetPosition((FrameworkElement)Canvas.Parent);           
                     
            //set TranslateTransform
            _translateTransform.X = Canvas.RenderTransform.Value.OffsetX - (_onClickPoint.X - onMovePoint.X);
            _translateTransform.Y = Canvas.RenderTransform.Value.OffsetY - (_onClickPoint.Y - onMovePoint.Y);
            //Update pointOnClic
            _onClickPoint = e.GetPosition((FrameworkElement)Canvas.Parent);
        }

        private void Canvas_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            Point mousePosition = e.GetPosition(Canvas);
            //Actual Zoom
            double zoomNow = Math.Round(Canvas.RenderTransform.Value.M11, 1);
            //ZoomScale
            double zoomScale = 0.1;
            //Positive or negative zoom
            double valZoom = e.Delta > 0 ? zoomScale : -zoomScale;
            Point pointOnMove = e.GetPosition((FrameworkElement)Canvas.Parent);
            Canvas.RenderTransformOrigin = new Point(mousePosition.X / Canvas.ActualWidth, mousePosition.Y / Canvas.ActualHeight);
            Zoom(new Point(mousePosition.X, mousePosition.Y), zoomNow + valZoom);
        }

        /// Zoom function
        private void Zoom(Point point, double scale)
        {
            double centerX = (point.X - _translateTransform.X) / _scaleTransform.ScaleX;
            double centerY = (point.Y - _translateTransform.Y) / _scaleTransform.ScaleY;
          
            _scaleTransform.ScaleX = scale;
            _scaleTransform.ScaleY = scale;
            _translateTransform.X = point.X - centerX * _scaleTransform.ScaleX;
            _translateTransform.Y = point.Y - centerY * _scaleTransform.ScaleY;
        }


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                if (_centerPoint == null)
                {
                    _centerPoint.Y = _visualizationVM.BGImage.Height / 2;
                    _centerPoint.X = _visualizationVM.BGImage.Width / 2;
                }
                Zoom(_centerPoint, 1);//zoom to original size
                RestoreView();   //show bild in center the window             
            }
        }

        private void RestoreView()
        {
            _translateTransform.X = _centerPoint.X;
            _translateTransform.Y = _centerPoint.Y;
        }
    }
}
