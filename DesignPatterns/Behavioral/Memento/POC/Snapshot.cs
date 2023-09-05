 namespace  Transflower.DesignPatterns.Strucutural.Memento;

public class Snapshot 
{
    private  Editor editor;
    private string Text;
    private int curX;
    private int curY;
    private int  selectionWidth;

    public Snapshot(Editor editor, string text, int curX, int curY, int selectionWidth)
    {
        this.editor = editor;
        this.text = text;
        this.curX = x;
        this.curY = y;
        this.selectionWidth = selectionWidth;

    }
        
    // At some point, a previous state of the editor can be
    // restored using a memento object.
    public  void Restore(){
        editor.setText(text);
        editor.setCursor(curX, curY);
        editor.setSelectionWidth(selectionWidth);

    }
}