﻿using SkiaSharp;

namespace ScottPlot.Axis.StandardAxes;

public class LeftAxis : YAxisBase, IYAxis
{
    public override Edge Edge { get; } = Edge.Left;

    public LeftAxis()
    {
        TickGenerator = new TickGenerators.ScottPlot4.NumericTickGenerator(true);
    }
}