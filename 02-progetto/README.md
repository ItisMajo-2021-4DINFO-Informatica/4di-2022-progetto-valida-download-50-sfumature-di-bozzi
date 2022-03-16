# Documento di Progetto -- 50_Sfumature_di_Bozzi

Stesura e organizzazione del lavoro, racconto della realizzazione della soluzione.  <br/>

## Inziamo

Il progetto dell'elaborato affronterà i seguenti punti:

### Stesura e Racconto Soluzione 

Il progetto ha come inizio nella creazione del file WPF.core su Visual Studio 2019. Dopo aver creato il file si passa all'ideazione dell'interfaccia, che dovrà essere facile da intuire e da usare. Per l'interfaccia verranno aggiunti più bottoni e diverse label, un paio di separatori per rendere tutto più organizzato. Creata l'interfaccia si passa al codice, come prima funzione verrà implementato il codice per permettere all'utente di scegliere quale file dovrà essere convalidato. Per un miglior funzionamento del programma, verrà aggiunta una condizione, per cui all'utente verrà data la conferma che un file è stato preso in considerazione, utilizzando un IF (per la conferma) e un ELSE (per un eventuale avviso). Per la convalida del file verrà aggiunto un metodo di decriptazione, tramite chiave pubblica PGP, della stringa di checksum SHA256. Qualora la stringa fosse diversa da quella dell'autore, verrà aggiunto un sistema di notifica che permetterà all'utente di visionare il problema. 

### Organizzazione

Fasi di Progetto:

* Fase 1. Definizione, chiarimento idee.
* Fase 2. Progetto, stesura e racconto soluzione.
* Fase 3. Codice, risoluzione pratica elaborato.
<br/>

Ruoli dei Membri:

* Decisi = scrittura codice e revisione documenti.
* Franco = ricerca fonti e implementazione di esse.
* De Filippis = lessico e struttura + scrittura codice.

<br/>
Stima Lavoro:
<br/><br/>
La stima per la realizzazione del progetto, nelle sue 3 fasi, è di circa 30 giorni. 
 
### Appunti e Commenti

CheckSum SHA256 --> sequenza di bit associata al pachetto; <br/>
Chiave pubblica PGP --> chiave per la trasmissione di messaggi crittografati; <br/>

### Relazioni e Collegamenti

Sistemi e reti: sequenza di bit leggibili su sistema operativo;
Telecomunicazioni: bit che rappresentano un messaggio;

## Autori

* Decisi Matteo
* Franco Andrea
* Marco De Filippis

## Licenza

Il Documento é sotto la licenza di 50SfumaturediBozzi.

## Info

Ispirazione:
* [fonte](https://gist.github.com/DomPizzie/7a5ff55ffa9081f2de27c315f5018afc)

