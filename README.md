# Artificial-Intelligence-Projects

## Uninformed Search Techniques

## Problems 

1. Social Golfers Problem 

    Description: This problem involves 32 golfers who play in groups of 4, once a week. The goal is to schedule the games in such a way that no two players play together more than once in the same group.

    Requirement: Depth First Search (DFS), Depth Limited Search, and Backtracking.
3. Sudoku Solver

    Description: This program solves a Sudoku puzzle, covering three different difficulty levels: Easy, Medium, and Hard.

    Requirement: Breadth First Search (BFS) and Backtracking.
5. Latin Square

    Description: A Latin square is an n x n grid filled with n different numbers, each appearing exactly once in every row and column. Given an input n, the program should print an n x n matrix composed of numbers from 1 to     n.

   Requirement: Iterative Deepening Depth First Search (IDDFS) and Backtracking.
#  Social Golfers Problem

Golf Scheduler është një aplikacion i zhvilluar në gjuhën programuese C# që menaxhon dhe planifikon lojtarët e golfit në grupe për një periudhë të caktuar kohe. Ky projekt synon të optimizojë ndarjen e lojtarëve në grupe, duke siguruar që ata të luajnë me lojtarë të ndryshëm në çdo javë, duke minimizuar përsëritjen e lojtarëve që kanë luajtur së bashku më parë.

## Planifikimi i Grupi

Aplikacioni ndan një numër të caktuar lojtarësh në grupe të caktuar  4 lojtarë në grup për secilën javë.
Siguron që çdo grup të përbëhet nga lojtarë të cilët nuk kanë luajtur së bashku më parë.

## Validimi i Grupit

Para se të formohen grupet, aplikacioni kontrollon nëse grupi i propozuar është valid, duke siguruar që lojtarët nuk kanë luajtur së bashku më parë.

## Krijimi i Planit Maksimal

Aplikacioni përpiqet të krijojë një planifikim maksimal të javëve, duke vazhduar derisa të mos ketë më mundësi për të formuar grupe të reja.

## Rezultatet e fituara

![output1](https://github.com/user-attachments/assets/ba2a6a4b-c943-464e-9941-e63d3f2c8752)

![output2](https://github.com/user-attachments/assets/08be3ee6-7a1e-4b66-882e-1fddf98acf66)
![output3](https://github.com/user-attachments/assets/5000dbed-d355-489f-9a13-30e99ec11d8b)

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
