using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Attributes;

namespace GameShardsCore3.Colors {

    [WIP()]
    public struct HEXColor {

        public HEXColor(string HexCode) {

        }

        public HEXColor(string R, string G, string B) {

        }

    }

    /*Public Class HEXColor
        Public Sub New(Red As String, Green As String, Blue As String)
            Me.Red = "00"
            Me.Green = "00"
            Me.Blue = "00"
            If CheckForValidValue(Red) Then
                Me.Red = Red
            End If
            If CheckForValidValue(Green) Then
                Me.Green = Green
            End If
            If CheckForValidValue(Blue) Then
                Me.Blue = Blue
            End If
        End Sub

        Public Sub New()
            Red = "00"
            Green = "00"
            Blue = "00"
        End Sub

        Public Shared Function CheckForValidValue(ByVal s As String) As Boolean
            If s.Length<> 2 Then
                Return False
            End If

            Dim digit() As Boolean = { False, False}

    For x As Integer = 0 To 1
                For y As Integer = 0 To Alphabet.HEX.Chars.Count - 1
                    If s(x) = Alphabet.HEX.Chars(y) Then
                        digit(x) = True
                    End If
                Next
            Next

            If digit(0) = True AndAlso digit(1) = True Then
                Return True
            End If
            Return False
        End Function

        Public Property Red As String

        Public Property Green As String

        Public Property Blue As String

        Public Shared Function FromRGB(ByVal c As Color) As HEXColor
            Return New HEXColor(BaseConverter.ConvertBaseTenToN(c.R, 16, Alphabet.HEX, 2), BaseConverter.ConvertBaseTenToN(c.G, 16, Alphabet.HEX, 2), BaseConverter.ConvertBaseTenToN(c.B, 16, Alphabet.HEX, 2))
        End Function

        Public Shared Function FromRGB(Red As Byte, Green As Byte, Blue As Byte) As HEXColor
            Return New HEXColor(BaseConverter.ConvertBaseTenToN(Red, 16, Alphabet.HEX, 2), BaseConverter.ConvertBaseTenToN(Green, 16, Alphabet.HEX, 2), BaseConverter.ConvertBaseTenToN(Blue, 16, Alphabet.HEX, 2))
        End Function

        Public Shared Function ToRGB(ByVal h As HEXColor) As Color
            Dim co As New Color
            Dim r, g, b As Integer
            r = CInt(BaseConverter.ConvertBaseNToTen(h.Red, 16, Alphabet.HEX, False))
            g = CInt(BaseConverter.ConvertBaseNToTen(h.Green, 16, Alphabet.HEX, False))
            b = CInt(BaseConverter.ConvertBaseNToTen(h.Blue, 16, Alphabet.HEX, False))
            co = Color.FromArgb(r, g, b)
            Return co
        End Function

        Public Overrides Function ToString() As String
            Return String.Format("#{0}{1}{2}", Red.ToUpper, Green.ToUpper, Blue.ToUpper)
        End Function
    End Class*/
}
