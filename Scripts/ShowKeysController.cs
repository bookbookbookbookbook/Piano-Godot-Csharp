using Godot;
using System;

public class ShowKeysController : Control
{

    public override void _Ready()
    {
        SetProcess(true);
    }


    public override void _Process(float delta)
    {

        if (ShowKeysButtonController.IsButtonPressed())
        {
            GetNode<Control>("All").SetVisible(true);

            if (EasyModeButtonController.IsButtonPressed())
            {
                GetNode<Control>("All").SetVisible(false);
                GetNode<Control>("EasyMode").SetVisible(true);
            }
            else
            {
                GetNode<Control>("EasyMode").SetVisible(false);
            }
            
        }
        else
        {
            GetNode<Control>("All").SetVisible(false);
            GetNode<Control>("EasyMode").SetVisible(false);
        }

    }

}
