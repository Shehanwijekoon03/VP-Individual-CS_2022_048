namespace VPIndividualCS2022048.Pathfinding;

public class GridNode
{
    public required Point Position { get; init; }

    public required GridCellState State { get; set; }
}
