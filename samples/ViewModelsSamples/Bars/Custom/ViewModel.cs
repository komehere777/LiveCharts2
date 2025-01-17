﻿using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.Collections.Generic;

namespace ViewModelsSamples.Bars.Custom
{
    public class ViewModel
    {
        public List<ISeries> Series { get; set; } = new List<ISeries>
        {
            // use the second type argument to specify the geometry to draw for every point
            // there are already many predefined geometries in the
            // LiveChartsCore.SkiaSharpView.Drawing.Geometries namespace
            new ColumnSeries<double, LiveChartsCore.SkiaSharpView.Drawing.Geometries.OvalGeometry>
            {
                Values = new List<double> { 4, 2, 0, 5, 2, 6 },
                Fill = new SolidColorPaint(SKColors.CornflowerBlue)
            },

            // you can also define your own geometry using SVG
            new ColumnSeries<double, MyGeometry>
            {
                Values = new List<double> { 3, 2, 3, 4, 5, 3 },
                Stroke = null,
                Fill = new SolidColorPaint(SKColors.Coral, 5)
            }
        };
    }

    public class MyGeometry : LiveChartsCore.SkiaSharpView.Drawing.Geometries.SVGPathGeometry
    {
        // Icon made by Freepik from www.flaticon.com
        // https://www.flaticon.es/icono-gratis/lineas-en-zigzag-en-posicion-de-vista-lateral_28680?term=line&page=1&position=9&page=1&position=9&related_id=28680&origin=search
        public static SKPath svgPath = SKPath.ParseSvgPathData(
            "M162.119,336.366l-37.218-37.206l39.181-39.183c5.239-5.256,5.239-13.779,0-19.004l-37.037-37.034l39.408-39.407    " +
            "c5.241-5.242,5.241-13.768,0-19.004l-37.221-37.218l39.182-39.181c5.241-5.242,5.241-13.767,0-19.003l-46.19-46.19   " +
            "C119.686,1.399,116.311,0,112.72,0c-3.591,0-6.966,1.399-9.504,3.937c-2.543,2.536-3.934,5.911-3.934,9.502    " +
            "c0,3.59,1.396,6.963,3.934,9.504l36.688,36.688l-39.155,39.155c-2.543,2.536-3.934,5.91-3.934,9.504    " +
            "c0,3.255,1.149,6.335,3.263,8.776l0.134,0.231l37.729,37.73l-39.152,39.153c-2.914,2.914-4.292,6.984-3.795,11.072    " +
            "c0.231,3.202,1.611,6.256,3.89,8.523l36.688,36.694l-39.155,39.15c-5.003,5.008-5.229,12.998-0.688,18.262l0.152,0.263    " +
            "l37.73,37.728L94.455,385.02c-5.242,5.243-5.242,13.769,0,19.002c2.538,2.545,5.913,3.921,9.503,3.921s6.966-1.396,9.505-3.921   " +
            " l48.656-48.662c2.544-2.547,3.935-5.926,3.935-9.518C166.054,342.251,164.673,338.913,162.119,336.366z M154.518,347.769    " +
            "l-48.651,48.662c-0.528,0.529-1.215,0.781-1.903,0.781s-1.375-0.262-1.902-0.781c-1.05-1.045-1.05-2.751,0-3.802l46.753-46.756    " +
            "l-44.292-44.274c-0.118-0.125-0.174-0.272-0.266-0.397c-0.073-0.074-0.165-0.096-0.235-0.158c-1.047-1.049-1.047-2.75,0-3.8    " +
            "l46.756-46.752l-44.289-44.288c-0.536-0.542-0.791-1.245-0.775-1.959c-0.176-0.853,0.019-1.779,0.686-2.441l46.753-46.754    " +
            "l-44.287-44.292c-0.113-0.115-0.167-0.259-0.26-0.388c-0.079-0.063-0.17-0.092-0.247-0.16c-1.047-1.05-1.047-2.754,0-3.802    " +
            "l46.756-46.756l-44.289-44.286c-1.047-1.05-1.047-2.753,0-3.801c1.047-1.049,2.753-1.049,3.8,0l46.193,46.19    " +
            "c1.046,1.05,1.046,2.753,0,3.8l-46.783,46.783l44.814,44.82c1.047,1.049,1.047,2.753,0,3.801l-47.009,47.008l44.638,44.635    " +
            "c1.048,1.051,1.048,2.752,0,3.801l-46.782,46.783l44.819,44.808C155.579,345.012,155.579,346.718,154.518,347.769z"
            + "M234.666,336.366l-37.201-37.206l39.175-39.183c5.24-5.256,5.24-13.779,0-19.004l-37.031-37.034l39.399-39.407    " +
            "c5.238-5.242,5.238-13.768,0-19.004l-37.212-37.213l39.181-39.181c5.245-5.242,5.245-13.767,0-19.003l-46.184-46.19    " +
            "c-2.538-2.538-5.914-3.937-9.504-3.937s-6.966,1.399-9.503,3.937c-2.543,2.536-3.935,5.911-3.935,9.502    " +
            "c0,3.593,1.396,6.963,3.935,9.503l36.693,36.688l-39.155,39.155c-2.543,2.536-3.935,5.914-3.935,9.504    " +
            "c0,3.331,1.209,6.481,3.293,8.83l0.118,0.209l37.709,37.709l-39.142,39.155c-2.893,2.89-4.268,6.927-3.806,10.99    " +
            "c0.214,3.224,1.596,6.299,3.894,8.62l36.684,36.682l-39.143,39.161c-5,4.997-5.23,12.987-0.69,18.252l0.152,0.262l37.724,37.729    " +
            "l-39.15,39.15c-5.241,5.238-5.241,13.774,0,18.997c2.539,2.545,5.914,3.937,9.504,3.937s6.966-1.412,9.504-3.937l48.651-48.661    " +
            "c2.552-2.547,3.927-5.927,3.927-9.518C238.619,342.271,237.212,338.913,234.666,336.366z M227.065,347.769l-48.646,48.662    " +
            "c-0.527,0.529-1.215,0.781-1.903,0.781s-1.377-0.262-1.903-0.781c-1.049-1.045-1.049-2.751,0-3.802l46.746-46.756l-44.279-44.274    " +
            "c-0.118-0.125-0.173-0.272-0.265-0.397c-0.073-0.074-0.165-0.096-0.236-0.158c-1.047-1.049-1.047-2.75,0-3.8l46.743-46.752    " +
            "l-44.281-44.288c-0.543-0.542-0.79-1.261-0.774-1.975c-0.171-0.855,0.023-1.769,0.682-2.431l46.752-46.754l-44.289-44.292    " +
            "c-0.118-0.121-0.171-0.265-0.263-0.394c-0.076-0.061-0.165-0.087-0.236-0.155c-1.047-1.05-1.047-2.754,0-3.801l46.747-46.756    " +
            "L183.375,15.36c-1.048-1.049-1.048-2.753,0-3.801c1.046-1.049,2.75-1.049,3.8,0l46.184,46.19c1.05,1.049,1.05,2.753,0,3.801    " +
            "l-46.769,46.782l44.806,44.814c1.044,1.048,1.044,2.754,0,3.801l-47,47.008l44.632,44.635c1.046,1.04,1.046,2.752,0,3.802    " +
            "l-46.777,46.783l44.804,44.808C228.111,345.012,228.111,346.718,227.065,347.769z"
            + "M311.565,145.529l-37.224-37.218l39.177-39.181c5.249-5.242,5.249-13.767,0-19.003l-46.189-46.19    " +
            "C264.782,1.399,261.412,0,257.822,0c-3.591,0-6.978,1.399-9.512,3.937c-5.249,5.239-5.249,13.764,0,19l36.684,36.688    " +
            "l-39.151,39.153c-2.551,2.538-3.926,5.913-3.926,9.504c0,3.257,1.145,6.338,3.254,8.779l0.127,0.231l37.738,37.73l-39.156,39.152    " +
            "c-2.914,2.914-4.29,6.984-3.795,11.077c0.229,3.202,1.621,6.256,3.899,8.523l36.684,36.694l-39.151,39.15    " +
            "c-5.012,4.997-5.238,12.987-0.691,18.252l0.146,0.262l37.732,37.729l-39.146,39.146c-5.243,5.254-5.243,13.779,0,19.002    " +
            "c2.537,2.545,5.911,3.921,9.502,3.921c3.597,0,6.978-1.396,9.507-3.921l48.667-48.651c2.547-2.557,3.932-5.926,3.932-9.518    " +
            "c0-3.591-1.407-6.961-3.932-9.502l-37.217-37.219l39.175-39.18c5.245-5.24,5.245-13.766,0-19.004l-37.04-37.037l39.413-39.408    " +
            "C316.783,159.296,316.783,150.771,311.565,145.529z M303.964,156.932L256.95,203.94l44.646,44.635    " +
            "c1.046,1.033,1.046,2.757,0,3.802l-46.781,46.783l44.817,44.808c1.046,1.044,1.046,2.75,0,3.801l-48.666,48.662    " +
            "c-0.524,0.529-1.208,0.781-1.906,0.781c-0.688,0-1.376-0.262-1.905-0.781c-1.039-1.045-1.039-2.751,0-3.802l46.752-46.756    " +
            "l-44.296-44.274c-0.109-0.125-0.156-0.272-0.263-0.397c-0.072-0.074-0.15-0.096-0.23-0.158c-1.039-1.049-1.039-2.75,0-3.8    " +
            "l46.752-46.752l-44.285-44.288c-0.54-0.542-0.781-1.245-0.776-1.959c-0.179-0.853,0.016-1.779,0.683-2.441l46.758-46.754    " +
            "l-44.291-44.292c-0.114-0.115-0.168-0.259-0.257-0.388c-0.078-0.063-0.174-0.092-0.247-0.16c-1.049-1.05-1.049-2.754,0-3.802    " +
            "l46.753-46.756l-44.285-44.286c-1.05-1.05-1.05-2.753,0-3.801c1.049-1.049,2.75-1.049,3.8,0l46.19,46.19    " +
            "c1.044,1.05,1.044,2.753,0,3.8l-46.783,46.783l44.814,44.82C305.003,154.173,305.003,155.876,303.964,156.932z"
            );

        public MyGeometry()
            : base(svgPath)
        {

        }
    }
}
