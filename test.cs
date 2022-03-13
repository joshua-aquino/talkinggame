using Godot;
using System;
using System.Collections.Generic;

public class test : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    List<resident> residentList = new List<resident>();
    public void onButtinPresst() {
        residentList[0].incRelationsWith(1, 10);
        GD.Print(residentList[0].name + " likes " +
        residentList[1].name + " " + residentList[0].relationsWith[1] +
        "%.");
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        short i = 0;
        residentList.Add(new resident(i, "Bob"));
        GD.Print(residentList[i].number + " is " + residentList[i].name);
        i++;
        residentList.Add(new resident(i, "Carl"));
        GD.Print(residentList[i].number + " is " + residentList[i].name);
        i++;
        residentList[0].relationsWith[1] = 50;
        GD.Print(residentList[0].name + " likes " +
        residentList[1].name + " " + residentList[0].relationsWith[1] +
        "%.");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
