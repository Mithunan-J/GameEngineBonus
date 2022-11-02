Mithunan Jayaseelan
100787442
Sum: 33
Odd
Game: Wrecking Crew

Is the singleton properly implemented?
Yes. The singleton can be found in the PlayerDamageSingleton script.
Is the singleton implementation properly described?
The singleton is used to modify the player's health. This occurs whenever the player collides with the enemy. When the player collides with the enemy, the player loses a heart. The hearts are located near the top left of the screen.
The enemy gameobject has a collider set to isTrigger. When a collision occurs, the OnTriggerEnter2D function is called which then calls the instance of the PlayerDamageSingleton and calls the appropriate function.
Making the player health a singleton allows any enemies or power ups to easily modify the player's health.

Controls
A to move left.
D to move right.
W to move up when standing infront of a ladder.
E to attack wall when standing infront of the wall.

Red capsule is Mario.
Black capsule is Enemy(Spike).
Green blocks are platforms.
Grey block is wall.
Yellow block is ladder.

Win condition: Player destorys all walls.
Lose condition: Player loses all lives.

Walls take 2 hits to destroy. The first hit shrinks the game object and the second hit destroys the gameobject.

Command and observer pattern not implemented. No flowchart available.