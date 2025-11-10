<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLoadFile = New Button()
        btnRunSim = New Button()
        btnExport = New Button()
        TabControl1 = New TabControl()
        Summary = New TabPage()
        DetailedLog = New TabPage()
        rtxSummary = New RichTextBox()
        rtxDetailedLog = New RichTextBox()
        openFileLoader = New OpenFileDialog()
        saveFileExporter = New SaveFileDialog()
        TabControl1.SuspendLayout()
        Summary.SuspendLayout()
        DetailedLog.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLoadFile
        ' 
        btnLoadFile.Location = New Point(545, 343)
        btnLoadFile.Name = "btnLoadFile"
        btnLoadFile.Size = New Size(112, 34)
        btnLoadFile.TabIndex = 0
        btnLoadFile.Text = "Load File"
        btnLoadFile.UseVisualStyleBackColor = True
        ' 
        ' btnRunSim
        ' 
        btnRunSim.Location = New Point(545, 456)
        btnRunSim.Name = "btnRunSim"
        btnRunSim.Size = New Size(112, 34)
        btnRunSim.TabIndex = 1
        btnRunSim.Text = "Run Sim"
        btnRunSim.UseVisualStyleBackColor = True
        ' 
        ' btnExport
        ' 
        btnExport.Location = New Point(545, 571)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(112, 34)
        btnExport.TabIndex = 2
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Summary)
        TabControl1.Controls.Add(DetailedLog)
        TabControl1.Location = New Point(-3, 979)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(3199, 816)
        TabControl1.TabIndex = 3
        ' 
        ' Summary
        ' 
        Summary.Controls.Add(rtxSummary)
        Summary.Location = New Point(4, 34)
        Summary.Name = "Summary"
        Summary.Padding = New Padding(3)
        Summary.Size = New Size(3191, 778)
        Summary.TabIndex = 0
        Summary.Text = "Summary"
        Summary.UseVisualStyleBackColor = True
        ' 
        ' DetailedLog
        ' 
        DetailedLog.Controls.Add(rtxDetailedLog)
        DetailedLog.Location = New Point(4, 34)
        DetailedLog.Name = "DetailedLog"
        DetailedLog.Padding = New Padding(3)
        DetailedLog.Size = New Size(3191, 778)
        DetailedLog.TabIndex = 1
        DetailedLog.Text = "Detailed Log"
        DetailedLog.UseVisualStyleBackColor = True
        ' 
        ' rtxSummary
        ' 
        rtxSummary.Location = New Point(0, 0)
        rtxSummary.Name = "rtxSummary"
        rtxSummary.Size = New Size(3188, 778)
        rtxSummary.TabIndex = 0
        rtxSummary.Text = ""
        ' 
        ' rtxDetailedLog
        ' 
        rtxDetailedLog.Location = New Point(0, 6)
        rtxDetailedLog.Name = "rtxDetailedLog"
        rtxDetailedLog.Size = New Size(3195, 776)
        rtxDetailedLog.TabIndex = 0
        rtxDetailedLog.Text = ""
        ' 
        ' openFileLoader
        ' 
        openFileLoader.FileName = "OpenFileDialog1"
        openFileLoader.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        ' 
        ' saveFileExporter
        ' 
        saveFileExporter.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(3191, 1799)
        Controls.Add(TabControl1)
        Controls.Add(btnExport)
        Controls.Add(btnRunSim)
        Controls.Add(btnLoadFile)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        Summary.ResumeLayout(False)
        DetailedLog.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLoadFile As Button
    Friend WithEvents btnRunSim As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Summary As TabPage
    Friend WithEvents DetailedLog As TabPage
    Friend WithEvents rtxSummary As RichTextBox
    Friend WithEvents rtxDetailedLog As RichTextBox
    Friend WithEvents openFileLoader As OpenFileDialog
    Friend WithEvents saveFileExporter As SaveFileDialog

End Class
