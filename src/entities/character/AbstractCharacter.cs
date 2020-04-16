using Godot;
using System;

public class AbstractCharacter : KinematicBody2D
{
    public string personName {get;set;}
    public float Health {get;set;}
    public float Strenght {get;set;}
    public float Agility {get;set;}
    public float Defence {get;set;}
    public float Attack {get;set;}
    public float Gold {get;set;}
    public int Weapon {get;set;}
    public int Shield {get;set;}
    public override void _Ready()
    {
        AbstractCharacter karol = new AbstractCharacter();
        GD.Print("Podaj swoje imię podróżniku:  ");
        karol.personName = "Karol_Rozkurwiacz!!!";
        GD.Print(karol.personName);
        
        
    }


}
