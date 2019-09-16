using System;
public class ActionKeysController
{
    public static string[]GetActionKeys()
    {

        if (EasyModeButtonController.IsButtonPressed() && ShowKeysButtonController.IsButtonPressed())
        {
            return new string[] {"1","2","3","4","5","6",
                                 "7","8","9","0","q","w",
                                 "e","r","t","y","u",
                                 "i","o","p","a","s",
                                 "d","f","g","h","j",
                                 "k","l","z","x","c",
                                 "v","b","n","m","Comma"};
        }
        else
        {
            return new string[] { "1","8","t","s","l","m",
                                  "2","9","y","d","z",
                                  "3","0","u","f","x",
                                  "4","q","i","g","c",
                                  "5","w","o","h","v",
                                  "6","e","p","j","b",
                                  "7","r","a","k","n",
                                  "Shift+1","Shift+6","Shift+q","Shift+y","Shift+a",
                                  "Shift+2","Shift+7","Shift+w","Shift+u","Shift+s",
                                  "Shift+3","Shift+8","Shift+e","Shift+i","Shift+d",
                                  "Shift+4","Shift+9","Shift+r","Shift+o","Shift+f",
                                  "Shift+5","Shift+0","Shift+t","Shift+p","Shift+g"};

        }
        /* this GetActionKeys() is calculated by GrandPianoController.GetSounds()
         * C1  C2  C3  C4  C5  C6
         * D1  D2  D3  D4  D5 
         * E1  E2  E3  E4  E5
         * F1  F2  F3  F4  F5
         * G1  G2  G3  G4  G5
         * A1  A2  A3  A4  A5
         * B1  B2  B3  B4  B5
         * C#1 C#2 C#3 C#4 C#5
         * D#1 D#2 D#3 D#4 D#5
         * F#1 F#2 F#3 F#4 F#5
         * G#1 G#2 G#3 G#4 G#5
         * A#1 A#2 A#3 A#4 A#5*/
    }

}
