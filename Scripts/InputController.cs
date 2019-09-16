using Godot;
using System;

public class InputController : Control
{
    
    private int playList;
    private string[] sounds;
    private string[] soundsName;
    private string[] actionKeys;
    private string soundName;
    private AudioStreamPlayer2D[] grandPianoSounds;
    private TextureButton textureButton;

    public override void _Ready()
    {
        playList = -1; 
        SetProcess(true);
    }


    public override void _Process(float delta)
    {
        actionKeys = ActionKeysController.GetActionKeys();
        SetAllSounds();
        Start();
    }

    public void Start()     {

        if (EasyModeButtonController.IsButtonPressed() && ShowKeysButtonController.IsButtonPressed())
        {
            for (int i = 0; i < actionKeys.Length; i++)
            {
                if(Input.IsActionJustPressed(actionKeys[i]))
                {
                    playList = PlayListController.GetPlayListNumber(soundsName[i]);
                    ChangePressedTextureButtonImage(soundsName[i]);
                    grandPianoSounds[i].Play();
                }
                if (!Input.IsActionPressed(actionKeys[i]))
                {
                    ChangeTextureButtonImage(soundsName[i]);
                }
            }

        }
        else
        {
            for (int i = 0; i < grandPianoSounds.Length; i++)
            {
                if (Input.IsActionJustPressed(actionKeys[i])&&!Input.IsActionJustPressed("Shift+"+actionKeys[i]))
                {
                    playList = PlayListController.GetPlayListNumber(soundsName[i]);
                    ChangePressedTextureButtonImage(soundsName[i]);
                    grandPianoSounds[i].Play();
                }
                if (!Input.IsActionPressed(actionKeys[i]))
                {
                    ChangeTextureButtonImage(soundsName[i]);
                }
            }
        }     }

    private void SetAllSounds()
    {
        sounds = GrandPianoController.GetSounds();

        soundsName = new string[sounds.Length];
        grandPianoSounds = new AudioStreamPlayer2D[sounds.Length];
        for (int i = 0; i < sounds.Length; i++)
        {
            soundsName[i] = sounds[i].Remove(0, 18);
            grandPianoSounds[i] = GetParent().GetNode<AudioStreamPlayer2D>(sounds[i]);
        }
    }


    private void ChangeTextureButtonImage(string nodeName)
    {
        textureButton = GetNode<TextureButton>(nodeName);

        if (nodeName.Contains("#"))
            textureButton.SetNormalTexture(ResourceLoader.Load<Texture>("res://Images/black.png"));
        else
            textureButton.SetNormalTexture(ResourceLoader.Load<Texture>("res://Images/white.png"));

    }

    private void ChangePressedTextureButtonImage(string nodeName)
    {

        textureButton = GetNode<TextureButton>(nodeName);

        if (nodeName.Contains("#"))
            textureButton.SetNormalTexture(ResourceLoader.Load<Texture>("res://Images/black_pressed.png"));
        else
            textureButton.SetNormalTexture(ResourceLoader.Load<Texture>("res://Images/white_pressed.png"));

    }
 
}
