# Mars Rover

A terminal app for moving Rovers around on the surface of Mars. Enjoy exploring! 


The Mars Rover Brief
The surface of Mars is represented by a Plateau (a square/rectangular grid).
Rovers navigate the Plateau by following a sequence of commands. They can also use their cameras and robot arms to collect photographs and samples.


The Rover position
A Rover's position is represented by x and y co-ordinates and the letters N, S, W, E to represent North, South, West, East (the four cardinal compass points) respectively.

Example
0 0 E
This means the Rover is at the bottom-left corner facing in the East direction.


Instructions
To move a Rover around the Plateau, a string of letters is sent to a Rover.

Letter	Action
L	Spins the Rover 90 degrees Left without moving from the current coordinate point
R	Spins the Rover 90 degrees Right without moving from the current coordinate point
M	Moves the Rover forward by one grid point, maintaining the same heading/orientation
Output
For each Rover, the output represents its final position: the coordinates and where it is facing.

Movement Rules
Rovers move sequentially, this means that if multiple Rovers are being landed then the first Rover needs to finish moving first before the next one can move.

Example
Given the following input:

5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM
This creates a plateau of size (5,5) and lands two rovers on it. The first lands at (1,2)N and this one moves LMLMLMLMM. The second lands at (3,3)E and it moves MMRMMRMRRM.

The expected output is:

1 3 N
5 1 E
