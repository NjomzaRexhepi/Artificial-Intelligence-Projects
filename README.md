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

## Testcase 

[Uploadingfrom collections import defaultdict


schedule = [
    [
        [21, 16, 31, 12],
        [22, 20, 6, 9],
        [8, 24, 3, 14],
        [28, 7, 27, 13],
        [11, 30, 1, 26],
        [2, 5, 15, 29],
        [23, 17, 10, 4],
        [18, 25, 19, 0],
    ],
    [
        [23, 22, 24, 27],
        [20, 10, 14, 13],
        [28, 16, 3, 9],
        [1, 4, 12, 2],
        [15, 7, 26, 8],
        [5, 25, 17, 30],
        [21, 18, 29, 6],
        [0, 31, 11, 23],
    ],
    [
        [19, 31, 15, 3],
        [8, 18, 2, 28],
        [6, 24, 0, 10],
        [14, 22, 21, 30],
        [27, 20, 16, 25],
        [29, 17, 9, 11],
        [4, 7, 5, 19],
        [26, 12, 13, 18],
    ],
    [
        [1, 0, 20, 3],
        [1, 24, 13, 17],
        [30, 2, 7, 31],
        [26, 14, 5, 6],
        [21, 8, 19, 9],
        [22, 15, 28, 25],
        [29, 16, 4, 0],
        [11, 12, 27, 10],
    ],
    [
        [23, 28, 19, 1],
        [24, 7, 16, 18],
        [10, 22, 2, 26],
        [15, 9, 23, 13],
        [27, 17, 14, 31],
        [25, 12, 29, 3],
        [30, 6, 8, 4],
        [5, 20, 21, 11],
    ],
    [
        [7, 17, 12, 22],
        [16, 15, 10, 30],
        [24, 21, 26, 25],
        [27, 5, 18, 9],
        [31, 29, 28, 20],
        [19, 6, 2, 13],
        [4, 14, 11, 15],
        [23, 3, 7, 21],
    ],
    [
        [8, 1, 27, 29],
        [0, 12, 30, 28],
        [6, 11, 25, 7],
        [4, 9, 31, 24],
        [16, 14, 2, 23],
        [10, 8, 5, 31],
        [20, 18, 17, 15],
        [1, 22, 16, 5],
    ],
    [
        [3, 13, 4, 22],
        [0, 27, 21, 2],
        [19, 26, 17, 16],
        [12, 8, 20, 23],
        [1, 10, 25, 9],
        [0, 14, 7, 9],
        [29, 30, 19, 24],
        [13, 11, 8, 16],
    ],
]


pairings = defaultdict(int)

for week in schedule:
    for group in week:
        for i in range(len(group)):
            for j in range(i + 1, len(group)):
                pair = tuple(sorted([group[i], group[j]]))
                pairings[pair] += 1


violations = {pair: count for pair, count in pairings.items() if count > 1}
missing = {pair for pair in pairings if pairings[pair] == 0}

if violations:
    print("Repeated pairings found:")
    for pair, count in violations.items():
        print(f"Pair {pair} appears {count} times")
else:
    print("No repeated pairings found.")

if missing:
    print("Missing pairings found:")
    for pair in missing:
        print(f"Pair {pair}")
else:
    print("No missing pairings.") testcase.py…]()


Rezultatet nga testcase 

 ![testcasebestsol](https://github.com/user-attachments/assets/b36abcf1-32c1-4d56-87d7-af3d82077e5a)

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
