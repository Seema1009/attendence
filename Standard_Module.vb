Imports System.Text
Module modConstants

    'Constant Parameters
    Public Const formFont = 16                  'Main Header FontSize
    Public Const HdrFont = 14                   'Header1 FontSize
    Public Const subHdrFont = 12                'Header2 FontSize
    Public Const ConFont = 11                   'Content FontSize
    Public Const fontNM = "Roboto"              'FontStyle
    Public Const Proj_Location = "IOCL Chittoor"
    Public User_ID As String
    ''Public ConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\192.168.240.3\General Vendor Data\wilson\Attendance Sys\AttendanceDB.accdb"
    Public ConnStr As String = "Provider=SQLNCLI11;Data Source=WilsonLaptop;User ID=unisuser;PAssword=unisamho;Initial Catalog=UNIS;"


    Public Sub Std_Colors(Edit As Button, Del As Button, add As Button, load As Button)
        'Color defined for buttons in database tables screens
        Edit.BackColor = Color.FromArgb(51, 122, 183) ' Define Blue Color
        Del.BackColor = Color.FromArgb(240, 184, 92) ' Define Yellow color
        add.BackColor = Color.FromArgb(92, 184, 92) ' Define Green Color
        load.BackColor = Color.CornflowerBlue
    End Sub
    Public Sub Init_Form(FormName As Object)
        'Defining FontStyle and Form Main Header FontSize
        FormName.Font = New Font(fontNM, formFont)
    End Sub
    Public Sub Init_Control(MainHdr As Object)
        'Defining FontStyle and Form Header1 FontSize
        MainHdr.font = New Font(fontNM, HdrFont)
    End Sub

    Public Sub Init_Subcntr(SubHdr As Object)
        'Defining FontStyle and Form Header2 FontSize
        SubHdr.Font = New Font(fontNM, subHdrFont)
    End Sub

    Public Sub Init_Content(Context As Object)
        'Defining FontStyle and Form Content FontSize
        Context.Font = New Font(fontNM, ConFont)
    End Sub

End Module
