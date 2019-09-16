using Godot;
using System;

public class EasyModeRight : Button
{
    private Control easyModeMovement;

    public override void _Ready()
    {
        easyModeMovement = GetParent().GetParent().GetParent().GetNode<Control>("ShowKeys/EasyMode");
    }

    private void OnRightButtonDown()
    {
        if (easyModeMovement.GetPosition().x < 870)
            easyModeMovement.SetPosition(new Vector2(easyModeMovement.GetPosition().x + 225, easyModeMovement.GetPosition().y));
    }

}
