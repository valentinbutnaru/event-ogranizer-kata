# event-ogranizer-kata
Event organizer 


Pentru realizarea sarcinii am facut o clasa de baza EventControl care va contine metoda SetCalendar.
Ea va depista toate conflictele in cazul daca ele exista.

Fiecare eveniment am introdus intro lista de tipul Event care contine denumirea evenimentului "EventName",
inceputul "StartTime" si sfirsitul "FinishTime".

Conflictele se determina prin intermediul clasei PeriodConflict care are metode ConflictDetermination.
Pentru fiecare conflict am creeat o lista cu tipul conflict.