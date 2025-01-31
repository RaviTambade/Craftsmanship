namespace  Transflower.DesignPatterns.Strucutural.Memento;
public  class Editor {
    public string Text {get;set;}
    public int CurX {get;set;}
    public int CurY{get;set;}
    public int SelectionWidth {get;set;}

    public void setCursor( int x,  int y){
        this.CurX = x;
        this.CurY = y;
    }
        
    // Saves the current state inside a memento.
    public  Snapshot createSnapshot() {
         // Memento is an immutable object; that's why the
        // originator passes its state to the memento's
        // constructor parameters.
        return new Snapshot(this, Text, CurX, CurY, SelectionWidth);

    } 
// The memento class stores the past state of the editor.
}
   