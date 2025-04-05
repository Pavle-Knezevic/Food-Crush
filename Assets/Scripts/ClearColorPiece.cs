public class ClearColorPiece : ClearablePiece
{
    //public ColorPiece.ColorType Color
    //{
    //    get { return color; }
    //    set { color = value; }
    //}

    //public override void Clear()
    //{
    //    base.Clear();

    //    //clear color
    //    piece.GridRef.ClearColor(color);
    //}
    public ColorPiece.ColorType Color { get; internal set; }
}
