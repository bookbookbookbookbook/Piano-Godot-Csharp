using Godot;
using System;

public class ShowKeysButtonController : CheckButton
{
    private static bool getBool;
 
    public override void _Ready()
    {
        SetProcess(true);
    }

    public override void _Process(float delta)
    {
        getBool = this.IsPressed();
    }

    public static bool IsButtonPressed()
    {
        return getBool;
    }

}
