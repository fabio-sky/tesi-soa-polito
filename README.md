
# Progetto di Tesi - Sense of Agency [Applicazione VR]

Progetto di tesi per la laurea magistrale di ingegneria informatica (Grafica e Multimedia) del Politecnico di Torino.

Il progetto, sviluppato in collaborazione con il **ContExp Lab** dell'Università di Torino, dal titolo *Sense of Agency and ERP correlates on delayed VR* si pone come obiettivo quello di studiare il [Sense of Agency](https://en.wikipedia.org/wiki/Sense_of_agency) tramite l'[ERP](https://en.wikipedia.org/wiki/Event-related_potential) all'interno di un ambiente virtuale nel quale viene introdotto un delay.


All'interno di questo repository vi è il codice sorgete dell'ambiente virtuale, sviluppato utilizzando il game engine Unity. È possibile utilizzarlo su un qualsiasi visore di VR immersivo che supporti lo standard OpenXR (come ad esempio il Meta Quest 2 utilizzato in questa sperimentazione).

# Info utili

## Gestione connessioni
Le richieste inviate dal software di gestione vengono processate dal componente _NetworkManager_, il quale inizializza un server TCP sulla porta 8080 e rimane in ascolto di eventuali richieste.

## Sessione sperimentale
La sessione sperimentale viene gestite dal componente _SessionManager_ (singleton). Questo si occupa di gestire la pressione del pulsante, i tempi di attesa e lo spawn dei target. Si occupa di applicare i parametri specificati per il blocco sperimentale attualmente in esecuzione (delay e mirroring). 

## Applicazione delay e mirroring
Nell'ambiente virtuale è presente il game object _HandVisualizer_ (MainScene > XR Origin > HandVisualizer) con il componente script _HandVisualizer_. Questo aggiunge alla scena gli oggetti mano, andando ad applicarne posizione e rotazione basandosi sui dati di tracking del visore. Gli oggetti _mano_ sono i prefab _RighHand_ e _LeftHand_ che vengono aggiunti alla scena ma senza la mesh.

I prefab _RighHand_ e _LeftHand_ possiedono lo script _HandTrackedController_ che ha il compito di gestire il buffer utilizzato per l'applicazione del delay, inserendo le nuove posizione e recuperando i dati sulla posizione affetta da delay e dai possibili mirroring abilitati.
La posizione e rotazione definitiva, recuperata e processata dal buffer, viene poi applicata agli oggetti _mano_ visibili all'interno della scena. Questi si trovano in (MainScene > XR Origin > HandVisualizer > LeftHand / RightHand). 

Gli oggetti _mano_ vengono recuperati del _HandTrackedController_ tramite i tag specificati come parametri dello script.

### Rissumendo

1. Il componente _HandVisualizer_ recupera POS e ROT ad ogni frame dal sistema handtracking e li applica ai prefab _RightHand_ e _LeftHand_ non visibili all'interno della scena (opzione _draw mesh_ disabilitata)
2. I prefab _RightHand_ e _LeftHand_ gestiscono il buffer, processano posizione e rotazione in base ai mirroring abilitati
3. Gli oggetti mano visibili nella scena (children del game object _XR Origin_ > _HandVisualizer_) vengono recuperati tramite il tag e ad essi viene applicata posizione e rotazione processata nel passaggio precedente