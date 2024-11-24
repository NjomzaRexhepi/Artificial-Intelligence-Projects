# Artificial-Intelligence-Projects

## Uninformed Search Techniques

## Problems 

### Social Golfers Problem

Përshkrimi: Ky problem përfshin 32 golferë që luajnë në grupe prej 4 personash, një herë në javë. Qëllimi është të planifikohen lojërat në një mënyrë që asnjë dy lojtarë të mos luajnë së bashku më shumë se një herë në të njëjtin grup.

Kërkesa: Depth First Search (DFS), Depth Limited Search, dhe Backtracking.

### Sudoku Solver

Përshkrimi: Ky program zgjidh një puzzle të Sudoku-s, duke përfshirë tre nivele të ndryshme të vështirësisë: E Lehtë, Mesatare, dhe E Vështirë.

Kërkesa: Breadth First Search (BFS) dhe Backtracking.

### Latin Square

Përshkrimi: Një shesh Latin është një matricë n x n e mbushur me n numra të ndryshëm, secili duke u shfaqur pikërisht një herë në çdo rresht dhe kolonë. Dhenë një n si input, programi duhet të printojë një matricë n x n të përbërë nga numrat nga 1 deri në n.

Kërkesa: Iterative Deepening Depth First Search (IDDFS) dhe Backtracking.

# Algoritmet e përdorura 
## BFS
BFS është një algoritëm kërkimi që eksploron të gjithë nivelet e mundshme të një grafi ose një strukture të dhënash duke filluar nga një nyje burimore, pastaj duke vizituar të gjithë fëmijët (fqinjtë) e nyjeve në nivelin 1, pastaj në nivelin 2, dhe kështu me radhë.

## DFS
DLS është një modifikim i DFS (Depth-First Search) që kufizon thellësinë e kërkimit. Në vend që të kërkojë në mënyrë të pakufizuar (si në DFS), DLS ndalon kërkimin kur arrin një thellësi të caktuar.

## Backtracking 
Backtracking është një teknikë kërkimi që përdor një qasje të provë-dhe-gabim për të eksploruar mundësitë e mundshme. Pasi të arrini një situatë që nuk mund të zgjidhet (p.sh. duke kaluar përmes një rruge që çon në një kundërshtim), algoritmi kthehet pas dhe provo të tjera mundësi.

## IDDFS 
IDDFS është një përmirësim i DFS, i cili përdor një kufi për thellësinë që rritet në çdo iteracion. Ndryshe nga DFS, i cili mund të shkojë pafundësisht në thellësi, IDDFS kontrollon thellësinë e kërkimit nëpërmjet disa iteraçionesh të shkurtra me thellësi të kufizuar, duke përparuar çdo herë duke rritur kufirin.
   
#  Social Golfers Problem

Golf Scheduler është një aplikacion i zhvilluar në gjuhën programuese C# që menaxhon dhe planifikon lojtarët e golfit në grupe për një periudhë të caktuar kohe. Ky projekt synon të optimizojë ndarjen e lojtarëve në grupe, duke siguruar që ata të luajnë me lojtarë të ndryshëm në çdo javë, duke minimizuar përsëritjen e lojtarëve që kanë luajtur së bashku më parë.


# Latin Square

Latin Square është një aplikacion i zhvilluar në gjuhën programuese C# që gjeneron dhe validon kuadrate latine (Latin Squares). Një kuadrat latin është një matricë n×n, ku secili numër shfaqet saktësisht një herë në çdo rresht dhe kolonë. Ky projekt ofron mundësinë që përdoruesit të japin si hyrje vlerën n dhe të ndërveprojnë me funksionalitetet e tij për të mësuar më shumë rreth këtij koncepti matematikor.

## Karakteristikat
    1. Gjenerimi i Kuadrateve Latine
            Gjeneron automatikisht kuadrate latine valide të madhësisë n×n.
            Siguron që secili numër shfaqet vetëm një herë në çdo rresht dhe kolonë.
    2. Validimi
            Kontrollon nëse një matricë e dhënë nga përdoruesi është kuadrat latin.
            Verifikon unikësinë e elementeve në rreshta dhe kolona.
    3. Input i Personalizuar
            Përdoruesi mund të japë hyrje manuale për matricën n×n dhe aplikacioni do të kryejë validimin e saj.
    4. Trajtimi i Gabimeve
            Jep mesazhe të sakta për raste kur hyrjet janë të pavlefshme ose kur matrica nuk përmbush rregullat e kuadratit latin.

## Si Funksionon
    1. Gjenerimi i Kuadratit Latin
            Përdoruesi jep vlerën e n (p.sh. n=4).
            Sistemi gjeneron një kuadrat latin n×n me numra nga 1 deri në n, duke respektuar rregullat.
    2. Validimi i Kuadratit Latin
            Përdoruesi fut një matricë n×n.
            Aplikacioni verifikon: Rreshtat kanë elemente unike. Kolonat kanë elemente unike.
            Jep rezultate përkatëse për validimin e matricës.
    3. Ndërveprimi me Përdoruesin
            Përdoruesi mund të zgjedhë mes opsioneve për të gjeneruar ose kontrolluar kuadratet latine.

## Instruksionet për Përdorim
Duhet të keni të instaluar një mjedis për zhvillimin e projekteve C# (p.sh. Visual Studio).

Klononi projektin nga GitHub: git clone [https://github.com/emri-i-projektit.git](https://github.com/NjomzaRexhepi/Artificial-Intelligence-Projects.git)

Hapni projektin në Visual Studio. Klikoni Run për të nisur aplikacionin.

Jepni vlerën n kur ju kërkohet.

Shembull

Hyrja:

Vendosni madhësinë e kuadratit latin (n): 3

Rezultati:

Kuadrati Latin i Gjeneruar:
```
1 2 3
3 1 2
2 3 1
```
## Mesazhe të Gabimeve
Hyrje e Pavlefshme:
Nëse n është më i vogël se 2, shfaqet mesazhi:
Gabim: Madhësia e kuadratit duhet të jetë të paktën 2.
