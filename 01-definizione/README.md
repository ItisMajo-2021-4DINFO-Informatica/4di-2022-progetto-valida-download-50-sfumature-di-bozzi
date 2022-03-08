# Documento di Definizione -- 50_Sfumature_di_Bozzi

Spiegazione e descrizione dei punti del progetto elaborato. <br/>

## Inziamo

La definizione dell'elaborato dovrà affrontare i seguenti punti:

### Esposizione Naturale Bisogni

Lettura della traccia e comprensione di essa. Organizzazione delle idee, eventuale chiarimento di dubbi e perplessitá. <br/>
Successiva creazione preliminare del file di progetto usando la piattaforma di sviluppo Visual Studio 2019. <br/>
Creazione di un'interfaccia utile e intuitiva, rispettando le esigenze della traccia: tra cui bottoni, label, stackpanel e separatori.<br/>
Navigazione dei file di sistema e possibilitá di prenderne in considerazione uno (scelto dall'utente stesso).<br/>
Acquisizione della stringa checksumSHA256 del file inserito dall'utente.<br/>
Importazione della chiave PGP (pubblica) del file in questione per verificare la firma digitale dell'autore.<br/>
Indicazione positiva o negativa posta all'utente in base alla riuscita o meno dei controlli effettuati.<br/>
Creazione di una chiave pubblica (PGP) con Kleopatra e inserimento dell'autenticazione nel file in questione.<br/>
Verifica della chiave + conferma o meno dell'autenticitá di essa.<br/>
Descrizione di evetuale problemi o imperfezioni, riscontrate dopo le azioni effettuate dall'utente, da parte dell'applicazione.<br/>
Ricerca su internet o richiesta d'aiuto ai due professori di servizio per la risoluzione del progetto e la massima funzionalitá di esso.<br/>

###  Esposizione Tecnologica Bisogni

Creazione di un applicazione WPF.core su visual studio 2019.<br/>
Bottone per la navigazione e l'inserimento del file da convalidare.<br/>
Bottone per il calcolo del checksumSHA256.<br/>
Metodo per navigare nel file system.<br/>
Metodo per il calcolo della stringa SHA256checksum.<br/>
Metodo per convertire i bit del checksum in un'unica stringa.<br/>
Kleopatra per la facile e intuitiva creazione della nostra chiave pubblica.<br/>
Funzione che spiega all'utente, qual'ora servisse, di spiegare ed evidenziare eventuali errori.
  
### Carenze/GAP

Come navigare il filesystem per indicare il file da convalidare.<br/>
Imparare cosa rappresenta SHA256 e saperlo implementare su visual studio.<br/>
Importare e creare la chiave PGP pubblica su visual studio.<br/>

### Modus Operandi

Incontro durante le ore scolastiche e meeting durante le ore extrascolastiche, e successiva suddivisione dei compiti. Analisi della traccia e comprensione del lavoro da svolgere. Per la risoluzione di eventuali dubbi, chiesto l'intervento dei due professori di materia o ricerca su internet dei termini/tecniche sconosciuti a noi. Per colmare i gap citati sopra abbiamo utilizzato siti come https://it.wikipedia.org/wiki/Checksum, https://knobs.it/chiave-pubblica-chiave-privata/, https://www.openpgp.org/software/kleopatra/. Discussione interna per il corretto sviluppo del progetto di Definizione e delle parti a venire. Svolgimento del contenuto del file di Definizione, con rilettura e aggiunta comune di parti aggiuntive.

## Autori

* Decisi Matteo
* Franco Andrea
* Marco De Filippis

## Licenza

Il Documento é sotto la licenza di 50SfumaturediBozzi.

## Info

Ispirazione:
* [fonte](https://gist.github.com/DomPizzie/7a5ff55ffa9081f2de27c315f5018afc)

