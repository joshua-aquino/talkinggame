using Godot;
using System;

public class Node2D : Godot.Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    private int[] bob = {1,2,3};
    private Node dialogueList;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        dialogueList = this.GetChild(0);
        foreach (int i in bob)
        dialogueList.Call("add_item", "bob");
        GD.Print(dialogueList.Call("get_item_count"));
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
