 namespace  Transflower.DesignPatterns.Strucutural.Memento;

public class Snapshot 
{
    public   Editor TheEditor;
    public string Text{get;set;}
    public int CurX{get;set;}
    public int CurY{get;set;}
    public int  SelectionWidth{get;set;}

    public Snapshot(Editor editor, string text, int curX, int curY, int selectionWidth)
    {
        this.TheEditor = editor;
        this.Text = text;
        this.CurX = curX;
        this.CurY = curY;
        this.SelectionWidth = selectionWidth;

    }
        
    // At some point, a previous state of the editor can be
    // restored using a memento object.
    public  void Restore(){
        TheEditor.Text=Text;
        TheEditor.setCursor(CurX, CurY);
        TheEditor.SelectionWidth=SelectionWidth;

    }
}