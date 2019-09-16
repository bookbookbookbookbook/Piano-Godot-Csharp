using Godot;
using System;

public class EasyModeButtonController : CheckButton
{

    private static bool []getBool;
    private Control easyModeMovement;

    public override void _Ready()
    {
        getBool = new bool[3];
        easyModeMovement = GetParent().GetParent().GetNode<Control>("ShowKeys/EasyMode");
        SetProcess(true);
    }

    public override void _Process(float delta)
    {
        getBool[0] = this.IsPressed();
        getBool[1] = false; getBool[2] = false;

        switch(easyModeMovement.GetPosition().x)
        {
            case 420:
                getBool[1] = true;
                break;
            case 870:
                getBool[2] = true;
                break;
        }





        if(ShowKeysButtonController.IsButtonPressed()&&IsButtonPressed())
        {
            this.GetChild<Button>(0).SetVisible(true);
            this.GetChild<Button>(1).SetVisible(true);
            this.GetChild<Label>(2).SetVisible(true);
        }
        else
        {
            this.GetChild<Button>(0).SetVisible(false);
            this.GetChild<Button>(1).SetVisible(false);
            this.GetChild<Label>(2).SetVisible(false);
        }
    }

    public static bool IsButtonPressed()
    {
        return getBool[0]; 
    }

    public static bool IsEasyModeLocatedLeft()
    {
        return getBool[1];
    }

    public static bool IsEasyModeLocatedRight()
    {
        return getBool[2];
    }
}
