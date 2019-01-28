using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Attributes;

namespace GameShardsCore3.Mathematics.BaseConverter {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [WIP()]
    public struct RomanSymbol : IEquatable<RomanSymbol> {

        public char Char { get; set; }

        public static bool operator <(RomanSymbol r1, RomanSymbol r2) => r1.ToNumber() < r2.ToNumber();
        
        public static bool operator >(RomanSymbol r1, RomanSymbol r2) => r1.ToNumber() > r2.ToNumber();

        public static bool operator ==(RomanSymbol r1, RomanSymbol r2) => r1.ToNumber() == r2.ToNumber();

        public static bool operator !=(RomanSymbol r1, RomanSymbol r2) => r1.ToNumber() != r2.ToNumber();
  
        public int ToNumber() {
            switch (Char.ToUpper(Char)) {
                case ('I'):
                    return 1;
                case ('V'):
                    return 5;
                case ('X'):
                    return 10;
                case ('L'):
                    return 50;
                case ('C'):
                    return 100;
                case ('D'):
                    return 500;
                case ('M'):
                    return 1000;
                default:
                    return 0;
            }
        }

        [ToDo()]
        public RomanSymbol FromInt16() {
            return new RomanSymbol();
        }

        public override bool Equals(object obj) {
            return obj is RomanSymbol && Equals((RomanSymbol)obj);
        }

        public bool Equals(RomanSymbol other) {
            return Char == other.Char;
        }

        public override int GetHashCode() {
            var hashCode = 679076413;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Char.GetHashCode();
            return hashCode;
        }

        /*
         * Public Class RomanSymbol


                Public Shared Operator <(ByVal Symbol1 As RomanSymbol, ByVal Symbol2 As RomanSymbol) As Boolean
                    Return SymbolToNumber(Symbol1.ch) < SymbolToNumber(Symbol2.ch)
                End Operator

                Public Shared Operator >(ByVal symbol1 As RomanSymbol, ByVal Symbol2 As RomanSymbol) As Boolean
                    Return SymbolToNumber(symbol1.ch) > SymbolToNumber(Symbol2.ch)
                End Operator

                Public Shared Function SymbolToNumber(ByVal symbol As Char) As Integer
                    Select Case True
                        Case symbol = "I"
                            Return 1
                        Case symbol = "V"
                            Return 5
                        Case symbol = "X"
                            Return 10
                        Case symbol = "L"
                            Return 50
                        Case symbol = "C"
                            Return 100
                        Case symbol = "D"
                            Return 500
                        Case symbol = "M"
                            Return 1000
                        Case Else
                            Return 0
                    End Select
                End Function

            End Class
         */
    }

}
