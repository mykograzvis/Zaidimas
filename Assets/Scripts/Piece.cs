using UnityEngine;

//objektas kaladeles
public class Piece : MonoBehaviour
{
    public Board board {get; private set; }
    public TileData data {get; private set; }
    public Vector3Int position {get; private set; }
    public Vector3Int[] cells {get; private set; }
    public void Initialize(Board board, Vector3Int position, TileData data)
    {
        this.board = board;
        this.data = data;
        this.position = position;

        if(this.cells == null)
        {
            this.cells = new Vector3Int[data.cells.Length];
        }

        for (int i = 0; i < data.cells.Length; i++)
        {
            this.cells[i] = (Vector3Int)data.cells[i];
        }
    }
}
