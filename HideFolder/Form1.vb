﻿Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim text1 As String = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        Shell("cmd /c" & "ren " & TextBox1.Text & " " & TextBox2.Text & text1)
        Shell("cmd /c" & "attrib +s +h " & TextBox1.Text & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\*.*" & " /S /D")
        Shell("cmd /c" & "attrib +s +h " & TextBox1.Text & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}" & " /S /D")

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim text1 As String = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        Shell("cmd /c" & "attrib -s -h " & TextBox1.Text & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}" & " /S /D")
        Shell("cmd /c" & "attrib -s -h " & TextBox1.Text & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\*.*" & " /S /D")
        System.Threading.Thread.Sleep(1000)
        Shell("cmd /c" & "ren " & TextBox1.Text & text1 & " " & TextBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim last As String

        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
        last = Path.GetFileName(FolderBrowserDialog1.SelectedPath)
        TextBox2.Text = last
        TextBox1.Text = TextBox1.Text.Replace(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", "")
        TextBox2.Text = TextBox2.Text.Replace(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", "")
    End Sub
End Class