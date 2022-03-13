using Godot;
using System;

public class resident : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    private const short MAX_RELATION = 100;
    public short number
    {get; set;}
    public string name
    {get; set;}
    public byte[] relationsWith = new byte[999];
    // index is resNumber; relation is 0-100
    // figure out get/set?
    // get and set logic for this should be placed in the method that alters this
    public void incRelationsWith(short number, byte increment) {
        byte sum = this.relationsWith[number];
        sum += increment;
        if (sum <= MAX_RELATION)
        this.relationsWith[number] = sum;
        else
        this.relationsWith[number] = 100;
    }
    public resident(short number, string name)
    {
        this.number = number;
        this.name = name;
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
