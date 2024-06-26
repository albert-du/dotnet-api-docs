// <Snippet1>
open System
open System.Collections.Generic

// <Snippet8>
type Box(h, l, w) =
    member val Height: int = h with get
    member val Length: int = l with get
    member val Width: int = w with get

    interface IComparable<Box> with
        member this.CompareTo(other) =
            // Compares Height, Length, and Width.
            if this.Height.CompareTo other.Height <> 0 then
                this.Height.CompareTo other.Height
            elif this.Length.CompareTo other.Length <> 0 then
                this.Length.CompareTo other.Length
            elif this.Width.CompareTo other.Width <> 0 then
                this.Width.CompareTo other.Width
            else
                0
// </Snippet8>

// <Snippet5>
type BoxLengthFirst() =
    inherit Comparer<Box>()

    // <Snippet6>
    // Compares by Length, Height, and Width.
    override _.Compare(x: Box, y: Box) =
        if x.Length.CompareTo y.Length <> 0 then
            x.Length.CompareTo y.Length
        elif x.Height.CompareTo y.Height <> 0 then
            x.Height.CompareTo y.Height
        elif x.Width.CompareTo y.Width <> 0 then
            x.Width.CompareTo y.Width
        else
            0
// </Snippet6>
// </Snippet5>
