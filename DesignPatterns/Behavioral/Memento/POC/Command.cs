 namespace  Transflower.DesignPatterns.Strucutural.Memento;
// A command object can act as a caretaker. In that case, the
// command gets a memento just before it changes the originator's state. 
//When undo is requested, it restores the originator's state from a memento.
class Command {
    private  Snapshot backup;

    public  makeBackup() {
            backup = editor.createSnapshot()
    }

    public  undo() {
        if (backup != null)
        backup.restore()

    }
}