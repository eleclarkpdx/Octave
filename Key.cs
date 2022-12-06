using Godot;
using System;

// TODO: consider moving animation-related code into the sprite itself
public class Key : Area2D
{
    [Export]
    public Color color = new Color(1);
    [Export]
    public String inputKey = "key1";
    private String textureFile = "temp-";
    protected Sprite keySprite;

    public override void _Ready()
    {
        keySprite = GetNode<Sprite>("KeySprite");
        textureFile += inputKey;
        var texture = (Texture)GD.Load("res://graphics/" + textureFile + ".png");
        keySprite.Texture = texture;

        var keyShader = (ShaderMaterial)keySprite.Material;
        Vector3 colorRGB = new Vector3(color.r, color.g, color.b);
        keyShader.SetShaderParam("rgb", colorRGB);
    }


}
