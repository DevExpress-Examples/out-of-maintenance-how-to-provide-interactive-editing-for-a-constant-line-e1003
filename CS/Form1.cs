using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace InteractiveConstantLine {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Cursor defCursor;
        bool dragging = false;
        ChartControl chart;
        XYDiagram diagram;
        ConstantLine line;

        private void Form1_Load(object sender, EventArgs e) {
            this.chart = this.chartControl1;
            this.diagram = this.chart.Diagram as XYDiagram;
            this.line = this.diagram.AxisX.ConstantLines.GetConstantLineByName("ConstantLine1");

            // Add a title to the chart.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "Drag the constant line...";
            this.chart.Titles.Add(chartTitle1);

        }

        private void chartControl1_MouseDown(object sender, MouseEventArgs e) {
            if (diagram == null)
                return;

            // Get the information about the clicked point.
            DiagramCoordinates coords = diagram.PointToDiagram(e.Location);

            // If the point is within the diagram and in the constant line ...
            if (!coords.IsEmpty && line.AxisValue is DateTime &&
                coords.DateTimeArgument.Equals((DateTime)line.AxisValue)) {

                // Allow dragging, catch the mouse and change the cursor.
                dragging = true;
                chart.Capture = true;
                SetCursor();
            }
        }

        private void chartControl1_MouseUp(object sender, MouseEventArgs e) {
            dragging = false;
            chart.Capture = false;
        }

        private void chartControl1_MouseMove(object sender, MouseEventArgs e) {
            if (diagram == null)
                return;

            if (dragging && (e.Button & MouseButtons.Left) == 0) {
                dragging = false;
                chart.Capture = false;
            }

            DiagramCoordinates coords = diagram.PointToDiagram(e.Location);
            if (coords.IsEmpty)
                RestoreCursor();
            else {
                if (dragging)
                    line.AxisValue = coords.DateTimeArgument;

                if (line.AxisValue is DateTime && coords.DateTimeArgument.Equals((DateTime)line.AxisValue))
                    SetCursor();
                else
                    RestoreCursor();
            }
        }
        void SetCursor() {
            if (defCursor == null)
                defCursor = Cursor.Current;
            Cursor.Current = Cursors.VSplit;
        }

        void RestoreCursor() {
            if (defCursor != null) {
                Cursor.Current = defCursor;
                defCursor = null;
            }
        }

    }
}