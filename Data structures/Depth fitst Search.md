##Depth–first search

Depth–first search (DFS) is an algorithm for traversing or searching tree or graph data structures. 
One starts at the root (selecting some arbitrary node as the root for a graph) and explore as far as possible along each branch before backtracking.

##Applications of DFS：
*Finding connected components in a graph.
*Topological sorting in a DAG(Directed Acyclic Graph).
*Finding 2/3–(edge or vertex)–connected components.
*Finding the bridges of a graph.
*Finding strongly connected components.
*Solving puzzles with only one solution, such as mazes.
*Finding biconnectivity in graphs and many more…

##Example code

```C#
procedure dfs(vertex v)
{

    visit(v);
    for each neighbor u of v
        if u is undiscovered
            call dfs(u);

}
```
