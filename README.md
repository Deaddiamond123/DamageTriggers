# Damage triggers
uhh yeah very original name. 

Damage triggers is a basic plugin that adds the possibility for the user to damage people within a TriggerBox/TriggerSphere.
So you can barely edit things, like the List name if you know how to change it, the enter/exit events name, the damage it causes to the player and in how many seconds it will damage the user that is inside the Trigger. 

Everything has a few comments that will tell you what you can change, and below this text line you'll find some useful things. 

On "public void Enter(ShPhysical physical, string triggerid)" you can actually change the Enter event, for example, from "Enter" to "Entrance", you can change it by removing Enter and placing Entrance, it would end like this: "public void Entrance(ShPhysical physical, string triggerid)"
Same applies for Exit.

The DamageIndex can be modified, the interval of seconds between each time it hurts the player too. 

If you need help with anything, you can just contact me by Discord (Deaddiamond123#5065).
Enjoy!
