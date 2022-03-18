using Godot;
using System;

public class resident : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    private const byte MAX_RELATION = 100;
    private const byte MIN_RELATION = 0;
    public short number
    {get; set;}
    public string name
    {get; set;}
    public byte[] relationsWith = new byte[999];
    // index is resNumber; relation is 0-100
    // figure out get/set?
    // get and set logic for this should be placed in the method that alters this
    public void incRelationsWith(short number, sbyte increment) {
        sbyte sum = (sbyte)this.relationsWith[number];
        if (increment > 0) {
            sum += increment;
            if (sum <= MAX_RELATION)
            this.relationsWith[number] = (byte)sum;
            else
            this.relationsWith[number] = MAX_RELATION;
        } else {
            sum += increment;
            if (sum >= MIN_RELATION)
            this.relationsWith[number] = (byte)sum;
            else
            this.relationsWith[number] = MIN_RELATION;
        }
    }
    public resident(short number, string name)
    {
        this.number = number;
        this.name = name;
    }
    // when you insult someone, THEY CHANGE THEIR OPINION ON YOU,
    // each character can only change their own opinions
    public void insultedBy(short offender) {
        incRelationsWith(offender, -6);
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
