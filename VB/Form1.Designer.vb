Imports Microsoft.VisualBasic
Imports System
Namespace InteractiveConstantLine
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim constantLine1 As New DevExpress.XtraCharts.ConstantLine()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 1, 1, 0, 0, 0, 0), New Object() { (CObj(4R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 2, 1, 0, 0, 0, 0), New Object() { (CObj(8R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 3, 1, 0, 0, 0, 0), New Object() { (CObj(2R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 4, 1, 0, 0, 0, 0), New Object() { (CObj(16R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 5, 1, 0, 0, 0, 0), New Object() { (CObj(5R))})
			Dim splineSeriesView1 As New DevExpress.XtraCharts.SplineSeriesView()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(splineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			constantLine1.AxisValueSerializable = "02/01/2001 00:00:00.000"
			constantLine1.Name = "ConstantLine1"
			xyDiagram1.AxisX.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() { constantLine1})
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			pointSeriesLabel1.LineVisible = True
			series1.Label = pointSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
			series1.View = splineSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			sideBySideBarSeriesLabel1.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chartControl1.Size = New System.Drawing.Size(486, 347)
			Me.chartControl1.TabIndex = 0
'			Me.chartControl1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.chartControl1_MouseDown);
'			Me.chartControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.chartControl1_MouseMove);
'			Me.chartControl1.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.chartControl1_MouseUp);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(486, 347)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(splineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

