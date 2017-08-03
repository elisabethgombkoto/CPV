using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace KNZ.CPV
{
    public abstract class MyShape<T> : UIElement where T : Datas
    {




        /*
        public void DrawOnMyCanvas(T datas, Canvas myCanvas)
        {
            UIElement uiElement = Create(datas);

            double top = CalculateDistanceToUperEdge(datas);
            double left = CalculateDistanceToSideEdge(datas);
            Canvas.SetTop(uiElement, top);
            Canvas.SetLeft(uiElement, left);

            myCanvas.Children.Add(uiElement);
        }

        protected abstract UIElement Create(T datas);
        protected abstract double CalculateDistanceToUperEdge(T datas);
        protected abstract double CalculateDistanceToSideEdge(T datas);

        internal double CalculateXb(double x)
        {
            // double x --> It corresponds to relative position in SPS
            double xEins = 10; //It is assumed here that 10 pixels on the screen corresponds 1 meter in Workspace
            double x0 = 0; // It is assumed here that 0 pixels on the screen is the zero position for the x axis
            double xB; //It corresponds to relative position on the screen

            return xB = x * (xEins - x0) + x0;
        }

        internal double CalculateYb(double y)
        {
            //double y--> It corresponds to relative position in SPS
            double yEins = 10; //It is assumed here that  pixels on the screen corresponds 1 meter in Workspace
            double y0 = 200; // It is assumed here that 250 pixels from the bottom 
                              //on the screen is the zero position for the y axis, this is the total height from the workspace
            double yB = y * (yEins - y0) + y0; // It corresponds to relative position on screen

            return yB;
        }   
        */
    }
}