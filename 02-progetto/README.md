# Progetto

Il progetto dell'elaborato dovrà affrontare i seguenti punti:
- stesura del progetto iniziale, racconto di come si andrà a realizzare la soluzione

Il progetto ha come inizio nella creazione del file WPF.core su Visual Studio 2019. Come prima funzione, abbiamo implementato il codice per permettere all'utente di scegliere quale file dovrà essere convalidato. Per realizzare ciò, abbiamo usufruito della classe Openfiledialog inserita in Bottone funzionale e intuitivo. Per un miglior funzionamento del programma, è stata aggiunta una condizione, per cui all'utente viene data la conferma che un file è stato preso in considerazione, utilizzando un IF (per la conferma) e un ELSE (per un eventuale avviso).

Passiamo al metodo per acquisire la stringa che rappresenta il checksum SHA256 del file inserito dall'utente. Questa volta abbiamo utilizzato l'estensione "using System.Security.Cryptography;", che con l'ausilio del replace abbiamo perfezionato il codice per renderlo ultimato. Per leggere il codice appena calcolato abbiamo covertito i bit in un'unica stringa, utilizzando il BitConverter.Tostring().





- organizzazione del lavoro, suddivisione della realizzazione in fasi, stima della durata e ruoli dei membri del gruppo
- ducumantazione del processo di realizzazione, attraverso appunti e commenti significativi alle versioni rilasciate su GitHub (commit)
- documentazione dei collegamenti e relazioni tra ciò che si sta realizzando e le informazioni di riferimento (teoria della materia, altre materie, soluzioni già esistenti)

Puoi editare questo file per creare il tuo documento di progetto oppure aggiungere un altro file in questa cartella. In ogni caso il documento deve essere un file di testo formattato con il linguaggio Markdown.
