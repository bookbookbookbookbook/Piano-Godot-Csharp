using Godot;
using System;

public class ButtonController : TextureButton
{
    private int playList;
    private string[] sounds;
    private AudioStreamPlayer2D[] GrandPiano;

    private void PlaySounds()
    {
        SearchSoundsFile();
        GrandPiano[playList].Play();
    }

    private void SearchSoundsFile()
    {
        playList = this.GetIndex();
        sounds = GrandPianoController.GetAllSounds();

        GrandPiano = new AudioStreamPlayer2D[sounds.Length];

        for (int i = 0; i < sounds.Length; i++)
            GrandPiano[i]=GetParent().GetParent().GetNode<AudioStreamPlayer2D>(sounds[i]);
    }

}
