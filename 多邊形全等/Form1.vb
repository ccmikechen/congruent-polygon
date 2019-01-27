Imports System.IO
Public Class Form1
    Dim sw As New StreamWriter("out.txt")
    Dim sr As New StreamReader("in.txt")

    Sub check()
        Dim str As String = sr.ReadLine
        Dim m() As String = Split(str, " ")
        Dim s(11) As String
        x(m(0), s)
        For i = 0 To 11
            Dim s1 = s(i) & s(i)
            Dim s2 As String
            s2 = s1.Replace("R", "T").Replace("L", "R").Replace("T", "L")
            s2 = s2.Replace("U", "T").Replace("D", "U").Replace("T", "D")
            s2 = StrReverse(s2)
            If s1.Contains(m(1)) Or s2.Contains(m(1)) Then
                sw.WriteLine("TRUE") : Exit Sub
            End If
        Next
        sw.WriteLine("FALSE")
    End Sub

    Sub x(ByVal m As String, ByRef s() As String)
        For Each i In m
            Select Case i
                Case "R"
                    s(0) &= "R" : s(1) &= "D" : s(2) &= "L" : s(3) &= "U"
                    s(4) &= "R" : s(5) &= "U" : s(6) &= "L" : s(7) &= "D"
                    s(8) &= "L" : s(9) &= "D" : s(10) &= "R" : s(11) &= "U"
                Case "D"
                    s(0) &= "D" : s(1) &= "L" : s(2) &= "U" : s(3) &= "R"
                    s(4) &= "U" : s(5) &= "L" : s(6) &= "D" : s(7) &= "R"
                    s(8) &= "D" : s(9) &= "R" : s(10) &= "U" : s(11) &= "L"
                Case "L"
                    s(0) &= "L" : s(1) &= "U" : s(2) &= "R" : s(3) &= "D"
                    s(4) &= "L" : s(5) &= "D" : s(6) &= "R" : s(7) &= "U"
                    s(8) &= "R" : s(9) &= "U" : s(10) &= "L" : s(11) &= "D"
                Case "U"
                    s(0) &= "U" : s(1) &= "R" : s(2) &= "D" : s(3) &= "L"
                    s(4) &= "D" : s(5) &= "R" : s(6) &= "U" : s(7) &= "L"
                    s(8) &= "U" : s(9) &= "L" : s(10) &= "D" : s(11) &= "R"
            End Select
        Next

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Do While sr.Peek > -1
            check()
        Loop
        sw.Flush() : End

    End Sub

    
End Class
