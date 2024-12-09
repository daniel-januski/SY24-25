Class MainWindow
    Private Sub button3_Click(sender As Object, e As RoutedEventArgs) Handles button3.Click
        black.Visibility = Visibility.Visible
        sperit.Visibility = Visibility.Hidden
        cargo.Visibility = Visibility.Hidden
        black1.Visibility = Visibility.Visible
        black2.Visibility = Visibility.Visible
        black3.Visibility = Visibility.Visible
        black4.Visibility = Visibility.Visible
        black5.Visibility = Visibility.Visible
    End Sub
    Private Sub button2_Click(sender As Object, e As RoutedEventArgs) Handles button2.Click
        black.Visibility = Visibility.Visible = False
        sperit.Visibility = Visibility.Visible = True
        cargo.Visibility = Visibility.Visible = False
        black1.Visibility = Visibility.Visible = False
        black2.Visibility = Visibility.Visible = False
        black3.Visibility = Visibility.Visible = False
        black4.Visibility = Visibility.Visible = False
        black5.Visibility = Visibility.Visible = False
    End Sub

    Private Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
        black.Visibility = Visibility.Visible = False
        sperit.Visibility = Visibility.Visible = False
        cargo.Visibility = Visibility.Visible = True
        black1.Visibility = Visibility.Visible = False
        black2.Visibility = Visibility.Visible = False
        black3.Visibility = Visibility.Visible = False
        black4.Visibility = Visibility.Visible = False
        black5.Visibility = Visibility.Visible = False
    End Sub
End Class
