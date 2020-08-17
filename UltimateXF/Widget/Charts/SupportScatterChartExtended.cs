﻿using System;
using UltimateXF.Widget.Charts.Models.Component;
using UltimateXF.Widget.Charts.Models.Legend;
using UltimateXF.Widget.Charts.Models.ScatterChart;
using Xamarin.Forms;

namespace UltimateXF.Widget.Charts
{
    public class SupportScatterChartExtended : SupportBarLineChartBase
    {
        public static readonly BindableProperty ChartDataProperty = BindableProperty.Create("ChartData", typeof(ScatterChartData), typeof(SupportScatterChartExtended), null);
        public ScatterChartData ChartData
        {
            get => (ScatterChartData)GetValue(ChartDataProperty);
            set => SetValue(ChartDataProperty, value);
        }

        public SupportScatterChartExtended()
        {
            AxisLeft = new YAxisConfig();
            AxisRight = new YAxisConfig();
            XAxis = new XAxisConfig();
            DescriptionChart = new ChartDescription();
            AnimationX = new AnimatorXF();
            AnimationY = new AnimatorXF();
            Legend = new LegendXF();
        }
    }
}