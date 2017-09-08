﻿using Prism.Commands;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace KNZ.CPV
{
    public class VisualizationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Canvas MyCanvas { get; }

        private VisualizationController _visualizationController;
        private DispatcherTimer _dispatchedTimer;
        private ImageSource _BGImage = new BitmapImage(new Uri(@".\pic.png", UriKind.Relative));


        private bool _hasTimerStared;
        private bool HasTimerStarted
        {
            get { return _hasTimerStared; }
            set
            {
                _hasTimerStared = value;
                _startVisualisingCommand.RaiseCanExecuteChanged();
                _stopVisualisingCommand.RaiseCanExecuteChanged();
            }
        }

        private DelegateCommand _startVisualisingCommand;
        public ICommand StartVisualisingCommand
        {
            get
            {
                if (_startVisualisingCommand == null)
                {
                    _startVisualisingCommand = new DelegateCommand(ExecuteStartVisualisingCommand, CanExecuteStartVisualisingCommand);
                }

                return _startVisualisingCommand;
            }
        }

        private DelegateCommand _stopVisualisingCommand;
        public ICommand StopVisualisingCommand
        {
            get
            {
                if (_stopVisualisingCommand == null)
                {
                    _stopVisualisingCommand = new DelegateCommand(ExecuteStopVisualisingCommand, CanExecuteStopVisualisingCommand);
                }
                return _stopVisualisingCommand;
            }
        }



        public VisualizationViewModel(Canvas canvas, VisualizationController visualizationController)
        {
            MyCanvas = canvas;
            _visualizationController = visualizationController;
            _dispatchedTimer = new DispatcherTimer();
            _dispatchedTimer.Interval = TimeSpan.FromMilliseconds(1);
            _dispatchedTimer.Tick += (object s, System.EventArgs e) =>
            {
                Draw();
            };
        }



        public ImageSource BGImage
        {
            get { return _BGImage; }
            set
            {
                _BGImage = value;
                NotifyPropertyChanged();
            }
        }



        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Draw()
        {
            _visualizationController.DrawShapesOnCanvas(MyCanvas);
        }



        private void ExecuteStartVisualisingCommand()
        {
            _dispatchedTimer.Start();
            HasTimerStarted = true;
        }

        private void ExecuteStopVisualisingCommand()
        {
            _dispatchedTimer.Stop();
            HasTimerStarted = false;
        }


        private bool CanExecuteStartVisualisingCommand()
        {
            return !HasTimerStarted;
        }

        private bool CanExecuteStopVisualisingCommand()
        {
            return HasTimerStarted;
        }


    }
}