# Definizione

La definizione dell'elaborato dovrà affrontare i seguenti punti:
- identificazione dei bisogni esposti nella traccia
  Per realizzare il progettto dovremo incontrarci e confrontare le idee, realizzare un app su visual studio (WPF) come già fatto più volte a scuola.
  Nell'applicazione dovremo navigare il filesystem per consentire all’utente di indicare il file da validare, acquisire la stringa che rappresenta il checksum SHA256,  importare     la chiave pubblica PGP del file per verificare la firma digitale e indicare all’utente se i controlli sono stati superati con successo o, in caso di errore, descrivere il         problema riscontrato. Molte di queste cose risulteranno difficili ed è per questo che dovremo ricercare informazioni sul web e imparare ciò che verrà spiegato a lezione
  
- descrizione delle risposte tecnologiche ai bisogni individuati
  Creazione di un applicazione su visual studio (WPF)
  Metodo OpenFileDiaolg per navigare nel file system
  Estensione usign System.Security.Cryptography e metodo SHA256.Create() per il calcolo della stringa SHA256checksum.
  (ps: utilizzato anche il metodo già conosciuto FileStream)
  Metodo BitConverter.Tostring() per convertire i bit del checksum in un'unica stringa.
  
  

  
- identificazione delle carenze (gap) nelle conoscenze rilevati nei membri del gruppo
  Come navigare il filesystem per indicare il file. Imparare cosa rappresenta SHA256 e saperlo implementare su visual studio, importare la chiave pubblica su visual studio.
  
  
- indicazione e organizzazione delle informazioni che si useranno per rispondere ai bisogni e colmare i gap di conoscenza
  Ricercare informazioni per conto proprio e confrontarle con cosa viene fornito dal professore 
    

Puoi editare questo file per creare il tuo documento di definizione oppure aggiungere un altro file in questa cartella. In ogni caso il documento deve essere un file di testo formattato con il linguaggio Markdown.
