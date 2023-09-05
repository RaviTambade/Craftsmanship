 using  Transflower.DesignPatterns.Strucutural.Memento.POC;
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using RefactoringGuru.DesignPatterns.Memento.Conceptual;
 


// Client code.
            Originator originator = new Originator("Super-duper-super-puper-super.");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();
            Console.WriteLine();