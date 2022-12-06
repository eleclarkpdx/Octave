using Godot;
using System;

// TODO: consider moving animation-related code into the sprite itself
public class Key : Area2D
{
    [Export]
    public String inputKey = "key1";
    private String textureFile = "temp-";
    private Sprite keySprite;
    private float[] animScaleValues = new float[] {1.0F, 0.9F, 1.1F, 1.07F, 1.04F, 1.01F, 0.98F};
    private int animFrame = 0;
    private bool playAnim = false;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        keySprite = GetNode<Sprite>("KeySprite");
        textureFile += inputKey;
        var texture = (Texture)GD.Load("res://graphics/" + textureFile + ".png");
        keySprite.Texture = texture;
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
