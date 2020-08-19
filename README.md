# MazeGame_CS

Maze generator
Implemented as a console game.

---

<p>
A side project of mine.
I tried to apply some graph algorithms that we learned in an algorithm class at the university.<br>
The original purpose was to use short-path finding algorithms to solve the maze.<br> 
I implemented the solution using the BFS algorithm as I did not plan to give weights to the edges.<br>
I might want to add features, such as coins, etc, then maybe I'll change the algorithm to Dijkstra. <br>
Then I also wanted to implement a randomly generated maze, for this I used a random prim algorithm:<br>
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

<p>
  The original project was implemented in java and can be found here:
  https://github.com/maoz-grossman/Maze
  <br>
  </p>
  
  


![Image](https://i.ibb.co/fQgN43m/MazeGame.png)
