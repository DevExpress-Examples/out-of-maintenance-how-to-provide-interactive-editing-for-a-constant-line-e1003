Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace InteractiveConstantLine
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private defCursor As Cursor
		Private dragging As Boolean = False
		Private chart As ChartControl
		Private diagram As XYDiagram
		Private line As ConstantLine

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.chart = Me.chartControl1
			Me.diagram = TryCast(Me.chart.Diagram, XYDiagram)
			Me.line = Me.diagram.AxisX.ConstantLines.GetConstantLineByName("ConstantLine1")

			' Add a title to the chart.
			Dim chartTitle1 As New ChartTitle()
			chartTitle1.Text = "Drag the constant line..."
			Me.chart.Titles.Add(chartTitle1)

		End Sub

		Private Sub chartControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chartControl1.MouseDown
			If diagram Is Nothing Then
				Return
			End If

			' Get the information about the clicked point.
			Dim coords As DiagramCoordinates = diagram.PointToDiagram(e.Location)

			' If the point is within the diagram and in the constant line ...
			If (Not coords.IsEmpty) AndAlso TypeOf line.AxisValue Is DateTime AndAlso coords.DateTimeArgument.Equals(CDate(line.AxisValue)) Then

				' Allow dragging, catch the mouse and change the cursor.
				dragging = True
				chart.Capture = True
				SetCursor()
			End If
		End Sub

		Private Sub chartControl1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chartControl1.MouseUp
			dragging = False
			chart.Capture = False
		End Sub

		Private Sub chartControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chartControl1.MouseMove
			If diagram Is Nothing Then
				Return
			End If

			If dragging AndAlso (e.Button And MouseButtons.Left) = 0 Then
				dragging = False
				chart.Capture = False
			End If

			Dim coords As DiagramCoordinates = diagram.PointToDiagram(e.Location)
			If coords.IsEmpty Then
				RestoreCursor()
			Else
				If dragging Then
					line.AxisValue = coords.DateTimeArgument
				End If

				If TypeOf line.AxisValue Is DateTime AndAlso coords.DateTimeArgument.Equals(CDate(line.AxisValue)) Then
					SetCursor()
				Else
					RestoreCursor()
				End If
			End If
		End Sub
		Private Sub SetCursor()
			If defCursor Is Nothing Then
				defCursor = Cursor.Current
			End If
			Cursor.Current = Cursors.VSplit
		End Sub

		Private Sub RestoreCursor()
			If defCursor IsNot Nothing Then
				Cursor.Current = defCursor
				defCursor = Nothing
			End If
		End Sub

	End Class
End Namespace