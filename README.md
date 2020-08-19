# MazeGame_CS

Maze generator
Implemented as a console game.

---

<p>

Side project,
I tried to apply graph algorithms that we learned in an algorithm class at university.<br>
The original purpose was to use short-path finding algorithms to solve the maze.<br> 

I implemented the solution using the BFS algorithm as I did not plan to give weights to the edges.
I might want to add features, such as coins, etc, then maybe I'll change the algorithm to Dijkstra. <br>
In the second stage I also wanted to implement a randomly generated maze, for this I used a random prim algorithm:<br>
  </p>
  
  ```python
This algorithm is a randomized version of Prim's algorithm.
   1. Start with a grid full of walls.
   2. Pick a cell, mark it as part of the maze. 
      Add the walls of the cell to the wall list.
   3. While there are walls in the list:
   	i) Pick a random wall from the list.
   	   If only one of the two cells that the wall divides is visited, then:
   		   a) Make the wall a passage and mark the unvisited cell 
   			  as part of the maze.
   		   b) Add the neighboring walls of the cell to the wall list.
   	ii) Remove the wall from the list.
```
 


![Image](https://i.ibb.co/fQgN43m/MazeGame.png)
