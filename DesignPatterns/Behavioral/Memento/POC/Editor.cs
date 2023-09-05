namespace  Transflower.DesignPatterns.Strucutural.Memento;
public  class Editor 
    private string Text {get;set;}
    private int curX {get;set;}
    private int curY{get;set;}
    private int SelectionWidth {get;set;}

    public void setCursor(x, y){
        this.curX = x;
        this.curY = y;
    }
        
    // Saves the current state inside a memento.
    public  Snapshot createSnapshot() {
         // Memento is an immutable object; that's why the
        // originator passes its state to the memento's
        // constructor parameters.
        return new Snapshot(this, text, curX, curY, selectionWidth);

    } 
// The memento class stores the past state of the editor.