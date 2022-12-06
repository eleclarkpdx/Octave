using Godot;
using System;

public class StaticKey : Key
{
    private float[] animScaleValues = new float[] {1.0F, 0.9F, 1.1F, 1.07F, 1.04F, 1.01F, 0.98F};
    private int animFrame = 0;
    private bool playAnim = false;

    public override void _Ready()
    {
        base._Ready();
    }

    public override void _Process(float delta)
    {
        if (Input.IsActionJustPressed(inputKey))
        {
            playAnim = true;
        }

        if (playAnim == true)
        {
            // TODO: incorporate delta
            animFrame += 1;
            if (animFrame >= animScaleValues.Length) {
                animFrame = 0;
                playAnim = false;
            }
            float scale = animScaleValues[animFrame];
            keySprite.Scale = new Vector2(scale, scale);
        }
    }

}
