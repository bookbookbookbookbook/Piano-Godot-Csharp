using Godot;
using System;

public class EasyModeLeft : Button
{
    private Control easyModeMovement;

    public override void _Ready()
    {
        easyModeMovement = GetParent().GetParent().GetParent().GetNode<Control>("ShowKeys/EasyMode");
    }

    private void OnLeftButtonDown()
    {
        if(easyModeMovement.GetPosition().x>420)
            easyModeMovement.SetPosition(new Vector2(easyModeMovement.GetPosition().x - 225, easyModeMovement.GetPosition().y));
    }

}
