##Backtracking
Backtracking is a general search algorithm used to find a feasible solution to a problem with multiple decision points. It is commonly used to solve problems involving trees or graphs, where multiple possible solutions need to be considered.

The basic idea of backtracking is to search through all possible solutions and return the one that satisfies the given conditions. If a solution is not feasible, the algorithm will backtrack to the previous step and try a different solution. This allows it to find the optimal solution among multiple possible solutions.

##Example
Here is an example of how backtracking can be used to solve a problem:

###Problem Describtion
Suppose we want to find a path through a maze that goes from the start to the end. We can use backtracking to search through all possible paths and return the one that leads to the end of the maze.

To implement this algorithm, we can use a recursive function that takes the current position in the maze as its input. At each step, the function will consider all possible moves from the current position and choose the one that leads closer to the end of the maze. If the chosen move leads to a dead end, the function will backtrack to the previous position and try a different move. This process will continue until a path to the end of the maze is found, or all possible paths have been explored.

##Example code
Here is some sample code that implements this backtracking algorithm:
```C#
List<Point> findPath(Maze maze, Point start, Point end)
{

    List<Point> path = new List<Point>();
    path.Add(start);

    bool findPathHelper(List<Point> path)
    {
        Point curr = path[path.Count - 1];

        if (curr == end)
        {
            return true;
        }

        foreach (Point neighbor in maze.getNeighbors(curr))
        {
            if (!path.Contains(neighbor))
            {
                path.Add(neighbor);
                if (findPathHelper(path))
                {
                    return true;
                }
                path.Remove(neighbor);
            }
        }

        return false;
    }

    if (findPathHelper(path))
    {
        return path;
    }

    return new List<Point>();

}

```

##Example of input and output
Here is an example of input and output for the findPath() function:

```c#
// Create a maze with a starting point at (1, 1) and an ending point at (4, 4)
Maze maze = new Maze(5, 5); 
maze.setStart(1, 1); 
maze.setEnd(4, 4); 

// Set the walls in the maze
maze.setWall(1, 2); 
maze.setWall(1, 3); 
maze.setWall(2, 1); 
maze.setWall(2, 3); 
maze.setWall(3, 2); 
```

This code would produce the following output:
```c#
(1, 1)
(2, 1)
(3, 1)
(3, 2)
(3, 3)
(4, 3)
(4, 4)
```
