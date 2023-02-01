using Godot;
using System;

public class Main : Node
{
    public PackedScene FKeyScene = (PackedScene)ResourceLoader.Load("res://FallingKey.tscn");
    private const int interval = 1;
    private float time = 0;
    public override void _Ready()
    {
        
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        time += delta*1;
        if (time > interval) {
            SpawnFKey();
            time = 0;
        }
    }

    private void SpawnFKey() {
        var fallingKey = (FallingKey)FKeyScene.Instance();

        fallingKey.Position = new Vector2((int)Lane.First, 0);
        fallingKey.color = new Color("d10079");

        AddChild(fallingKey);
    }
}
