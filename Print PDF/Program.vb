'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports System.Collections.Generic
Imports System.Windows.Forms

NotInheritable Class Program
    Private Sub New()
    End Sub
    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread> _
    Friend Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub
End Class
