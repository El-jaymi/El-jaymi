Namespace LibraryManagementSystem
    Public Class Notification
        Public Property NotificationID As Integer
        Public Property StudentID As Integer
        Public Property NotificationType As String
        Public Property Title As String
        Public Property Message As String
        Public Property CreatedAt As DateTime
        Public Property IsRead As Boolean
        Public Property RelatedBookID As Integer?
        Public Property RelatedTransactionID As Integer?
    End Class
End Namespace
