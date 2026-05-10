namespace VPIndividualCS2022048.Pathfinding;

public class DijkstraPathfinder
{
    private static readonly Point[] Directions =
    [
        new Point(0, -1),
        new Point(1, 0),
        new Point(0, 1),
        new Point(-1, 0)
    ];

    public List<PathfindingStep> CreateSteps(GridCellState[,] grid, Point start, Point end)
    {
        int rows = grid.GetLength(0);
        int columns = grid.GetLength(1);
        GridCellState[,] workingGrid = (GridCellState[,])grid.Clone();
        List<PathfindingStep> steps = new();
        Queue<Point> frontier = new();
        bool[,] visited = new bool[rows, columns];
        Point?[,] previous = new Point?[rows, columns];

        frontier.Enqueue(start);
        visited[start.Y, start.X] = true;
        AddStep(steps, workingGrid, "Starting Dijkstra search.");

        bool foundPath = false;

        while (frontier.Count > 0)
        {
            Point current = frontier.Dequeue();

            if (current != start && current != end)
            {
                workingGrid[current.Y, current.X] = GridCellState.Visited;
                AddStep(
                    steps,
                    workingGrid,
                    $"Visited node ({current.X}, {current.Y}).");
            }

            if (current == end)
            {
                foundPath = true;
                break;
            }

            foreach (Point direction in Directions)
            {
                Point next = new(current.X + direction.X, current.Y + direction.Y);

                if (!IsInsideGrid(next, rows, columns) ||
                    visited[next.Y, next.X] ||
                    workingGrid[next.Y, next.X] == GridCellState.Wall)
                {
                    continue;
                }

                visited[next.Y, next.X] = true;
                previous[next.Y, next.X] = current;
                frontier.Enqueue(next);
            }
        }

        if (!foundPath)
        {
            AddStep(steps, workingGrid, "No path found.");
            return steps;
        }

        Point? trace = end;
        while (trace is Point point && point != start)
        {
            if (point != end)
            {
                workingGrid[point.Y, point.X] = GridCellState.Path;
                AddStep(
                    steps,
                    workingGrid,
                    $"Tracing final path through ({point.X}, {point.Y}).");
            }

            trace = previous[point.Y, point.X];
        }

        AddStep(steps, workingGrid, "Shortest path found.");
        return steps;
    }

    private static bool IsInsideGrid(Point point, int rows, int columns)
    {
        return point.X >= 0 && point.X < columns && point.Y >= 0 && point.Y < rows;
    }

    private static void AddStep(List<PathfindingStep> steps, GridCellState[,] grid, string description)
    {
        steps.Add(new PathfindingStep
        {
            Snapshot = (GridCellState[,])grid.Clone(),
            Description = description
        });
    }
}
