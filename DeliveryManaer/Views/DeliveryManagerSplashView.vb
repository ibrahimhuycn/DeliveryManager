Public Class DeliveryManagerSplashView
    Sub New
        InitializeComponent()
        Me.labelCopyright.Text = "© Swat, Inc" & DateTime.Now.Year.ToString()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
        Me.Close()
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

End Class
