using System;
using Godot;
public class PlayListController
{
    private static int isLeft, isRight;

    public static int GetPlayListNumber(string nodeName)     {
        switch(nodeName)
        {
            case "C1":
                return 0;
            case "C2":
                return 1;
            case "C3":
                return 2;
            case "C4":
                return 3;
            case "C5":
                return 4;
            case "C6":
                return 5;
            case "D1":
                return 6;
            case "D2":
                return 7;
            case "D3":
                return 8;
            case "D4":
                return 9;
            case "D5":
                return 10;
            case "E1":
                return 11;
            case "E2":
                return 12;
            case "E3":
                return 13;
            case "E4":
                return 14;
            case "E5":
                return 15;
            case "F1":
                return 16;
            case "F2":
                return 17;
            case "F3":
                return 18;
            case "F4":
                return 19;
            case "F5":
                return 20;
            case "G1":
                return 21;
            case "G2":
                return 22;
            case "G3":
                return 23;
            case "G4":
                return 24;
            case "G5":
                return 25;
            case "A1":
                return 26;
            case "A2":
                return 27;
            case "A3":
                return 28;
            case "A4":
                return 29;
            case "A5":
                return 30;
            case "B1":
                return 31;
            case "B2":
                return 32;
            case "B3":
                return 33;
            case "B4":
                return 34;
            case "B5":
                return 35;
            case "C#1":
                return 36;
            case "C#2":
                return 37;
            case "C#3":
                return 38;
            case "C#4":
                return 39;
            case "C#5":
                return 40;
            case "D#1":
                return 41;
            case "D#2":
                return 42;
            case "D#3":
                return 43;
            case "D#4":
                return 44;
            case "D#5":
                return 45;
            case "F#1":
                return 46;
            case "F#2":
                return 47;
            case "F#3":
                return 48;
            case "F#4":
                return 49;
            case "F#5":
                return 50;
            case "G#1":
                return 51;
            case "G#2":
                return 52;
            case "G#3":
                return 53;
            case "G#4":
                return 54;
            case "G#5":
                return 55;
            case "A#1":
                return 56;
            case "A#2":
                return 57;
            case "A#3":
                return 58;
            case "A#4":
                return 59;
            case "A#5":
                return 60;
            default:
                return -1; // -1 = error
        }

     } 

}
